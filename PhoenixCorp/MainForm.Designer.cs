namespace PhoenixCorp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbDatabaseInformation = new System.Windows.Forms.RichTextBox();
            this.gbAddParams = new System.Windows.Forms.GroupBox();
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.numUDAddProfit = new System.Windows.Forms.NumericUpDown();
            this.lbAddProfit = new System.Windows.Forms.Label();
            this.numUDAddMonth = new System.Windows.Forms.NumericUpDown();
            this.lbAddMonth = new System.Windows.Forms.Label();
            this.numUDAddYear = new System.Windows.Forms.NumericUpDown();
            this.lbAddYear = new System.Windows.Forms.Label();
            this.tbAddDepName = new System.Windows.Forms.TextBox();
            this.lbAddDepName = new System.Windows.Forms.Label();
            this.numUDAddNumRec = new System.Windows.Forms.NumericUpDown();
            this.rbAddNumRec = new System.Windows.Forms.RadioButton();
            this.rbAddLast = new System.Windows.Forms.RadioButton();
            this.rbAddFirst = new System.Windows.Forms.RadioButton();
            this.gbChangeParams = new System.Windows.Forms.GroupBox();
            this.btnChangeRecord = new System.Windows.Forms.Button();
            this.tbChangeDepName = new System.Windows.Forms.TextBox();
            this.numUDChangeProfit = new System.Windows.Forms.NumericUpDown();
            this.lbChangeProfit = new System.Windows.Forms.Label();
            this.tbChangeID = new System.Windows.Forms.TextBox();
            this.numUDChangeMonth = new System.Windows.Forms.NumericUpDown();
            this.lbChangeDepName = new System.Windows.Forms.Label();
            this.lbChangeMonth = new System.Windows.Forms.Label();
            this.rbChangeID = new System.Windows.Forms.RadioButton();
            this.numUDChangeYear = new System.Windows.Forms.NumericUpDown();
            this.numUDChangeNumRec = new System.Windows.Forms.NumericUpDown();
            this.lbChangeYear = new System.Windows.Forms.Label();
            this.rbChangeNumRec = new System.Windows.Forms.RadioButton();
            this.gbRemoveParams = new System.Windows.Forms.GroupBox();
            this.btnRemoveRecord = new System.Windows.Forms.Button();
            this.tbRemoveID = new System.Windows.Forms.TextBox();
            this.rbRemoveID = new System.Windows.Forms.RadioButton();
            this.numUDRemoveNumRec = new System.Windows.Forms.NumericUpDown();
            this.rbRemoveNumRec = new System.Windows.Forms.RadioButton();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.toolFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMostProfit = new System.Windows.Forms.Button();
            this.btnWorstPeriod = new System.Windows.Forms.Button();
            this.btnMinProfit = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.gbAddParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddNumRec)).BeginInit();
            this.gbChangeParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeNumRec)).BeginInit();
            this.gbRemoveParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRemoveNumRec)).BeginInit();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDatabaseInformation
            // 
            this.rtbDatabaseInformation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDatabaseInformation.Location = new System.Drawing.Point(12, 27);
            this.rtbDatabaseInformation.Name = "rtbDatabaseInformation";
            this.rtbDatabaseInformation.ReadOnly = true;
            this.rtbDatabaseInformation.Size = new System.Drawing.Size(360, 447);
            this.rtbDatabaseInformation.TabIndex = 0;
            this.rtbDatabaseInformation.Text = "";
            // 
            // gbAddParams
            // 
            this.gbAddParams.Controls.Add(this.btnAddRecord);
            this.gbAddParams.Controls.Add(this.numUDAddProfit);
            this.gbAddParams.Controls.Add(this.lbAddProfit);
            this.gbAddParams.Controls.Add(this.numUDAddMonth);
            this.gbAddParams.Controls.Add(this.lbAddMonth);
            this.gbAddParams.Controls.Add(this.numUDAddYear);
            this.gbAddParams.Controls.Add(this.lbAddYear);
            this.gbAddParams.Controls.Add(this.tbAddDepName);
            this.gbAddParams.Controls.Add(this.lbAddDepName);
            this.gbAddParams.Controls.Add(this.numUDAddNumRec);
            this.gbAddParams.Controls.Add(this.rbAddNumRec);
            this.gbAddParams.Controls.Add(this.rbAddLast);
            this.gbAddParams.Controls.Add(this.rbAddFirst);
            this.gbAddParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddParams.Location = new System.Drawing.Point(386, 27);
            this.gbAddParams.Name = "gbAddParams";
            this.gbAddParams.Size = new System.Drawing.Size(432, 221);
            this.gbAddParams.TabIndex = 1;
            this.gbAddParams.TabStop = false;
            this.gbAddParams.Text = "Добавление:";
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(221, 176);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(201, 28);
            this.btnAddRecord.TabIndex = 12;
            this.btnAddRecord.Text = "Добавить запись";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // numUDAddProfit
            // 
            this.numUDAddProfit.Location = new System.Drawing.Point(69, 178);
            this.numUDAddProfit.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUDAddProfit.Name = "numUDAddProfit";
            this.numUDAddProfit.Size = new System.Drawing.Size(120, 26);
            this.numUDAddProfit.TabIndex = 11;
            // 
            // lbAddProfit
            // 
            this.lbAddProfit.AutoSize = true;
            this.lbAddProfit.Location = new System.Drawing.Point(2, 180);
            this.lbAddProfit.Name = "lbAddProfit";
            this.lbAddProfit.Size = new System.Drawing.Size(61, 20);
            this.lbAddProfit.TabIndex = 10;
            this.lbAddProfit.Text = "Доход:";
            // 
            // numUDAddMonth
            // 
            this.numUDAddMonth.Location = new System.Drawing.Point(221, 141);
            this.numUDAddMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUDAddMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDAddMonth.Name = "numUDAddMonth";
            this.numUDAddMonth.Size = new System.Drawing.Size(53, 26);
            this.numUDAddMonth.TabIndex = 9;
            this.numUDAddMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbAddMonth
            // 
            this.lbAddMonth.AutoSize = true;
            this.lbAddMonth.Location = new System.Drawing.Point(154, 143);
            this.lbAddMonth.Name = "lbAddMonth";
            this.lbAddMonth.Size = new System.Drawing.Size(61, 20);
            this.lbAddMonth.TabIndex = 8;
            this.lbAddMonth.Text = "Месяц:";
            // 
            // numUDAddYear
            // 
            this.numUDAddYear.Location = new System.Drawing.Point(51, 141);
            this.numUDAddYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numUDAddYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUDAddYear.Name = "numUDAddYear";
            this.numUDAddYear.Size = new System.Drawing.Size(72, 26);
            this.numUDAddYear.TabIndex = 7;
            this.numUDAddYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // lbAddYear
            // 
            this.lbAddYear.AutoSize = true;
            this.lbAddYear.Location = new System.Drawing.Point(3, 143);
            this.lbAddYear.Name = "lbAddYear";
            this.lbAddYear.Size = new System.Drawing.Size(42, 20);
            this.lbAddYear.TabIndex = 6;
            this.lbAddYear.Text = "Год:";
            // 
            // tbAddDepName
            // 
            this.tbAddDepName.Location = new System.Drawing.Point(221, 106);
            this.tbAddDepName.Name = "tbAddDepName";
            this.tbAddDepName.Size = new System.Drawing.Size(201, 26);
            this.tbAddDepName.TabIndex = 5;
            // 
            // lbAddDepName
            // 
            this.lbAddDepName.AutoSize = true;
            this.lbAddDepName.Location = new System.Drawing.Point(3, 109);
            this.lbAddDepName.Name = "lbAddDepName";
            this.lbAddDepName.Size = new System.Drawing.Size(212, 20);
            this.lbAddDepName.TabIndex = 4;
            this.lbAddDepName.Text = "Название подразделения:";
            // 
            // numUDAddNumRec
            // 
            this.numUDAddNumRec.AutoSize = true;
            this.numUDAddNumRec.Enabled = false;
            this.numUDAddNumRec.Location = new System.Drawing.Point(209, 74);
            this.numUDAddNumRec.Name = "numUDAddNumRec";
            this.numUDAddNumRec.Size = new System.Drawing.Size(52, 26);
            this.numUDAddNumRec.TabIndex = 3;
            this.numUDAddNumRec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbAddNumRec
            // 
            this.rbAddNumRec.AutoSize = true;
            this.rbAddNumRec.Location = new System.Drawing.Point(7, 74);
            this.rbAddNumRec.Name = "rbAddNumRec";
            this.rbAddNumRec.Size = new System.Drawing.Size(196, 24);
            this.rbAddNumRec.TabIndex = 2;
            this.rbAddNumRec.Text = "По заданному номеру:";
            this.rbAddNumRec.UseVisualStyleBackColor = true;
            this.rbAddNumRec.CheckedChanged += new System.EventHandler(this.rbAddNumRec_CheckedChanged);
            // 
            // rbAddLast
            // 
            this.rbAddLast.AutoSize = true;
            this.rbAddLast.Location = new System.Drawing.Point(7, 50);
            this.rbAddLast.Name = "rbAddLast";
            this.rbAddLast.Size = new System.Drawing.Size(86, 24);
            this.rbAddLast.TabIndex = 1;
            this.rbAddLast.Text = "В конец";
            this.rbAddLast.UseVisualStyleBackColor = true;
            this.rbAddLast.CheckedChanged += new System.EventHandler(this.rbAddLast_CheckedChanged);
            // 
            // rbAddFirst
            // 
            this.rbAddFirst.AutoSize = true;
            this.rbAddFirst.Checked = true;
            this.rbAddFirst.Location = new System.Drawing.Point(6, 25);
            this.rbAddFirst.Name = "rbAddFirst";
            this.rbAddFirst.Size = new System.Drawing.Size(97, 24);
            this.rbAddFirst.TabIndex = 0;
            this.rbAddFirst.TabStop = true;
            this.rbAddFirst.Text = "В начало";
            this.rbAddFirst.UseVisualStyleBackColor = true;
            this.rbAddFirst.CheckedChanged += new System.EventHandler(this.rbAddFirst_CheckedChanged);
            // 
            // gbChangeParams
            // 
            this.gbChangeParams.Controls.Add(this.btnChangeRecord);
            this.gbChangeParams.Controls.Add(this.tbChangeDepName);
            this.gbChangeParams.Controls.Add(this.numUDChangeProfit);
            this.gbChangeParams.Controls.Add(this.lbChangeProfit);
            this.gbChangeParams.Controls.Add(this.tbChangeID);
            this.gbChangeParams.Controls.Add(this.numUDChangeMonth);
            this.gbChangeParams.Controls.Add(this.lbChangeDepName);
            this.gbChangeParams.Controls.Add(this.lbChangeMonth);
            this.gbChangeParams.Controls.Add(this.rbChangeID);
            this.gbChangeParams.Controls.Add(this.numUDChangeYear);
            this.gbChangeParams.Controls.Add(this.numUDChangeNumRec);
            this.gbChangeParams.Controls.Add(this.lbChangeYear);
            this.gbChangeParams.Controls.Add(this.rbChangeNumRec);
            this.gbChangeParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChangeParams.Location = new System.Drawing.Point(386, 256);
            this.gbChangeParams.Name = "gbChangeParams";
            this.gbChangeParams.Size = new System.Drawing.Size(432, 209);
            this.gbChangeParams.TabIndex = 2;
            this.gbChangeParams.TabStop = false;
            this.gbChangeParams.Text = "Изменение:";
            // 
            // btnChangeRecord
            // 
            this.btnChangeRecord.Location = new System.Drawing.Point(224, 171);
            this.btnChangeRecord.Name = "btnChangeRecord";
            this.btnChangeRecord.Size = new System.Drawing.Size(201, 28);
            this.btnChangeRecord.TabIndex = 19;
            this.btnChangeRecord.Text = "Изменить запись";
            this.btnChangeRecord.UseVisualStyleBackColor = true;
            this.btnChangeRecord.Click += new System.EventHandler(this.btnChangeRecord_Click);
            // 
            // tbChangeDepName
            // 
            this.tbChangeDepName.Location = new System.Drawing.Point(224, 101);
            this.tbChangeDepName.Name = "tbChangeDepName";
            this.tbChangeDepName.Size = new System.Drawing.Size(201, 26);
            this.tbChangeDepName.TabIndex = 14;
            // 
            // numUDChangeProfit
            // 
            this.numUDChangeProfit.Location = new System.Drawing.Point(72, 173);
            this.numUDChangeProfit.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numUDChangeProfit.Name = "numUDChangeProfit";
            this.numUDChangeProfit.Size = new System.Drawing.Size(120, 26);
            this.numUDChangeProfit.TabIndex = 18;
            // 
            // lbChangeProfit
            // 
            this.lbChangeProfit.AutoSize = true;
            this.lbChangeProfit.Location = new System.Drawing.Point(5, 175);
            this.lbChangeProfit.Name = "lbChangeProfit";
            this.lbChangeProfit.Size = new System.Drawing.Size(61, 20);
            this.lbChangeProfit.TabIndex = 17;
            this.lbChangeProfit.Text = "Доход:";
            // 
            // tbChangeID
            // 
            this.tbChangeID.Enabled = false;
            this.tbChangeID.Location = new System.Drawing.Point(85, 66);
            this.tbChangeID.Name = "tbChangeID";
            this.tbChangeID.Size = new System.Drawing.Size(189, 26);
            this.tbChangeID.TabIndex = 3;
            this.tbChangeID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbChangeID_KeyPress);
            // 
            // numUDChangeMonth
            // 
            this.numUDChangeMonth.Location = new System.Drawing.Point(224, 136);
            this.numUDChangeMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUDChangeMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDChangeMonth.Name = "numUDChangeMonth";
            this.numUDChangeMonth.Size = new System.Drawing.Size(53, 26);
            this.numUDChangeMonth.TabIndex = 16;
            this.numUDChangeMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbChangeDepName
            // 
            this.lbChangeDepName.AutoSize = true;
            this.lbChangeDepName.Location = new System.Drawing.Point(6, 104);
            this.lbChangeDepName.Name = "lbChangeDepName";
            this.lbChangeDepName.Size = new System.Drawing.Size(212, 20);
            this.lbChangeDepName.TabIndex = 13;
            this.lbChangeDepName.Text = "Название подразделения:";
            // 
            // lbChangeMonth
            // 
            this.lbChangeMonth.AutoSize = true;
            this.lbChangeMonth.Location = new System.Drawing.Point(157, 138);
            this.lbChangeMonth.Name = "lbChangeMonth";
            this.lbChangeMonth.Size = new System.Drawing.Size(61, 20);
            this.lbChangeMonth.TabIndex = 15;
            this.lbChangeMonth.Text = "Месяц:";
            // 
            // rbChangeID
            // 
            this.rbChangeID.AutoSize = true;
            this.rbChangeID.Location = new System.Drawing.Point(6, 67);
            this.rbChangeID.Name = "rbChangeID";
            this.rbChangeID.Size = new System.Drawing.Size(73, 24);
            this.rbChangeID.TabIndex = 2;
            this.rbChangeID.Text = "По ID:";
            this.rbChangeID.UseVisualStyleBackColor = true;
            this.rbChangeID.CheckedChanged += new System.EventHandler(this.rbChangeID_CheckedChanged);
            // 
            // numUDChangeYear
            // 
            this.numUDChangeYear.Location = new System.Drawing.Point(54, 136);
            this.numUDChangeYear.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numUDChangeYear.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numUDChangeYear.Name = "numUDChangeYear";
            this.numUDChangeYear.Size = new System.Drawing.Size(72, 26);
            this.numUDChangeYear.TabIndex = 14;
            this.numUDChangeYear.Value = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            // 
            // numUDChangeNumRec
            // 
            this.numUDChangeNumRec.Location = new System.Drawing.Point(178, 25);
            this.numUDChangeNumRec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDChangeNumRec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDChangeNumRec.Name = "numUDChangeNumRec";
            this.numUDChangeNumRec.Size = new System.Drawing.Size(96, 26);
            this.numUDChangeNumRec.TabIndex = 1;
            this.numUDChangeNumRec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbChangeYear
            // 
            this.lbChangeYear.AutoSize = true;
            this.lbChangeYear.Location = new System.Drawing.Point(6, 138);
            this.lbChangeYear.Name = "lbChangeYear";
            this.lbChangeYear.Size = new System.Drawing.Size(42, 20);
            this.lbChangeYear.TabIndex = 13;
            this.lbChangeYear.Text = "Год:";
            // 
            // rbChangeNumRec
            // 
            this.rbChangeNumRec.AutoSize = true;
            this.rbChangeNumRec.Checked = true;
            this.rbChangeNumRec.Location = new System.Drawing.Point(6, 25);
            this.rbChangeNumRec.Name = "rbChangeNumRec";
            this.rbChangeNumRec.Size = new System.Drawing.Size(166, 24);
            this.rbChangeNumRec.TabIndex = 0;
            this.rbChangeNumRec.TabStop = true;
            this.rbChangeNumRec.Text = "По номеру записи:";
            this.rbChangeNumRec.UseVisualStyleBackColor = true;
            this.rbChangeNumRec.CheckedChanged += new System.EventHandler(this.rbChangeNumRec_CheckedChanged);
            // 
            // gbRemoveParams
            // 
            this.gbRemoveParams.Controls.Add(this.btnRemoveRecord);
            this.gbRemoveParams.Controls.Add(this.tbRemoveID);
            this.gbRemoveParams.Controls.Add(this.rbRemoveID);
            this.gbRemoveParams.Controls.Add(this.numUDRemoveNumRec);
            this.gbRemoveParams.Controls.Add(this.rbRemoveNumRec);
            this.gbRemoveParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRemoveParams.Location = new System.Drawing.Point(845, 292);
            this.gbRemoveParams.Name = "gbRemoveParams";
            this.gbRemoveParams.Size = new System.Drawing.Size(288, 145);
            this.gbRemoveParams.TabIndex = 20;
            this.gbRemoveParams.TabStop = false;
            this.gbRemoveParams.Text = "Изменение:";
            // 
            // btnRemoveRecord
            // 
            this.btnRemoveRecord.Location = new System.Drawing.Point(44, 108);
            this.btnRemoveRecord.Name = "btnRemoveRecord";
            this.btnRemoveRecord.Size = new System.Drawing.Size(201, 28);
            this.btnRemoveRecord.TabIndex = 20;
            this.btnRemoveRecord.Text = "Удалить запись";
            this.btnRemoveRecord.UseVisualStyleBackColor = true;
            this.btnRemoveRecord.Click += new System.EventHandler(this.btnRemoveRecord_Click);
            // 
            // tbRemoveID
            // 
            this.tbRemoveID.Enabled = false;
            this.tbRemoveID.Location = new System.Drawing.Point(85, 66);
            this.tbRemoveID.Name = "tbRemoveID";
            this.tbRemoveID.Size = new System.Drawing.Size(189, 26);
            this.tbRemoveID.TabIndex = 3;
            this.tbRemoveID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRemoveID_KeyPress);
            // 
            // rbRemoveID
            // 
            this.rbRemoveID.AutoSize = true;
            this.rbRemoveID.Location = new System.Drawing.Point(6, 67);
            this.rbRemoveID.Name = "rbRemoveID";
            this.rbRemoveID.Size = new System.Drawing.Size(73, 24);
            this.rbRemoveID.TabIndex = 2;
            this.rbRemoveID.Text = "По ID:";
            this.rbRemoveID.UseVisualStyleBackColor = true;
            this.rbRemoveID.CheckedChanged += new System.EventHandler(this.rbRemoveID_CheckedChanged);
            // 
            // numUDRemoveNumRec
            // 
            this.numUDRemoveNumRec.Location = new System.Drawing.Point(178, 25);
            this.numUDRemoveNumRec.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUDRemoveNumRec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDRemoveNumRec.Name = "numUDRemoveNumRec";
            this.numUDRemoveNumRec.Size = new System.Drawing.Size(96, 26);
            this.numUDRemoveNumRec.TabIndex = 1;
            this.numUDRemoveNumRec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbRemoveNumRec
            // 
            this.rbRemoveNumRec.AutoSize = true;
            this.rbRemoveNumRec.Checked = true;
            this.rbRemoveNumRec.Location = new System.Drawing.Point(6, 25);
            this.rbRemoveNumRec.Name = "rbRemoveNumRec";
            this.rbRemoveNumRec.Size = new System.Drawing.Size(166, 24);
            this.rbRemoveNumRec.TabIndex = 0;
            this.rbRemoveNumRec.TabStop = true;
            this.rbRemoveNumRec.Text = "По номеру записи:";
            this.rbRemoveNumRec.UseVisualStyleBackColor = true;
            this.rbRemoveNumRec.CheckedChanged += new System.EventHandler(this.rbRemoveNumRec_CheckedChanged);
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolAbout});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(1158, 28);
            this.menuStripFile.TabIndex = 21;
            this.menuStripFile.Text = "menuStrip1";
            // 
            // toolFile
            // 
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFileOpen,
            this.toolFileSave});
            this.toolFile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(57, 24);
            this.toolFile.Text = "Файл";
            this.toolFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolFileOpen
            // 
            this.toolFileOpen.Name = "toolFileOpen";
            this.toolFileOpen.Size = new System.Drawing.Size(191, 24);
            this.toolFileOpen.Text = "Открыть файл";
            this.toolFileOpen.Click += new System.EventHandler(this.toolFileOpen_Click);
            // 
            // toolFileSave
            // 
            this.toolFileSave.Name = "toolFileSave";
            this.toolFileSave.Size = new System.Drawing.Size(191, 24);
            this.toolFileSave.Text = "Сохранить файл";
            this.toolFileSave.Click += new System.EventHandler(this.toolFileSave_Click);
            // 
            // toolAbout
            // 
            this.toolAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolAbout.Name = "toolAbout";
            this.toolAbout.Size = new System.Drawing.Size(116, 24);
            this.toolAbout.Text = "О программе";
            this.toolAbout.Click += new System.EventHandler(this.toolAbout_Click);
            // 
            // btnMostProfit
            // 
            this.btnMostProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostProfit.Location = new System.Drawing.Point(845, 40);
            this.btnMostProfit.Name = "btnMostProfit";
            this.btnMostProfit.Size = new System.Drawing.Size(288, 49);
            this.btnMostProfit.TabIndex = 22;
            this.btnMostProfit.Text = "Определить самые прибыльные годы подразделений";
            this.btnMostProfit.UseVisualStyleBackColor = true;
            this.btnMostProfit.Click += new System.EventHandler(this.btnMostProfit_Click);
            // 
            // btnWorstPeriod
            // 
            this.btnWorstPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorstPeriod.Location = new System.Drawing.Point(845, 101);
            this.btnWorstPeriod.Name = "btnWorstPeriod";
            this.btnWorstPeriod.Size = new System.Drawing.Size(288, 95);
            this.btnWorstPeriod.TabIndex = 23;
            this.btnWorstPeriod.Text = "Определить наиболее длинный период каждого подразделения с доходом ниже среднего " +
    "по всей фирме";
            this.btnWorstPeriod.UseVisualStyleBackColor = true;
            this.btnWorstPeriod.Click += new System.EventHandler(this.btnWorstPeriod_Click);
            // 
            // btnMinProfit
            // 
            this.btnMinProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinProfit.Location = new System.Drawing.Point(845, 208);
            this.btnMinProfit.Name = "btnMinProfit";
            this.btnMinProfit.Size = new System.Drawing.Size(288, 49);
            this.btnMinProfit.TabIndex = 24;
            this.btnMinProfit.Text = "Определить год с минимальным доходом подразделений";
            this.btnMinProfit.UseVisualStyleBackColor = true;
            this.btnMinProfit.Click += new System.EventHandler(this.btnMinProfit_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 482);
            this.Controls.Add(this.btnMinProfit);
            this.Controls.Add(this.btnWorstPeriod);
            this.Controls.Add(this.btnMostProfit);
            this.Controls.Add(this.gbRemoveParams);
            this.Controls.Add(this.gbChangeParams);
            this.Controls.Add(this.gbAddParams);
            this.Controls.Add(this.rtbDatabaseInformation);
            this.Controls.Add(this.menuStripFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фирма \"Феникс\"";
            this.gbAddParams.ResumeLayout(false);
            this.gbAddParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDAddNumRec)).EndInit();
            this.gbChangeParams.ResumeLayout(false);
            this.gbChangeParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDChangeNumRec)).EndInit();
            this.gbRemoveParams.ResumeLayout(false);
            this.gbRemoveParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDRemoveNumRec)).EndInit();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Поле вывода данных из БД
        private System.Windows.Forms.RichTextBox rtbDatabaseInformation;

        // Контейнер с параметрами добавления новой записи
        private System.Windows.Forms.GroupBox gbAddParams;

        #region Элементы контейнера gbAddParams

        /* Радиокнопки */

        // Добавление в начало (по умолчанию)
        private System.Windows.Forms.RadioButton rbAddFirst;

        // Добавление в конец
        private System.Windows.Forms.RadioButton rbAddLast;

        // Добавление с условием (по заданному номеру)
        private System.Windows.Forms.RadioButton rbAddNumRec;

        /* Поля */

        // Поле задания номера (индекса). По умолчанию недоступно
        private System.Windows.Forms.NumericUpDown numUDAddNumRec;

        // Метка "Название подразделения:"
        private System.Windows.Forms.Label lbAddDepName;
        // Текстовое поле для ввода названия подразделения
        private System.Windows.Forms.TextBox tbAddDepName;

        // Метка "Год:"
        private System.Windows.Forms.Label lbAddYear;
        // Поле задания года. По умолчанию: 2020
        private System.Windows.Forms.NumericUpDown numUDAddYear;

        // Метка "Месяц:"
        private System.Windows.Forms.Label lbAddMonth;
        // Поле задания месяца. По умолчанию: 1
        private System.Windows.Forms.NumericUpDown numUDAddMonth;

        // Метка "Доход:"
        private System.Windows.Forms.Label lbAddProfit;
        // Поле задания дохода
        private System.Windows.Forms.NumericUpDown numUDAddProfit;

        /* Кнопки */

        // Добавление записи
        private System.Windows.Forms.Button btnAddRecord;

        #endregion

        // Контейнер с параметрами изменения записи
        private System.Windows.Forms.GroupBox gbChangeParams;

        #region Элементы контейнера gbChangeParams

        /* Радиокнопки */

        // Изменение по номеру записи (по умолчанию)
        private System.Windows.Forms.RadioButton rbChangeNumRec;

        // Изменение по ID
        private System.Windows.Forms.RadioButton rbChangeID;

        /* Поля */

        // Поле задания номера записи
        private System.Windows.Forms.NumericUpDown numUDChangeNumRec;

        // Текстовое поле для ввода ID. По умолчанию недоступно
        private System.Windows.Forms.TextBox tbChangeID;

        // Метка "Название подразделения:"
        private System.Windows.Forms.Label lbChangeDepName;
        // Текстовое поле для ввода нового названия подразделения
        private System.Windows.Forms.TextBox tbChangeDepName;

        // Метка "Год:"
        private System.Windows.Forms.Label lbChangeYear;
        // Поле задания года. По умолчанию: 2020
        private System.Windows.Forms.NumericUpDown numUDChangeYear;

        // Метка "Месяц:"
        private System.Windows.Forms.NumericUpDown numUDChangeMonth;
        // Поле задания месяца. По умолчанию: 1
        private System.Windows.Forms.Label lbChangeMonth;

        // Метка "Доход:"
        private System.Windows.Forms.Label lbChangeProfit;
        // Поле задания дохода
        private System.Windows.Forms.NumericUpDown numUDChangeProfit;

        /* Кнопки */

        // Изменение записи
        private System.Windows.Forms.Button btnChangeRecord;

        #endregion

        // Контейнер с параметрами удаления записи
        private System.Windows.Forms.GroupBox gbRemoveParams;

        #region Элементы контейнера gbRemoveParams

        /* Радиокнопки */

        // Удаление по номеру записи (по умолчанию)
        private System.Windows.Forms.RadioButton rbRemoveNumRec;

        // Удаление по ID
        private System.Windows.Forms.RadioButton rbRemoveID;

        /* Поля */

        // Поле задания номера записи
        private System.Windows.Forms.NumericUpDown numUDRemoveNumRec;

        // Текстовое поле для ввода ID
        private System.Windows.Forms.TextBox tbRemoveID;

        /* Кнопки */

        // Удаление записи
        private System.Windows.Forms.Button btnRemoveRecord;

        #endregion

        // Главное меню программы
        private System.Windows.Forms.MenuStrip menuStripFile;

        // Вкладка "Файл"
        private System.Windows.Forms.ToolStripMenuItem toolFile;

        #region Элементы вкладки "Файл"

        // Действие "Открыть файл"
        private System.Windows.Forms.ToolStripMenuItem toolFileOpen;

        // Действие "Сохранить файл"
        private System.Windows.Forms.ToolStripMenuItem toolFileSave;

        #endregion

        // Вкладка "О программе"
        private System.Windows.Forms.ToolStripMenuItem toolAbout;

        /* Главные действия */

        // Определить самые прибыльные годы подразделений
        private System.Windows.Forms.Button btnMostProfit;
        // Определить самый долгий плохой период
        private System.Windows.Forms.Button btnWorstPeriod;
        // Определить минимальный доход подразделений
        private System.Windows.Forms.Button btnMinProfit;

        // Диалоговое окно открытия файла
        private System.Windows.Forms.OpenFileDialog openFileDialog;

        // Диалоговое окно сохранения файла
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

