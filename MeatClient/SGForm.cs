using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeatClient
{
    public partial class SGForm : Form
    {
        public SGForm()
        {
            InitializeComponent();
        }

        private void SGForm_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
}
