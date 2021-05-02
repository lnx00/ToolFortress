using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolFortress
{
    public partial class AlertBox : UserControl
    {
        public AlertBox(string pTitle, string pMessage)
        {
            InitializeComponent();

            lblTitle.Text = pTitle;
            lblMessage.Text = pMessage;
        }
    }
}
