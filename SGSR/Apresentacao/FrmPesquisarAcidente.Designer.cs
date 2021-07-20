namespace Apresentacao
{
    partial class FrmPesquisarAcidente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPesquisarAcidente));
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DataAcidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Província = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Via = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAcidente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.data_acidente_2 = new System.Windows.Forms.DateTimePicker();
            this.data_acidente_1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_municipio = new System.Windows.Forms.ComboBox();
            this.cmb_provincia = new System.Windows.Forms.ComboBox();
            this.rdb_provincia = new System.Windows.Forms.RadioButton();
            this.rdb_data_intervalo = new System.Windows.Forms.RadioButton();
            this.rdb_municipio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(383, 8);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(340, 36);
            this.bunifuCustomLabel5.TabIndex = 9;
            this.bunifuCustomLabel5.Text = "Consulta de Acidentes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 554);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 528);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta por data";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataAcidente,
            this.Província,
            this.Municipio,
            this.Via,
            this.Periodo,
            this.Matricula,
            this.Modelo,
            this.Condutor,
            this.Classificacao,
            this.IdAcidente});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(2, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1045, 259);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // DataAcidente
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataAcidente.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataAcidente.HeaderText = "Data-Acidente";
            this.DataAcidente.Name = "DataAcidente";
            this.DataAcidente.ReadOnly = true;
            this.DataAcidente.Width = 126;
            // 
            // Província
            // 
            this.Província.HeaderText = "Provincia";
            this.Província.Name = "Província";
            this.Província.ReadOnly = true;
            this.Província.Width = 91;
            // 
            // Municipio
            // 
            this.Municipio.HeaderText = "Município";
            this.Municipio.Name = "Municipio";
            this.Municipio.ReadOnly = true;
            this.Municipio.Width = 93;
            // 
            // Via
            // 
            this.Via.HeaderText = "Via";
            this.Via.Name = "Via";
            this.Via.ReadOnly = true;
            this.Via.Width = 52;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "Período";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            this.Periodo.Width = 81;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula do Veículo";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 107;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo do Veículo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 140;
            // 
            // Condutor
            // 
            this.Condutor.HeaderText = "Condutor";
            this.Condutor.Name = "Condutor";
            this.Condutor.ReadOnly = true;
            this.Condutor.Width = 94;
            // 
            // Classificacao
            // 
            this.Classificacao.HeaderText = "Classificação";
            this.Classificacao.Name = "Classificacao";
            this.Classificacao.ReadOnly = true;
            this.Classificacao.Width = 117;
            // 
            // IdAcidente
            // 
            this.IdAcidente.HeaderText = "ID";
            this.IdAcidente.Name = "IdAcidente";
            this.IdAcidente.ReadOnly = true;
            this.IdAcidente.Visible = false;
            this.IdAcidente.Width = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_buscar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 211);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_buscar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Image = ((System.Drawing.Image)(resources.GetObject("btn_buscar.Image")));
            this.btn_buscar.Location = new System.Drawing.Point(455, 179);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(76, 25);
            this.btn_buscar.TabIndex = 7;
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.data_acidente_2);
            this.groupBox2.Controls.Add(this.data_acidente_1);
            this.groupBox2.Controls.Add(this.cmb_municipio);
            this.groupBox2.Controls.Add(this.cmb_provincia);
            this.groupBox2.Controls.Add(this.rdb_provincia);
            this.groupBox2.Controls.Add(this.rdb_data_intervalo);
            this.groupBox2.Controls.Add(this.rdb_municipio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 152);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // data_acidente_2
            // 
            this.data_acidente_2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_acidente_2.Location = new System.Drawing.Point(341, 22);
            this.data_acidente_2.Name = "data_acidente_2";
            this.data_acidente_2.Size = new System.Drawing.Size(168, 20);
            this.data_acidente_2.TabIndex = 16;
            // 
            // data_acidente_1
            // 
            this.data_acidente_1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_acidente_1.Location = new System.Drawing.Point(48, 22);
            this.data_acidente_1.Name = "data_acidente_1";
            this.data_acidente_1.Size = new System.Drawing.Size(179, 20);
            this.data_acidente_1.TabIndex = 16;
            // 
            // cmb_municipio
            // 
            this.cmb_municipio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmb_municipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_municipio.Enabled = false;
            this.cmb_municipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_municipio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_municipio.ForeColor = System.Drawing.Color.White;
            this.cmb_municipio.FormattingEnabled = true;
            this.cmb_municipio.Location = new System.Drawing.Point(301, 109);
            this.cmb_municipio.Name = "cmb_municipio";
            this.cmb_municipio.Size = new System.Drawing.Size(208, 24);
            this.cmb_municipio.TabIndex = 15;
            // 
            // cmb_provincia
            // 
            this.cmb_provincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cmb_provincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_provincia.Enabled = false;
            this.cmb_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_provincia.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_provincia.ForeColor = System.Drawing.Color.White;
            this.cmb_provincia.FormattingEnabled = true;
            this.cmb_provincia.Location = new System.Drawing.Point(19, 109);
            this.cmb_provincia.Name = "cmb_provincia";
            this.cmb_provincia.Size = new System.Drawing.Size(208, 24);
            this.cmb_provincia.TabIndex = 15;
            this.cmb_provincia.SelectionChangeCommitted += new System.EventHandler(this.cmb_provincia_SelectionChangeCommitted);
            // 
            // rdb_provincia
            // 
            this.rdb_provincia.AutoSize = true;
            this.rdb_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdb_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_provincia.Location = new System.Drawing.Point(220, 57);
            this.rdb_provincia.Name = "rdb_provincia";
            this.rdb_provincia.Size = new System.Drawing.Size(89, 17);
            this.rdb_provincia.TabIndex = 14;
            this.rdb_provincia.Text = "Por Província";
            this.rdb_provincia.UseVisualStyleBackColor = true;
            this.rdb_provincia.CheckedChanged += new System.EventHandler(this.rdb_provincia_CheckedChanged);
            // 
            // rdb_data_intervalo
            // 
            this.rdb_data_intervalo.AutoSize = true;
            this.rdb_data_intervalo.Checked = true;
            this.rdb_data_intervalo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdb_data_intervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_data_intervalo.Location = new System.Drawing.Point(83, 57);
            this.rdb_data_intervalo.Name = "rdb_data_intervalo";
            this.rdb_data_intervalo.Size = new System.Drawing.Size(66, 17);
            this.rdb_data_intervalo.TabIndex = 14;
            this.rdb_data_intervalo.TabStop = true;
            this.rdb_data_intervalo.Text = "Por Data";
            this.rdb_data_intervalo.UseVisualStyleBackColor = true;
            this.rdb_data_intervalo.CheckedChanged += new System.EventHandler(this.rdb_data_intervalo_CheckedChanged);
            // 
            // rdb_municipio
            // 
            this.rdb_municipio.AutoSize = true;
            this.rdb_municipio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rdb_municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_municipio.Location = new System.Drawing.Point(370, 57);
            this.rdb_municipio.Name = "rdb_municipio";
            this.rdb_municipio.Size = new System.Drawing.Size(90, 17);
            this.rdb_municipio.TabIndex = 14;
            this.rdb_municipio.Text = "Por Município";
            this.rdb_municipio.UseVisualStyleBackColor = true;
            this.rdb_municipio.CheckedChanged += new System.EventHandler(this.rdb_municipio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Para:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Município";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Província";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "De:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 528);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // FrmPesquisarAcidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPesquisarAcidente";
            this.Text = "FrmPesquisarAcidente";
            this.Load += new System.EventHandler(this.FrmPesquisarAcidente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataAcidente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Província;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Via;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAcidente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_municipio;
        private System.Windows.Forms.ComboBox cmb_provincia;
        private System.Windows.Forms.RadioButton rdb_provincia;
        private System.Windows.Forms.RadioButton rdb_data_intervalo;
        private System.Windows.Forms.RadioButton rdb_municipio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker data_acidente_2;
        private System.Windows.Forms.DateTimePicker data_acidente_1;
    }
}