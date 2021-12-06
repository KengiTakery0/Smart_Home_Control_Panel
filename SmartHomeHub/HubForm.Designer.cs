
namespace SmartHomeHub
{
    partial class HubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HubForm));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Namelabel = new System.Windows.Forms.Label();
            this.hollLight = new System.Windows.Forms.Label();
            this.mainRoomLight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kitchenLight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RoombaOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.DishwasherOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.CondicionerOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.TeapotOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.tgBathLightONOFF = new SmartHomeHub.Controls.ToggleButtons();
            this.tgKitchenLightONOFF = new SmartHomeHub.Controls.ToggleButtons();
            this.mainRoomLightOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.tbHallLightOnOff = new SmartHomeHub.Controls.ToggleButtons();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.Namelabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1221, 53);
            this.MainPanel.TabIndex = 4;
            // 
            // Namelabel
            // 
            this.Namelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Namelabel.Font = new System.Drawing.Font("Times New Roman", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Namelabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Namelabel.Location = new System.Drawing.Point(0, 0);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(1221, 53);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Панель Управления";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hollLight
            // 
            this.hollLight.AutoSize = true;
            this.hollLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.hollLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hollLight.ForeColor = System.Drawing.Color.White;
            this.hollLight.Location = new System.Drawing.Point(5, 235);
            this.hollLight.Name = "hollLight";
            this.hollLight.Size = new System.Drawing.Size(163, 24);
            this.hollLight.TabIndex = 6;
            this.hollLight.Text = "Свет в коридоре";
            // 
            // mainRoomLight
            // 
            this.mainRoomLight.AutoSize = true;
            this.mainRoomLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainRoomLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainRoomLight.ForeColor = System.Drawing.Color.White;
            this.mainRoomLight.Location = new System.Drawing.Point(5, 288);
            this.mainRoomLight.Name = "mainRoomLight";
            this.mainRoomLight.Size = new System.Drawing.Size(229, 24);
            this.mainRoomLight.TabIndex = 8;
            this.mainRoomLight.Text = "Свет в главной комнате";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(376, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Управление освещением\r\n";
            // 
            // kitchenLight
            // 
            this.kitchenLight.AutoSize = true;
            this.kitchenLight.BackColor = System.Drawing.Color.RoyalBlue;
            this.kitchenLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kitchenLight.ForeColor = System.Drawing.Color.White;
            this.kitchenLight.Location = new System.Drawing.Point(5, 348);
            this.kitchenLight.Name = "kitchenLight";
            this.kitchenLight.Size = new System.Drawing.Size(136, 24);
            this.kitchenLight.TabIndex = 11;
            this.kitchenLight.Text = "Свет на кухне";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Выкл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ручное Управление\r\n";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выкл\r\n\r\n\r\n";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(194, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выкл";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(194, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Выкл";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "Свет в ванной";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(410, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(361, 36);
            this.label8.TabIndex = 19;
            this.label8.Text = "Управление приборами";
            // 
            // label90
            // 
            this.label90.BackColor = System.Drawing.Color.RoyalBlue;
            this.label90.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label90.ForeColor = System.Drawing.Color.White;
            this.label90.Location = new System.Drawing.Point(601, 394);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(54, 32);
            this.label90.TabIndex = 31;
            this.label90.Text = "Выкл";
            this.label90.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(431, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Робот пылесос\r\n";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(601, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 24);
            this.label11.TabIndex = 28;
            this.label11.Text = "Выкл";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.RoyalBlue;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(601, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Выкл\r\n\r\n\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.RoyalBlue;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(601, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "Выкл";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.RoyalBlue;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(431, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(135, 24);
            this.label14.TabIndex = 25;
            this.label14.Text = "Посудомойка \r\n";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.RoyalBlue;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(431, 288);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 24);
            this.label15.TabIndex = 23;
            this.label15.Text = "Кондиционер";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.RoyalBlue;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(431, 235);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 24);
            this.label16.TabIndex = 21;
            this.label16.Text = "Чайник\r\n";
            // 
            // RoombaOnOff
            // 
            this.RoombaOnOff.AutoSize = true;
            this.RoombaOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.RoombaOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RoombaOnOff.Location = new System.Drawing.Point(662, 394);
            this.RoombaOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.RoombaOnOff.Name = "RoombaOnOff";
            this.RoombaOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.RoombaOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.RoombaOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.RoombaOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.RoombaOnOff.Size = new System.Drawing.Size(45, 22);
            this.RoombaOnOff.TabIndex = 29;
            this.RoombaOnOff.Text = "\r\n";
            this.RoombaOnOff.UseVisualStyleBackColor = false;
            // 
            // DishwasherOnOff
            // 
            this.DishwasherOnOff.AutoSize = true;
            this.DishwasherOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.DishwasherOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DishwasherOnOff.Location = new System.Drawing.Point(662, 348);
            this.DishwasherOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.DishwasherOnOff.Name = "DishwasherOnOff";
            this.DishwasherOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.DishwasherOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.DishwasherOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.DishwasherOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.DishwasherOnOff.Size = new System.Drawing.Size(45, 22);
            this.DishwasherOnOff.TabIndex = 24;
            this.DishwasherOnOff.Text = "\r\n";
            this.DishwasherOnOff.UseVisualStyleBackColor = false;
            this.DishwasherOnOff.CheckedChanged += new System.EventHandler(this.DishwasherOnOff_CheckedChanged);
            // 
            // CondicionerOnOff
            // 
            this.CondicionerOnOff.AutoSize = true;
            this.CondicionerOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.CondicionerOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CondicionerOnOff.Location = new System.Drawing.Point(662, 288);
            this.CondicionerOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.CondicionerOnOff.Name = "CondicionerOnOff";
            this.CondicionerOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.CondicionerOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.CondicionerOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.CondicionerOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.CondicionerOnOff.Size = new System.Drawing.Size(45, 22);
            this.CondicionerOnOff.TabIndex = 22;
            this.CondicionerOnOff.Text = "\r\n";
            this.CondicionerOnOff.UseVisualStyleBackColor = false;
            this.CondicionerOnOff.CheckedChanged += new System.EventHandler(this.CondicionerOnOff_CheckedChanged);
            // 
            // TeapotOnOff
            // 
            this.TeapotOnOff.AutoSize = true;
            this.TeapotOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.TeapotOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeapotOnOff.Location = new System.Drawing.Point(662, 231);
            this.TeapotOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.TeapotOnOff.Name = "TeapotOnOff";
            this.TeapotOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.TeapotOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TeapotOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.TeapotOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.TeapotOnOff.Size = new System.Drawing.Size(45, 22);
            this.TeapotOnOff.TabIndex = 20;
            this.TeapotOnOff.Text = "\r\n";
            this.TeapotOnOff.UseVisualStyleBackColor = false;
            this.TeapotOnOff.CheckedChanged += new System.EventHandler(this.TeapotOnOff_CheckedChanged);
            // 
            // tgBathLightONOFF
            // 
            this.tgBathLightONOFF.AutoSize = true;
            this.tgBathLightONOFF.BackColor = System.Drawing.Color.RoyalBlue;
            this.tgBathLightONOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgBathLightONOFF.Location = new System.Drawing.Point(244, 394);
            this.tgBathLightONOFF.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgBathLightONOFF.Name = "tgBathLightONOFF";
            this.tgBathLightONOFF.OffBackColor = System.Drawing.Color.DimGray;
            this.tgBathLightONOFF.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBathLightONOFF.OnBackColor = System.Drawing.Color.BlueViolet;
            this.tgBathLightONOFF.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgBathLightONOFF.Size = new System.Drawing.Size(45, 22);
            this.tgBathLightONOFF.TabIndex = 16;
            this.tgBathLightONOFF.Text = "\r\n";
            this.tgBathLightONOFF.UseVisualStyleBackColor = false;
            this.tgBathLightONOFF.CheckedChanged += new System.EventHandler(this.tgBathLightONOFF_CheckedChanged);
            // 
            // tgKitchenLightONOFF
            // 
            this.tgKitchenLightONOFF.AutoSize = true;
            this.tgKitchenLightONOFF.BackColor = System.Drawing.Color.RoyalBlue;
            this.tgKitchenLightONOFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tgKitchenLightONOFF.Location = new System.Drawing.Point(244, 348);
            this.tgKitchenLightONOFF.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgKitchenLightONOFF.Name = "tgKitchenLightONOFF";
            this.tgKitchenLightONOFF.OffBackColor = System.Drawing.Color.DimGray;
            this.tgKitchenLightONOFF.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgKitchenLightONOFF.OnBackColor = System.Drawing.Color.BlueViolet;
            this.tgKitchenLightONOFF.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgKitchenLightONOFF.Size = new System.Drawing.Size(45, 22);
            this.tgKitchenLightONOFF.TabIndex = 10;
            this.tgKitchenLightONOFF.Text = "\r\n";
            this.tgKitchenLightONOFF.UseVisualStyleBackColor = false;
            this.tgKitchenLightONOFF.CheckedChanged += new System.EventHandler(this.tgKitchenLightONOFF_CheckedChanged);
            // 
            // mainRoomLightOnOff
            // 
            this.mainRoomLightOnOff.AutoSize = true;
            this.mainRoomLightOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.mainRoomLightOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainRoomLightOnOff.Location = new System.Drawing.Point(266, 290);
            this.mainRoomLightOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.mainRoomLightOnOff.Name = "mainRoomLightOnOff";
            this.mainRoomLightOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.mainRoomLightOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.mainRoomLightOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.mainRoomLightOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.mainRoomLightOnOff.Size = new System.Drawing.Size(45, 22);
            this.mainRoomLightOnOff.TabIndex = 7;
            this.mainRoomLightOnOff.Text = "\r\n";
            this.mainRoomLightOnOff.UseVisualStyleBackColor = false;
            this.mainRoomLightOnOff.CheckedChanged += new System.EventHandler(this.mainRoomLightOnOff_CheckedChanged);
            // 
            // tbHallLightOnOff
            // 
            this.tbHallLightOnOff.AutoSize = true;
            this.tbHallLightOnOff.BackColor = System.Drawing.Color.RoyalBlue;
            this.tbHallLightOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbHallLightOnOff.Location = new System.Drawing.Point(244, 231);
            this.tbHallLightOnOff.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbHallLightOnOff.Name = "tbHallLightOnOff";
            this.tbHallLightOnOff.OffBackColor = System.Drawing.Color.DimGray;
            this.tbHallLightOnOff.OffToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbHallLightOnOff.OnBackColor = System.Drawing.Color.BlueViolet;
            this.tbHallLightOnOff.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbHallLightOnOff.Size = new System.Drawing.Size(45, 22);
            this.tbHallLightOnOff.TabIndex = 5;
            this.tbHallLightOnOff.Text = "\r\n";
            this.tbHallLightOnOff.UseVisualStyleBackColor = false;
            this.tbHallLightOnOff.CheckedChanged += new System.EventHandler(this.tbHallLightOnOff_CheckedChanged);
            // 
            // HubForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1221, 792);
            this.Controls.Add(this.label90);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RoombaOnOff);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.DishwasherOnOff);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CondicionerOnOff);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TeapotOnOff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tgBathLightONOFF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitchenLight);
            this.Controls.Add(this.tgKitchenLightONOFF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainRoomLight);
            this.Controls.Add(this.mainRoomLightOnOff);
            this.Controls.Add(this.hollLight);
            this.Controls.Add(this.tbHallLightOnOff);
            this.Controls.Add(this.MainPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HubForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HubForm";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HubForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label Namelabel;
        private Controls.ToggleButtons tbHallLightOnOff;
        private System.Windows.Forms.Label hollLight;
        private System.Windows.Forms.Label mainRoomLight;
        private Controls.ToggleButtons mainRoomLightOnOff;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kitchenLight;
        private Controls.ToggleButtons tgKitchenLightONOFF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Controls.ToggleButtons tgBathLightONOFF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label10;
        private Controls.ToggleButtons RoombaOnOff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Controls.ToggleButtons DishwasherOnOff;
        private System.Windows.Forms.Label label15;
        private Controls.ToggleButtons CondicionerOnOff;
        private System.Windows.Forms.Label label16;
        private Controls.ToggleButtons TeapotOnOff;
        private System.Windows.Forms.Timer timer1;
    }
}