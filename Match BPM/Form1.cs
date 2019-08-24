using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Match_BPM {
    public partial class Form1 : Form {

        public Form1 () {
            InitializeComponent();

            target = new BPMInfo( TargetBPMTextBox, TargetDelay, ResetTargetBPM, MeasureTargetBPM );
            sequence = new BPMInfo( ImageBPMTextBox, ImageDelay, ResetImageBPM, MeasureImageBPM );

            images = new ImageSequence( Location, SelectLocation, folderBrowserDialog1, Prefix, Interfix, Suffix, BeginFrame, EndFrame, FPS, Frames, pictureBox1, Load, this );

            MaximizeBox = false;

            //this.ControlBox = false;
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.ShowIcon = false;
            this.KeyPreview = true;

            this.KeyUp += Form1_KeyUp;
            Measure();
        }

        private void Form1_KeyUp ( object sender, KeyEventArgs e ) {
            if ( e.KeyCode == Keys.F4 ) {
                Splash();
            }
        }

        public class Interval {
            double beginTime;
            public double delay;
            public Action action;
            private bool disposing = false;
            Task me;
            public Interval ( double millis, Action action ) {
                this.action = action;
                delay = millis;
                beginTime = ( DateTime.UtcNow - new DateTime(1970, 1, 1) ).TotalMilliseconds;
                me = Task.Run( async () => {
                    while ( !disposing ) {
                        await Task.Delay( 10 );
                        double now = ( DateTime.UtcNow - new DateTime(1970, 1, 1) ).TotalMilliseconds;
                        while ( now - beginTime >= delay ) {
                            beginTime += delay;
                            if ( !disposing )
                                action.Invoke();
                        }
                    }
                } );
            }

            public async void Dispose () {
                disposing = true;
                while ( !me.IsCompleted ) {
                    await Task.Delay( 10 );
                }
                me.Dispose();
            }
        }

        public class BPMInfo {
            public double BPM = 120;
            public double delay = 0;

            public bool waiting = false;

            public double beginTime;
            public double endTime;

            public double clicks;

            public TextBox BPMBox;
            public TextBox Delay;
            public Button ResetButton;
            public TextBox Measure;
            public BPMInfo ( TextBox BPM, TextBox Delay, Button Reset, TextBox Measure ) {
                this.BPMBox = BPM;
                this.Delay = Delay;
                this.ResetButton = Reset;
                this.Measure = Measure;
                BPM.TextChanged += BPM_TextChanged;
                Delay.TextChanged += Delay_TextChanged;
                Reset.Click += Reset_Click;
                Measure.TextChanged += Measure_TextChanged;
            }

            private void Measure_TextChanged ( object sender, EventArgs e ) {
                if ( ignoreEvents || Measure.Text.Length == 0 ) return;
                TimeSpan t = DateTime.UtcNow - new DateTime( 1970, 1, 1 );
                double time = t.TotalMinutes;
                if ( waiting ) {
                    waiting = false;
                    beginTime = time;
                } else {
                    clicks++;
                    endTime = time;
                    BPM = clicks / ( endTime - beginTime );
                    delay = beginTime;
                    Display();
                }
                ignoreEvents = true;
                Measure.Text = Measure.Text.Substring( 0, Measure.Text.Length - 1 );
                ignoreEvents = false;
            }

            public void Display () {
                ignoreEvents = true;
                Delay.Text = delay.ToString();
                BPMBox.Text = BPM.ToString();
                ignoreEvents = false;
            }

            private bool ignoreEvents = false;

            private void Reset_Click ( object sender, EventArgs e ) => Reset();

            private void Delay_TextChanged ( object sender, EventArgs e ) {
                if ( ignoreEvents ) return;
                if ( CheckDoubleFormat( Delay, out double result ) ) {
                    delay = result;
                }
            }

            private void BPM_TextChanged ( object sender, EventArgs e ) {
                if ( ignoreEvents ) return;
                if ( CheckDoubleFormat( BPMBox, out double result ) ) {
                    BPM = result;
                }
            }

            public BPMInfo () {

            }

            public void Reset () {
                waiting = true;
                clicks = 0;
                BPMBox.Text = "Not measured yet";
                Delay.Text = "Not measured yet";
            }
        }

        public BPMInfo target;
        public BPMInfo sequence;
        public BPMInfo result = new BPMInfo();
        public ImageSequence images;

        public static bool CheckDoubleFormat ( TextBox box, out double result, bool specialcase = true ) {
            if ( double.TryParse( box.Text.Replace( '.', ',' ), out result ) ) {
                Valid( box );
                return true;
            }
            if ( specialcase && box.Text == "Not measured yet" ) {
                Valid( box );
            } else {
                Error( box );
            }
            return false;
        }

        public static bool CheckIntFormat ( TextBox box, out int result, bool specialcase = true ) {
            if ( int.TryParse( box.Text, out result ) ) {
                Valid( box );
                return true;
            }
            if ( specialcase && box.Text == "auto" ) {
                Valid( box );
            } else {
                Error( box );
            }
            return false;
        }

        private static void Valid ( TextBox box ) {
            box.BackColor = SystemColors.Window;
            box.ForeColor = SystemColors.WindowText;
        }

        private static void Error ( TextBox box ) {
            box.BackColor = Color.Red;
            box.ForeColor = Color.White;
        }

        public class ImageSequence {

            private TextBox Location;
            private Button LocationSelect;
            private FolderBrowserDialog Dialog;
            private TextBox Prefix;
            private TextBox Interfix;
            private TextBox Suffix;
            private TextBox Begin;
            private TextBox End;
            private TextBox FPS;
            private TextBox Frames;
            private PictureBox Picture;
            private Form1 Parent;

            public ImageSequence ( 
                TextBox location, Button selectLocation, FolderBrowserDialog dialog,
                TextBox prefix, TextBox interfix, TextBox suffix, 
                TextBox begin, TextBox end, TextBox fPS, TextBox frames, PictureBox pic, Button Load, Form1 parent ) {

                Location = location;
                LocationSelect = selectLocation;
                Dialog = dialog;
                Prefix = prefix;
                Interfix = interfix;
                Suffix = suffix;
                Begin = begin;
                End = end;
                FPS = fPS;
                Frames = frames;
                Picture = pic;
                Parent = parent;

                Location.TextChanged += Location_TextChanged;
                LocationSelect.Click += LocationSelect_Click;
                Prefix.TextChanged += Prefix_TextChanged;
                Interfix.TextChanged += Interfix_TextChanged;
                Suffix.TextChanged += Suffix_TextChanged;
                Begin.TextChanged += Begin_TextChanged;
                End.TextChanged += End_TextChanged;
                FPS.TextChanged += FPS_TextChanged;
                Load.Click += Load_Click;
            }

            private void Load_Click ( object sender, EventArgs e ) {
                TryLoad( true );
            }

            private void FPS_TextChanged ( object sender, EventArgs e ) {
                if ( CheckDoubleFormat( FPS, out double fps, false ) ) {
                    TryLoad();
                }
            }

            private void End_TextChanged ( object sender, EventArgs e ) {
                if ( CheckIntFormat( End, out int r ) || End.Text == "auto" ) {
                    TryLoad();
                }
            }

            private void Begin_TextChanged ( object sender, EventArgs e ) {
                if ( CheckIntFormat( Begin, out int r ) || Begin.Text == "auto" ) {
                    TryLoad();
                }
            }
            private void Suffix_TextChanged ( object sender, EventArgs e ) => TryLoad();
            private void Interfix_TextChanged ( object sender, EventArgs e ) => TryLoad();
            private void Prefix_TextChanged ( object sender, EventArgs e ) => TryLoad();

            private void LocationSelect_Click ( object sender, EventArgs e ) {
                if ( Dialog.ShowDialog() == DialogResult.OK ) {
                    Location.Text = Dialog.SelectedPath;
                }
            }

            public bool OK = false;

            public void TryLoad ( bool animate = false ) {
                OK = false;
                string location = Location.Text;
                if ( System.IO.Directory.Exists( location ) ) {
                    Valid( Location );
                } else {
                    Error( Location );
                    return;
                }
                string prefix = Prefix.Text;
                string interfix = Interfix.Text;
                string suffix = Suffix.Text;

                // get all files
                var files = System.IO.Directory.GetFiles( location, $"{ prefix }*{ suffix }", System.IO.SearchOption.TopDirectoryOnly ).ToList(); // E:\kr\bangin frames
                for ( int i = 0; i < files.Count; i++ ) {
                    var path = files[ i ];
                    path = path.Substring( path.LastIndexOf( '\\' ) + 1 );
                    path = path.Substring( 0, path.LastIndexOf( suffix ) );
                    path = path.Substring( prefix.Length );

                    if ( path.Length < interfix.Length ) {
                        files.RemoveAt( i-- );
                        continue;
                    } else {
                        if ( path.Length == interfix.Length ) {
                            for ( int x = 0; x < interfix.Length; x++ ) {
                                if ( interfix[ x ] == path[ 0 ] ) {
                                    path = path.Substring( 1 );
                                } else {
                                    break;
                                }
                            }
                        }
                        files[ i ] = path;
                    }
                }
                var indexes = new List< int >();
                foreach ( var i in files ) {
                    if ( int.TryParse( i, out int x ) ) {
                        if ( System.IO.File.Exists( $@"{ location }\{ prefix }{ Indexify( x ) }{ suffix }" ) ) {
                            indexes.Add( x );
                        }
                    }
                }
                indexes.Sort( new Comparison<int>( ( int a, int b ) => { return a - b; } ) );
                int min = 0, max = 0;
                if ( indexes.Count > 0 ) {
                    max = indexes.Last();
                    min = indexes[ 0 ];
                }
                if ( CheckIntFormat( Begin, out int r ) ) {
                    min = r;
                } else if ( Begin.Text != "auto" ) {
                    return;
                }
                if ( CheckIntFormat( End, out int r2 ) ) {
                    max = r2;
                } else if ( End.Text != "auto" ) {
                    return;
                }

                for ( int i = 0; i < indexes.Count; i++ ) {
                    if ( indexes[ i ] < min || indexes[ i ] > max ) {
                        indexes.RemoveAt( i-- );
                    }
                }

                if ( indexes.Count == 0 ) {
                    Frames.Text = "Couldn't find any frames";
                    Error( Frames );
                    return;
                }
                
                Frames.Text = indexes.Count.ToString();
                Valid( Frames );
                //
                if ( !CheckDoubleFormat( FPS, out double fps, false ) ) {
                    return;
                }

                OK = true;
                // OK, all ready, load images and animate
                if ( animate )
                    Display( location, prefix, suffix, indexes.ToArray(), fps );
            }

            public async void Display ( string loc, string pre, string suf, int[] indexes, double fps ) {
                while ( loading ) {
                    waiting = true;
                    await Task.Delay( 100 );
                }
                loading = true;
                if ( waiting ) {
                    string[] anim = new string[] {
                        "Reloading",
                        "Reloading.",
                        "Reloading..",
                        "Reloading...",
                        "Reloading..",
                        "Reloading.",
                        "Reloading"
                    };
                    
                    for ( int i = 0; i < anim.Length; i++ ) {
                        Frames.Text = anim[ i ];
                        await Task.Delay( 80 );
                    }
                }
                waiting = false;
                string[] paths = new string[ indexes.Length ];
                for ( int i = 0; i < indexes.Length; i++ ) {
                    paths[ i ] = $@"{ loc }\{ pre }{ Indexify( indexes[ i ] ) }{ suf }";
                }
                foreach ( Bitmap i in this.images ) {
                    if ( i != null )
                        i.Dispose();
                }
                if ( animation != null ) {
                    animation.Dispose();
                }
                Bitmap[] images = new Bitmap[ paths.Length ];
                this.images = images;
                await Task.Factory.StartNew( () => {
                    for ( int i = 0; i < paths.Length; i++ ) {
                        MethodInvoker inv = delegate {
                            Frames.Text = $"{ i } / { images.Length }";
                        };
                        Parent.Invoke( inv );

                        Image A = Image.FromFile( paths[ i ] );
                        images[ i ] = new Bitmap( A, new Size( Rescale( A, Picture ) ) );
                        A.Dispose();
                        if ( waiting ) {
                            return;
                        }
                    }
                    Animate( fps );
                } );
                Frames.Text = waiting ? "Reloading..." : $"{ images.Length } ( Loaded )";
                loading = false;
            }

            public void Animate ( double fps, PictureBox box = null, Form parent = null ) {
                if ( box == null ) box = Picture;
                if ( parent == null ) parent = Parent;
                if ( animation != null ) {
                    animation.Dispose();
                }
                if ( images.Length == 0 ) {
                    return;
                }
                box.Image = images[ 0 ];
                int fr = 1;
                animation = new Interval( 1000d / fps, () => {
                    fr++;
                    fr %= images.Length;
                    MethodInvoker inv = delegate {
                        box.Image = images[ fr ];
                    };
                    parent.Invoke( inv );
                } );
            }

            public Point Rescale ( Image A, PictureBox B ) {
                double WoH = B.Width / B.Height;
                double HoW = B.Height / B.Width;
                double scale = A.Width / A.Height;
                double scale2 = A.Height / A.Width;
                if ( WoH < scale ) { // if image is wider
                    return new Point( B.Width, (int)( B.Width * scale2 ) );
                } else {
                    return new Point( (int)( B.Height * scale ), B.Height );
                }
            }

            Interval animation;
            private bool waiting = false;
            private bool loading = false;
            Bitmap[] images = new Bitmap[ 0 ];

            private string Indexify ( int index ) {
                string i = index.ToString();
                if ( i.Length >= Interfix.Text.Length ) {
                    return i;
                }
                int diff = Interfix.Text.Length - i.Length;
                return Interfix.Text.Substring( 0, diff ) + i;
            }

            private void Location_TextChanged ( object sender, EventArgs e ) {
                if ( System.IO.Directory.Exists( Location.Text ) ) {
                    Valid( Location );
                    TryLoad();
                } else {
                    Error( Location );
                }
            }
        }

        double trueDelay;
        double trueSpeed;
        private void GetTrueDelay () {
            trueDelay = target.delay - sequence.delay;
        }

        private void GetTrueSpeed () {
            trueSpeed = target.BPM / sequence.BPM;
        }

        private bool Measure () {
            bool x = true;
            GetTrueDelay();
            TrueDelay.Text = trueDelay.ToString();
            if ( TargetDelay.Text == "Not measured yet" || ImageDelay.Text == "Not measured yet" ) {
                TrueDelay.Text = "Not calculated";
                x = false;
            }
            GetTrueSpeed();
            TrueSpeed.Text = "x" + trueSpeed.ToString();
            if ( TargetBPMTextBox.Text == "Not measured yet" || ImageBPMTextBox.Text == "Not measured yet" ) {
                TrueSpeed.Text = "Not calculated";
                x = false;
            }
            return x;
        }

        private void TargetBPMTextBox_TextChanged ( object sender, EventArgs e ) => Measure();

        private void TargetDelay_TextChanged ( object sender, EventArgs e ) => Measure();

        private void ImageBPMTextBox_TextChanged ( object sender, EventArgs e ) => Measure();

        private void ImageDelay_TextChanged ( object sender, EventArgs e ) => Measure();

        private void Play_Click ( object sender, EventArgs e ) {
            if ( Measure() ) images.Animate( double.Parse( FPS.Text ) * trueSpeed );
        }

        private SplashAnimcs splash;

        private void button1_Click ( object sender, EventArgs e ) {
            Splash();
        }

        private void Splash () {
            if ( Measure() ) {
                if ( splash != null ) {
                    splash.Close();
                }
                splash = new SplashAnimcs();
                splash.StartPosition = FormStartPosition.Manual;
                splash.Location = new Point( Left, Top );
                splash.Show();
                images.Animate( double.Parse( FPS.Text ) * trueSpeed, splash.pictureBox1, splash );
            }
        }
    }
}
