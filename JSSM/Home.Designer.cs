using JSSM.Properties;

namespace JSSM
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            labelTitle = new Label();
            StartBtn = new Button();
            StopBtn = new Button();
            RestartBtn = new Button();
            labelByDavih306 = new Label();
            UpdateBtn = new Button();
            groupBoxStatus = new GroupBox();
            labelStatus = new Label();
            groupBoxStatus.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(72, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(395, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Jellyfin Server Service Management";
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.PaleGreen;
            StartBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            StartBtn.ForeColor = SystemColors.ControlText;
            StartBtn.Location = new Point(352, 108);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(150, 51);
            StartBtn.TabIndex = 1;
            StartBtn.Text = "START";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.LightCoral;
            StopBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            StopBtn.Location = new Point(350, 165);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(155, 51);
            StopBtn.TabIndex = 2;
            StopBtn.Text = "STOP";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // RestartBtn
            // 
            RestartBtn.BackColor = Color.FromArgb(255, 255, 128);
            RestartBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            RestartBtn.Location = new Point(350, 222);
            RestartBtn.Name = "RestartBtn";
            RestartBtn.Size = new Size(155, 51);
            RestartBtn.TabIndex = 3;
            RestartBtn.Text = "RESET";
            RestartBtn.UseVisualStyleBackColor = false;
            RestartBtn.Click += RestartBtn_Click;
            // 
            // labelByDavih306
            // 
            labelByDavih306.AutoSize = true;
            labelByDavih306.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelByDavih306.Location = new Point(352, 41);
            labelByDavih306.Name = "labelByDavih306";
            labelByDavih306.Size = new Size(115, 25);
            labelByDavih306.TabIndex = 4;
            labelByDavih306.Text = "by: davih306";
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = Color.FromArgb(128, 255, 255);
            UpdateBtn.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBtn.Location = new Point(350, 279);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(155, 51);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // groupBoxStatus
            // 
            groupBoxStatus.Controls.Add(labelStatus);
            groupBoxStatus.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxStatus.Location = new Point(39, 128);
            groupBoxStatus.Name = "groupBoxStatus";
            groupBoxStatus.Size = new Size(250, 100);
            groupBoxStatus.TabIndex = 7;
            groupBoxStatus.TabStop = false;
            groupBoxStatus.Text = "Status:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(6, 22);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(180, 56);
            labelStatus.TabIndex = 6;
            labelStatus.Text = "status";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 345);
            Controls.Add(groupBoxStatus);
            Controls.Add(UpdateBtn);
            Controls.Add(labelByDavih306);
            Controls.Add(RestartBtn);
            Controls.Add(StopBtn);
            Controls.Add(StartBtn);
            Controls.Add(labelTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Text = "Jellyfin Server Service Management";
            Load += Home_Load;
            groupBoxStatus.ResumeLayout(false);
            groupBoxStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartBtn;
        private Button StopBtn;
        private Button RestartBtn;
        private Label labelTitle;
        private Label labelByDavih306;
        private Button UpdateBtn;
        private GroupBox groupBoxStatus;
        private Label labelStatus;
    }
}