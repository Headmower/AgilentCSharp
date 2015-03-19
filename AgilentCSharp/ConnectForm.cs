using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgilentCSharp
{
    public partial class ConnectForm : Form
    {
        Reference<Agilent> aglnt = null;
        public ConnectForm(Reference<Agilent> agilent)
        {
            InitializeComponent();
            aglnt = agilent;
        }

        private void ConnectForm_Load(object sender, EventArgs e)
        {

        }

    }
}
