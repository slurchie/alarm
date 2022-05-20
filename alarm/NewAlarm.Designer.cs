
namespace alarm
{
    partial class NewAlarm
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
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.newAlarmgroupBox = new System.Windows.Forms.GroupBox();
            this.NOradioButton = new System.Windows.Forms.RadioButton();
            this.YESradioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.newAlarmgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(223, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveButton.Location = new System.Drawing.Point(476, 73);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(93, 43);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // newAlarmgroupBox
            // 
            this.newAlarmgroupBox.Controls.Add(this.NOradioButton);
            this.newAlarmgroupBox.Controls.Add(this.YESradioButton);
            this.newAlarmgroupBox.Controls.Add(this.label2);
            this.newAlarmgroupBox.Controls.Add(this.button3);
            this.newAlarmgroupBox.Controls.Add(this.label1);
            this.newAlarmgroupBox.Controls.Add(this.textBox1);
            this.newAlarmgroupBox.Location = new System.Drawing.Point(223, 189);
            this.newAlarmgroupBox.Name = "newAlarmgroupBox";
            this.newAlarmgroupBox.Size = new System.Drawing.Size(337, 272);
            this.newAlarmgroupBox.TabIndex = 3;
            this.newAlarmgroupBox.TabStop = false;
            // 
            // NOradioButton
            // 
            this.NOradioButton.AutoSize = true;
            this.NOradioButton.Location = new System.Drawing.Point(136, 212);
            this.NOradioButton.Name = "NOradioButton";
            this.NOradioButton.Size = new System.Drawing.Size(54, 21);
            this.NOradioButton.TabIndex = 6;
            this.NOradioButton.TabStop = true;
            this.NOradioButton.Text = "Нет";
            this.NOradioButton.UseVisualStyleBackColor = true;
            this.NOradioButton.CheckedChanged += new System.EventHandler(this.NOradioButton_CheckedChanged);
            // 
            // YESradioButton
            // 
            this.YESradioButton.AutoSize = true;
            this.YESradioButton.Location = new System.Drawing.Point(20, 212);
            this.YESradioButton.Name = "YESradioButton";
            this.YESradioButton.Size = new System.Drawing.Size(48, 21);
            this.YESradioButton.TabIndex = 5;
            this.YESradioButton.TabStop = true;
            this.YESradioButton.Text = "Да";
            this.YESradioButton.UseVisualStyleBackColor = true;
            this.YESradioButton.CheckedChanged += new System.EventHandler(this.YESradioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Повторение сигнала";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "повтор";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(372, 140);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(57, 30);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // NewAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.newAlarmgroupBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button1);
            this.Name = "NewAlarm";
            this.Text = "NewAlarm";
            this.Load += new System.EventHandler(this.NewAlarm_Load);
            this.newAlarmgroupBox.ResumeLayout(false);
            this.newAlarmgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox newAlarmgroupBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton NOradioButton;
        private System.Windows.Forms.RadioButton YESradioButton;
        private System.Windows.Forms.Label label2;
    }
}