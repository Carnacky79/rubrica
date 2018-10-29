using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rubrica
{
    public partial class Form2 : Form
    {
        public Form2(int ID)
        {
            InitializeComponent();
            this.nominativiTableAdapter.FillByID(this.dataSet1.nominativi, ID);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
