using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class Ende : Form
    {
        public Ende()
        {
            InitializeComponent();
        }

        private void Ende_Load(object sender, System.EventArgs e)
        {
            this.Show();
            this.Activate();
            Application.DoEvents();
            System.Threading.Thread.Sleep(2000);
            this.Close();
        }
    }
}
