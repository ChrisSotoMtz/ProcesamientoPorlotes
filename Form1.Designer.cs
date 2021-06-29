
namespace Procesamiento_por_lotes
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.id_tb = new System.Windows.Forms.TextBox();
            this.tiempo_tb = new System.Windows.Forms.TextBox();
            this.primerNum = new System.Windows.Forms.TextBox();
            this.segundoNum = new System.Windows.Forms.TextBox();
            this.operando = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.agregar = new System.Windows.Forms.Button();
            this.nombre_tb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numlote = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.registros = new System.Windows.Forms.TabPage();
            this.registroTabla = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ejecucion = new System.Windows.Forms.TabPage();
            this.loteActual_ = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tbTiempo = new System.Windows.Forms.TextBox();
            this.tbOp = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.Title2 = new System.Windows.Forms.TextBox();
            this.Pendientes = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tablaCompletados = new System.Windows.Forms.ListView();
            this.lote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tiempo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.op = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title1 = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tbTiempoTr = new System.Windows.Forms.TextBox();
            this.Conteo = new System.Windows.Forms.Timer(this.components);
            this.tiempoProceso = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.registros.SuspendLayout();
            this.ejecucion.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_tb
            // 
            this.id_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.id_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_tb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_tb.ForeColor = System.Drawing.Color.Silver;
            this.id_tb.Location = new System.Drawing.Point(576, 104);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(159, 24);
            this.id_tb.TabIndex = 5;
            this.id_tb.Text = "ID";
            this.id_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_tb.Enter += new System.EventHandler(this.id_tb_Enter);
            this.id_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_tb_KeyPress);
            this.id_tb.Leave += new System.EventHandler(this.id_tb_Leave);
            // 
            // tiempo_tb
            // 
            this.tiempo_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tiempo_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tiempo_tb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempo_tb.ForeColor = System.Drawing.Color.Silver;
            this.tiempo_tb.Location = new System.Drawing.Point(576, 202);
            this.tiempo_tb.Name = "tiempo_tb";
            this.tiempo_tb.Size = new System.Drawing.Size(159, 24);
            this.tiempo_tb.TabIndex = 7;
            this.tiempo_tb.Text = "Tiempo Estimado";
            this.tiempo_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tiempo_tb.Enter += new System.EventHandler(this.tiempo_tb_Enter);
            this.tiempo_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tiempo_tb_KeyPress);
            this.tiempo_tb.Leave += new System.EventHandler(this.tiempo_tb_Leave);
            // 
            // primerNum
            // 
            this.primerNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.primerNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.primerNum.ForeColor = System.Drawing.Color.Silver;
            this.primerNum.Location = new System.Drawing.Point(576, 250);
            this.primerNum.Name = "primerNum";
            this.primerNum.Size = new System.Drawing.Size(47, 31);
            this.primerNum.TabIndex = 8;
            this.primerNum.Text = "--";
            this.primerNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.primerNum.Enter += new System.EventHandler(this.primerNum_Enter);
            this.primerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.primerNum_KeyPress);
            this.primerNum.Leave += new System.EventHandler(this.primerNum_Leave);
            // 
            // segundoNum
            // 
            this.segundoNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.segundoNum.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoNum.ForeColor = System.Drawing.Color.Silver;
            this.segundoNum.Location = new System.Drawing.Point(688, 250);
            this.segundoNum.Name = "segundoNum";
            this.segundoNum.Size = new System.Drawing.Size(47, 31);
            this.segundoNum.TabIndex = 9;
            this.segundoNum.Text = "--";
            this.segundoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.segundoNum.Enter += new System.EventHandler(this.segundoNum_Enter);
            this.segundoNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.segundoNum_KeyPress);
            this.segundoNum.Leave += new System.EventHandler(this.segundoNum_Leave);
            // 
            // operando
            // 
            this.operando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.operando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operando.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operando.ForeColor = System.Drawing.Color.DodgerBlue;
            this.operando.FormattingEnabled = true;
            this.operando.Items.AddRange(new object[] {
            "+",
            "-",
            "X",
            "/",
            "%"});
            this.operando.Location = new System.Drawing.Point(629, 250);
            this.operando.Name = "operando";
            this.operando.Size = new System.Drawing.Size(53, 30);
            this.operando.TabIndex = 10;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(762, 629);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 576;
            this.lineShape3.X2 = 735;
            this.lineShape3.Y1 = 178;
            this.lineShape3.Y2 = 178;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 570;
            this.lineShape2.X2 = 728;
            this.lineShape2.Y1 = 128;
            this.lineShape2.Y2 = 128;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 576;
            this.lineShape1.X2 = 736;
            this.lineShape1.Y1 = 228;
            this.lineShape1.Y2 = 228;
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregar.ForeColor = System.Drawing.Color.FloralWhite;
            this.agregar.Location = new System.Drawing.Point(576, 301);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(160, 33);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // nombre_tb
            // 
            this.nombre_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.nombre_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nombre_tb.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tb.ForeColor = System.Drawing.Color.Silver;
            this.nombre_tb.Location = new System.Drawing.Point(576, 153);
            this.nombre_tb.Name = "nombre_tb";
            this.nombre_tb.Size = new System.Drawing.Size(159, 24);
            this.nombre_tb.TabIndex = 6;
            this.nombre_tb.Text = "Nombre";
            this.nombre_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombre_tb.Enter += new System.EventHandler(this.nombre_tb_Enter);
            this.nombre_tb.Leave += new System.EventHandler(this.nombre_tb_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(720, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(686, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(576, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numlote
            // 
            this.numlote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.numlote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numlote.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlote.ForeColor = System.Drawing.Color.Silver;
            this.numlote.Location = new System.Drawing.Point(578, 57);
            this.numlote.Name = "numlote";
            this.numlote.Size = new System.Drawing.Size(159, 24);
            this.numlote.TabIndex = 25;
            this.numlote.Text = "(Lote)";
            this.numlote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.registros);
            this.tabControl1.Controls.Add(this.ejecucion);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 611);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 26;
            // 
            // registros
            // 
            this.registros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registros.Controls.Add(this.registroTabla);
            this.registros.Location = new System.Drawing.Point(4, 25);
            this.registros.Margin = new System.Windows.Forms.Padding(0);
            this.registros.Name = "registros";
            this.registros.Padding = new System.Windows.Forms.Padding(3);
            this.registros.Size = new System.Drawing.Size(474, 582);
            this.registros.TabIndex = 0;
            this.registros.Text = "tabPage1";
            // 
            // registroTabla
            // 
            this.registroTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.registroTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.registroTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.registroTabla.Cursor = System.Windows.Forms.Cursors.Default;
            this.registroTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroTabla.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroTabla.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registroTabla.HideSelection = false;
            this.registroTabla.Location = new System.Drawing.Point(3, 3);
            this.registroTabla.Name = "registroTabla";
            this.registroTabla.Size = new System.Drawing.Size(468, 576);
            this.registroTabla.TabIndex = 10;
            this.registroTabla.UseCompatibleStateImageBehavior = false;
            this.registroTabla.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lote";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "nombre";
            this.columnHeader3.Width = 108;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tiempo";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Operacion";
            this.columnHeader5.Width = 135;
            // 
            // ejecucion
            // 
            this.ejecucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ejecucion.Controls.Add(this.loteActual_);
            this.ejecucion.Controls.Add(this.textBox11);
            this.ejecucion.Controls.Add(this.textBox8);
            this.ejecucion.Controls.Add(this.textBox7);
            this.ejecucion.Controls.Add(this.textBox6);
            this.ejecucion.Controls.Add(this.textBox5);
            this.ejecucion.Controls.Add(this.tbTiempo);
            this.ejecucion.Controls.Add(this.tbOp);
            this.ejecucion.Controls.Add(this.tbNom);
            this.ejecucion.Controls.Add(this.tbID);
            this.ejecucion.Controls.Add(this.Title2);
            this.ejecucion.Controls.Add(this.Pendientes);
            this.ejecucion.Controls.Add(this.tablaCompletados);
            this.ejecucion.Controls.Add(this.title1);
            this.ejecucion.Controls.Add(this.shapeContainer2);
            this.ejecucion.Location = new System.Drawing.Point(4, 25);
            this.ejecucion.Name = "ejecucion";
            this.ejecucion.Padding = new System.Windows.Forms.Padding(3);
            this.ejecucion.Size = new System.Drawing.Size(474, 582);
            this.ejecucion.TabIndex = 1;
            this.ejecucion.Text = "tabPage2";

            // 
            // loteActual_
            // 
            this.loteActual_.AutoSize = true;
            this.loteActual_.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loteActual_.ForeColor = System.Drawing.Color.Silver;
            this.loteActual_.Location = new System.Drawing.Point(322, 402);
            this.loteActual_.Name = "loteActual_";
            this.loteActual_.Size = new System.Drawing.Size(0, 22);
            this.loteActual_.TabIndex = 51;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Silver;
            this.textBox11.Location = new System.Drawing.Point(152, 194);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(198, 24);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "Procesos en Ejecuciom";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Silver;
            this.textBox8.Location = new System.Drawing.Point(37, 336);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(159, 24);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "Tiempo Estimado";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Silver;
            this.textBox7.Location = new System.Drawing.Point(37, 301);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox7.Size = new System.Drawing.Size(159, 24);
            this.textBox7.TabIndex = 18;
            this.textBox7.Text = "Operacion";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Silver;
            this.textBox6.Location = new System.Drawing.Point(37, 270);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(159, 24);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Nombre";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Silver;
            this.textBox5.Location = new System.Drawing.Point(37, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(159, 24);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "ID";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTiempo
            // 
            this.tbTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTiempo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiempo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbTiempo.Location = new System.Drawing.Point(202, 334);
            this.tbTiempo.Name = "tbTiempo";
            this.tbTiempo.ReadOnly = true;
            this.tbTiempo.Size = new System.Drawing.Size(148, 27);
            this.tbTiempo.TabIndex = 15;
            this.tbTiempo.TabStop = false;
            // 
            // tbOp
            // 
            this.tbOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbOp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbOp.Location = new System.Drawing.Point(202, 301);
            this.tbOp.Name = "tbOp";
            this.tbOp.ReadOnly = true;
            this.tbOp.Size = new System.Drawing.Size(148, 27);
            this.tbOp.TabIndex = 14;
            this.tbOp.TabStop = false;
            // 
            // tbNom
            // 
            this.tbNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbNom.Location = new System.Drawing.Point(202, 268);
            this.tbNom.Name = "tbNom";
            this.tbNom.ReadOnly = true;
            this.tbNom.Size = new System.Drawing.Size(148, 27);
            this.tbNom.TabIndex = 13;
            this.tbNom.TabStop = false;
            // 
            // tbID
            // 
            this.tbID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbID.Location = new System.Drawing.Point(202, 235);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(148, 27);
            this.tbID.TabIndex = 12;
            this.tbID.TabStop = false;
            // 
            // Title2
            // 
            this.Title2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Title2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.Silver;
            this.Title2.Location = new System.Drawing.Point(149, 400);
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            this.Title2.Size = new System.Drawing.Size(164, 24);
            this.Title2.TabIndex = 11;
            this.Title2.Text = "Cantidad de lotes";
            this.Title2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Pendientes
            // 
            this.Pendientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Pendientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Pendientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.Pendientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.Pendientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pendientes.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Pendientes.HideSelection = false;
            this.Pendientes.Location = new System.Drawing.Point(4, 433);
            this.Pendientes.Name = "Pendientes";
            this.Pendientes.Size = new System.Drawing.Size(464, 143);
            this.Pendientes.TabIndex = 10;
            this.Pendientes.UseCompatibleStateImageBehavior = false;
            this.Pendientes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lote";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "nombre";
            this.columnHeader8.Width = 108;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tiempo";
            this.columnHeader9.Width = 97;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Operacion";
            this.columnHeader10.Width = 135;
            // 
            // tablaCompletados
            // 
            this.tablaCompletados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tablaCompletados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCompletados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lote,
            this.id,
            this.Nombre,
            this.tiempo,
            this.op,
            this.resultado});
            this.tablaCompletados.Cursor = System.Windows.Forms.Cursors.Default;
            this.tablaCompletados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaCompletados.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tablaCompletados.HideSelection = false;
            this.tablaCompletados.Location = new System.Drawing.Point(3, 34);
            this.tablaCompletados.Name = "tablaCompletados";
            this.tablaCompletados.Size = new System.Drawing.Size(467, 158);
            this.tablaCompletados.TabIndex = 9;
            this.tablaCompletados.UseCompatibleStateImageBehavior = false;
            this.tablaCompletados.View = System.Windows.Forms.View.Details;
            // 
            // lote
            // 
            this.lote.Text = "Lote";
            // 
            // id
            // 
            this.id.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Text = "nombre";
            this.Nombre.Width = 108;
            // 
            // tiempo
            // 
            this.tiempo.Text = "Tiempo";
            this.tiempo.Width = 97;
            // 
            // op
            // 
            this.op.Text = "Operacion";
            this.op.Width = 114;
            // 
            // resultado
            // 
            this.resultado.Text = "Resultado";
            this.resultado.Width = 113;
            // 
            // title1
            // 
            this.title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.title1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title1.ForeColor = System.Drawing.Color.Silver;
            this.title1.Location = new System.Drawing.Point(152, 3);
            this.title1.Name = "title1";
            this.title1.ReadOnly = true;
            this.title1.Size = new System.Drawing.Size(198, 24);
            this.title1.TabIndex = 50;
            this.title1.Text = "Procesos terminados";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape7,
            this.lineShape6,
            this.lineShape5,
            this.lineShape4});
            this.shapeContainer2.Size = new System.Drawing.Size(468, 576);
            this.shapeContainer2.TabIndex = 20;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape7
            // 
            this.lineShape7.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape7.BorderWidth = 2;
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 145;
            this.lineShape7.X2 = 326;
            this.lineShape7.Y1 = 422;
            this.lineShape7.Y2 = 422;
            // 
            // lineShape6
            // 
            this.lineShape6.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape6.BorderWidth = 2;
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 147;
            this.lineShape6.X2 = 350;
            this.lineShape6.Y1 = 215;
            this.lineShape6.Y2 = 215;
            // 
            // lineShape5
            // 
            this.lineShape5.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape5.BorderWidth = 2;
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 146;
            this.lineShape5.X2 = 339;
            this.lineShape5.Y1 = 25;
            this.lineShape5.Y2 = 25;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.Gainsboro;
            this.lineShape4.BorderWidth = 2;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 166;
            this.lineShape4.X2 = 383;
            this.lineShape4.Y1 = 111;
            this.lineShape4.Y2 = 111;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Silver;
            this.textBox9.Location = new System.Drawing.Point(570, 417);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(186, 24);
            this.textBox9.TabIndex = 27;
            this.textBox9.Text = "Tiempo Transcurrido";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTiempoTr
            // 
            this.tbTiempoTr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tbTiempoTr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTiempoTr.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbTiempoTr.Location = new System.Drawing.Point(594, 447);
            this.tbTiempoTr.Name = "tbTiempoTr";
            this.tbTiempoTr.ReadOnly = true;
            this.tbTiempoTr.Size = new System.Drawing.Size(135, 27);
            this.tbTiempoTr.TabIndex = 28;
            // 
            // Conteo
            // 
            this.Conteo.Interval = 1000;
            this.Conteo.Tick += new System.EventHandler(this.Conteo_Tick);
            // 
            // tiempoProceso
            // 
            this.tiempoProceso.Interval = 1000;
            this.tiempoProceso.Tick += new System.EventHandler(this.tiempoProceso_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(762, 629);
            this.Controls.Add(this.tbTiempoTr);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.numlote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.operando);
            this.Controls.Add(this.segundoNum);
            this.Controls.Add(this.primerNum);
            this.Controls.Add(this.tiempo_tb);
            this.Controls.Add(this.nombre_tb);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";

            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.registros.ResumeLayout(false);
            this.ejecucion.ResumeLayout(false);
            this.ejecucion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.TextBox tiempo_tb;
        private System.Windows.Forms.TextBox primerNum;
        private System.Windows.Forms.TextBox segundoNum;
        private System.Windows.Forms.ComboBox operando;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numlote;
        public System.Windows.Forms.TextBox nombre_tb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registros;
        private System.Windows.Forms.TabPage ejecucion;
        public System.Windows.Forms.ListView registroTabla;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.TextBox title1;
        public System.Windows.Forms.ListView tablaCompletados;
        private System.Windows.Forms.ColumnHeader lote;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader tiempo;
        private System.Windows.Forms.ColumnHeader op;
        private System.Windows.Forms.ColumnHeader resultado;
        public System.Windows.Forms.ListView Pendientes;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox Title2;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox tbTiempo;
        private System.Windows.Forms.TextBox tbOp;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox tbTiempoTr;
        private System.Windows.Forms.Timer Conteo;
        private System.Windows.Forms.Timer tiempoProceso;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        public System.Windows.Forms.TextBox textBox11;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private System.Windows.Forms.Label loteActual_;
    }
}

