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
            try
            {
                this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);
            }
            catch
            {
                findDB();
            }

            LoadList();

            loadComboBox();

            this.cbAlfabeto.SelectedIndexChanged += new System.EventHandler(this.cbAlfabeto_SelectedIndexChanged);
        }

        public void UpdateList()
        {
            this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);

            LoadList();
        }


        private void loadComboBox()
        {
            cbAlfabeto.Items.Clear();
            Dictionary<char, int> dctOccur = new Dictionary<char, int>();

            char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

            string[] strLetters = null;
            Array.Resize(ref strLetters, letters.Length);

            for (int i = 0; i < letters.Length; i++)
            {
                strLetters[i] = new string(letters[i], 1);
                strLetters[i] = strLetters[i].ToUpper();

                dctOccur.Add(strLetters[i][0], 0);
            }

            DataTable dtable = dataSet1.Tables["nominativi"];
            char firstLetter;


            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                DataRow drow = dtable.Rows[i];

                // Only row that have not been deleted
                if ((drow.RowState != DataRowState.Deleted) && !string.IsNullOrEmpty(drow["cognome"].ToString()))
                {
                    firstLetter = drow["cognome"].ToString().ToUpper()[0];

                    dctOccur[firstLetter] += 1;
                }
            }

            foreach (char key in dctOccur.Keys)
            {
                if(dctOccur[key] > 0)
                {
                    cbAlfabeto.Items.Add(key);
                }
            }

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

        private void cbAlfabeto_SelectedIndexChanged(Object sender, EventArgs e)
        {
            string firstLet = cbAlfabeto.ComboBox.SelectedItem.ToString();
            firstLet = firstLet + "%";

            this.nominativiTableAdapter.FirstLetter(this.dataSet1.nominativi, firstLet);

            LoadList();
        }

        private void scrBtn_Click(object sender, EventArgs e)
        {
            string nome = srcTxtNome.Text;
            string cognome = srcTxtCognome.Text;
            string tel = srcTxtTelefono.Text;

            nome = string.IsNullOrEmpty(nome) ? nome : nome + "%";
            cognome = string.IsNullOrEmpty(cognome) ? cognome : cognome + "%";
            tel = string.IsNullOrEmpty(tel) ? tel : tel + "%";

            if (string.IsNullOrEmpty(nome) && string.IsNullOrEmpty(cognome) && string.IsNullOrEmpty(tel))
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

        private void aggiornaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutBox ab = new aboutBox();
            ab.Show();
        }

        private void sourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findDB();
        }

        private void findDB()
        {
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Access Database (*.mdb)|*.mdb";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    this.nominativiTableAdapter.Connection.Close();
                    Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings.Remove("Rubrica.Properties.Settings.rubricaConnectionString");
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("Rubrica.Properties.Settings.rubricaConnectionString", "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath));
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("connectionStrings");

                    this.nominativiTableAdapter.Connection.ConnectionString = config.ConnectionStrings.ConnectionStrings["Rubrica.Properties.Settings.rubricaConnectionString"].ToString();
                    this.nominativiTableAdapter.Connection.Open();
                    this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);

                    LoadList();
                    loadComboBox();
                }
            }
        }
    }
}
