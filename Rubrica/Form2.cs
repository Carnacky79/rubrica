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

        private void btnAggiorna_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string tel = txtTel.Text;
            string cell = txtCell.Text;
            string fax = txtFax.Text;
            string indirizzo = txtIndirizzo.Text;
            string note = txtNote.Text;
            int ID = Convert.ToInt32(txtID.Text);

            DialogResult result = MessageBox.Show("Aggiornare il Nominativo?", "Aggiornamento", MessageBoxButtons.OKCancel);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        this.nominativiTableAdapter.UpdateQueryByID(nome, cognome, indirizzo, tel, cell, fax, note, ID);
                        Form1.form1.UpdateList();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        
                        break;
                    }
            }

        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(txtID.Text);

            DialogResult result = MessageBox.Show("Eliminare il Nominativo?", "Eliminazione", MessageBoxButtons.OKCancel);

            switch (result)
            {
                case DialogResult.OK:
                    {
                        this.nominativiTableAdapter.DeleteQuery(ID);
                        Form1.form1.UpdateList();
                        this.Close();
                        break;
                    }
                case DialogResult.Cancel:
                    {
                        
                        break;
                    }
            }
        }
    }
}
