namespace Rubrica
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scrBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.srcTxtTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srcTxtCognome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.srcTxtNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnOrderNomeAsc = new System.Windows.Forms.Button();
            this.dataSet1 = new Rubrica.DataSet1();
            this.nominativiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominativiTableAdapter = new Rubrica.DataSet1TableAdapters.nominativiTableAdapter();
            this.tableAdapterManager = new Rubrica.DataSet1TableAdapters.TableAdapterManager();
            this.btnOrderNomeDesc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominativiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(13, 13);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(783, 398);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cognome";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Telefono";
            this.columnHeader4.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scrBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.srcTxtTelefono);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.srcTxtCognome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.srcTxtNome);
            this.groupBox1.Location = new System.Drawing.Point(13, 417);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca";
            // 
            // scrBtn
            // 
            this.scrBtn.Location = new System.Drawing.Point(77, 107);
            this.scrBtn.Name = "scrBtn";
            this.scrBtn.Size = new System.Drawing.Size(113, 23);
            this.scrBtn.TabIndex = 6;
            this.scrBtn.Text = "Cerca";
            this.scrBtn.UseVisualStyleBackColor = true;
            this.scrBtn.Click += new System.EventHandler(this.scrBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefono:";
            // 
            // srcTxtTelefono
            // 
            this.srcTxtTelefono.Location = new System.Drawing.Point(77, 79);
            this.srcTxtTelefono.Name = "srcTxtTelefono";
            this.srcTxtTelefono.Size = new System.Drawing.Size(113, 20);
            this.srcTxtTelefono.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome:";
            // 
            // srcTxtCognome
            // 
            this.srcTxtCognome.Location = new System.Drawing.Point(77, 49);
            this.srcTxtCognome.Name = "srcTxtCognome";
            this.srcTxtCognome.Size = new System.Drawing.Size(113, 20);
            this.srcTxtCognome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // srcTxtNome
            // 
            this.srcTxtNome.Location = new System.Drawing.Point(77, 19);
            this.srcTxtNome.Name = "srcTxtNome";
            this.srcTxtNome.Size = new System.Drawing.Size(113, 20);
            this.srcTxtNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIndirizzo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtFax);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCell);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCognome);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(215, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(581, 138);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Aggiunta";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Window;
            this.txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNote.Location = new System.Drawing.Point(441, 19);
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtNote.Size = new System.Drawing.Size(134, 80);
            this.txtNote.TabIndex = 14;
            this.txtNote.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(401, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Note:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Indirizzo:";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(276, 79);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(113, 20);
            this.txtIndirizzo.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fax:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(276, 49);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(113, 20);
            this.txtFax.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cellulare:";
            // 
            // txtCell
            // 
            this.txtCell.Location = new System.Drawing.Point(276, 19);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(113, 20);
            this.txtCell.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(441, 107);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Aggiungi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefono:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(77, 79);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(113, 20);
            this.txtTel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cognome:";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(77, 49);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(113, 20);
            this.txtCognome.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(113, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnOrderNomeAsc
            // 
            this.btnOrderNomeAsc.Location = new System.Drawing.Point(13, 562);
            this.btnOrderNomeAsc.Name = "btnOrderNomeAsc";
            this.btnOrderNomeAsc.Size = new System.Drawing.Size(392, 23);
            this.btnOrderNomeAsc.TabIndex = 8;
            this.btnOrderNomeAsc.Text = "Ordina per Nome ASC";
            this.btnOrderNomeAsc.UseVisualStyleBackColor = true;
            this.btnOrderNomeAsc.Click += new System.EventHandler(this.btnOrderNomeAsc_Click);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominativiBindingSource
            // 
            this.nominativiBindingSource.DataMember = "nominativi";
            this.nominativiBindingSource.DataSource = this.dataSet1;
            // 
            // nominativiTableAdapter
            // 
            this.nominativiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.nominativiTableAdapter = this.nominativiTableAdapter;
            this.tableAdapterManager.UpdateOrder = Rubrica.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnOrderNomeDesc
            // 
            this.btnOrderNomeDesc.Location = new System.Drawing.Point(12, 591);
            this.btnOrderNomeDesc.Name = "btnOrderNomeDesc";
            this.btnOrderNomeDesc.Size = new System.Drawing.Size(392, 23);
            this.btnOrderNomeDesc.TabIndex = 9;
            this.btnOrderNomeDesc.Text = "Ordina per Nome DESC";
            this.btnOrderNomeDesc.UseVisualStyleBackColor = true;
            this.btnOrderNomeDesc.Click += new System.EventHandler(this.btnOrderNomeDesc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 623);
            this.Controls.Add(this.btnOrderNomeDesc);
            this.Controls.Add(this.btnOrderNomeAsc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominativiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nominativiBindingSource;
        private DataSet1TableAdapters.nominativiTableAdapter nominativiTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scrBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox srcTxtTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srcTxtCognome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox srcTxtNome;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnOrderNomeAsc;
        private System.Windows.Forms.Button btnOrderNomeDesc;
    }
}

