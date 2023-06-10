namespace robot
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
			this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
			this.gb_robot = new System.Windows.Forms.GroupBox();
			this.tlp_Robot = new System.Windows.Forms.TableLayoutPanel();
			this.btn_ServoOn = new System.Windows.Forms.Button();
			this.btn_ServoOff = new System.Windows.Forms.Button();
			this.btn_startProgram = new System.Windows.Forms.Button();
			this.btn_stopProgram = new System.Windows.Forms.Button();
			this.btn_resetProgram = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_zalaczStrefe = new System.Windows.Forms.Button();
			this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
			this.rb_strefaZaloczona = new System.Windows.Forms.RadioButton();
			this.rb_oczekiwanieNaZawory = new System.Windows.Forms.RadioButton();
			this.rb_przepelnienieZjazduZaladunek = new System.Windows.Forms.RadioButton();
			this.btn_resetStrefy = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_resetStrefyRozlad = new System.Windows.Forms.Button();
			this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
			this.rb_strefaZalaczonaRozladunek = new System.Windows.Forms.RadioButton();
			this.rb_przepelnienieRozladunku = new System.Windows.Forms.RadioButton();
			this.rb_przepelnieniZjazduPalletRozlad = new System.Windows.Forms.RadioButton();
			this.btn_zalaczStrefeRozlad = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_SendFrame = new System.Windows.Forms.Button();
			this.txbFrame = new System.Windows.Forms.TextBox();
			this.gb_commands = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_autoMode = new System.Windows.Forms.Button();
			this.btn_manualMode = new System.Windows.Forms.Button();
			this.btn_sycleStart = new System.Windows.Forms.Button();
			this.btn_cycleStop = new System.Windows.Forms.Button();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_AlarmsReset = new System.Windows.Forms.Button();
			this.rtb_AlarmField = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.rb_robotAuto = new System.Windows.Forms.RadioButton();
			this.rb_raobotManual = new System.Windows.Forms.RadioButton();
			this.rb_robotStart = new System.Windows.Forms.RadioButton();
			this.rb_robotAlarm = new System.Windows.Forms.RadioButton();
			this.rb_bypass = new System.Windows.Forms.RadioButton();
			this.rb_autoExt = new System.Windows.Forms.RadioButton();
			this.rb_emergenctStop = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_robotStatus = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btn_speedUp = new System.Windows.Forms.Button();
			this.btn_speedDown = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_wybierzSchemat = new System.Windows.Forms.Button();
			this.btn_aktywujSchemat = new System.Windows.Forms.Button();
			this.tlp_Main.SuspendLayout();
			this.gb_robot.SuspendLayout();
			this.tlp_Robot.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tableLayoutPanel11.SuspendLayout();
			this.tableLayoutPanel12.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tableLayoutPanel13.SuspendLayout();
			this.tableLayoutPanel14.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.gb_commands.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.tableLayoutPanel10.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// tlp_Main
			// 
			this.tlp_Main.ColumnCount = 3;
			this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.03185F));
			this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.96815F));
			this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
			this.tlp_Main.Controls.Add(this.gb_robot, 0, 0);
			this.tlp_Main.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tlp_Main.Controls.Add(this.tableLayoutPanel4, 2, 1);
			this.tlp_Main.Controls.Add(this.gb_commands, 0, 1);
			this.tlp_Main.Controls.Add(this.tableLayoutPanel6, 1, 1);
			this.tlp_Main.Controls.Add(this.groupBox2, 2, 0);
			this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_Main.Location = new System.Drawing.Point(0, 0);
			this.tlp_Main.Name = "tlp_Main";
			this.tlp_Main.RowCount = 3;
			this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.49233F));
			this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.50767F));
			this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlp_Main.Size = new System.Drawing.Size(1193, 608);
			this.tlp_Main.TabIndex = 0;
			// 
			// gb_robot
			// 
			this.gb_robot.Controls.Add(this.tlp_Robot);
			this.gb_robot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gb_robot.Location = new System.Drawing.Point(3, 3);
			this.gb_robot.Name = "gb_robot";
			this.gb_robot.Size = new System.Drawing.Size(133, 308);
			this.gb_robot.TabIndex = 1;
			this.gb_robot.TabStop = false;
			this.gb_robot.Text = "Robot";
			// 
			// tlp_Robot
			// 
			this.tlp_Robot.ColumnCount = 1;
			this.tlp_Robot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlp_Robot.Controls.Add(this.btn_ServoOn, 0, 0);
			this.tlp_Robot.Controls.Add(this.btn_ServoOff, 0, 1);
			this.tlp_Robot.Controls.Add(this.btn_startProgram, 0, 2);
			this.tlp_Robot.Controls.Add(this.btn_stopProgram, 0, 3);
			this.tlp_Robot.Controls.Add(this.btn_resetProgram, 0, 4);
			this.tlp_Robot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tlp_Robot.Location = new System.Drawing.Point(3, 16);
			this.tlp_Robot.Name = "tlp_Robot";
			this.tlp_Robot.RowCount = 5;
			this.tlp_Robot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.06123F));
			this.tlp_Robot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.93877F));
			this.tlp_Robot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
			this.tlp_Robot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tlp_Robot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
			this.tlp_Robot.Size = new System.Drawing.Size(127, 289);
			this.tlp_Robot.TabIndex = 0;
			// 
			// btn_ServoOn
			// 
			this.btn_ServoOn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_ServoOn.Location = new System.Drawing.Point(3, 3);
			this.btn_ServoOn.Name = "btn_ServoOn";
			this.btn_ServoOn.Size = new System.Drawing.Size(121, 59);
			this.btn_ServoOn.TabIndex = 0;
			this.btn_ServoOn.Text = "SERVO ON";
			this.btn_ServoOn.UseVisualStyleBackColor = true;
			this.btn_ServoOn.Click += new System.EventHandler(this.btn_ServoOn_Click);
			// 
			// btn_ServoOff
			// 
			this.btn_ServoOff.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_ServoOff.Enabled = false;
			this.btn_ServoOff.Location = new System.Drawing.Point(3, 68);
			this.btn_ServoOff.Name = "btn_ServoOff";
			this.btn_ServoOff.Size = new System.Drawing.Size(121, 52);
			this.btn_ServoOff.TabIndex = 1;
			this.btn_ServoOff.Text = "SERVO OFF";
			this.btn_ServoOff.UseVisualStyleBackColor = true;
			this.btn_ServoOff.Click += new System.EventHandler(this.btn_ServoOff_Click);
			// 
			// btn_startProgram
			// 
			this.btn_startProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_startProgram.Location = new System.Drawing.Point(3, 126);
			this.btn_startProgram.Name = "btn_startProgram";
			this.btn_startProgram.Size = new System.Drawing.Size(121, 53);
			this.btn_startProgram.TabIndex = 2;
			this.btn_startProgram.Text = "START PROGRAM";
			this.btn_startProgram.UseVisualStyleBackColor = true;
			// 
			// btn_stopProgram
			// 
			this.btn_stopProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_stopProgram.Location = new System.Drawing.Point(3, 185);
			this.btn_stopProgram.Name = "btn_stopProgram";
			this.btn_stopProgram.Size = new System.Drawing.Size(121, 51);
			this.btn_stopProgram.TabIndex = 3;
			this.btn_stopProgram.Text = "STOP PROGRAM";
			this.btn_stopProgram.UseVisualStyleBackColor = true;
			// 
			// btn_resetProgram
			// 
			this.btn_resetProgram.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_resetProgram.Location = new System.Drawing.Point(3, 242);
			this.btn_resetProgram.Name = "btn_resetProgram";
			this.btn_resetProgram.Size = new System.Drawing.Size(121, 44);
			this.btn_resetProgram.TabIndex = 4;
			this.btn_resetProgram.Text = "RESET PROGRAM";
			this.btn_resetProgram.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.14221F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(142, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.46875F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 308);
			this.tableLayoutPanel2.TabIndex = 4;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.groupBox4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.groupBox5, 1, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 302);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.tableLayoutPanel11);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox4.Location = new System.Drawing.Point(3, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(383, 296);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "STREFA ZAŁADUNKU";
			// 
			// tableLayoutPanel11
			// 
			this.tableLayoutPanel11.ColumnCount = 2;
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel11.Controls.Add(this.btn_zalaczStrefe, 0, 0);
			this.tableLayoutPanel11.Controls.Add(this.tableLayoutPanel12, 0, 1);
			this.tableLayoutPanel11.Controls.Add(this.btn_resetStrefy, 1, 0);
			this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel11.Name = "tableLayoutPanel11";
			this.tableLayoutPanel11.RowCount = 2;
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.68592F));
			this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.31408F));
			this.tableLayoutPanel11.Size = new System.Drawing.Size(377, 277);
			this.tableLayoutPanel11.TabIndex = 0;
			// 
			// btn_zalaczStrefe
			// 
			this.btn_zalaczStrefe.Location = new System.Drawing.Point(40, 20);
			this.btn_zalaczStrefe.Margin = new System.Windows.Forms.Padding(40, 20, 20, 20);
			this.btn_zalaczStrefe.Name = "btn_zalaczStrefe";
			this.btn_zalaczStrefe.Size = new System.Drawing.Size(90, 42);
			this.btn_zalaczStrefe.TabIndex = 0;
			this.btn_zalaczStrefe.Text = "ZALACZ STREFE";
			this.btn_zalaczStrefe.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel12
			// 
			this.tableLayoutPanel12.ColumnCount = 1;
			this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel12.Controls.Add(this.rb_strefaZaloczona, 0, 0);
			this.tableLayoutPanel12.Controls.Add(this.rb_oczekiwanieNaZawory, 0, 1);
			this.tableLayoutPanel12.Controls.Add(this.rb_przepelnienieZjazduZaladunek, 0, 2);
			this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 88);
			this.tableLayoutPanel12.Name = "tableLayoutPanel12";
			this.tableLayoutPanel12.RowCount = 3;
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.47619F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.52381F));
			this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
			this.tableLayoutPanel12.Size = new System.Drawing.Size(182, 186);
			this.tableLayoutPanel12.TabIndex = 3;
			// 
			// rb_strefaZaloczona
			// 
			this.rb_strefaZaloczona.AutoSize = true;
			this.rb_strefaZaloczona.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.rb_strefaZaloczona.ForeColor = System.Drawing.SystemColors.ControlText;
			this.rb_strefaZaloczona.Location = new System.Drawing.Point(3, 3);
			this.rb_strefaZaloczona.Name = "rb_strefaZaloczona";
			this.rb_strefaZaloczona.Size = new System.Drawing.Size(106, 17);
			this.rb_strefaZaloczona.TabIndex = 2;
			this.rb_strefaZaloczona.TabStop = true;
			this.rb_strefaZaloczona.Text = "Strefa załaczona";
			this.rb_strefaZaloczona.UseVisualStyleBackColor = true;
			// 
			// rb_oczekiwanieNaZawory
			// 
			this.rb_oczekiwanieNaZawory.AutoSize = true;
			this.rb_oczekiwanieNaZawory.Location = new System.Drawing.Point(3, 65);
			this.rb_oczekiwanieNaZawory.Name = "rb_oczekiwanieNaZawory";
			this.rb_oczekiwanieNaZawory.Size = new System.Drawing.Size(137, 17);
			this.rb_oczekiwanieNaZawory.TabIndex = 3;
			this.rb_oczekiwanieNaZawory.TabStop = true;
			this.rb_oczekiwanieNaZawory.Text = "Oczekiwnaie na zawory";
			this.rb_oczekiwanieNaZawory.UseVisualStyleBackColor = true;
			// 
			// rb_przepelnienieZjazduZaladunek
			// 
			this.rb_przepelnienieZjazduZaladunek.AutoSize = true;
			this.rb_przepelnienieZjazduZaladunek.Location = new System.Drawing.Point(3, 126);
			this.rb_przepelnienieZjazduZaladunek.Name = "rb_przepelnienieZjazduZaladunek";
			this.rb_przepelnienieZjazduZaladunek.Size = new System.Drawing.Size(149, 17);
			this.rb_przepelnienieZjazduZaladunek.TabIndex = 4;
			this.rb_przepelnienieZjazduZaladunek.TabStop = true;
			this.rb_przepelnienieZjazduZaladunek.Text = "Przepełnienie zjazdu palet";
			this.rb_przepelnienieZjazduZaladunek.UseVisualStyleBackColor = true;
			// 
			// btn_resetStrefy
			// 
			this.btn_resetStrefy.Location = new System.Drawing.Point(228, 20);
			this.btn_resetStrefy.Margin = new System.Windows.Forms.Padding(40, 20, 20, 20);
			this.btn_resetStrefy.Name = "btn_resetStrefy";
			this.btn_resetStrefy.Size = new System.Drawing.Size(90, 45);
			this.btn_resetStrefy.TabIndex = 1;
			this.btn_resetStrefy.Text = "RESET STREFY";
			this.btn_resetStrefy.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.tableLayoutPanel13);
			this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox5.Location = new System.Drawing.Point(392, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(383, 296);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "STREFA ROZŁADUNKU";
			// 
			// tableLayoutPanel13
			// 
			this.tableLayoutPanel13.ColumnCount = 2;
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel13.Controls.Add(this.btn_resetStrefyRozlad, 1, 0);
			this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel14, 0, 1);
			this.tableLayoutPanel13.Controls.Add(this.btn_zalaczStrefeRozlad, 0, 0);
			this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel13.Name = "tableLayoutPanel13";
			this.tableLayoutPanel13.RowCount = 2;
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.04693F));
			this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.95307F));
			this.tableLayoutPanel13.Size = new System.Drawing.Size(377, 277);
			this.tableLayoutPanel13.TabIndex = 0;
			// 
			// btn_resetStrefyRozlad
			// 
			this.btn_resetStrefyRozlad.Location = new System.Drawing.Point(228, 20);
			this.btn_resetStrefyRozlad.Margin = new System.Windows.Forms.Padding(40, 20, 20, 20);
			this.btn_resetStrefyRozlad.Name = "btn_resetStrefyRozlad";
			this.btn_resetStrefyRozlad.Size = new System.Drawing.Size(84, 45);
			this.btn_resetStrefyRozlad.TabIndex = 1;
			this.btn_resetStrefyRozlad.Text = "RESET STREFY";
			this.btn_resetStrefyRozlad.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel14
			// 
			this.tableLayoutPanel14.ColumnCount = 1;
			this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel14.Controls.Add(this.rb_strefaZalaczonaRozladunek, 0, 0);
			this.tableLayoutPanel14.Controls.Add(this.rb_przepelnienieRozladunku, 0, 1);
			this.tableLayoutPanel14.Controls.Add(this.rb_przepelnieniZjazduPalletRozlad, 0, 2);
			this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 89);
			this.tableLayoutPanel14.Name = "tableLayoutPanel14";
			this.tableLayoutPanel14.RowCount = 3;
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.76033F));
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.23967F));
			this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel14.Size = new System.Drawing.Size(182, 185);
			this.tableLayoutPanel14.TabIndex = 2;
			// 
			// rb_strefaZalaczonaRozladunek
			// 
			this.rb_strefaZalaczonaRozladunek.AutoSize = true;
			this.rb_strefaZalaczonaRozladunek.Location = new System.Drawing.Point(3, 3);
			this.rb_strefaZalaczonaRozladunek.Name = "rb_strefaZalaczonaRozladunek";
			this.rb_strefaZalaczonaRozladunek.Size = new System.Drawing.Size(106, 17);
			this.rb_strefaZalaczonaRozladunek.TabIndex = 0;
			this.rb_strefaZalaczonaRozladunek.TabStop = true;
			this.rb_strefaZalaczonaRozladunek.Text = "Strefa załaczona";
			this.rb_strefaZalaczonaRozladunek.UseVisualStyleBackColor = true;
			// 
			// rb_przepelnienieRozladunku
			// 
			this.rb_przepelnienieRozladunku.AutoSize = true;
			this.rb_przepelnienieRozladunku.Location = new System.Drawing.Point(3, 62);
			this.rb_przepelnienieRozladunku.Name = "rb_przepelnienieRozladunku";
			this.rb_przepelnienieRozladunku.Size = new System.Drawing.Size(143, 17);
			this.rb_przepelnienieRozladunku.TabIndex = 1;
			this.rb_przepelnienieRozladunku.TabStop = true;
			this.rb_przepelnienieRozladunku.Text = "Przepelnienie rozladunku";
			this.rb_przepelnienieRozladunku.UseVisualStyleBackColor = true;
			// 
			// rb_przepelnieniZjazduPalletRozlad
			// 
			this.rb_przepelnieniZjazduPalletRozlad.AutoSize = true;
			this.rb_przepelnieniZjazduPalletRozlad.Location = new System.Drawing.Point(3, 124);
			this.rb_przepelnieniZjazduPalletRozlad.Name = "rb_przepelnieniZjazduPalletRozlad";
			this.rb_przepelnieniZjazduPalletRozlad.Size = new System.Drawing.Size(147, 17);
			this.rb_przepelnieniZjazduPalletRozlad.TabIndex = 2;
			this.rb_przepelnieniZjazduPalletRozlad.TabStop = true;
			this.rb_przepelnieniZjazduPalletRozlad.Text = "Przepelnienie zjazdu palet";
			this.rb_przepelnieniZjazduPalletRozlad.UseVisualStyleBackColor = true;
			// 
			// btn_zalaczStrefeRozlad
			// 
			this.btn_zalaczStrefeRozlad.Location = new System.Drawing.Point(40, 20);
			this.btn_zalaczStrefeRozlad.Margin = new System.Windows.Forms.Padding(40, 20, 20, 20);
			this.btn_zalaczStrefeRozlad.Name = "btn_zalaczStrefeRozlad";
			this.btn_zalaczStrefeRozlad.Size = new System.Drawing.Size(82, 45);
			this.btn_zalaczStrefeRozlad.TabIndex = 0;
			this.btn_zalaczStrefeRozlad.Text = "ZALACZ STREFE";
			this.btn_zalaczStrefeRozlad.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.btn_SendFrame, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.txbFrame, 0, 2);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(932, 317);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 3;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.52632F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.47368F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(148, 134);
			this.tableLayoutPanel4.TabIndex = 5;
			// 
			// btn_SendFrame
			// 
			this.btn_SendFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_SendFrame.Location = new System.Drawing.Point(3, 49);
			this.btn_SendFrame.Name = "btn_SendFrame";
			this.btn_SendFrame.Size = new System.Drawing.Size(142, 24);
			this.btn_SendFrame.TabIndex = 2;
			this.btn_SendFrame.Text = "Send Frame";
			this.btn_SendFrame.UseVisualStyleBackColor = true;
			this.btn_SendFrame.Click += new System.EventHandler(this.button1_Click);
			// 
			// txbFrame
			// 
			this.txbFrame.Dock = System.Windows.Forms.DockStyle.Top;
			this.txbFrame.Location = new System.Drawing.Point(3, 79);
			this.txbFrame.Name = "txbFrame";
			this.txbFrame.Size = new System.Drawing.Size(142, 20);
			this.txbFrame.TabIndex = 3;
			// 
			// gb_commands
			// 
			this.gb_commands.Controls.Add(this.tableLayoutPanel5);
			this.gb_commands.Location = new System.Drawing.Point(3, 317);
			this.gb_commands.Name = "gb_commands";
			this.gb_commands.Size = new System.Drawing.Size(133, 267);
			this.gb_commands.TabIndex = 6;
			this.gb_commands.TabStop = false;
			this.gb_commands.Text = "COMMANDS";
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.btn_autoMode, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.btn_manualMode, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.btn_sycleStart, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.btn_cycleStop, 0, 4);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 5;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.06383F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.93617F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(127, 248);
			this.tableLayoutPanel5.TabIndex = 0;
			// 
			// btn_autoMode
			// 
			this.btn_autoMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_autoMode.Location = new System.Drawing.Point(3, 3);
			this.btn_autoMode.Name = "btn_autoMode";
			this.btn_autoMode.Size = new System.Drawing.Size(121, 42);
			this.btn_autoMode.TabIndex = 0;
			this.btn_autoMode.Text = "AUTO MODE";
			this.btn_autoMode.UseVisualStyleBackColor = true;
			// 
			// btn_manualMode
			// 
			this.btn_manualMode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_manualMode.Location = new System.Drawing.Point(3, 51);
			this.btn_manualMode.Name = "btn_manualMode";
			this.btn_manualMode.Size = new System.Drawing.Size(121, 40);
			this.btn_manualMode.TabIndex = 1;
			this.btn_manualMode.Text = "MANUAL MODE";
			this.btn_manualMode.UseVisualStyleBackColor = true;
			// 
			// btn_sycleStart
			// 
			this.btn_sycleStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_sycleStart.Location = new System.Drawing.Point(3, 172);
			this.btn_sycleStart.Name = "btn_sycleStart";
			this.btn_sycleStart.Size = new System.Drawing.Size(121, 38);
			this.btn_sycleStart.TabIndex = 2;
			this.btn_sycleStart.Text = "CYCLES START";
			this.btn_sycleStart.UseVisualStyleBackColor = true;
			// 
			// btn_cycleStop
			// 
			this.btn_cycleStop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_cycleStop.Location = new System.Drawing.Point(3, 216);
			this.btn_cycleStop.Name = "btn_cycleStop";
			this.btn_cycleStop.Size = new System.Drawing.Size(121, 29);
			this.btn_cycleStop.TabIndex = 3;
			this.btn_cycleStop.Text = "CYCLE STOP";
			this.btn_cycleStop.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(142, 317);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.43071F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.56929F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(784, 267);
			this.tableLayoutPanel6.TabIndex = 7;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.tableLayoutPanel1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.Location = new System.Drawing.Point(3, 151);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(778, 113);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Alarmy";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.85095F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.14905F));
			this.tableLayoutPanel1.Controls.Add(this.btn_AlarmsReset, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.rtb_AlarmField, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(772, 94);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btn_AlarmsReset
			// 
			this.btn_AlarmsReset.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_AlarmsReset.Location = new System.Drawing.Point(3, 3);
			this.btn_AlarmsReset.Name = "btn_AlarmsReset";
			this.btn_AlarmsReset.Size = new System.Drawing.Size(131, 88);
			this.btn_AlarmsReset.TabIndex = 0;
			this.btn_AlarmsReset.Text = "Alarm RESET";
			this.btn_AlarmsReset.UseVisualStyleBackColor = true;
			// 
			// rtb_AlarmField
			// 
			this.rtb_AlarmField.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtb_AlarmField.Location = new System.Drawing.Point(140, 3);
			this.rtb_AlarmField.Name = "rtb_AlarmField";
			this.rtb_AlarmField.ReadOnly = true;
			this.rtb_AlarmField.Size = new System.Drawing.Size(629, 88);
			this.rtb_AlarmField.TabIndex = 1;
			this.rtb_AlarmField.Text = "";
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 4;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.74074F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25926F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 148F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 369F));
			this.tableLayoutPanel8.Controls.Add(this.rb_robotAuto, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.rb_raobotManual, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.rb_robotStart, 0, 2);
			this.tableLayoutPanel8.Controls.Add(this.rb_robotAlarm, 1, 0);
			this.tableLayoutPanel8.Controls.Add(this.rb_bypass, 1, 1);
			this.tableLayoutPanel8.Controls.Add(this.rb_autoExt, 1, 2);
			this.tableLayoutPanel8.Controls.Add(this.rb_emergenctStop, 2, 2);
			this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 3, 1);
			this.tableLayoutPanel8.Controls.Add(this.groupBox3, 3, 2);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 3;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.0566F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.9434F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(778, 142);
			this.tableLayoutPanel8.TabIndex = 4;
			// 
			// rb_robotAuto
			// 
			this.rb_robotAuto.AutoSize = true;
			this.rb_robotAuto.Location = new System.Drawing.Point(3, 3);
			this.rb_robotAuto.Name = "rb_robotAuto";
			this.rb_robotAuto.Size = new System.Drawing.Size(93, 17);
			this.rb_robotAuto.TabIndex = 0;
			this.rb_robotAuto.TabStop = true;
			this.rb_robotAuto.Text = "Robot (AUTO)";
			this.rb_robotAuto.UseVisualStyleBackColor = true;
			// 
			// rb_raobotManual
			// 
			this.rb_raobotManual.AutoSize = true;
			this.rb_raobotManual.Location = new System.Drawing.Point(3, 44);
			this.rb_raobotManual.Name = "rb_raobotManual";
			this.rb_raobotManual.Size = new System.Drawing.Size(96, 17);
			this.rb_raobotManual.TabIndex = 1;
			this.rb_raobotManual.TabStop = true;
			this.rb_raobotManual.Text = "ROBOT (MAN)";
			this.rb_raobotManual.UseVisualStyleBackColor = true;
			// 
			// rb_robotStart
			// 
			this.rb_robotStart.AutoSize = true;
			this.rb_robotStart.Location = new System.Drawing.Point(3, 87);
			this.rb_robotStart.Name = "rb_robotStart";
			this.rb_robotStart.Size = new System.Drawing.Size(79, 17);
			this.rb_robotStart.TabIndex = 2;
			this.rb_robotStart.TabStop = true;
			this.rb_robotStart.Text = "Robot Start";
			this.rb_robotStart.UseVisualStyleBackColor = true;
			// 
			// rb_robotAlarm
			// 
			this.rb_robotAlarm.AutoSize = true;
			this.rb_robotAlarm.Location = new System.Drawing.Point(135, 3);
			this.rb_robotAlarm.Name = "rb_robotAlarm";
			this.rb_robotAlarm.Size = new System.Drawing.Size(83, 17);
			this.rb_robotAlarm.TabIndex = 3;
			this.rb_robotAlarm.TabStop = true;
			this.rb_robotAlarm.Text = "Robot Alarm";
			this.rb_robotAlarm.UseVisualStyleBackColor = true;
			// 
			// rb_bypass
			// 
			this.rb_bypass.AutoSize = true;
			this.rb_bypass.Location = new System.Drawing.Point(135, 44);
			this.rb_bypass.Name = "rb_bypass";
			this.rb_bypass.Size = new System.Drawing.Size(59, 17);
			this.rb_bypass.TabIndex = 4;
			this.rb_bypass.TabStop = true;
			this.rb_bypass.Text = "Bypass";
			this.rb_bypass.UseVisualStyleBackColor = true;
			// 
			// rb_autoExt
			// 
			this.rb_autoExt.AutoSize = true;
			this.rb_autoExt.Location = new System.Drawing.Point(135, 87);
			this.rb_autoExt.Name = "rb_autoExt";
			this.rb_autoExt.Size = new System.Drawing.Size(109, 17);
			this.rb_autoExt.TabIndex = 5;
			this.rb_autoExt.TabStop = true;
			this.rb_autoExt.Text = "AUTO-EXTHOST";
			this.rb_autoExt.UseVisualStyleBackColor = true;
			// 
			// rb_emergenctStop
			// 
			this.rb_emergenctStop.AutoSize = true;
			this.rb_emergenctStop.Location = new System.Drawing.Point(263, 87);
			this.rb_emergenctStop.Name = "rb_emergenctStop";
			this.rb_emergenctStop.Size = new System.Drawing.Size(125, 17);
			this.rb_emergenctStop.TabIndex = 6;
			this.rb_emergenctStop.TabStop = true;
			this.rb_emergenctStop.Text = "EMERGENCY STOP";
			this.rb_emergenctStop.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.txb_robotStatus, 1, 0);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(411, 44);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 1;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(364, 37);
			this.tableLayoutPanel9.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Status programu robota";
			// 
			// txb_robotStatus
			// 
			this.txb_robotStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txb_robotStatus.Location = new System.Drawing.Point(185, 3);
			this.txb_robotStatus.Name = "txb_robotStatus";
			this.txb_robotStatus.Size = new System.Drawing.Size(176, 20);
			this.txb_robotStatus.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tableLayoutPanel10);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox3.Location = new System.Drawing.Point(411, 87);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(364, 52);
			this.groupBox3.TabIndex = 8;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Prędkośćrobota";
			// 
			// tableLayoutPanel10
			// 
			this.tableLayoutPanel10.ColumnCount = 3;
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.13462F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.86538F));
			this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
			this.tableLayoutPanel10.Controls.Add(this.textBox1, 1, 0);
			this.tableLayoutPanel10.Controls.Add(this.btn_speedUp, 0, 0);
			this.tableLayoutPanel10.Controls.Add(this.btn_speedDown, 2, 0);
			this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel10.Name = "tableLayoutPanel10";
			this.tableLayoutPanel10.RowCount = 1;
			this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel10.Size = new System.Drawing.Size(358, 33);
			this.tableLayoutPanel10.TabIndex = 8;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBox1.Location = new System.Drawing.Point(124, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(78, 24);
			this.textBox1.TabIndex = 0;
			// 
			// btn_speedUp
			// 
			this.btn_speedUp.Dock = System.Windows.Forms.DockStyle.Right;
			this.btn_speedUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_speedUp.Location = new System.Drawing.Point(43, 3);
			this.btn_speedUp.Name = "btn_speedUp";
			this.btn_speedUp.Size = new System.Drawing.Size(75, 27);
			this.btn_speedUp.TabIndex = 1;
			this.btn_speedUp.Text = "+";
			this.btn_speedUp.UseVisualStyleBackColor = true;
			this.btn_speedUp.Click += new System.EventHandler(this.btn_speedUp_Click);
			// 
			// btn_speedDown
			// 
			this.btn_speedDown.Dock = System.Windows.Forms.DockStyle.Left;
			this.btn_speedDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_speedDown.Location = new System.Drawing.Point(208, 3);
			this.btn_speedDown.Name = "btn_speedDown";
			this.btn_speedDown.Size = new System.Drawing.Size(75, 27);
			this.btn_speedDown.TabIndex = 2;
			this.btn_speedDown.Text = "-";
			this.btn_speedDown.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tableLayoutPanel7);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(932, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(258, 308);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "WYBÓR PRODUKTU";
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.Controls.Add(this.btn_wybierzSchemat, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.btn_aktywujSchemat, 1, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(252, 62);
			this.tableLayoutPanel7.TabIndex = 0;
			// 
			// btn_wybierzSchemat
			// 
			this.btn_wybierzSchemat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_wybierzSchemat.Location = new System.Drawing.Point(3, 3);
			this.btn_wybierzSchemat.Name = "btn_wybierzSchemat";
			this.btn_wybierzSchemat.Size = new System.Drawing.Size(120, 56);
			this.btn_wybierzSchemat.TabIndex = 0;
			this.btn_wybierzSchemat.Text = "Wybierz schemat";
			this.btn_wybierzSchemat.UseVisualStyleBackColor = true;
			// 
			// btn_aktywujSchemat
			// 
			this.btn_aktywujSchemat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btn_aktywujSchemat.Location = new System.Drawing.Point(129, 3);
			this.btn_aktywujSchemat.Name = "btn_aktywujSchemat";
			this.btn_aktywujSchemat.Size = new System.Drawing.Size(120, 56);
			this.btn_aktywujSchemat.TabIndex = 1;
			this.btn_aktywujSchemat.Text = "Aktywuj Schemat";
			this.btn_aktywujSchemat.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1193, 608);
			this.Controls.Add(this.tlp_Main);
			this.Name = "Form1";
			this.Text = "Paletyzacja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tlp_Main.ResumeLayout(false);
			this.gb_robot.ResumeLayout(false);
			this.tlp_Robot.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tableLayoutPanel11.ResumeLayout(false);
			this.tableLayoutPanel12.ResumeLayout(false);
			this.tableLayoutPanel12.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.tableLayoutPanel13.ResumeLayout(false);
			this.tableLayoutPanel14.ResumeLayout(false);
			this.tableLayoutPanel14.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.gb_commands.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel9.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.tableLayoutPanel10.ResumeLayout(false);
			this.tableLayoutPanel10.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Main;
        private System.Windows.Forms.GroupBox gb_robot;
        private System.Windows.Forms.TableLayoutPanel tlp_Robot;
        private System.Windows.Forms.Button btn_ServoOn;
        private System.Windows.Forms.Button btn_ServoOff;
        private System.Windows.Forms.Button btn_SendFrame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_AlarmsReset;
        private System.Windows.Forms.RichTextBox rtb_AlarmField;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox txbFrame;
		private System.Windows.Forms.Button btn_startProgram;
		private System.Windows.Forms.Button btn_stopProgram;
		private System.Windows.Forms.Button btn_resetProgram;
		private System.Windows.Forms.GroupBox gb_commands;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Button btn_autoMode;
		private System.Windows.Forms.Button btn_manualMode;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private System.Windows.Forms.Button btn_sycleStart;
		private System.Windows.Forms.Button btn_cycleStop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.RadioButton rb_robotAuto;
		private System.Windows.Forms.RadioButton rb_raobotManual;
		private System.Windows.Forms.RadioButton rb_robotStart;
		private System.Windows.Forms.RadioButton rb_robotAlarm;
		private System.Windows.Forms.RadioButton rb_bypass;
		private System.Windows.Forms.RadioButton rb_autoExt;
		private System.Windows.Forms.RadioButton rb_emergenctStop;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_robotStatus;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_speedUp;
		private System.Windows.Forms.Button btn_speedDown;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
		private System.Windows.Forms.Button btn_zalaczStrefe;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
		private System.Windows.Forms.RadioButton rb_strefaZaloczona;
		private System.Windows.Forms.RadioButton rb_oczekiwanieNaZawory;
		private System.Windows.Forms.RadioButton rb_przepelnienieZjazduZaladunek;
		private System.Windows.Forms.Button btn_resetStrefy;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button btn_wybierzSchemat;
		private System.Windows.Forms.Button btn_aktywujSchemat;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
		private System.Windows.Forms.Button btn_resetStrefyRozlad;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
		private System.Windows.Forms.RadioButton rb_strefaZalaczonaRozladunek;
		private System.Windows.Forms.RadioButton rb_przepelnienieRozladunku;
		private System.Windows.Forms.RadioButton rb_przepelnieniZjazduPalletRozlad;
		private System.Windows.Forms.Button btn_zalaczStrefeRozlad;
	}
}

