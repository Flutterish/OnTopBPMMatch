using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Match_BPM {
    public partial class SplashAnimcs : Form {
        public SplashAnimcs () {
            InitializeComponent();

            SetStyle( ControlStyles.SupportsTransparentBackColor, true );
            this.BackColor = Color.FromArgb( 0, 0, 0, 0 );
            this.TransparencyKey = Color.FromArgb( 0, 0, 0, 0 );

            this.FormBorderStyle = FormBorderStyle.None;

            SetStyle( ControlStyles.OptimizedDoubleBuffer, true );

            SetWindowPos( this.Handle, HWND_TOPMOST, this.Location.X, this.Location.Y, 0, 0, TOPMOST_FLAGS );

            var style = GetWindowLong( this.Handle, GWL_EXSTYLE );
            SetWindowLong( this.Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT );
            this.Opacity = 0.5;
        }

        protected override void OnPaintBackground ( PaintEventArgs e ) { /* Ignore */ }

        private void SplashAnimcs_Load ( object sender, EventArgs e ) {

        }

        private static readonly IntPtr HWND_TOPMOST = new IntPtr( -1 );
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport( "user32.dll" )]
        [return: MarshalAs( UnmanagedType.Bool )]
        public static extern bool SetWindowPos ( IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags );

        [DllImport( "user32.dll", SetLastError = true )]
        static extern int GetWindowLong ( IntPtr hWnd, int nIndex );
        [DllImport( "user32.dll" )]
        static extern int SetWindowLong ( IntPtr hWnd, int nIndex, int dwNewLong );
        const int GWL_EXSTYLE = -20;
        const int WS_EX_LAYERED = 0x80000;
        const int WS_EX_TRANSPARENT = 0x20;
    }
}
