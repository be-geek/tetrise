namespace Tetrise
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.SpeedTimer = new System.Windows.Forms.Timer(this.components);
            this.PreView = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.Label_level = new System.Windows.Forms.Label();
            this.Label_score = new System.Windows.Forms.Label();
            this.PlayField = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.CausesValidation = false;
            this.StartButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Location = new System.Drawing.Point(263, 339);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 46);
            this.StartButton.TabIndex = 1;
            this.StartButton.TabStop = false;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // SpeedTimer
            // 
            this.SpeedTimer.Tick += new System.EventHandler(this.SpeedTimer_Tick);
            // 
            // PreView
            // 
            this.PreView.BackColor = System.Drawing.Color.Black;
            this.PreView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreView.Location = new System.Drawing.Point(263, 12);
            this.PreView.Name = "PreView";
            this.PreView.Size = new System.Drawing.Size(125, 125);
            this.PreView.TabIndex = 4;
            // 
            // ExitButton
            // 
            this.ExitButton.CausesValidation = false;
            this.ExitButton.Location = new System.Drawing.Point(263, 391);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(125, 46);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.TabStop = false;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Label_level
            // 
            this.Label_level.AutoSize = true;
            this.Label_level.Location = new System.Drawing.Point(263, 154);
            this.Label_level.Name = "Label_level";
            this.Label_level.Size = new System.Drawing.Size(47, 12);
            this.Label_level.TabIndex = 5;
            this.Label_level.Text = "Level:0";
            // 
            // Label_score
            // 
            this.Label_score.AutoSize = true;
            this.Label_score.Location = new System.Drawing.Point(263, 181);
            this.Label_score.Name = "Label_score";
            this.Label_score.Size = new System.Drawing.Size(47, 12);
            this.Label_score.TabIndex = 6;
            this.Label_score.Text = "Score:0";
            // 
            // PlayField
            // 
            this.PlayField.BackColor = System.Drawing.Color.Black;
            this.PlayField.BackgroundImage = global::Tetrise.Properties.Resources.BackGround;
            this.PlayField.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayField.Location = new System.Drawing.Point(12, 12);
            this.PlayField.Name = "PlayField";
            this.PlayField.Size = new System.Drawing.Size(245, 425);
            this.PlayField.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 448);
            this.Controls.Add(this.Label_score);
            this.Controls.Add(this.Label_level);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PreView);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.PlayField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetrise Plus!";
            this.TopMost = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PlayField;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer SpeedTimer;
        private System.Windows.Forms.Panel PreView;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label Label_level;
        private System.Windows.Forms.Label Label_score;
    }
}

