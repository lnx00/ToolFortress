using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolFortress
{
    public partial class Overlay : Form
    {
        #region DLL Imports
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out Rect lpRect);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        #endregion

        private Graphics _gfx;
        private Process _tfProcess;

        private GLabel _plLabel;
        private List<string> _msgQueue = new List<string>();
        private GLabel msgBox;

        public Overlay()
        {
            InitializeComponent();

            int initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            _gfx = this.CreateGraphics();
            _plLabel = CreateLabel("", 20, 400, 16, false);
        }

        public void Enable()
        {
            Process[] tfList = Process.GetProcessesByName("hl2");
            if (tfList.Length >= 1)
            {
                // Get the tf2 process
                _tfProcess = tfList.First();
                Rect tfRect = new Rect();
                GetWindowRect(_tfProcess.MainWindowHandle, out tfRect);

                // Resize this window
                this.Location = new Point(tfRect.Left, tfRect.Top);
                this.Size = new Size(tfRect.Right, tfRect.Bottom);

                CreateLabel("ToolFortress", 20, 60, 22);

                // Initialize message drawer
                msgBox = new GLabel
                {
                    Location = new Point(this.Width - 500, 10),
                    Size = new Size(490, this.Height - 20),
                    AutoSize = false,
                    TextAlign = ContentAlignment.BottomRight,
                    Text = "",
                    Font = new Font("Consolas", 18, FontStyle.Regular),
                    BackColor = Color.Transparent,
                    ForeColor = Color.White
                };
            }
        }

        /* Clear the screen */
        public void Clear()
        {
            _gfx.Clear(Color.Lime);
        }

        /* Draw a rect on the screen */
        public void DrawRect(int pX, int pY, int pWidth, int pHeight, Color pColor, int pThickness = 2)
        {
            _gfx.DrawRectangle(new Pen(pColor, pThickness), pX, pY, pWidth, pHeight);
        }

        /* Draw a string on the screen */
        public GLabel CreateLabel(string pText, int pX, int pY, int pSize = 30, bool pBold = true)
        {
            GLabel label = new GLabel
            {
                Location = new Point(pX, pY),
                AutoSize = true,
                Text = pText,
                Font = new Font("Consolas", pSize, (pBold) ? FontStyle.Bold : FontStyle.Regular),
                BackColor = Color.Transparent,
                ForeColor = Color.White
            };

            this.Controls.Add(label);
            return label;
        }

        public void PushMessage(string pMessage)
        {
            _msgQueue.Add(pMessage);
            UpdateMessages();
        }

        public void UpdatePlayerlist(String[] pPlayerlist)
        {
            _plLabel.Text = string.Join("\n", pPlayerlist);
        }

        private void UpdateMessages()
        {
            msgBox.Text = string.Join("\n\n", _msgQueue.ToArray());
        }

        /* Custom label with optimized gfx */
        public class GLabel : Label
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            }
        }
    }
}
