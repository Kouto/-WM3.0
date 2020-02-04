namespace Clock_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClear = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtCustomer = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSettings = new System.Windows.Forms.ToolStripButton();
            this.btnCalc = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPDF = new System.Windows.Forms.ToolStripButton();
            this.btnSaveReport = new System.Windows.Forms.ToolStripButton();
            this.grpStages = new System.Windows.Forms.GroupBox();
            this.grdFloors = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFloorsPerimeter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFloorsCnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFloorsNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAddFloor = new System.Windows.Forms.ToolStripButton();
            this.btnDelFloor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnReplacement = new System.Windows.Forms.RadioButton();
            this.btnUchimado = new System.Windows.Forms.RadioButton();
            this.pnlReplacement = new System.Windows.Forms.Panel();
            this.grbAssemblySeam_replace = new System.Windows.Forms.GroupBox();
            this.lstReplacePsulSilicon = new System.Windows.Forms.CheckedListBox();
            this.lstReplaceFoamSilicon = new System.Windows.Forms.CheckedListBox();
            this.rbReplace_free = new System.Windows.Forms.RadioButton();
            this.rbReplace_PSUL = new System.Windows.Forms.RadioButton();
            this.rbReplace_foam = new System.Windows.Forms.RadioButton();
            this.pnlUchimado = new System.Windows.Forms.Panel();
            this.grbAssemblySeam_uchimado = new System.Windows.Forms.GroupBox();
            this.lstMountingSeamSilicon = new System.Windows.Forms.CheckedListBox();
            this.rbUchimado_free = new System.Windows.Forms.RadioButton();
            this.rbUchimado_PSUL = new System.Windows.Forms.RadioButton();
            this.rbUchimado_silicon = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pnlMosquitos = new System.Windows.Forms.Panel();
            this.numMosq_door = new System.Windows.Forms.NumericUpDown();
            this.chkMosquito_door = new System.Windows.Forms.CheckBox();
            this.chkMosquito_pliss = new System.Windows.Forms.CheckBox();
            this.numMosq_border = new System.Windows.Forms.NumericUpDown();
            this.numMosq_pliss = new System.Windows.Forms.NumericUpDown();
            this.chkMosquito_border = new System.Windows.Forms.CheckBox();
            this.chkMosquito_slide = new System.Windows.Forms.CheckBox();
            this.numMosq_slide = new System.Windows.Forms.NumericUpDown();
            this.chkMosquitos = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkDismantling = new System.Windows.Forms.CheckBox();
            this.pnlDismantling = new System.Windows.Forms.Panel();
            this.chkThread_2_PVH_reils = new System.Windows.Forms.CheckBox();
            this.chkThread_2_PVH_only = new System.Windows.Forms.CheckBox();
            this.chkThread_2_PVH = new System.Windows.Forms.CheckBox();
            this.chkThread_2_wood_reils = new System.Windows.Forms.CheckBox();
            this.chkThread_2_wood_only = new System.Windows.Forms.CheckBox();
            this.chkThread_2_wood = new System.Windows.Forms.CheckBox();
            this.chkThread_1_beton = new System.Windows.Forms.CheckBox();
            this.chkThread_1_wood = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkOther = new System.Windows.Forms.CheckBox();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.chkOther_rain = new System.Windows.Forms.CheckBox();
            this.chkOther_clear_glass = new System.Windows.Forms.CheckBox();
            this.chkOther_workspace_clear = new System.Windows.Forms.CheckBox();
            this.chkOther_workspace = new System.Windows.Forms.CheckBox();
            this.lstReport = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlInstallationConditions = new System.Windows.Forms.Panel();
            this.numPilastra = new System.Windows.Forms.NumericUpDown();
            this.numJoinProfil20 = new System.Windows.Forms.NumericUpDown();
            this.numJoinProfil2 = new System.Windows.Forms.NumericUpDown();
            this.chlPilastra = new System.Windows.Forms.CheckBox();
            this.chkJoinProfil20 = new System.Windows.Forms.CheckBox();
            this.chkJoinProfil2 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pnlMountingMethod = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.chkMountingMethod = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlTypeOfFastening = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.chkTypeOfFastening = new System.Windows.Forms.CheckBox();
            this.chkPrimat = new System.Windows.Forms.CheckBox();
            this.numPrimat = new System.Windows.Forms.NumericUpDown();
            this.lstInstallationConditions = new System.Windows.Forms.CheckedListBox();
            this.chkInstallationConditions = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.grpStages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFloors)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlReplacement.SuspendLayout();
            this.grbAssemblySeam_replace.SuspendLayout();
            this.pnlUchimado.SuspendLayout();
            this.grbAssemblySeam_uchimado.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pnlMosquitos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_border)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_pliss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_slide)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.pnlDismantling.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.pnlOther.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlInstallationConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPilastra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinProfil20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinProfil2)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.pnlMountingMethod.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlTypeOfFastening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrimat)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(22, 22);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClear,
            this.toolStripLabel1,
            this.txtCustomer,
            this.toolStripSeparator3,
            this.btnAbout,
            this.toolStripSeparator4,
            this.btnSettings,
            this.btnCalc,
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.btnPDF,
            this.btnSaveReport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Clock_calculator.Properties.Resources.clear_list_22;
            this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(63, 41);
            this.btnClear.Text = "Очистить";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 41);
            this.toolStripLabel1.Text = "Заказчик";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(300, 44);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // btnAbout
            // 
            this.btnAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnAbout.Image = global::Clock_calculator.Properties.Resources.about_22;
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(86, 41);
            this.btnAbout.Text = "О программе";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // btnSettings
            // 
            this.btnSettings.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSettings.Image = global::Clock_calculator.Properties.Resources.settings_22;
            this.btnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(71, 41);
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Image = global::Clock_calculator.Properties.Resources.calculator_22;
            this.btnCalc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(72, 41);
            this.btnCalc.Text = "Рассчитать";
            this.btnCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::Clock_calculator.Properties.Resources.log_22;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(68, 41);
            this.toolStripButton1.Text = "Подробно";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Выводить подробный лог\r\n";
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // btnPDF
            // 
            this.btnPDF.Image = global::Clock_calculator.Properties.Resources.pdf_22;
            this.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(89, 41);
            this.btnPDF.Text = "Экспорт в PDF";
            this.btnPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Image = global::Clock_calculator.Properties.Resources.save_22;
            this.btnSaveReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(69, 41);
            this.btnSaveReport.Text = "Сохранить";
            this.btnSaveReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveReport.ToolTipText = "Сохранить отчет";
            this.btnSaveReport.Click += new System.EventHandler(this.BtnSaveReport_Click);
            // 
            // grpStages
            // 
            this.grpStages.Controls.Add(this.grdFloors);
            this.grpStages.Controls.Add(this.panel1);
            this.grpStages.Controls.Add(this.toolStrip2);
            this.grpStages.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpStages.Location = new System.Drawing.Point(0, 44);
            this.grpStages.Name = "grpStages";
            this.grpStages.Size = new System.Drawing.Size(250, 686);
            this.grpStages.TabIndex = 1;
            this.grpStages.TabStop = false;
            this.grpStages.Text = "Этажи";
            // 
            // grdFloors
            // 
            this.grdFloors.AllowUserToAddRows = false;
            this.grdFloors.AllowUserToDeleteRows = false;
            this.grdFloors.AllowUserToResizeRows = false;
            this.grdFloors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFloors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.grdFloors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFloors.Location = new System.Drawing.Point(3, 41);
            this.grdFloors.MultiSelect = false;
            this.grdFloors.Name = "grdFloors";
            this.grdFloors.ReadOnly = true;
            this.grdFloors.RowHeadersVisible = false;
            this.grdFloors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFloors.Size = new System.Drawing.Size(244, 543);
            this.grdFloors.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Этаж";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Кол-во, шт.";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 81;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Общий периметр, м.";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 99);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFloorsPerimeter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtFloorsCnt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFloorsNum);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 99);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Итого";
            // 
            // txtFloorsPerimeter
            // 
            this.txtFloorsPerimeter.Location = new System.Drawing.Point(123, 71);
            this.txtFloorsPerimeter.Name = "txtFloorsPerimeter";
            this.txtFloorsPerimeter.ReadOnly = true;
            this.txtFloorsPerimeter.Size = new System.Drawing.Size(118, 20);
            this.txtFloorsPerimeter.TabIndex = 5;
            this.txtFloorsPerimeter.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Периметр, м";
            // 
            // txtFloorsCnt
            // 
            this.txtFloorsCnt.Location = new System.Drawing.Point(123, 45);
            this.txtFloorsCnt.Name = "txtFloorsCnt";
            this.txtFloorsCnt.ReadOnly = true;
            this.txtFloorsCnt.Size = new System.Drawing.Size(118, 20);
            this.txtFloorsCnt.TabIndex = 3;
            this.txtFloorsCnt.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кол-во изделий, шт";
            // 
            // txtFloorsNum
            // 
            this.txtFloorsNum.Location = new System.Drawing.Point(123, 19);
            this.txtFloorsNum.Name = "txtFloorsNum";
            this.txtFloorsNum.ReadOnly = true;
            this.txtFloorsNum.Size = new System.Drawing.Size(118, 20);
            this.txtFloorsNum.TabIndex = 1;
            this.txtFloorsNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Этажей";
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFloor,
            this.btnDelFloor,
            this.toolStripSeparator2,
            this.btnEdit});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(244, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAddFloor
            // 
            this.btnAddFloor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddFloor.Image = global::Clock_calculator.Properties.Resources.add_16;
            this.btnAddFloor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddFloor.Name = "btnAddFloor";
            this.btnAddFloor.Size = new System.Drawing.Size(23, 22);
            this.btnAddFloor.Text = "Добавить";
            this.btnAddFloor.Click += new System.EventHandler(this.BtnAddFloor_Click);
            // 
            // btnDelFloor
            // 
            this.btnDelFloor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelFloor.Image = global::Clock_calculator.Properties.Resources.remove_16;
            this.btnDelFloor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelFloor.Name = "btnDelFloor";
            this.btnDelFloor.Size = new System.Drawing.Size(23, 22);
            this.btnDelFloor.Text = "Удалить";
            this.btnDelFloor.Click += new System.EventHandler(this.BtnDelFloor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = global::Clock_calculator.Properties.Resources.edit_16;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.Text = "Редактировать";
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnReplacement
            // 
            this.btnReplacement.AccessibleName = "typeOfWork";
            this.btnReplacement.AutoSize = true;
            this.btnReplacement.Location = new System.Drawing.Point(177, 19);
            this.btnReplacement.Name = "btnReplacement";
            this.btnReplacement.Size = new System.Drawing.Size(64, 17);
            this.btnReplacement.TabIndex = 6;
            this.btnReplacement.TabStop = true;
            this.btnReplacement.Text = "Замена";
            this.btnReplacement.UseVisualStyleBackColor = true;
            this.btnReplacement.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // btnUchimado
            // 
            this.btnUchimado.AccessibleName = "typeOfWork";
            this.btnUchimado.AutoSize = true;
            this.btnUchimado.Location = new System.Drawing.Point(6, 19);
            this.btnUchimado.Name = "btnUchimado";
            this.btnUchimado.Size = new System.Drawing.Size(70, 17);
            this.btnUchimado.TabIndex = 5;
            this.btnUchimado.TabStop = true;
            this.btnUchimado.Text = "Учимадо";
            this.btnUchimado.UseVisualStyleBackColor = true;
            this.btnUchimado.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // pnlReplacement
            // 
            this.pnlReplacement.Controls.Add(this.grbAssemblySeam_replace);
            this.pnlReplacement.Enabled = false;
            this.pnlReplacement.Location = new System.Drawing.Point(177, 45);
            this.pnlReplacement.Name = "pnlReplacement";
            this.pnlReplacement.Size = new System.Drawing.Size(165, 292);
            this.pnlReplacement.TabIndex = 3;
            // 
            // grbAssemblySeam_replace
            // 
            this.grbAssemblySeam_replace.Controls.Add(this.lstReplacePsulSilicon);
            this.grbAssemblySeam_replace.Controls.Add(this.lstReplaceFoamSilicon);
            this.grbAssemblySeam_replace.Controls.Add(this.rbReplace_free);
            this.grbAssemblySeam_replace.Controls.Add(this.rbReplace_PSUL);
            this.grbAssemblySeam_replace.Controls.Add(this.rbReplace_foam);
            this.grbAssemblySeam_replace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAssemblySeam_replace.Location = new System.Drawing.Point(0, 0);
            this.grbAssemblySeam_replace.Name = "grbAssemblySeam_replace";
            this.grbAssemblySeam_replace.Size = new System.Drawing.Size(165, 292);
            this.grbAssemblySeam_replace.TabIndex = 0;
            this.grbAssemblySeam_replace.TabStop = false;
            this.grbAssemblySeam_replace.Text = "Монтажный шов";
            // 
            // lstReplacePsulSilicon
            // 
            this.lstReplacePsulSilicon.BackColor = System.Drawing.SystemColors.Control;
            this.lstReplacePsulSilicon.Enabled = false;
            this.lstReplacePsulSilicon.FormattingEnabled = true;
            this.lstReplacePsulSilicon.Items.AddRange(new object[] {
            "Силикон внутренний",
            "Силикон наружный"});
            this.lstReplacePsulSilicon.Location = new System.Drawing.Point(6, 165);
            this.lstReplacePsulSilicon.Name = "lstReplacePsulSilicon";
            this.lstReplacePsulSilicon.Size = new System.Drawing.Size(150, 94);
            this.lstReplacePsulSilicon.TabIndex = 4;
            this.lstReplacePsulSilicon.Tag = "301,302";
            // 
            // lstReplaceFoamSilicon
            // 
            this.lstReplaceFoamSilicon.BackColor = System.Drawing.SystemColors.Control;
            this.lstReplaceFoamSilicon.Enabled = false;
            this.lstReplaceFoamSilicon.FormattingEnabled = true;
            this.lstReplaceFoamSilicon.Items.AddRange(new object[] {
            "Силикон внутренний",
            "Силикон наружный",
            "Робибанд внутренний",
            "Робибанд наружный"});
            this.lstReplaceFoamSilicon.Location = new System.Drawing.Point(6, 42);
            this.lstReplaceFoamSilicon.Name = "lstReplaceFoamSilicon";
            this.lstReplaceFoamSilicon.Size = new System.Drawing.Size(150, 94);
            this.lstReplaceFoamSilicon.TabIndex = 3;
            this.lstReplaceFoamSilicon.Tag = "301,302,303,304";
            // 
            // rbReplace_free
            // 
            this.rbReplace_free.AutoSize = true;
            this.rbReplace_free.Location = new System.Drawing.Point(6, 265);
            this.rbReplace_free.Name = "rbReplace_free";
            this.rbReplace_free.Size = new System.Drawing.Size(92, 17);
            this.rbReplace_free.TabIndex = 2;
            this.rbReplace_free.TabStop = true;
            this.rbReplace_free.Tag = "306";
            this.rbReplace_free.Text = "Без монтажа";
            this.rbReplace_free.UseVisualStyleBackColor = true;
            this.rbReplace_free.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // rbReplace_PSUL
            // 
            this.rbReplace_PSUL.AutoSize = true;
            this.rbReplace_PSUL.Location = new System.Drawing.Point(6, 142);
            this.rbReplace_PSUL.Name = "rbReplace_PSUL";
            this.rbReplace_PSUL.Size = new System.Drawing.Size(91, 17);
            this.rbReplace_PSUL.TabIndex = 1;
            this.rbReplace_PSUL.TabStop = true;
            this.rbReplace_PSUL.Tag = "305";
            this.rbReplace_PSUL.Text = "ПСУЛ illmond";
            this.rbReplace_PSUL.UseVisualStyleBackColor = true;
            this.rbReplace_PSUL.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // rbReplace_foam
            // 
            this.rbReplace_foam.AutoSize = true;
            this.rbReplace_foam.Location = new System.Drawing.Point(6, 19);
            this.rbReplace_foam.Name = "rbReplace_foam";
            this.rbReplace_foam.Size = new System.Drawing.Size(110, 17);
            this.rbReplace_foam.TabIndex = 0;
            this.rbReplace_foam.TabStop = true;
            this.rbReplace_foam.Tag = "300";
            this.rbReplace_foam.Text = "Монтажная пена";
            this.rbReplace_foam.UseVisualStyleBackColor = true;
            this.rbReplace_foam.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // pnlUchimado
            // 
            this.pnlUchimado.Controls.Add(this.grbAssemblySeam_uchimado);
            this.pnlUchimado.Enabled = false;
            this.pnlUchimado.Location = new System.Drawing.Point(6, 45);
            this.pnlUchimado.Name = "pnlUchimado";
            this.pnlUchimado.Size = new System.Drawing.Size(165, 292);
            this.pnlUchimado.TabIndex = 0;
            // 
            // grbAssemblySeam_uchimado
            // 
            this.grbAssemblySeam_uchimado.Controls.Add(this.lstMountingSeamSilicon);
            this.grbAssemblySeam_uchimado.Controls.Add(this.rbUchimado_free);
            this.grbAssemblySeam_uchimado.Controls.Add(this.rbUchimado_PSUL);
            this.grbAssemblySeam_uchimado.Controls.Add(this.rbUchimado_silicon);
            this.grbAssemblySeam_uchimado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbAssemblySeam_uchimado.Location = new System.Drawing.Point(0, 0);
            this.grbAssemblySeam_uchimado.Name = "grbAssemblySeam_uchimado";
            this.grbAssemblySeam_uchimado.Size = new System.Drawing.Size(165, 292);
            this.grbAssemblySeam_uchimado.TabIndex = 0;
            this.grbAssemblySeam_uchimado.TabStop = false;
            this.grbAssemblySeam_uchimado.Text = "Монтажный шов";
            // 
            // lstMountingSeamSilicon
            // 
            this.lstMountingSeamSilicon.BackColor = System.Drawing.SystemColors.Control;
            this.lstMountingSeamSilicon.Enabled = false;
            this.lstMountingSeamSilicon.FormattingEnabled = true;
            this.lstMountingSeamSilicon.Items.AddRange(new object[] {
            "Внутренний",
            "Наружный"});
            this.lstMountingSeamSilicon.Location = new System.Drawing.Point(6, 42);
            this.lstMountingSeamSilicon.Name = "lstMountingSeamSilicon";
            this.lstMountingSeamSilicon.Size = new System.Drawing.Size(150, 94);
            this.lstMountingSeamSilicon.TabIndex = 3;
            this.lstMountingSeamSilicon.Tag = "200,201";
            // 
            // rbUchimado_free
            // 
            this.rbUchimado_free.AutoSize = true;
            this.rbUchimado_free.Location = new System.Drawing.Point(6, 265);
            this.rbUchimado_free.Name = "rbUchimado_free";
            this.rbUchimado_free.Size = new System.Drawing.Size(92, 17);
            this.rbUchimado_free.TabIndex = 2;
            this.rbUchimado_free.Tag = "203";
            this.rbUchimado_free.Text = "Без монтажа";
            this.rbUchimado_free.UseVisualStyleBackColor = true;
            this.rbUchimado_free.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // rbUchimado_PSUL
            // 
            this.rbUchimado_PSUL.AutoSize = true;
            this.rbUchimado_PSUL.Location = new System.Drawing.Point(6, 142);
            this.rbUchimado_PSUL.Name = "rbUchimado_PSUL";
            this.rbUchimado_PSUL.Size = new System.Drawing.Size(91, 17);
            this.rbUchimado_PSUL.TabIndex = 1;
            this.rbUchimado_PSUL.Tag = "202";
            this.rbUchimado_PSUL.Text = "ПСУЛ illmond";
            this.rbUchimado_PSUL.UseVisualStyleBackColor = true;
            this.rbUchimado_PSUL.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // rbUchimado_silicon
            // 
            this.rbUchimado_silicon.AutoSize = true;
            this.rbUchimado_silicon.Location = new System.Drawing.Point(6, 19);
            this.rbUchimado_silicon.Name = "rbUchimado_silicon";
            this.rbUchimado_silicon.Size = new System.Drawing.Size(68, 17);
            this.rbUchimado_silicon.TabIndex = 0;
            this.rbUchimado_silicon.Tag = "204";
            this.rbUchimado_silicon.Text = "Силикон";
            this.rbUchimado_silicon.UseVisualStyleBackColor = true;
            this.rbUchimado_silicon.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pnlReplacement);
            this.groupBox5.Controls.Add(this.btnReplacement);
            this.groupBox5.Controls.Add(this.btnUchimado);
            this.groupBox5.Controls.Add(this.pnlUchimado);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 345);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = " Вид работ ";
            this.groupBox5.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxPaint);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pnlMosquitos);
            this.groupBox6.Controls.Add(this.chkMosquitos);
            this.groupBox6.Location = new System.Drawing.Point(3, 354);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(349, 127);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxPaint);
            // 
            // pnlMosquitos
            // 
            this.pnlMosquitos.Controls.Add(this.numMosq_door);
            this.pnlMosquitos.Controls.Add(this.chkMosquito_door);
            this.pnlMosquitos.Controls.Add(this.chkMosquito_pliss);
            this.pnlMosquitos.Controls.Add(this.numMosq_border);
            this.pnlMosquitos.Controls.Add(this.numMosq_pliss);
            this.pnlMosquitos.Controls.Add(this.chkMosquito_border);
            this.pnlMosquitos.Controls.Add(this.chkMosquito_slide);
            this.pnlMosquitos.Controls.Add(this.numMosq_slide);
            this.pnlMosquitos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMosquitos.Enabled = false;
            this.pnlMosquitos.Location = new System.Drawing.Point(3, 18);
            this.pnlMosquitos.Name = "pnlMosquitos";
            this.pnlMosquitos.Size = new System.Drawing.Size(343, 106);
            this.pnlMosquitos.TabIndex = 18;
            // 
            // numMosq_door
            // 
            this.numMosq_door.Enabled = false;
            this.numMosq_door.Location = new System.Drawing.Point(259, 3);
            this.numMosq_door.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMosq_door.Name = "numMosq_door";
            this.numMosq_door.Size = new System.Drawing.Size(77, 20);
            this.numMosq_door.TabIndex = 10;
            this.numMosq_door.Tag = "400";
            // 
            // chkMosquito_door
            // 
            this.chkMosquito_door.AutoSize = true;
            this.chkMosquito_door.Location = new System.Drawing.Point(3, 3);
            this.chkMosquito_door.Name = "chkMosquito_door";
            this.chkMosquito_door.Size = new System.Drawing.Size(140, 17);
            this.chkMosquito_door.TabIndex = 9;
            this.chkMosquito_door.Text = "Наличие дверной м. с.";
            this.chkMosquito_door.UseVisualStyleBackColor = true;
            this.chkMosquito_door.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkMosquito_pliss
            // 
            this.chkMosquito_pliss.AutoSize = true;
            this.chkMosquito_pliss.Location = new System.Drawing.Point(3, 81);
            this.chkMosquito_pliss.Name = "chkMosquito_pliss";
            this.chkMosquito_pliss.Size = new System.Drawing.Size(134, 17);
            this.chkMosquito_pliss.TabIndex = 15;
            this.chkMosquito_pliss.Text = "Наличие плиссе м. с.";
            this.chkMosquito_pliss.UseVisualStyleBackColor = true;
            this.chkMosquito_pliss.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // numMosq_border
            // 
            this.numMosq_border.Enabled = false;
            this.numMosq_border.Location = new System.Drawing.Point(259, 29);
            this.numMosq_border.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMosq_border.Name = "numMosq_border";
            this.numMosq_border.Size = new System.Drawing.Size(77, 20);
            this.numMosq_border.TabIndex = 12;
            this.numMosq_border.Tag = "401";
            // 
            // numMosq_pliss
            // 
            this.numMosq_pliss.Enabled = false;
            this.numMosq_pliss.Location = new System.Drawing.Point(259, 81);
            this.numMosq_pliss.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMosq_pliss.Name = "numMosq_pliss";
            this.numMosq_pliss.Size = new System.Drawing.Size(77, 20);
            this.numMosq_pliss.TabIndex = 16;
            this.numMosq_pliss.Tag = "403";
            // 
            // chkMosquito_border
            // 
            this.chkMosquito_border.AutoSize = true;
            this.chkMosquito_border.Location = new System.Drawing.Point(3, 29);
            this.chkMosquito_border.Name = "chkMosquito_border";
            this.chkMosquito_border.Size = new System.Drawing.Size(147, 17);
            this.chkMosquito_border.TabIndex = 11;
            this.chkMosquito_border.Text = "Наличие рамочной м. с.";
            this.chkMosquito_border.UseVisualStyleBackColor = true;
            this.chkMosquito_border.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkMosquito_slide
            // 
            this.chkMosquito_slide.AutoSize = true;
            this.chkMosquito_slide.Location = new System.Drawing.Point(3, 55);
            this.chkMosquito_slide.Name = "chkMosquito_slide";
            this.chkMosquito_slide.Size = new System.Drawing.Size(128, 17);
            this.chkMosquito_slide.TabIndex = 13;
            this.chkMosquito_slide.Text = "Наличие слайд м. с.";
            this.chkMosquito_slide.UseVisualStyleBackColor = true;
            this.chkMosquito_slide.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // numMosq_slide
            // 
            this.numMosq_slide.Enabled = false;
            this.numMosq_slide.Location = new System.Drawing.Point(259, 55);
            this.numMosq_slide.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMosq_slide.Name = "numMosq_slide";
            this.numMosq_slide.Size = new System.Drawing.Size(77, 20);
            this.numMosq_slide.TabIndex = 14;
            this.numMosq_slide.Tag = "402";
            // 
            // chkMosquitos
            // 
            this.chkMosquitos.AutoSize = true;
            this.chkMosquitos.Location = new System.Drawing.Point(6, 0);
            this.chkMosquitos.Name = "chkMosquitos";
            this.chkMosquitos.Size = new System.Drawing.Size(122, 17);
            this.chkMosquitos.TabIndex = 17;
            this.chkMosquitos.Text = " Москитные сетки ";
            this.chkMosquitos.UseVisualStyleBackColor = true;
            this.chkMosquitos.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkDismantling);
            this.groupBox7.Controls.Add(this.pnlDismantling);
            this.groupBox7.Location = new System.Drawing.Point(650, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(237, 227);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxPaint);
            // 
            // chkDismantling
            // 
            this.chkDismantling.AutoSize = true;
            this.chkDismantling.Location = new System.Drawing.Point(6, 0);
            this.chkDismantling.Name = "chkDismantling";
            this.chkDismantling.Size = new System.Drawing.Size(80, 17);
            this.chkDismantling.TabIndex = 0;
            this.chkDismantling.Text = "Демонтаж";
            this.chkDismantling.UseVisualStyleBackColor = true;
            this.chkDismantling.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // pnlDismantling
            // 
            this.pnlDismantling.Controls.Add(this.chkThread_2_PVH_reils);
            this.pnlDismantling.Controls.Add(this.chkThread_2_PVH_only);
            this.pnlDismantling.Controls.Add(this.chkThread_2_PVH);
            this.pnlDismantling.Controls.Add(this.chkThread_2_wood_reils);
            this.pnlDismantling.Controls.Add(this.chkThread_2_wood_only);
            this.pnlDismantling.Controls.Add(this.chkThread_2_wood);
            this.pnlDismantling.Controls.Add(this.chkThread_1_beton);
            this.pnlDismantling.Controls.Add(this.chkThread_1_wood);
            this.pnlDismantling.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDismantling.Enabled = false;
            this.pnlDismantling.Location = new System.Drawing.Point(3, 23);
            this.pnlDismantling.Name = "pnlDismantling";
            this.pnlDismantling.Size = new System.Drawing.Size(231, 201);
            this.pnlDismantling.TabIndex = 1;
            // 
            // chkThread_2_PVH_reils
            // 
            this.chkThread_2_PVH_reils.AutoSize = true;
            this.chkThread_2_PVH_reils.Enabled = false;
            this.chkThread_2_PVH_reils.Location = new System.Drawing.Point(27, 177);
            this.chkThread_2_PVH_reils.Name = "chkThread_2_PVH_reils";
            this.chkThread_2_PVH_reils.Size = new System.Drawing.Size(177, 17);
            this.chkThread_2_PVH_reils.TabIndex = 16;
            this.chkThread_2_PVH_reils.Tag = "607";
            this.chkThread_2_PVH_reils.Text = "Снять направляющие рельсы";
            this.chkThread_2_PVH_reils.UseVisualStyleBackColor = true;
            // 
            // chkThread_2_PVH_only
            // 
            this.chkThread_2_PVH_only.AutoSize = true;
            this.chkThread_2_PVH_only.Enabled = false;
            this.chkThread_2_PVH_only.Location = new System.Drawing.Point(27, 154);
            this.chkThread_2_PVH_only.Name = "chkThread_2_PVH_only";
            this.chkThread_2_PVH_only.Size = new System.Drawing.Size(100, 17);
            this.chkThread_2_PVH_only.TabIndex = 15;
            this.chkThread_2_PVH_only.Tag = "606";
            this.chkThread_2_PVH_only.Text = "Снять створки";
            this.chkThread_2_PVH_only.UseVisualStyleBackColor = true;
            // 
            // chkThread_2_PVH
            // 
            this.chkThread_2_PVH.AutoSize = true;
            this.chkThread_2_PVH.Location = new System.Drawing.Point(3, 131);
            this.chkThread_2_PVH.Name = "chkThread_2_PVH";
            this.chkThread_2_PVH.Size = new System.Drawing.Size(98, 17);
            this.chkThread_2_PVH.TabIndex = 12;
            this.chkThread_2_PVH.Tag = "605";
            this.chkThread_2_PVH.Text = "2-я нитка ПВХ";
            this.chkThread_2_PVH.UseVisualStyleBackColor = true;
            this.chkThread_2_PVH.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkThread_2_wood_reils
            // 
            this.chkThread_2_wood_reils.AutoSize = true;
            this.chkThread_2_wood_reils.Enabled = false;
            this.chkThread_2_wood_reils.Location = new System.Drawing.Point(27, 106);
            this.chkThread_2_wood_reils.Name = "chkThread_2_wood_reils";
            this.chkThread_2_wood_reils.Size = new System.Drawing.Size(189, 17);
            this.chkThread_2_wood_reils.TabIndex = 11;
            this.chkThread_2_wood_reils.Tag = "604";
            this.chkThread_2_wood_reils.Text = "Срезать направляющие рельсы";
            this.chkThread_2_wood_reils.UseVisualStyleBackColor = true;
            // 
            // chkThread_2_wood_only
            // 
            this.chkThread_2_wood_only.AutoSize = true;
            this.chkThread_2_wood_only.Enabled = false;
            this.chkThread_2_wood_only.Location = new System.Drawing.Point(27, 83);
            this.chkThread_2_wood_only.Name = "chkThread_2_wood_only";
            this.chkThread_2_wood_only.Size = new System.Drawing.Size(100, 17);
            this.chkThread_2_wood_only.TabIndex = 10;
            this.chkThread_2_wood_only.Tag = "603";
            this.chkThread_2_wood_only.Text = "Снять створки";
            this.chkThread_2_wood_only.UseVisualStyleBackColor = true;
            // 
            // chkThread_2_wood
            // 
            this.chkThread_2_wood.AutoSize = true;
            this.chkThread_2_wood.Location = new System.Drawing.Point(3, 60);
            this.chkThread_2_wood.Name = "chkThread_2_wood";
            this.chkThread_2_wood.Size = new System.Drawing.Size(176, 17);
            this.chkThread_2_wood.TabIndex = 7;
            this.chkThread_2_wood.Tag = "602";
            this.chkThread_2_wood.Text = "2-я нитка в деревянном доме";
            this.chkThread_2_wood.UseVisualStyleBackColor = true;
            this.chkThread_2_wood.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkThread_1_beton
            // 
            this.chkThread_1_beton.AutoSize = true;
            this.chkThread_1_beton.Location = new System.Drawing.Point(3, 34);
            this.chkThread_1_beton.Name = "chkThread_1_beton";
            this.chkThread_1_beton.Size = new System.Drawing.Size(163, 17);
            this.chkThread_1_beton.TabIndex = 4;
            this.chkThread_1_beton.Tag = "601";
            this.chkThread_1_beton.Text = "1-я нитка в бетонном доме";
            this.chkThread_1_beton.UseVisualStyleBackColor = true;
            this.chkThread_1_beton.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkThread_1_wood
            // 
            this.chkThread_1_wood.AutoSize = true;
            this.chkThread_1_wood.Location = new System.Drawing.Point(3, 8);
            this.chkThread_1_wood.Name = "chkThread_1_wood";
            this.chkThread_1_wood.Size = new System.Drawing.Size(176, 17);
            this.chkThread_1_wood.TabIndex = 1;
            this.chkThread_1_wood.Tag = "600";
            this.chkThread_1_wood.Text = "1-я нитка в деревянном доме";
            this.chkThread_1_wood.UseVisualStyleBackColor = true;
            this.chkThread_1_wood.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkOther);
            this.groupBox8.Controls.Add(this.pnlOther);
            this.groupBox8.Location = new System.Drawing.Point(650, 233);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(237, 120);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxPaint);
            // 
            // chkOther
            // 
            this.chkOther.AutoSize = true;
            this.chkOther.Location = new System.Drawing.Point(6, 0);
            this.chkOther.Name = "chkOther";
            this.chkOther.Size = new System.Drawing.Size(107, 17);
            this.chkOther.TabIndex = 1;
            this.chkOther.Text = "Прочие условия";
            this.chkOther.UseVisualStyleBackColor = true;
            this.chkOther.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // pnlOther
            // 
            this.pnlOther.Controls.Add(this.chkOther_rain);
            this.pnlOther.Controls.Add(this.chkOther_clear_glass);
            this.pnlOther.Controls.Add(this.chkOther_workspace_clear);
            this.pnlOther.Controls.Add(this.chkOther_workspace);
            this.pnlOther.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOther.Enabled = false;
            this.pnlOther.Location = new System.Drawing.Point(3, 19);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(231, 98);
            this.pnlOther.TabIndex = 0;
            // 
            // chkOther_rain
            // 
            this.chkOther_rain.AutoSize = true;
            this.chkOther_rain.Location = new System.Drawing.Point(3, 74);
            this.chkOther_rain.Name = "chkOther_rain";
            this.chkOther_rain.Size = new System.Drawing.Size(126, 17);
            this.chkOther_rain.TabIndex = 14;
            this.chkOther_rain.Tag = "517";
            this.chkOther_rain.Text = "Вероятность дождя";
            this.chkOther_rain.UseVisualStyleBackColor = true;
            // 
            // chkOther_clear_glass
            // 
            this.chkOther_clear_glass.AutoSize = true;
            this.chkOther_clear_glass.Location = new System.Drawing.Point(3, 51);
            this.chkOther_clear_glass.Name = "chkOther_clear_glass";
            this.chkOther_clear_glass.Size = new System.Drawing.Size(148, 17);
            this.chkOther_clear_glass.TabIndex = 13;
            this.chkOther_clear_glass.Tag = "516";
            this.chkOther_clear_glass.Text = "Мытье профиля, стекол";
            this.chkOther_clear_glass.UseVisualStyleBackColor = true;
            // 
            // chkOther_workspace_clear
            // 
            this.chkOther_workspace_clear.AutoSize = true;
            this.chkOther_workspace_clear.Location = new System.Drawing.Point(3, 28);
            this.chkOther_workspace_clear.Name = "chkOther_workspace_clear";
            this.chkOther_workspace_clear.Size = new System.Drawing.Size(147, 17);
            this.chkOther_workspace_clear.TabIndex = 12;
            this.chkOther_workspace_clear.Tag = "515";
            this.chkOther_workspace_clear.Text = "Уборка рабочего места";
            this.chkOther_workspace_clear.UseVisualStyleBackColor = true;
            this.chkOther_workspace_clear.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkOther_workspace
            // 
            this.chkOther_workspace.AutoSize = true;
            this.chkOther_workspace.Location = new System.Drawing.Point(3, 5);
            this.chkOther_workspace.Name = "chkOther_workspace";
            this.chkOther_workspace.Size = new System.Drawing.Size(169, 17);
            this.chkOther_workspace.TabIndex = 0;
            this.chkOther_workspace.Tag = "514";
            this.chkOther_workspace.Text = "Подготовка рабочего места";
            this.chkOther_workspace.UseVisualStyleBackColor = true;
            this.chkOther_workspace.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // lstReport
            // 
            this.lstReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReport.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstReport.FormattingEnabled = true;
            this.lstReport.ItemHeight = 16;
            this.lstReport.Location = new System.Drawing.Point(250, 528);
            this.lstReport.Name = "lstReport";
            this.lstReport.Size = new System.Drawing.Size(934, 202);
            this.lstReport.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlInstallationConditions);
            this.groupBox1.Controls.Add(this.chkInstallationConditions);
            this.groupBox1.Location = new System.Drawing.Point(358, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 378);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxPaint);
            // 
            // pnlInstallationConditions
            // 
            this.pnlInstallationConditions.Controls.Add(this.numPilastra);
            this.pnlInstallationConditions.Controls.Add(this.numJoinProfil20);
            this.pnlInstallationConditions.Controls.Add(this.numJoinProfil2);
            this.pnlInstallationConditions.Controls.Add(this.chlPilastra);
            this.pnlInstallationConditions.Controls.Add(this.chkJoinProfil20);
            this.pnlInstallationConditions.Controls.Add(this.chkJoinProfil2);
            this.pnlInstallationConditions.Controls.Add(this.groupBox4);
            this.pnlInstallationConditions.Controls.Add(this.groupBox3);
            this.pnlInstallationConditions.Controls.Add(this.chkPrimat);
            this.pnlInstallationConditions.Controls.Add(this.numPrimat);
            this.pnlInstallationConditions.Controls.Add(this.lstInstallationConditions);
            this.pnlInstallationConditions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlInstallationConditions.Enabled = false;
            this.pnlInstallationConditions.Location = new System.Drawing.Point(3, 18);
            this.pnlInstallationConditions.Name = "pnlInstallationConditions";
            this.pnlInstallationConditions.Size = new System.Drawing.Size(280, 357);
            this.pnlInstallationConditions.TabIndex = 1;
            this.pnlInstallationConditions.EnabledChanged += new System.EventHandler(this.PnlInstallationConditions_EnabledChanged);
            // 
            // numPilastra
            // 
            this.numPilastra.Enabled = false;
            this.numPilastra.Location = new System.Drawing.Point(197, 329);
            this.numPilastra.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPilastra.Name = "numPilastra";
            this.numPilastra.Size = new System.Drawing.Size(77, 20);
            this.numPilastra.TabIndex = 19;
            this.numPilastra.Tag = "513";
            // 
            // numJoinProfil20
            // 
            this.numJoinProfil20.Enabled = false;
            this.numJoinProfil20.Location = new System.Drawing.Point(197, 303);
            this.numJoinProfil20.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numJoinProfil20.Name = "numJoinProfil20";
            this.numJoinProfil20.Size = new System.Drawing.Size(77, 20);
            this.numJoinProfil20.TabIndex = 18;
            this.numJoinProfil20.Tag = "512";
            // 
            // numJoinProfil2
            // 
            this.numJoinProfil2.Enabled = false;
            this.numJoinProfil2.Location = new System.Drawing.Point(197, 277);
            this.numJoinProfil2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numJoinProfil2.Name = "numJoinProfil2";
            this.numJoinProfil2.Size = new System.Drawing.Size(77, 20);
            this.numJoinProfil2.TabIndex = 14;
            this.numJoinProfil2.Tag = "511";
            // 
            // chlPilastra
            // 
            this.chlPilastra.AutoSize = true;
            this.chlPilastra.Location = new System.Drawing.Point(3, 330);
            this.chlPilastra.Name = "chlPilastra";
            this.chlPilastra.Size = new System.Drawing.Size(75, 17);
            this.chlPilastra.TabIndex = 17;
            this.chlPilastra.Text = "Пилястра";
            this.chlPilastra.UseVisualStyleBackColor = true;
            this.chlPilastra.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkJoinProfil20
            // 
            this.chkJoinProfil20.AutoSize = true;
            this.chkJoinProfil20.Location = new System.Drawing.Point(3, 304);
            this.chkJoinProfil20.Name = "chkJoinProfil20";
            this.chkJoinProfil20.Size = new System.Drawing.Size(138, 17);
            this.chkJoinProfil20.TabIndex = 16;
            this.chkJoinProfil20.Text = "Соед. профиль  20 мм";
            this.chkJoinProfil20.UseVisualStyleBackColor = true;
            this.chkJoinProfil20.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkJoinProfil2
            // 
            this.chkJoinProfil2.AutoSize = true;
            this.chkJoinProfil2.Location = new System.Drawing.Point(3, 278);
            this.chkJoinProfil2.Name = "chkJoinProfil2";
            this.chkJoinProfil2.Size = new System.Drawing.Size(132, 17);
            this.chkJoinProfil2.TabIndex = 15;
            this.chkJoinProfil2.Text = "Соед. профиль  2 мм";
            this.chkJoinProfil2.UseVisualStyleBackColor = true;
            this.chkJoinProfil2.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pnlMountingMethod);
            this.groupBox4.Controls.Add(this.chkMountingMethod);
            this.groupBox4.Location = new System.Drawing.Point(3, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 75);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // pnlMountingMethod
            // 
            this.pnlMountingMethod.Controls.Add(this.radioButton3);
            this.pnlMountingMethod.Controls.Add(this.radioButton4);
            this.pnlMountingMethod.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMountingMethod.Enabled = false;
            this.pnlMountingMethod.Location = new System.Drawing.Point(3, 24);
            this.pnlMountingMethod.Name = "pnlMountingMethod";
            this.pnlMountingMethod.Size = new System.Drawing.Size(265, 48);
            this.pnlMountingMethod.TabIndex = 13;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(70, 17);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "510";
            this.radioButton3.Text = "Саморез";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "509";
            this.radioButton4.Text = "Анкер";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // chkMountingMethod
            // 
            this.chkMountingMethod.AutoSize = true;
            this.chkMountingMethod.Location = new System.Drawing.Point(6, 1);
            this.chkMountingMethod.Name = "chkMountingMethod";
            this.chkMountingMethod.Size = new System.Drawing.Size(120, 17);
            this.chkMountingMethod.TabIndex = 12;
            this.chkMountingMethod.Text = "Способ крепления";
            this.chkMountingMethod.UseVisualStyleBackColor = true;
            this.chkMountingMethod.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlTypeOfFastening);
            this.groupBox3.Controls.Add(this.chkTypeOfFastening);
            this.groupBox3.Location = new System.Drawing.Point(3, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(271, 75);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // pnlTypeOfFastening
            // 
            this.pnlTypeOfFastening.Controls.Add(this.radioButton2);
            this.pnlTypeOfFastening.Controls.Add(this.radioButton1);
            this.pnlTypeOfFastening.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTypeOfFastening.Enabled = false;
            this.pnlTypeOfFastening.Location = new System.Drawing.Point(3, 24);
            this.pnlTypeOfFastening.Name = "pnlTypeOfFastening";
            this.pnlTypeOfFastening.Size = new System.Drawing.Size(265, 48);
            this.pnlTypeOfFastening.TabIndex = 13;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "508";
            this.radioButton2.Text = "Сквозной монтаж";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(124, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "507";
            this.radioButton1.Text = "Анкерная пластина";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // chkTypeOfFastening
            // 
            this.chkTypeOfFastening.AutoSize = true;
            this.chkTypeOfFastening.Location = new System.Drawing.Point(6, 1);
            this.chkTypeOfFastening.Name = "chkTypeOfFastening";
            this.chkTypeOfFastening.Size = new System.Drawing.Size(102, 17);
            this.chkTypeOfFastening.TabIndex = 12;
            this.chkTypeOfFastening.Text = "Вид крепления";
            this.chkTypeOfFastening.UseVisualStyleBackColor = true;
            this.chkTypeOfFastening.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // chkPrimat
            // 
            this.chkPrimat.AutoSize = true;
            this.chkPrimat.Location = new System.Drawing.Point(3, 103);
            this.chkPrimat.Name = "chkPrimat";
            this.chkPrimat.Size = new System.Drawing.Size(84, 17);
            this.chkPrimat.TabIndex = 11;
            this.chkPrimat.Text = "Примат, шт";
            this.chkPrimat.UseVisualStyleBackColor = true;
            this.chkPrimat.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // numPrimat
            // 
            this.numPrimat.Enabled = false;
            this.numPrimat.Location = new System.Drawing.Point(197, 103);
            this.numPrimat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPrimat.Name = "numPrimat";
            this.numPrimat.Size = new System.Drawing.Size(77, 20);
            this.numPrimat.TabIndex = 12;
            this.numPrimat.Tag = "506";
            // 
            // lstInstallationConditions
            // 
            this.lstInstallationConditions.BackColor = System.Drawing.SystemColors.Control;
            this.lstInstallationConditions.FormattingEnabled = true;
            this.lstInstallationConditions.Items.AddRange(new object[] {
            "Внутренний ПВХ уголок",
            "Наружный ПВХ уголок",
            "Внутренняя обналичка",
            "Внешняя обналичка",
            "Провиль 3028",
            "Отлив"});
            this.lstInstallationConditions.Location = new System.Drawing.Point(3, 3);
            this.lstInstallationConditions.Name = "lstInstallationConditions";
            this.lstInstallationConditions.Size = new System.Drawing.Size(271, 94);
            this.lstInstallationConditions.TabIndex = 4;
            this.lstInstallationConditions.Tag = "500,501,502,503,504,505";
            // 
            // chkInstallationConditions
            // 
            this.chkInstallationConditions.AutoSize = true;
            this.chkInstallationConditions.Location = new System.Drawing.Point(6, 0);
            this.chkInstallationConditions.Name = "chkInstallationConditions";
            this.chkInstallationConditions.Size = new System.Drawing.Size(118, 17);
            this.chkInstallationConditions.TabIndex = 0;
            this.chkInstallationConditions.Text = "Условия монтажа";
            this.chkInstallationConditions.UseVisualStyleBackColor = true;
            this.chkInstallationConditions.CheckedChanged += new System.EventHandler(this.checkInGUIHelpers);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Controls.Add(this.groupBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(250, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 484);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.lstReport);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpStages);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 768);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор монтажных часов 3.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpStages.ResumeLayout(false);
            this.grpStages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFloors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlReplacement.ResumeLayout(false);
            this.grbAssemblySeam_replace.ResumeLayout(false);
            this.grbAssemblySeam_replace.PerformLayout();
            this.pnlUchimado.ResumeLayout(false);
            this.grbAssemblySeam_uchimado.ResumeLayout(false);
            this.grbAssemblySeam_uchimado.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pnlMosquitos.ResumeLayout(false);
            this.pnlMosquitos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_border)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_pliss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMosq_slide)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.pnlDismantling.ResumeLayout(false);
            this.pnlDismantling.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlInstallationConditions.ResumeLayout(false);
            this.pnlInstallationConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPilastra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinProfil20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numJoinProfil2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlMountingMethod.ResumeLayout(false);
            this.pnlMountingMethod.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlTypeOfFastening.ResumeLayout(false);
            this.pnlTypeOfFastening.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrimat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSettings;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpStages;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAddFloor;
        private System.Windows.Forms.ToolStripButton btnDelFloor;
        private System.Windows.Forms.DataGridView grdFloors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFloorsPerimeter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFloorsCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFloorsNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnPDF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Panel pnlUchimado;
        private System.Windows.Forms.GroupBox grbAssemblySeam_uchimado;
        private System.Windows.Forms.CheckedListBox lstMountingSeamSilicon;
        private System.Windows.Forms.RadioButton rbUchimado_free;
        private System.Windows.Forms.RadioButton rbUchimado_PSUL;
        private System.Windows.Forms.RadioButton rbUchimado_silicon;
        private System.Windows.Forms.Panel pnlReplacement;
        private System.Windows.Forms.GroupBox grbAssemblySeam_replace;
        private System.Windows.Forms.CheckedListBox lstReplaceFoamSilicon;
        private System.Windows.Forms.RadioButton rbReplace_free;
        private System.Windows.Forms.RadioButton rbReplace_PSUL;
        private System.Windows.Forms.RadioButton rbReplace_foam;
        private System.Windows.Forms.CheckedListBox lstReplacePsulSilicon;
        private System.Windows.Forms.RadioButton btnUchimado;
        private System.Windows.Forms.RadioButton btnReplacement;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkMosquito_door;
        private System.Windows.Forms.NumericUpDown numMosq_door;
        private System.Windows.Forms.CheckBox chkMosquito_border;
        private System.Windows.Forms.NumericUpDown numMosq_border;
        private System.Windows.Forms.CheckBox chkMosquito_slide;
        private System.Windows.Forms.NumericUpDown numMosq_slide;
        private System.Windows.Forms.CheckBox chkMosquito_pliss;
        private System.Windows.Forms.NumericUpDown numMosq_pliss;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel pnlDismantling;
        private System.Windows.Forms.CheckBox chkDismantling;
        private System.Windows.Forms.CheckBox chkThread_2_PVH_reils;
        private System.Windows.Forms.CheckBox chkThread_2_PVH_only;
        private System.Windows.Forms.CheckBox chkThread_2_PVH;
        private System.Windows.Forms.CheckBox chkThread_2_wood_reils;
        private System.Windows.Forms.CheckBox chkThread_2_wood_only;
        private System.Windows.Forms.CheckBox chkThread_2_wood;
        private System.Windows.Forms.CheckBox chkThread_1_beton;
        private System.Windows.Forms.CheckBox chkThread_1_wood;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkOther;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.CheckBox chkOther_rain;
        private System.Windows.Forms.CheckBox chkOther_clear_glass;
        private System.Windows.Forms.CheckBox chkOther_workspace_clear;
        private System.Windows.Forms.CheckBox chkOther_workspace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCalc;
        private System.Windows.Forms.ListBox lstReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlInstallationConditions;
        private System.Windows.Forms.CheckBox chkInstallationConditions;
        private System.Windows.Forms.CheckedListBox lstInstallationConditions;
        private System.Windows.Forms.CheckBox chkPrimat;
        private System.Windows.Forms.NumericUpDown numPrimat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnlTypeOfFastening;
        private System.Windows.Forms.CheckBox chkTypeOfFastening;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel pnlMountingMethod;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox chkMountingMethod;
        private System.Windows.Forms.NumericUpDown numPilastra;
        private System.Windows.Forms.NumericUpDown numJoinProfil20;
        private System.Windows.Forms.NumericUpDown numJoinProfil2;
        private System.Windows.Forms.CheckBox chlPilastra;
        private System.Windows.Forms.CheckBox chkJoinProfil20;
        private System.Windows.Forms.CheckBox chkJoinProfil2;
        private System.Windows.Forms.CheckBox chkMosquitos;
        private System.Windows.Forms.Panel pnlMosquitos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnSaveReport;
        private System.Windows.Forms.ToolStripButton btnClear;
        private System.Windows.Forms.Panel panel2;
    }
}

