namespace Robots.Sabueso
{
    partial class SabuesoPanel
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SabuesoPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudKd = new System.Windows.Forms.NumericUpDown();
            this.lKd = new System.Windows.Forms.Label();
            this.nudKp = new System.Windows.Forms.NumericUpDown();
            this.lKp = new System.Windows.Forms.Label();
            this.lIntervalHelp = new System.Windows.Forms.Label();
            this.nudInterval = new System.Windows.Forms.NumericUpDown();
            this.lInterval = new System.Windows.Forms.Label();
            this.bUpdate = new System.Windows.Forms.Button();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.lSpeed = new System.Windows.Forms.Label();
            this.bState = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbSabueso = new System.Windows.Forms.PictureBox();
            this.pSensor7 = new System.Windows.Forms.Panel();
            this.pSensor6 = new System.Windows.Forms.Panel();
            this.pSensor5 = new System.Windows.Forms.Panel();
            this.pSensor4 = new System.Windows.Forms.Panel();
            this.pSensor3 = new System.Windows.Forms.Panel();
            this.pSensor2 = new System.Windows.Forms.Panel();
            this.pSensor1 = new System.Windows.Forms.Panel();
            this.pSensor0 = new System.Windows.Forms.Panel();
            this.pbLeftForward = new System.Windows.Forms.PictureBox();
            this.pbRightForward = new System.Windows.Forms.PictureBox();
            this.pbRightBackward = new System.Windows.Forms.PictureBox();
            this.pbLeftBackward = new System.Windows.Forms.PictureBox();
            this.lRightSpeedForward = new System.Windows.Forms.Label();
            this.lLeftSpeedForward = new System.Windows.Forms.Label();
            this.lLeftSpeedBackward = new System.Windows.Forms.Label();
            this.lRightSpeedBackward = new System.Windows.Forms.Label();
            this.pbRightHidden = new System.Windows.Forms.PictureBox();
            this.pbLeftHidden = new System.Windows.Forms.PictureBox();
            this.lError = new System.Windows.Forms.Label();
            this.cbShowStatus = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSabueso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBackward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHidden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHidden)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudKd);
            this.groupBox1.Controls.Add(this.lKd);
            this.groupBox1.Controls.Add(this.nudKp);
            this.groupBox1.Controls.Add(this.lKp);
            this.groupBox1.Controls.Add(this.lIntervalHelp);
            this.groupBox1.Controls.Add(this.nudInterval);
            this.groupBox1.Controls.Add(this.lInterval);
            this.groupBox1.Controls.Add(this.bUpdate);
            this.groupBox1.Controls.Add(this.nudSpeed);
            this.groupBox1.Controls.Add(this.lSpeed);
            this.groupBox1.Location = new System.Drawing.Point(280, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // nudKd
            // 
            this.nudKd.Location = new System.Drawing.Point(90, 111);
            this.nudKd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKd.Name = "nudKd";
            this.nudKd.Size = new System.Drawing.Size(50, 21);
            this.nudKd.TabIndex = 11;
            this.toolTip1.SetToolTip(this.nudKd, "Kd variable for PD control\r\nMin: 0, Max: 1000");
            // 
            // lKd
            // 
            this.lKd.Location = new System.Drawing.Point(34, 112);
            this.lKd.Name = "lKd";
            this.lKd.Size = new System.Drawing.Size(50, 17);
            this.lKd.TabIndex = 10;
            this.lKd.Text = "Kd";
            this.lKd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudKp
            // 
            this.nudKp.Location = new System.Drawing.Point(90, 84);
            this.nudKp.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKp.Name = "nudKp";
            this.nudKp.Size = new System.Drawing.Size(50, 21);
            this.nudKp.TabIndex = 8;
            this.toolTip1.SetToolTip(this.nudKp, "Kp variable for PD control\r\nMin: 0, Max: 1000");
            // 
            // lKp
            // 
            this.lKp.Location = new System.Drawing.Point(34, 85);
            this.lKp.Name = "lKp";
            this.lKp.Size = new System.Drawing.Size(50, 17);
            this.lKp.TabIndex = 7;
            this.lKp.Text = "Kp";
            this.lKp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lIntervalHelp
            // 
            this.lIntervalHelp.AutoSize = true;
            this.lIntervalHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lIntervalHelp.Location = new System.Drawing.Point(146, 61);
            this.lIntervalHelp.Name = "lIntervalHelp";
            this.lIntervalHelp.Size = new System.Drawing.Size(22, 13);
            this.lIntervalHelp.TabIndex = 6;
            this.lIntervalHelp.Text = "mS";
            // 
            // nudInterval
            // 
            this.nudInterval.Location = new System.Drawing.Point(90, 57);
            this.nudInterval.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudInterval.Name = "nudInterval";
            this.nudInterval.Size = new System.Drawing.Size(50, 21);
            this.nudInterval.TabIndex = 5;
            this.toolTip1.SetToolTip(this.nudInterval, "Work process interval\r\nMin: 1, Max: 20");
            this.nudInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lInterval
            // 
            this.lInterval.Location = new System.Drawing.Point(34, 58);
            this.lInterval.Name = "lInterval";
            this.lInterval.Size = new System.Drawing.Size(50, 17);
            this.lInterval.TabIndex = 4;
            this.lInterval.Text = "Interval";
            this.lInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(63, 156);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 2;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // nudSpeed
            // 
            this.nudSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSpeed.Location = new System.Drawing.Point(90, 30);
            this.nudSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(50, 21);
            this.nudSpeed.TabIndex = 1;
            this.toolTip1.SetToolTip(this.nudSpeed, "Default speed\r\nMin: 200, Max: 1000");
            this.nudSpeed.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lSpeed
            // 
            this.lSpeed.Location = new System.Drawing.Point(34, 31);
            this.lSpeed.Name = "lSpeed";
            this.lSpeed.Size = new System.Drawing.Size(50, 17);
            this.lSpeed.TabIndex = 0;
            this.lSpeed.Text = "Speed";
            this.lSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bState
            // 
            this.bState.BackColor = System.Drawing.SystemColors.Control;
            this.bState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.bState.ForeColor = System.Drawing.Color.Green;
            this.bState.Location = new System.Drawing.Point(290, 221);
            this.bState.Name = "bState";
            this.bState.Size = new System.Drawing.Size(180, 58);
            this.bState.TabIndex = 12;
            this.bState.Text = "START";
            this.bState.UseVisualStyleBackColor = false;
            this.bState.Click += new System.EventHandler(this.bState_Click);
            // 
            // pbSabueso
            // 
            this.pbSabueso.BackColor = System.Drawing.SystemColors.Window;
            this.pbSabueso.Image = ((System.Drawing.Image)(resources.GetObject("pbSabueso.Image")));
            this.pbSabueso.Location = new System.Drawing.Point(10, 15);
            this.pbSabueso.Name = "pbSabueso";
            this.pbSabueso.Size = new System.Drawing.Size(240, 300);
            this.pbSabueso.TabIndex = 13;
            this.pbSabueso.TabStop = false;
            // 
            // pSensor7
            // 
            this.pSensor7.BackColor = System.Drawing.Color.Black;
            this.pSensor7.Location = new System.Drawing.Point(32, 58);
            this.pSensor7.Name = "pSensor7";
            this.pSensor7.Size = new System.Drawing.Size(15, 15);
            this.pSensor7.TabIndex = 14;
            // 
            // pSensor6
            // 
            this.pSensor6.BackColor = System.Drawing.Color.Black;
            this.pSensor6.Location = new System.Drawing.Point(59, 40);
            this.pSensor6.Name = "pSensor6";
            this.pSensor6.Size = new System.Drawing.Size(15, 15);
            this.pSensor6.TabIndex = 15;
            // 
            // pSensor5
            // 
            this.pSensor5.BackColor = System.Drawing.Color.Black;
            this.pSensor5.Location = new System.Drawing.Point(86, 26);
            this.pSensor5.Name = "pSensor5";
            this.pSensor5.Size = new System.Drawing.Size(15, 15);
            this.pSensor5.TabIndex = 16;
            // 
            // pSensor4
            // 
            this.pSensor4.BackColor = System.Drawing.Color.Black;
            this.pSensor4.Location = new System.Drawing.Point(111, 21);
            this.pSensor4.Name = "pSensor4";
            this.pSensor4.Size = new System.Drawing.Size(15, 15);
            this.pSensor4.TabIndex = 16;
            // 
            // pSensor3
            // 
            this.pSensor3.BackColor = System.Drawing.Color.Black;
            this.pSensor3.Location = new System.Drawing.Point(134, 21);
            this.pSensor3.Name = "pSensor3";
            this.pSensor3.Size = new System.Drawing.Size(15, 15);
            this.pSensor3.TabIndex = 16;
            // 
            // pSensor2
            // 
            this.pSensor2.BackColor = System.Drawing.Color.Black;
            this.pSensor2.Location = new System.Drawing.Point(159, 26);
            this.pSensor2.Name = "pSensor2";
            this.pSensor2.Size = new System.Drawing.Size(15, 15);
            this.pSensor2.TabIndex = 17;
            // 
            // pSensor1
            // 
            this.pSensor1.BackColor = System.Drawing.Color.Black;
            this.pSensor1.Location = new System.Drawing.Point(186, 40);
            this.pSensor1.Name = "pSensor1";
            this.pSensor1.Size = new System.Drawing.Size(15, 15);
            this.pSensor1.TabIndex = 17;
            // 
            // pSensor0
            // 
            this.pSensor0.BackColor = System.Drawing.Color.Black;
            this.pSensor0.Location = new System.Drawing.Point(213, 58);
            this.pSensor0.Name = "pSensor0";
            this.pSensor0.Size = new System.Drawing.Size(15, 15);
            this.pSensor0.TabIndex = 18;
            // 
            // pbLeftForward
            // 
            this.pbLeftForward.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftForward.Image")));
            this.pbLeftForward.Location = new System.Drawing.Point(17, 203);
            this.pbLeftForward.Name = "pbLeftForward";
            this.pbLeftForward.Size = new System.Drawing.Size(16, 50);
            this.pbLeftForward.TabIndex = 19;
            this.pbLeftForward.TabStop = false;
            this.pbLeftForward.Visible = false;
            // 
            // pbRightForward
            // 
            this.pbRightForward.Image = ((System.Drawing.Image)(resources.GetObject("pbRightForward.Image")));
            this.pbRightForward.Location = new System.Drawing.Point(227, 203);
            this.pbRightForward.Name = "pbRightForward";
            this.pbRightForward.Size = new System.Drawing.Size(16, 50);
            this.pbRightForward.TabIndex = 20;
            this.pbRightForward.TabStop = false;
            this.pbRightForward.Visible = false;
            // 
            // pbRightBackward
            // 
            this.pbRightBackward.Image = ((System.Drawing.Image)(resources.GetObject("pbRightBackward.Image")));
            this.pbRightBackward.Location = new System.Drawing.Point(227, 253);
            this.pbRightBackward.Name = "pbRightBackward";
            this.pbRightBackward.Size = new System.Drawing.Size(16, 50);
            this.pbRightBackward.TabIndex = 22;
            this.pbRightBackward.TabStop = false;
            this.pbRightBackward.Visible = false;
            // 
            // pbLeftBackward
            // 
            this.pbLeftBackward.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftBackward.Image")));
            this.pbLeftBackward.Location = new System.Drawing.Point(17, 253);
            this.pbLeftBackward.Name = "pbLeftBackward";
            this.pbLeftBackward.Size = new System.Drawing.Size(16, 50);
            this.pbLeftBackward.TabIndex = 21;
            this.pbLeftBackward.TabStop = false;
            this.pbLeftBackward.Visible = false;
            // 
            // lRightSpeedForward
            // 
            this.lRightSpeedForward.Location = new System.Drawing.Point(218, 177);
            this.lRightSpeedForward.Name = "lRightSpeedForward";
            this.lRightSpeedForward.Size = new System.Drawing.Size(35, 17);
            this.lRightSpeedForward.TabIndex = 12;
            this.lRightSpeedForward.Text = "800";
            this.lRightSpeedForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRightSpeedForward.Visible = false;
            // 
            // lLeftSpeedForward
            // 
            this.lLeftSpeedForward.Location = new System.Drawing.Point(8, 177);
            this.lLeftSpeedForward.Name = "lLeftSpeedForward";
            this.lLeftSpeedForward.Size = new System.Drawing.Size(35, 17);
            this.lLeftSpeedForward.TabIndex = 23;
            this.lLeftSpeedForward.Text = "800";
            this.lLeftSpeedForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lLeftSpeedForward.Visible = false;
            // 
            // lLeftSpeedBackward
            // 
            this.lLeftSpeedBackward.Location = new System.Drawing.Point(8, 311);
            this.lLeftSpeedBackward.Name = "lLeftSpeedBackward";
            this.lLeftSpeedBackward.Size = new System.Drawing.Size(35, 17);
            this.lLeftSpeedBackward.TabIndex = 25;
            this.lLeftSpeedBackward.Text = "800";
            this.lLeftSpeedBackward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lLeftSpeedBackward.Visible = false;
            // 
            // lRightSpeedBackward
            // 
            this.lRightSpeedBackward.Location = new System.Drawing.Point(218, 311);
            this.lRightSpeedBackward.Name = "lRightSpeedBackward";
            this.lRightSpeedBackward.Size = new System.Drawing.Size(35, 17);
            this.lRightSpeedBackward.TabIndex = 24;
            this.lRightSpeedBackward.Text = "800";
            this.lRightSpeedBackward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lRightSpeedBackward.Visible = false;
            // 
            // pbRightHidden
            // 
            this.pbRightHidden.Image = ((System.Drawing.Image)(resources.GetObject("pbRightHidden.Image")));
            this.pbRightHidden.Location = new System.Drawing.Point(227, 203);
            this.pbRightHidden.Name = "pbRightHidden";
            this.pbRightHidden.Size = new System.Drawing.Size(16, 50);
            this.pbRightHidden.TabIndex = 27;
            this.pbRightHidden.TabStop = false;
            this.pbRightHidden.Visible = false;
            // 
            // pbLeftHidden
            // 
            this.pbLeftHidden.Image = ((System.Drawing.Image)(resources.GetObject("pbLeftHidden.Image")));
            this.pbLeftHidden.Location = new System.Drawing.Point(17, 203);
            this.pbLeftHidden.Name = "pbLeftHidden";
            this.pbLeftHidden.Size = new System.Drawing.Size(16, 50);
            this.pbLeftHidden.TabIndex = 26;
            this.pbLeftHidden.TabStop = false;
            this.pbLeftHidden.Visible = false;
            // 
            // lError
            // 
            this.lError.BackColor = System.Drawing.Color.White;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lError.Location = new System.Drawing.Point(110, 81);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(40, 19);
            this.lError.TabIndex = 28;
            this.lError.Text = "0";
            this.lError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbShowStatus
            // 
            this.cbShowStatus.AutoSize = true;
            this.cbShowStatus.Location = new System.Drawing.Point(86, 319);
            this.cbShowStatus.Name = "cbShowStatus";
            this.cbShowStatus.Size = new System.Drawing.Size(94, 19);
            this.cbShowStatus.TabIndex = 29;
            this.cbShowStatus.Text = "Show Status";
            this.cbShowStatus.UseVisualStyleBackColor = true;
            this.cbShowStatus.CheckedChanged += new System.EventHandler(this.cbShowStatus_CheckedChanged);
            // 
            // SabuesoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pbLeftHidden);
            this.Controls.Add(this.pbRightHidden);
            this.Controls.Add(this.cbShowStatus);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.lLeftSpeedBackward);
            this.Controls.Add(this.lRightSpeedBackward);
            this.Controls.Add(this.lLeftSpeedForward);
            this.Controls.Add(this.lRightSpeedForward);
            this.Controls.Add(this.pbRightBackward);
            this.Controls.Add(this.pbLeftBackward);
            this.Controls.Add(this.pbRightForward);
            this.Controls.Add(this.pbLeftForward);
            this.Controls.Add(this.pSensor0);
            this.Controls.Add(this.pSensor1);
            this.Controls.Add(this.pSensor2);
            this.Controls.Add(this.pSensor3);
            this.Controls.Add(this.pSensor4);
            this.Controls.Add(this.pSensor5);
            this.Controls.Add(this.pSensor6);
            this.Controls.Add(this.pSensor7);
            this.Controls.Add(this.pbSabueso);
            this.Controls.Add(this.bState);
            this.Controls.Add(this.groupBox1);
            this.Name = "SabuesoPanel";
            this.Size = new System.Drawing.Size(491, 350);
            this.Load += new System.EventHandler(this.SabuesoPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSabueso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftBackward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRightHidden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeftHidden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudKd;
        private System.Windows.Forms.Label lKd;
        private System.Windows.Forms.NumericUpDown nudKp;
        private System.Windows.Forms.Label lKp;
        private System.Windows.Forms.Label lIntervalHelp;
        private System.Windows.Forms.NumericUpDown nudInterval;
        private System.Windows.Forms.Label lInterval;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.Label lSpeed;
        private System.Windows.Forms.Button bState;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pbSabueso;
        private System.Windows.Forms.Panel pSensor7;
        private System.Windows.Forms.Panel pSensor6;
        private System.Windows.Forms.Panel pSensor5;
        private System.Windows.Forms.Panel pSensor4;
        private System.Windows.Forms.Panel pSensor3;
        private System.Windows.Forms.Panel pSensor2;
        private System.Windows.Forms.Panel pSensor1;
        private System.Windows.Forms.Panel pSensor0;
        private System.Windows.Forms.PictureBox pbLeftForward;
        private System.Windows.Forms.PictureBox pbRightForward;
        private System.Windows.Forms.PictureBox pbRightBackward;
        private System.Windows.Forms.PictureBox pbLeftBackward;
        private System.Windows.Forms.Label lRightSpeedForward;
        private System.Windows.Forms.Label lLeftSpeedForward;
        private System.Windows.Forms.Label lLeftSpeedBackward;
        private System.Windows.Forms.Label lRightSpeedBackward;
        private System.Windows.Forms.PictureBox pbRightHidden;
        private System.Windows.Forms.PictureBox pbLeftHidden;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.CheckBox cbShowStatus;

    }
}
