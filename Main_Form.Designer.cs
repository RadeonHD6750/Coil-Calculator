namespace Coil_EML
{
    partial class Main_Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.System_Message_Box = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ek_TextBox = new System.Windows.Forms.TextBox();
            this.Ek_label = new System.Windows.Forms.Label();
            this.Projectile_Velocity_TextBox = new System.Windows.Forms.TextBox();
            this.muzzle_velocity_label = new System.Windows.Forms.Label();
            this.Projectile_Length_TextBox = new System.Windows.Forms.TextBox();
            this.projectile_length_label = new System.Windows.Forms.Label();
            this.Projectile_Mass_TextBox = new System.Windows.Forms.TextBox();
            this.projectile_mass_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Solenoid_Voltage_TextBox = new System.Windows.Forms.TextBox();
            this.solenoid_voltage_label = new System.Windows.Forms.Label();
            this.Solenoid_Current_TextBox = new System.Windows.Forms.TextBox();
            this.solenoid_current_label = new System.Windows.Forms.Label();
            this.Solenoid_Length_TextBox = new System.Windows.Forms.TextBox();
            this.solenoid_length_label = new System.Windows.Forms.Label();
            this.Solenoid_Inductance_TextBox = new System.Windows.Forms.TextBox();
            this.solenoid_inductance_label = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Accelerator_Stagenumber_TextBox = new System.Windows.Forms.TextBox();
            this.acceleator_stage_label = new System.Windows.Forms.Label();
            this.Rising_Time_TextBox = new System.Windows.Forms.TextBox();
            this.rising_time_label = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Solenoid_Energy_Button = new System.Windows.Forms.Button();
            this.Energy_to_Velocity = new System.Windows.Forms.Button();
            this.Projectile_Ek_Button = new System.Windows.Forms.Button();
            this.TextBox_Clear = new System.Windows.Forms.Button();
            this.Textbox_clear_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // System_Message_Box
            // 
            this.System_Message_Box.Font = new System.Drawing.Font("휴먼명조", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.System_Message_Box.Location = new System.Drawing.Point(13, 13);
            this.System_Message_Box.Name = "System_Message_Box";
            this.System_Message_Box.Size = new System.Drawing.Size(900, 500);
            this.System_Message_Box.TabIndex = 0;
            this.System_Message_Box.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.Ek_TextBox);
            this.groupBox1.Controls.Add(this.Ek_label);
            this.groupBox1.Controls.Add(this.Projectile_Velocity_TextBox);
            this.groupBox1.Controls.Add(this.muzzle_velocity_label);
            this.groupBox1.Controls.Add(this.Projectile_Length_TextBox);
            this.groupBox1.Controls.Add(this.projectile_length_label);
            this.groupBox1.Controls.Add(this.Projectile_Mass_TextBox);
            this.groupBox1.Controls.Add(this.projectile_mass_label);
            this.groupBox1.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 564);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(900, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "탄자";
            // 
            // Ek_TextBox
            // 
            this.Ek_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ek_TextBox.Location = new System.Drawing.Point(670, 123);
            this.Ek_TextBox.Name = "Ek_TextBox";
            this.Ek_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Ek_TextBox.TabIndex = 7;
            // 
            // Ek_label
            // 
            this.Ek_label.AutoSize = true;
            this.Ek_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ek_label.ForeColor = System.Drawing.Color.Black;
            this.Ek_label.Location = new System.Drawing.Point(442, 126);
            this.Ek_label.Name = "Ek_label";
            this.Ek_label.Size = new System.Drawing.Size(188, 28);
            this.Ek_label.TabIndex = 6;
            this.Ek_label.Text = "운동에너지 (J)";
            this.Ek_label.Click += new System.EventHandler(this.Ek_label_Click);
            // 
            // Projectile_Velocity_TextBox
            // 
            this.Projectile_Velocity_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Projectile_Velocity_TextBox.Location = new System.Drawing.Point(670, 56);
            this.Projectile_Velocity_TextBox.Name = "Projectile_Velocity_TextBox";
            this.Projectile_Velocity_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Projectile_Velocity_TextBox.TabIndex = 5;
            // 
            // muzzle_velocity_label
            // 
            this.muzzle_velocity_label.AutoSize = true;
            this.muzzle_velocity_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.muzzle_velocity_label.ForeColor = System.Drawing.Color.Black;
            this.muzzle_velocity_label.Location = new System.Drawing.Point(442, 59);
            this.muzzle_velocity_label.Name = "muzzle_velocity_label";
            this.muzzle_velocity_label.Size = new System.Drawing.Size(136, 28);
            this.muzzle_velocity_label.TabIndex = 4;
            this.muzzle_velocity_label.Text = "탄속 (M/s)";
            this.muzzle_velocity_label.Click += new System.EventHandler(this.muzzle_velocity_label_Click);
            // 
            // Projectile_Length_TextBox
            // 
            this.Projectile_Length_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Projectile_Length_TextBox.Location = new System.Drawing.Point(196, 126);
            this.Projectile_Length_TextBox.Name = "Projectile_Length_TextBox";
            this.Projectile_Length_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Projectile_Length_TextBox.TabIndex = 3;
            // 
            // projectile_length_label
            // 
            this.projectile_length_label.AutoSize = true;
            this.projectile_length_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.projectile_length_label.ForeColor = System.Drawing.Color.Black;
            this.projectile_length_label.Location = new System.Drawing.Point(7, 126);
            this.projectile_length_label.Name = "projectile_length_label";
            this.projectile_length_label.Size = new System.Drawing.Size(140, 28);
            this.projectile_length_label.TabIndex = 2;
            this.projectile_length_label.Text = "길이 (mm)";
            this.projectile_length_label.Click += new System.EventHandler(this.projectile_length_label_Click);
            // 
            // Projectile_Mass_TextBox
            // 
            this.Projectile_Mass_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Projectile_Mass_TextBox.Location = new System.Drawing.Point(196, 56);
            this.Projectile_Mass_TextBox.Name = "Projectile_Mass_TextBox";
            this.Projectile_Mass_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Projectile_Mass_TextBox.TabIndex = 1;
            // 
            // projectile_mass_label
            // 
            this.projectile_mass_label.AutoSize = true;
            this.projectile_mass_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.projectile_mass_label.ForeColor = System.Drawing.Color.Black;
            this.projectile_mass_label.Location = new System.Drawing.Point(7, 59);
            this.projectile_mass_label.Name = "projectile_mass_label";
            this.projectile_mass_label.Size = new System.Drawing.Size(121, 28);
            this.projectile_mass_label.TabIndex = 0;
            this.projectile_mass_label.Text = "질량 (gf)";
            this.projectile_mass_label.Click += new System.EventHandler(this.projectile_mass_label_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.Solenoid_Voltage_TextBox);
            this.groupBox2.Controls.Add(this.solenoid_voltage_label);
            this.groupBox2.Controls.Add(this.Solenoid_Current_TextBox);
            this.groupBox2.Controls.Add(this.solenoid_current_label);
            this.groupBox2.Controls.Add(this.Solenoid_Length_TextBox);
            this.groupBox2.Controls.Add(this.solenoid_length_label);
            this.groupBox2.Controls.Add(this.Solenoid_Inductance_TextBox);
            this.groupBox2.Controls.Add(this.solenoid_inductance_label);
            this.groupBox2.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 816);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(900, 185);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "솔레노이드";
            // 
            // Solenoid_Voltage_TextBox
            // 
            this.Solenoid_Voltage_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Solenoid_Voltage_TextBox.Location = new System.Drawing.Point(670, 123);
            this.Solenoid_Voltage_TextBox.Name = "Solenoid_Voltage_TextBox";
            this.Solenoid_Voltage_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Solenoid_Voltage_TextBox.TabIndex = 7;
            // 
            // solenoid_voltage_label
            // 
            this.solenoid_voltage_label.AutoSize = true;
            this.solenoid_voltage_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.solenoid_voltage_label.ForeColor = System.Drawing.Color.Black;
            this.solenoid_voltage_label.Location = new System.Drawing.Point(442, 126);
            this.solenoid_voltage_label.Name = "solenoid_voltage_label";
            this.solenoid_voltage_label.Size = new System.Drawing.Size(168, 28);
            this.solenoid_voltage_label.TabIndex = 6;
            this.solenoid_voltage_label.Text = "인가전압 (V)";
            this.solenoid_voltage_label.Click += new System.EventHandler(this.solenoid_voltage_label_Click);
            // 
            // Solenoid_Current_TextBox
            // 
            this.Solenoid_Current_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Solenoid_Current_TextBox.Location = new System.Drawing.Point(670, 56);
            this.Solenoid_Current_TextBox.Name = "Solenoid_Current_TextBox";
            this.Solenoid_Current_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Solenoid_Current_TextBox.TabIndex = 5;
            // 
            // solenoid_current_label
            // 
            this.solenoid_current_label.AutoSize = true;
            this.solenoid_current_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.solenoid_current_label.ForeColor = System.Drawing.Color.Black;
            this.solenoid_current_label.Location = new System.Drawing.Point(442, 59);
            this.solenoid_current_label.Name = "solenoid_current_label";
            this.solenoid_current_label.Size = new System.Drawing.Size(168, 28);
            this.solenoid_current_label.TabIndex = 4;
            this.solenoid_current_label.Text = "인가전류 (A)";
            this.solenoid_current_label.Click += new System.EventHandler(this.solenoid_current_label_Click);
            // 
            // Solenoid_Length_TextBox
            // 
            this.Solenoid_Length_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Solenoid_Length_TextBox.Location = new System.Drawing.Point(196, 123);
            this.Solenoid_Length_TextBox.Name = "Solenoid_Length_TextBox";
            this.Solenoid_Length_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Solenoid_Length_TextBox.TabIndex = 3;
            // 
            // solenoid_length_label
            // 
            this.solenoid_length_label.AutoSize = true;
            this.solenoid_length_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.solenoid_length_label.ForeColor = System.Drawing.Color.Black;
            this.solenoid_length_label.Location = new System.Drawing.Point(7, 126);
            this.solenoid_length_label.Name = "solenoid_length_label";
            this.solenoid_length_label.Size = new System.Drawing.Size(140, 28);
            this.solenoid_length_label.TabIndex = 2;
            this.solenoid_length_label.Text = "길이 (mm)";
            this.solenoid_length_label.Click += new System.EventHandler(this.solenoid_length_label_Click);
            // 
            // Solenoid_Inductance_TextBox
            // 
            this.Solenoid_Inductance_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Solenoid_Inductance_TextBox.Location = new System.Drawing.Point(196, 56);
            this.Solenoid_Inductance_TextBox.Name = "Solenoid_Inductance_TextBox";
            this.Solenoid_Inductance_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Solenoid_Inductance_TextBox.TabIndex = 1;
            // 
            // solenoid_inductance_label
            // 
            this.solenoid_inductance_label.AutoSize = true;
            this.solenoid_inductance_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.solenoid_inductance_label.ForeColor = System.Drawing.Color.Black;
            this.solenoid_inductance_label.Location = new System.Drawing.Point(7, 59);
            this.solenoid_inductance_label.Name = "solenoid_inductance_label";
            this.solenoid_inductance_label.Size = new System.Drawing.Size(183, 28);
            this.solenoid_inductance_label.TabIndex = 0;
            this.solenoid_inductance_label.Text = "인덕턴스 (uH)";
            this.solenoid_inductance_label.Click += new System.EventHandler(this.solenoid_inductance_label_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Silver;
            this.groupBox3.Controls.Add(this.Accelerator_Stagenumber_TextBox);
            this.groupBox3.Controls.Add(this.acceleator_stage_label);
            this.groupBox3.Controls.Add(this.Rising_Time_TextBox);
            this.groupBox3.Controls.Add(this.rising_time_label);
            this.groupBox3.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(991, 564);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(725, 185);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "타이밍";
            // 
            // Accelerator_Stagenumber_TextBox
            // 
            this.Accelerator_Stagenumber_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Accelerator_Stagenumber_TextBox.Location = new System.Drawing.Point(250, 123);
            this.Accelerator_Stagenumber_TextBox.Name = "Accelerator_Stagenumber_TextBox";
            this.Accelerator_Stagenumber_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Accelerator_Stagenumber_TextBox.TabIndex = 3;
            // 
            // acceleator_stage_label
            // 
            this.acceleator_stage_label.AutoSize = true;
            this.acceleator_stage_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.acceleator_stage_label.ForeColor = System.Drawing.Color.Black;
            this.acceleator_stage_label.Location = new System.Drawing.Point(7, 126);
            this.acceleator_stage_label.Name = "acceleator_stage_label";
            this.acceleator_stage_label.Size = new System.Drawing.Size(177, 28);
            this.acceleator_stage_label.TabIndex = 2;
            this.acceleator_stage_label.Text = "가속단수 (단)";
            this.acceleator_stage_label.Click += new System.EventHandler(this.acceleator_stage_label_Click);
            // 
            // Rising_Time_TextBox
            // 
            this.Rising_Time_TextBox.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Rising_Time_TextBox.Location = new System.Drawing.Point(250, 56);
            this.Rising_Time_TextBox.Name = "Rising_Time_TextBox";
            this.Rising_Time_TextBox.Size = new System.Drawing.Size(188, 39);
            this.Rising_Time_TextBox.TabIndex = 1;
            // 
            // rising_time_label
            // 
            this.rising_time_label.AutoSize = true;
            this.rising_time_label.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rising_time_label.ForeColor = System.Drawing.Color.Black;
            this.rising_time_label.Location = new System.Drawing.Point(7, 59);
            this.rising_time_label.Name = "rising_time_label";
            this.rising_time_label.Size = new System.Drawing.Size(183, 28);
            this.rising_time_label.TabIndex = 0;
            this.rising_time_label.Text = "인가시간 (ms)";
            this.rising_time_label.Click += new System.EventHandler(this.rising_time_label_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.Solenoid_Energy_Button);
            this.groupBox4.Controls.Add(this.Energy_to_Velocity);
            this.groupBox4.Controls.Add(this.Projectile_Ek_Button);
            this.groupBox4.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox4.Location = new System.Drawing.Point(991, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(725, 376);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "계산";
            // 
            // Solenoid_Energy_Button
            // 
            this.Solenoid_Energy_Button.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Solenoid_Energy_Button.ForeColor = System.Drawing.Color.Black;
            this.Solenoid_Energy_Button.Location = new System.Drawing.Point(384, 57);
            this.Solenoid_Energy_Button.Name = "Solenoid_Energy_Button";
            this.Solenoid_Energy_Button.Size = new System.Drawing.Size(335, 60);
            this.Solenoid_Energy_Button.TabIndex = 2;
            this.Solenoid_Energy_Button.Text = "솔레노이드 에너지 계산";
            this.Solenoid_Energy_Button.UseVisualStyleBackColor = true;
            this.Solenoid_Energy_Button.Click += new System.EventHandler(this.Solenoid_Energy_Button_Click);
            // 
            // Energy_to_Velocity
            // 
            this.Energy_to_Velocity.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Energy_to_Velocity.ForeColor = System.Drawing.Color.Black;
            this.Energy_to_Velocity.Location = new System.Drawing.Point(12, 138);
            this.Energy_to_Velocity.Name = "Energy_to_Velocity";
            this.Energy_to_Velocity.Size = new System.Drawing.Size(335, 60);
            this.Energy_to_Velocity.TabIndex = 1;
            this.Energy_to_Velocity.Text = "에너지에 의한 탄속 계산";
            this.Energy_to_Velocity.UseVisualStyleBackColor = true;
            this.Energy_to_Velocity.Click += new System.EventHandler(this.Energy_to_Velocity_Click);
            // 
            // Projectile_Ek_Button
            // 
            this.Projectile_Ek_Button.Font = new System.Drawing.Font("휴먼명조", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Projectile_Ek_Button.ForeColor = System.Drawing.Color.Black;
            this.Projectile_Ek_Button.Location = new System.Drawing.Point(12, 57);
            this.Projectile_Ek_Button.Name = "Projectile_Ek_Button";
            this.Projectile_Ek_Button.Size = new System.Drawing.Size(335, 60);
            this.Projectile_Ek_Button.TabIndex = 0;
            this.Projectile_Ek_Button.Text = "탄자 운동에너지 계산";
            this.Projectile_Ek_Button.UseVisualStyleBackColor = true;
            this.Projectile_Ek_Button.Click += new System.EventHandler(this.Projectile_Ek_Button_Click);
            // 
            // TextBox_Clear
            // 
            this.TextBox_Clear.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TextBox_Clear.Location = new System.Drawing.Point(1003, 13);
            this.TextBox_Clear.Name = "TextBox_Clear";
            this.TextBox_Clear.Size = new System.Drawing.Size(218, 60);
            this.TextBox_Clear.TabIndex = 5;
            this.TextBox_Clear.Text = "화면 지우기";
            this.TextBox_Clear.UseVisualStyleBackColor = true;
            this.TextBox_Clear.Click += new System.EventHandler(this.TextBox_Clear_Click);
            // 
            // Textbox_clear_button
            // 
            this.Textbox_clear_button.Font = new System.Drawing.Font("HY헤드라인M", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Textbox_clear_button.Location = new System.Drawing.Point(1227, 13);
            this.Textbox_clear_button.Name = "Textbox_clear_button";
            this.Textbox_clear_button.Size = new System.Drawing.Size(339, 60);
            this.Textbox_clear_button.TabIndex = 6;
            this.Textbox_clear_button.Text = "입력값 전체 지우기";
            this.Textbox_clear_button.UseVisualStyleBackColor = true;
            this.Textbox_clear_button.Click += new System.EventHandler(this.textbox_clear_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1728, 1057);
            this.Controls.Add(this.Textbox_clear_button);
            this.Controls.Add(this.TextBox_Clear);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.System_Message_Box);
            this.Font = new System.Drawing.Font("휴먼명조", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "코일건 계산기 v1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_Form_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox System_Message_Box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label projectile_mass_label;
        private System.Windows.Forms.TextBox Projectile_Mass_TextBox;
        private System.Windows.Forms.TextBox Projectile_Length_TextBox;
        private System.Windows.Forms.Label projectile_length_label;
        private System.Windows.Forms.TextBox Projectile_Velocity_TextBox;
        private System.Windows.Forms.Label muzzle_velocity_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Solenoid_Current_TextBox;
        private System.Windows.Forms.Label solenoid_current_label;
        private System.Windows.Forms.TextBox Solenoid_Length_TextBox;
        private System.Windows.Forms.Label solenoid_length_label;
        private System.Windows.Forms.TextBox Solenoid_Inductance_TextBox;
        private System.Windows.Forms.Label solenoid_inductance_label;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox Accelerator_Stagenumber_TextBox;
        private System.Windows.Forms.Label acceleator_stage_label;
        private System.Windows.Forms.TextBox Rising_Time_TextBox;
        private System.Windows.Forms.Label rising_time_label;
        private System.Windows.Forms.TextBox Solenoid_Voltage_TextBox;
        private System.Windows.Forms.Label solenoid_voltage_label;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Projectile_Ek_Button;
        private System.Windows.Forms.Button TextBox_Clear;
        private System.Windows.Forms.Button Energy_to_Velocity;
        private System.Windows.Forms.TextBox Ek_TextBox;
        private System.Windows.Forms.Label Ek_label;
        private System.Windows.Forms.Button Solenoid_Energy_Button;
        private System.Windows.Forms.Button Textbox_clear_button;
    }
}

