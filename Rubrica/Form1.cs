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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet1.nominativi'. È possibile spostarla o rimuoverla se necessario.
            this.nominativiTableAdapter.Fill(this.dataSet1.nominativi);

            LoadList();


        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominativiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

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


    }
}
