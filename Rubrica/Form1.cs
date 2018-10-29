using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace Rubrica
{
    public partial class Form1 : Form
    {
        internal static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet1.nominativi'. È possibile spostarla o rimuoverla se necessario.
            this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);

            LoadList();
        }

        public void UpdateList()
        {
            this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);

            LoadList();
        }


        private void LoadList()
        {
            // Get the table from the data set
            DataTable dtable = dataSet1.Tables["nominativi"];

            // Clear the ListView control
            listView.Items.Clear();

            // Display items in the ListView control
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if (drow.RowState != DataRowState.Deleted)
                {
                    // Define the list items
                    ListViewItem lvi = new ListViewItem(drow["ID"].ToString());
                    lvi.SubItems.Add(drow["nome"].ToString());
                    lvi.SubItems.Add(drow["cognome"].ToString());
                    lvi.SubItems.Add(drow["tel"].ToString());

                    // Add the list items to the ListView
                    listView.Items.Add(lvi);
                }
            }
        }

        private void scrBtn_Click(object sender, EventArgs e)
        {
            string nome = srcTxtNome.Text;
            string cognome = srcTxtCognome.Text;
            string tel = srcTxtTelefono.Text;

            if(string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(cognome) && string.IsNullOrEmpty(tel))
            {
                this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);
            }
            else
            {
                this.nominativiTableAdapter.Search(this.dataSet1.nominativi, nome, cognome, tel);
            }

            LoadList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string cognome = txtCognome.Text;
            string tel = txtTel.Text;
            string cell = txtCell.Text;
            string fax = txtFax.Text;
            string indirizzo = txtIndirizzo.Text;
            string note = txtNote.Text;

            nome = string.IsNullOrEmpty(nome) ? nome = " " : nome;
            cognome = string.IsNullOrEmpty(cognome) ? cognome = " " : cognome;
            tel = string.IsNullOrEmpty(tel) ? tel = " " : tel;
            cell = string.IsNullOrEmpty(cell) ? cell = " " : cell;
            fax = string.IsNullOrEmpty(fax) ? fax = " " : fax;
            indirizzo = string.IsNullOrEmpty(indirizzo) ? indirizzo = " " : indirizzo;
            note = string.IsNullOrEmpty(note) ? note = " " : note;

            if (nome == " " || cognome == " " || tel == " ")
            {
                MessageBox.Show("Almeno il Nome, il Cognome e il Telefono devono essere impostati","ERRORE");
            }
            else
            {
                this.nominativiTableAdapter.InsertQuery(nome, cognome, indirizzo, tel, cell, fax, note);

                txtNome.Text = string.Empty;
                txtCognome.Text = string.Empty;
                txtTel.Text = string.Empty;
                txtCell.Text = string.Empty;
                txtFax.Text = string.Empty;
                txtIndirizzo.Text = string.Empty;
                txtNote.Text = string.Empty;
            }

            this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);
            LoadList();

        }

        private void btnOrderNomeAsc_Click(object sender, EventArgs e)
        {
            this.nominativiTableAdapter.orderByNomeAsc(this.dataSet1.nominativi);
            LoadList();
        }

        private void btnOrderNomeDesc_Click(object sender, EventArgs e)
        {
            this.nominativiTableAdapter.orderByNomeDesc(this.dataSet1.nominativi);
            LoadList();
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count > 0)
            {
                string lvSelectedItem = listView.SelectedItems[0].Text;
                //MessageBox.Show(lvSelectedItem);
                // Create a new instance of the Form2 class
                Form2 settingsForm = new Form2(Convert.ToInt32(lvSelectedItem));

                // Show the settings form
                settingsForm.Show();
                settingsForm.BringToFront();
                settingsForm.Activate();


            }
            
        }

        private void btnOrderCognomeAsc_Click(object sender, EventArgs e)
        {
            this.nominativiTableAdapter.orderByCognomeAsc(this.dataSet1.nominativi);
            LoadList();
        }

        private void btnOrderCognomeDesc_Click(object sender, EventArgs e)
        {
            this.nominativiTableAdapter.orderByCognomeDesc(this.dataSet1.nominativi);
            LoadList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
