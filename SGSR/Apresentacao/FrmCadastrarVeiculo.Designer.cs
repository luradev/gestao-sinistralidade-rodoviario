namespace Apresentacao
{
    partial class FrmCadastrarVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarVeiculo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_marca = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_tipo = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cmb_modelo = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.num_lotacao = new System.Windows.Forms.NumericUpDown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_matricula = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.modelo_btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modelo_cmb_marca = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.modelo_txt_nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.marca_btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.marca_txt_nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.IdVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lotacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ModeloVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.categoria_txt_nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.list_categoria = new System.Windows.Forms.ListBox();
            this.list_marca = new System.Windows.Forms.ListBox();
            this.list_modelo = new System.Windows.Forms.ListBox();
            this.categoria_btn_salvar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lotacao)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_marca);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.cmb_tipo);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.cmb_modelo);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.num_lotacao);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.txt_matricula);
            this.panel1.Location = new System.Drawing.Point(42, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 370);
            this.panel1.TabIndex = 1;
            // 
            // cmb_marca
            // 
            this.cmb_marca.BackColor = System.Drawing.Color.Transparent;
            this.cmb_marca.BorderRadius = 3;
            this.cmb_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_marca.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_marca.ForeColor = System.Drawing.Color.White;
            this.cmb_marca.Items = new string[0];
            this.cmb_marca.Location = new System.Drawing.Point(34, 173);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_marca.onHoverColor = System.Drawing.Color.Silver;
            this.cmb_marca.selectedIndex = -1;
            this.cmb_marca.Size = new System.Drawing.Size(369, 24);
            this.cmb_marca.TabIndex = 7;
            this.cmb_marca.onItemSelected += new System.EventHandler(this.cmb_marca_onItemSelected);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(31, 150);
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
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(245, 36);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Registar Veículo";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_tipo.BorderRadius = 3;
            this.cmb_tipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_tipo.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_tipo.ForeColor = System.Drawing.Color.White;
            this.cmb_tipo.Items = new string[0];
            this.cmb_tipo.Location = new System.Drawing.Point(36, 313);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_tipo.onHoverColor = System.Drawing.Color.Silver;
            this.cmb_tipo.selectedIndex = -1;
            this.cmb_tipo.Size = new System.Drawing.Size(369, 24);
            this.cmb_tipo.TabIndex = 7;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(33, 290);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(107, 17);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Tipo de Veículo";
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.BackColor = System.Drawing.Color.Transparent;
            this.cmb_modelo.BorderRadius = 3;
            this.cmb_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_modelo.DisabledColor = System.Drawing.Color.Gray;
            this.cmb_modelo.ForeColor = System.Drawing.Color.White;
            this.cmb_modelo.Items = new string[0];
            this.cmb_modelo.Location = new System.Drawing.Point(36, 242);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.cmb_modelo.onHoverColor = System.Drawing.Color.Silver;
            this.cmb_modelo.selectedIndex = -1;
            this.cmb_modelo.Size = new System.Drawing.Size(369, 24);
            this.cmb_modelo.TabIndex = 5;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(33, 219);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(57, 17);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Modelo";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(296, 87);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(63, 17);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Lotação";
            // 
            // num_lotacao
            // 
            this.num_lotacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.num_lotacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_lotacao.ForeColor = System.Drawing.Color.White;
            this.num_lotacao.Location = new System.Drawing.Point(299, 109);
            this.num_lotacao.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.num_lotacao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_lotacao.Name = "num_lotacao";
            this.num_lotacao.Size = new System.Drawing.Size(106, 20);
            this.num_lotacao.TabIndex = 2;
            this.num_lotacao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 87);
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
            this.txt_matricula.ForeColor = System.Drawing.Color.Silver;
            this.txt_matricula.isPassword = false;
            this.txt_matricula.Location = new System.Drawing.Point(34, 108);
            this.txt_matricula.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(221, 21);
            this.txt_matricula.TabIndex = 0;
            this.txt_matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(527, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 612);
            this.panel2.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(11, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 494);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.btn_salvar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Veículo";
            // 
            // btn_salvar
            // 
            this.btn_salvar.ActiveBorderThickness = 1;
            this.btn_salvar.ActiveCornerRadius = 1;
            this.btn_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.btn_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salvar.BackgroundImage")));
            this.btn_salvar.ButtonText = "Cadastrar";
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.btn_salvar.IdleBorderThickness = 1;
            this.btn_salvar.IdleCornerRadius = 1;
            this.btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btn_salvar.Location = new System.Drawing.Point(77, 418);
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
            this.tabPage2.Controls.Add(this.modelo_btn_salvar);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(522, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modelo";
            // 
            // modelo_btn_salvar
            // 
            this.modelo_btn_salvar.ActiveBorderThickness = 1;
            this.modelo_btn_salvar.ActiveCornerRadius = 1;
            this.modelo_btn_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.modelo_btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.modelo_btn_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.modelo_btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.modelo_btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modelo_btn_salvar.BackgroundImage")));
            this.modelo_btn_salvar.ButtonText = "Cadastrar";
            this.modelo_btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modelo_btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelo_btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.modelo_btn_salvar.IdleBorderThickness = 1;
            this.modelo_btn_salvar.IdleCornerRadius = 1;
            this.modelo_btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.modelo_btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.modelo_btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.modelo_btn_salvar.Location = new System.Drawing.Point(78, 419);
            this.modelo_btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.modelo_btn_salvar.Name = "modelo_btn_salvar";
            this.modelo_btn_salvar.Size = new System.Drawing.Size(369, 41);
            this.modelo_btn_salvar.TabIndex = 3;
            this.modelo_btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modelo_btn_salvar.Click += new System.EventHandler(this.modelo_btn_salvar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.list_modelo);
            this.panel3.Controls.Add(this.modelo_cmb_marca);
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
            this.modelo_cmb_marca.BackColor = System.Drawing.Color.Transparent;
            this.modelo_cmb_marca.BorderRadius = 3;
            this.modelo_cmb_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelo_cmb_marca.DisabledColor = System.Drawing.Color.Gray;
            this.modelo_cmb_marca.ForeColor = System.Drawing.Color.White;
            this.modelo_cmb_marca.Items = new string[0];
            this.modelo_cmb_marca.Location = new System.Drawing.Point(33, 190);
            this.modelo_cmb_marca.Name = "modelo_cmb_marca";
            this.modelo_cmb_marca.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.modelo_cmb_marca.onHoverColor = System.Drawing.Color.Silver;
            this.modelo_cmb_marca.selectedIndex = -1;
            this.modelo_cmb_marca.Size = new System.Drawing.Size(370, 30);
            this.modelo_cmb_marca.TabIndex = 7;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(30, 167);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(49, 17);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Marca";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(108, 17);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(249, 36);
            this.bunifuCustomLabel8.TabIndex = 8;
            this.bunifuCustomLabel8.Text = "Registar Modelo";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(33, 86);
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
            this.modelo_txt_nome.ForeColor = System.Drawing.Color.Silver;
            this.modelo_txt_nome.isPassword = false;
            this.modelo_txt_nome.Location = new System.Drawing.Point(34, 107);
            this.modelo_txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.modelo_txt_nome.Name = "modelo_txt_nome";
            this.modelo_txt_nome.Size = new System.Drawing.Size(369, 30);
            this.modelo_txt_nome.TabIndex = 0;
            this.modelo_txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.marca_btn_salvar);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(522, 468);
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
            this.marca_btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.marca_btn_salvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("marca_btn_salvar.BackgroundImage")));
            this.marca_btn_salvar.ButtonText = "Cadastrar";
            this.marca_btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.marca_btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marca_btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.marca_btn_salvar.IdleBorderThickness = 1;
            this.marca_btn_salvar.IdleCornerRadius = 1;
            this.marca_btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.marca_btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.marca_btn_salvar.Location = new System.Drawing.Point(78, 419);
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
            this.panel4.Controls.Add(this.list_marca);
            this.panel4.Controls.Add(this.bunifuCustomLabel14);
            this.panel4.Controls.Add(this.bunifuCustomLabel18);
            this.panel4.Controls.Add(this.marca_txt_nome);
            this.panel4.Location = new System.Drawing.Point(41, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 370);
            this.panel4.TabIndex = 2;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(111, 17);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(234, 36);
            this.bunifuCustomLabel14.TabIndex = 8;
            this.bunifuCustomLabel14.Text = "Registar Marca";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(34, 97);
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
            this.marca_txt_nome.ForeColor = System.Drawing.Color.Silver;
            this.marca_txt_nome.isPassword = false;
            this.marca_txt_nome.Location = new System.Drawing.Point(37, 118);
            this.marca_txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.marca_txt_nome.Name = "marca_txt_nome";
            this.marca_txt_nome.Size = new System.Drawing.Size(369, 31);
            this.marca_txt_nome.TabIndex = 0;
            this.marca_txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVeiculo,
            this.Matricula,
            this.Lotacao,
            this.ModeloVeiculo,
            this.TipoVeiculo});
            this.dataGridView.Location = new System.Drawing.Point(15, 75);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(497, 448);
            this.dataGridView.TabIndex = 3;
            // 
            // IdVeiculo
            // 
            this.IdVeiculo.HeaderText = "ID";
            this.IdVeiculo.Name = "IdVeiculo";
            // 
            // Matricula
            // 
            this.Matricula.HeaderText = "Matrícula";
            this.Matricula.Name = "Matricula";
            // 
            // Lotacao
            // 
            this.Lotacao.HeaderText = "Lotação";
            this.Lotacao.Name = "Lotacao";
            // 
            // ModeloVeiculo
            // 
            this.ModeloVeiculo.HeaderText = "Modelo";
            this.ModeloVeiculo.Name = "ModeloVeiculo";
            // 
            // TipoVeiculo
            // 
            this.TipoVeiculo.HeaderText = "Tipo";
            this.TipoVeiculo.Name = "TipoVeiculo";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.tabPage4.Controls.Add(this.categoria_btn_salvar);
            this.tabPage4.Controls.Add(this.panel5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(522, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Categoria";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.list_categoria);
            this.panel5.Controls.Add(this.bunifuCustomLabel9);
            this.panel5.Controls.Add(this.bunifuCustomLabel10);
            this.panel5.Controls.Add(this.categoria_txt_nome);
            this.panel5.Location = new System.Drawing.Point(41, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(440, 370);
            this.panel5.TabIndex = 3;
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(80, 17);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(285, 36);
            this.bunifuCustomLabel9.TabIndex = 8;
            this.bunifuCustomLabel9.Text = "Registar Categoria";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.Color.DarkGray;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(34, 97);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(54, 17);
            this.bunifuCustomLabel10.TabIndex = 1;
            this.bunifuCustomLabel10.Text = "Nome*";
            // 
            // categoria_txt_nome
            // 
            this.categoria_txt_nome.BorderColorFocused = System.Drawing.Color.Silver;
            this.categoria_txt_nome.BorderColorIdle = System.Drawing.Color.Gray;
            this.categoria_txt_nome.BorderColorMouseHover = System.Drawing.Color.Silver;
            this.categoria_txt_nome.BorderThickness = 1;
            this.categoria_txt_nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categoria_txt_nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.categoria_txt_nome.ForeColor = System.Drawing.Color.Silver;
            this.categoria_txt_nome.isPassword = false;
            this.categoria_txt_nome.Location = new System.Drawing.Point(37, 118);
            this.categoria_txt_nome.Margin = new System.Windows.Forms.Padding(4);
            this.categoria_txt_nome.Name = "categoria_txt_nome";
            this.categoria_txt_nome.Size = new System.Drawing.Size(369, 31);
            this.categoria_txt_nome.TabIndex = 0;
            this.categoria_txt_nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // list_categoria
            // 
            this.list_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.list_categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_categoria.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_categoria.ForeColor = System.Drawing.Color.White;
            this.list_categoria.FormattingEnabled = true;
            this.list_categoria.ItemHeight = 16;
            this.list_categoria.Location = new System.Drawing.Point(37, 207);
            this.list_categoria.Name = "list_categoria";
            this.list_categoria.Size = new System.Drawing.Size(369, 114);
            this.list_categoria.TabIndex = 9;
            // 
            // list_marca
            // 
            this.list_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.list_marca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_marca.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_marca.ForeColor = System.Drawing.Color.White;
            this.list_marca.FormattingEnabled = true;
            this.list_marca.ItemHeight = 16;
            this.list_marca.Location = new System.Drawing.Point(37, 207);
            this.list_marca.Name = "list_marca";
            this.list_marca.Size = new System.Drawing.Size(369, 114);
            this.list_marca.TabIndex = 10;
            // 
            // list_modelo
            // 
            this.list_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.list_modelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list_modelo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_modelo.ForeColor = System.Drawing.Color.White;
            this.list_modelo.FormattingEnabled = true;
            this.list_modelo.ItemHeight = 16;
            this.list_modelo.Location = new System.Drawing.Point(33, 252);
            this.list_modelo.Name = "list_modelo";
            this.list_modelo.Size = new System.Drawing.Size(369, 98);
            this.list_modelo.TabIndex = 11;
            // 
            // categoria_btn_salvar
            // 
            this.categoria_btn_salvar.ActiveBorderThickness = 1;
            this.categoria_btn_salvar.ActiveCornerRadius = 1;
            this.categoria_btn_salvar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.categoria_btn_salvar.ActiveForecolor = System.Drawing.Color.White;
            this.categoria_btn_salvar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.categoria_btn_salvar.BackColor = System.Drawing.Color.SeaGreen;
            this.categoria_btn_salvar.ButtonText = "Cadastrar";
            this.categoria_btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoria_btn_salvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria_btn_salvar.ForeColor = System.Drawing.Color.DarkGray;
            this.categoria_btn_salvar.IdleBorderThickness = 1;
            this.categoria_btn_salvar.IdleCornerRadius = 1;
            this.categoria_btn_salvar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.categoria_btn_salvar.IdleForecolor = System.Drawing.Color.DarkGray;
            this.categoria_btn_salvar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.categoria_btn_salvar.Location = new System.Drawing.Point(78, 419);
            this.categoria_btn_salvar.Margin = new System.Windows.Forms.Padding(5);
            this.categoria_btn_salvar.Name = "categoria_btn_salvar";
            this.categoria_btn_salvar.Size = new System.Drawing.Size(369, 41);
            this.categoria_btn_salvar.TabIndex = 5;
            this.categoria_btn_salvar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.categoria_btn_salvar.Click += new System.EventHandler(this.categoria_btn_salvar_Click);
            // 
            // FrmCadastrarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCadastrarVeiculo";
            this.Text = "FrmCadastrarVeiculo";
            this.Load += new System.EventHandler(this.FrmCadastrarVeiculo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_lotacao)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDropdown cmb_tipo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuDropdown cmb_modelo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.NumericUpDown num_lotacao;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_matricula;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuThinButton2 btn_salvar;
        private Bunifu.Framework.UI.BunifuDropdown cmb_marca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lotacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModeloVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVeiculo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuDropdown modelo_cmb_marca;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuMetroTextbox modelo_txt_nome;
        private System.Windows.Forms.TabPage tabPage3;
        private Bunifu.Framework.UI.BunifuThinButton2 modelo_btn_salvar;
        private Bunifu.Framework.UI.BunifuThinButton2 marca_btn_salvar;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private Bunifu.Framework.UI.BunifuMetroTextbox marca_txt_nome;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuMetroTextbox categoria_txt_nome;
        private System.Windows.Forms.ListBox list_modelo;
        private System.Windows.Forms.ListBox list_marca;
        private Bunifu.Framework.UI.BunifuThinButton2 categoria_btn_salvar;
        private System.Windows.Forms.ListBox list_categoria;
    }
}