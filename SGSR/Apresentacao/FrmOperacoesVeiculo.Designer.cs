namespace Apresentacao
{
    partial class FrmOperacoesVeiculo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.txt_lotacao = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_id = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_matricula = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modelo_btn_eliminar = new System.Windows.Forms.Button();
            this.modelo_btn_edit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modelo_cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_idModelo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.list_modelo = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modelo_txt_nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.marca_btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.list_marca = new System.Windows.Forms.ListBox();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.marca_txt_nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_modelo_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_MarcaID = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_marca_eliminar = new System.Windows.Forms.Button();
            this.btn_marca_editar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(527, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 612);
            this.panel2.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 494);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_salvar);
            this.tabPage1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 465);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Editar Veículo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_marca);
            this.panel1.Controls.Add(this.cmb_modelo);
            this.panel1.Controls.Add(this.cmb_tipo);
            this.panel1.Controls.Add(this.txt_lotacao);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txt_matricula);
            this.panel1.Location = new System.Drawing.Point(42, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 370);
            this.panel1.TabIndex = 1;
            // 
            // cmb_marca
            // 
            this.cmb_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_marca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_marca.ForeColor = System.Drawing.Color.White;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(32, 169);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(371, 25);
            this.cmb_marca.TabIndex = 10;
            this.cmb_marca.SelectedValueChanged += new System.EventHandler(this.cmb_marca_SelectedValueChanged);
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_modelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modelo.ForeColor = System.Drawing.Color.White;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(32, 238);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(371, 25);
            this.cmb_modelo.TabIndex = 10;
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_tipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.ForeColor = System.Drawing.Color.White;
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(34, 309);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(371, 25);
            this.cmb_tipo.TabIndex = 10;
            // 
            // txt_lotacao
            // 
            this.txt_lotacao.BorderColorFocused = System.Drawing.Color.Silver;
            this.txt_lotacao.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_lotacao.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txt_lotacao.BorderThickness = 1;
            this.txt_lotacao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lotacao.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lotacao.ForeColor = System.Drawing.Color.White;
            this.txt_lotacao.isPassword = false;
            this.txt_lotacao.Location = new System.Drawing.Point(299, 107);
            this.txt_lotacao.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lotacao.Name = "txt_lotacao";
            this.txt_lotacao.Size = new System.Drawing.Size(106, 25);
            this.txt_lotacao.TabIndex = 9;
            this.txt_lotacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(31, 149);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel6.TabIndex = 6;
            this.bunifuCustomLabel6.Text = "Marca";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(111, 17);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(213, 36);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Editar Veículo";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(33, 289);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Tipo de Veículo";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 218);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Modelo";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_id.Location = new System.Drawing.Point(383, 66);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 17);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Id";
            this.lbl_id.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(296, 86);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Lotação";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 86);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(74, 17);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Matricula*";
            // 
            // txt_matricula
            // 
            this.txt_matricula.BorderColorFocused = System.Drawing.Color.Silver;
            this.txt_matricula.BorderColorIdle = System.Drawing.Color.Gray;
            this.txt_matricula.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.txt_matricula.BorderThickness = 1;
            this.txt_matricula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matricula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_matricula.ForeColor = System.Drawing.Color.White;
            this.txt_matricula.isPassword = false;
            this.txt_matricula.Location = new System.Drawing.Point(34, 107);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(221, 25);
            this.txt_matricula.TabIndex = 0;
            this.txt_matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_salvar
            // 
            this.btn_salvar.ActiveBorderThickness = 1;
            this.btn_salvar.ActiveCornerRadius = 1;
            this.btn_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.ButtonText = "Guardar";
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.IdleBorderThickness = 1;
            this.btn_salvar.IdleCornerRadius = 1;
            this.btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.Location = new System.Drawing.Point(77, 414);
            this.btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(369, 41);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.btn_modelo_salvar);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 465);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo";
            // 
            // modelo_btn_eliminar
            // 
            this.modelo_btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modelo_btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.modelo_btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelo_btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_btn_eliminar.ForeColor = System.Drawing.Color.Silver;
            this.modelo_btn_eliminar.Location = new System.Drawing.Point(236, 332);
            this.modelo_btn_eliminar.Name = "modelo_btn_eliminar";
            this.modelo_btn_eliminar.Size = new System.Drawing.Size(77, 24);
            this.modelo_btn_eliminar.TabIndex = 42;
            this.modelo_btn_eliminar.Text = "Eliminar";
            this.modelo_btn_eliminar.UseVisualStyleBackColor = true;
            this.modelo_btn_eliminar.Click += new System.EventHandler(this.modelo_btn_eliminar_Click);
            // 
            // modelo_btn_edit
            // 
            this.modelo_btn_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modelo_btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.modelo_btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelo_btn_edit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_btn_edit.ForeColor = System.Drawing.Color.Silver;
            this.modelo_btn_edit.Location = new System.Drawing.Point(144, 332);
            this.modelo_btn_edit.Name = "modelo_btn_edit";
            this.modelo_btn_edit.Size = new System.Drawing.Size(77, 24);
            this.modelo_btn_edit.TabIndex = 41;
            this.modelo_btn_edit.Text = "Editar";
            this.modelo_btn_edit.UseVisualStyleBackColor = true;
            this.modelo_btn_edit.Click += new System.EventHandler(this.modelo_btn_edit_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.modelo_btn_eliminar);
            this.panel3.Controls.Add(this.modelo_cmb_marca);
            this.panel3.Controls.Add(this.modelo_btn_edit);
            this.panel3.Controls.Add(this.lbl_idModelo);
            this.panel3.Controls.Add(this.bunifuCustomLabel11);
            this.panel3.Controls.Add(this.list_modelo);
            this.panel3.Controls.Add(this.bunifuCustomLabel7);
            this.panel3.Controls.Add(this.bunifuCustomLabel8);
            this.panel3.Controls.Add(this.bunifuCustomLabel12);
            this.panel3.Controls.Add(this.modelo_txt_nome);
            this.panel3.Location = new System.Drawing.Point(42, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 370);
            this.panel3.TabIndex = 2;
            // 
            // modelo_cmb_marca
            // 
            this.modelo_cmb_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.modelo_cmb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modelo_cmb_marca.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_cmb_marca.ForeColor = System.Drawing.Color.White;
            this.modelo_cmb_marca.FormattingEnabled = true;
            this.modelo_cmb_marca.Location = new System.Drawing.Point(36, 152);
            this.modelo_cmb_marca.Name = "modelo_cmb_marca";
            this.modelo_cmb_marca.Size = new System.Drawing.Size(371, 25);
            this.modelo_cmb_marca.TabIndex = 14;
            // 
            // lbl_idModelo
            // 
            this.lbl_idModelo.AutoSize = true;
            this.lbl_idModelo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idModelo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_idModelo.Location = new System.Drawing.Point(382, 65);
            this.lbl_idModelo.Name = "lbl_idModelo";
            this.lbl_idModelo.Size = new System.Drawing.Size(20, 17);
            this.lbl_idModelo.TabIndex = 13;
            this.lbl_idModelo.Text = "Id";
            this.lbl_idModelo.Visible = false;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(36, 192);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(62, 17);
            this.bunifuCustomLabel11.TabIndex = 12;
            this.bunifuCustomLabel11.Text = "Modelos";
            // 
            // list_modelo
            // 
            this.list_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.list_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_modelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_modelo.ForeColor = System.Drawing.Color.White;
            this.list_modelo.FormattingEnabled = true;
            this.list_modelo.ItemHeight = 16;
            this.list_modelo.Location = new System.Drawing.Point(36, 214);
            this.list_modelo.Name = "list_modelo";
            this.list_modelo.Size = new System.Drawing.Size(369, 98);
            this.list_modelo.TabIndex = 11;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(33, 131);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Marca*";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(110, 18);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(217, 36);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Editar Modelo";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(33, 65);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel12.TabIndex = 1;
            this.bunifuCustomLabel12.Text = "Nome*";
            // 
            // modelo_txt_nome
            // 
            this.modelo_txt_nome.BorderColorFocused = System.Drawing.Color.Silver;
            this.modelo_txt_nome.BorderColorIdle = System.Drawing.Color.Gray;
            this.modelo_txt_nome.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.modelo_txt_nome.BorderThickness = 1;
            this.modelo_txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modelo_txt_nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.modelo_txt_nome.ForeColor = System.Drawing.Color.White;
            this.modelo_txt_nome.isPassword = false;
            this.modelo_txt_nome.Location = new System.Drawing.Point(34, 86);
            this.modelo_txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.modelo_txt_nome.Name = "modelo_txt_nome";
            this.modelo_txt_nome.Size = new System.Drawing.Size(369, 25);
            this.modelo_txt_nome.TabIndex = 0;
            this.modelo_txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.marca_btn_salvar);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 465);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Marca";
            // 
            // marca_btn_salvar
            // 
            this.marca_btn_salvar.ActiveBorderThickness = 1;
            this.marca_btn_salvar.ActiveCornerRadius = 1;
            this.marca_btn_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.marca_btn_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.BackColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.ButtonText = "Guardar";
            this.marca_btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marca_btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.marca_btn_salvar.IdleBorderThickness = 1;
            this.marca_btn_salvar.IdleCornerRadius = 1;
            this.marca_btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.marca_btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.Location = new System.Drawing.Point(78, 415);
            this.marca_btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.marca_btn_salvar.Name = "marca_btn_salvar";
            this.marca_btn_salvar.Size = new System.Drawing.Size(369, 41);
            this.marca_btn_salvar.TabIndex = 4;
            this.marca_btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.marca_btn_salvar.Click += new System.EventHandler(this.marca_btn_salvar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btn_marca_eliminar);
            this.panel4.Controls.Add(this.btn_marca_editar);
            this.panel4.Controls.Add(this.lbl_MarcaID);
            this.panel4.Controls.Add(this.bunifuCustomLabel13);
            this.panel4.Controls.Add(this.list_marca);
            this.panel4.Controls.Add(this.bunifuCustomLabel14);
            this.panel4.Controls.Add(this.bunifuCustomLabel18);
            this.panel4.Controls.Add(this.marca_txt_nome);
            this.panel4.Location = new System.Drawing.Point(41, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 370);
            this.panel4.TabIndex = 2;
            // 
            // list_marca
            // 
            this.list_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.list_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_marca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_marca.ForeColor = System.Drawing.Color.White;
            this.list_marca.FormattingEnabled = true;
            this.list_marca.ItemHeight = 16;
            this.list_marca.Location = new System.Drawing.Point(36, 203);
            this.list_marca.Name = "list_marca";
            this.list_marca.Size = new System.Drawing.Size(369, 114);
            this.list_marca.TabIndex = 10;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(116, 18);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(202, 36);
            this.bunifuCustomLabel14.TabIndex = 8;
            this.bunifuCustomLabel14.Text = "Editar Marca";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(33, 93);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel18.TabIndex = 1;
            this.bunifuCustomLabel18.Text = "Nome*";
            // 
            // marca_txt_nome
            // 
            this.marca_txt_nome.BorderColorFocused = System.Drawing.Color.Silver;
            this.marca_txt_nome.BorderColorIdle = System.Drawing.Color.Gray;
            this.marca_txt_nome.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.marca_txt_nome.BorderThickness = 1;
            this.marca_txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.marca_txt_nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.marca_txt_nome.ForeColor = System.Drawing.Color.White;
            this.marca_txt_nome.isPassword = false;
            this.marca_txt_nome.Location = new System.Drawing.Point(36, 114);
            this.marca_txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.marca_txt_nome.Name = "marca_txt_nome";
            this.marca_txt_nome.Size = new System.Drawing.Size(369, 31);
            this.marca_txt_nome.TabIndex = 0;
            this.marca_txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 36;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVeiculo,
            this.Matricula,
            this.Lotacao,
            this.Modelo,
            this.Tipo});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.Location = new System.Drawing.Point(16, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(496, 370);
            this.dataGridView1.TabIndex = 7;
            // 
            // IdVeiculo
            // 
            this.IdVeiculo.HeaderText = "ID";
            this.IdVeiculo.Name = "IdVeiculo";
            this.IdVeiculo.ReadOnly = true;
            this.IdVeiculo.Width = 44;
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            this.Matricula.ReadOnly = true;
            this.Matricula.Width = 91;
            // 
            // Lotacao
            // 
            this.Lotacao.HeaderText = "Lotação";
            this.Lotacao.Name = "Lotacao";
            this.Lotacao.ReadOnly = true;
            this.Lotacao.Width = 86;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 57;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(16, 470);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(93, 28);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.Red;
            this.btn_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(127, 470);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(93, 28);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modelo_salvar
            // 
            this.btn_modelo_salvar.ActiveBorderThickness = 1;
            this.btn_modelo_salvar.ActiveCornerRadius = 1;
            this.btn_modelo_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_modelo_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_modelo_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_modelo_salvar.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_modelo_salvar.ButtonText = "Guardar";
            this.btn_modelo_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modelo_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modelo_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_modelo_salvar.IdleBorderThickness = 1;
            this.btn_modelo_salvar.IdleCornerRadius = 1;
            this.btn_modelo_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_modelo_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btn_modelo_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_modelo_salvar.Location = new System.Drawing.Point(81, 412);
            this.btn_modelo_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_modelo_salvar.Name = "btn_modelo_salvar";
            this.btn_modelo_salvar.Size = new System.Drawing.Size(369, 41);
            this.btn_modelo_salvar.TabIndex = 3;
            this.btn_modelo_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modelo_salvar.Click += new System.EventHandler(this.btn_modelo_salvar_Click);
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(33, 183);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel13.TabIndex = 11;
            this.bunifuCustomLabel13.Text = "Marcas";
            // 
            // lbl_MarcaID
            // 
            this.lbl_MarcaID.AutoSize = true;
            this.lbl_MarcaID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarcaID.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_MarcaID.Location = new System.Drawing.Point(385, 93);
            this.lbl_MarcaID.Name = "lbl_MarcaID";
            this.lbl_MarcaID.Size = new System.Drawing.Size(20, 17);
            this.lbl_MarcaID.TabIndex = 12;
            this.lbl_MarcaID.Text = "Id";
            this.lbl_MarcaID.Visible = false;
            // 
            // btn_marca_eliminar
            // 
            this.btn_marca_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_marca_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marca_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marca_eliminar.ForeColor = System.Drawing.Color.Silver;
            this.btn_marca_eliminar.Location = new System.Drawing.Point(223, 332);
            this.btn_marca_eliminar.Name = "btn_marca_eliminar";
            this.btn_marca_eliminar.Size = new System.Drawing.Size(77, 24);
            this.btn_marca_eliminar.TabIndex = 44;
            this.btn_marca_eliminar.Text = "Eliminar";
            this.btn_marca_eliminar.UseVisualStyleBackColor = true;
            this.btn_marca_eliminar.Click += new System.EventHandler(this.btn_marca_eliminar_Click);
            // 
            // btn_marca_editar
            // 
            this.btn_marca_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btn_marca_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marca_editar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_marca_editar.ForeColor = System.Drawing.Color.Silver;
            this.btn_marca_editar.Location = new System.Drawing.Point(131, 332);
            this.btn_marca_editar.Name = "btn_marca_editar";
            this.btn_marca_editar.Size = new System.Drawing.Size(77, 24);
            this.btn_marca_editar.TabIndex = 43;
            this.btn_marca_editar.Text = "Editar";
            this.btn_marca_editar.UseVisualStyleBackColor = true;
            this.btn_marca_editar.Click += new System.EventHandler(this.btn_marca_editar_Click);
            // 
            // FrmOperacoesVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOperacoesVeiculo";
            this.Text = "FrmOperacoesVeiculo";
            this.Load += new System.EventHandler(this.FrmOperacoesVeiculo_Load);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_matricula;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox list_modelo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMetroTextbox modelo_txt_nome;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuThinButton2 marca_btn_salvar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox list_marca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuMetroTextbox marca_txt_nome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_lotacao;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_id;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Button modelo_btn_eliminar;
        private System.Windows.Forms.Button modelo_btn_edit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_idModelo;
        private System.Windows.Forms.ComboBox modelo_cmb_marca;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_modelo_salvar;
        private System.Windows.Forms.Button btn_marca_eliminar;
        private System.Windows.Forms.Button btn_marca_editar;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_MarcaID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
    }
}