namespace BreakTime
{
    partial class Gui
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
            this.SelectMode = new System.Windows.Forms.ComboBox();
            this.LabelModes = new System.Windows.Forms.Label();
            this.BotTime = new System.Windows.Forms.Label();
            this.LabelMinBotTime = new System.Windows.Forms.Label();
            this.LabelMaxBotTime = new System.Windows.Forms.Label();
            this.BreakTime = new System.Windows.Forms.Label();
            this.LabelMinBreakTime = new System.Windows.Forms.Label();
            this.LabelMaxBreakTime = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.NumericMinBotTime = new System.Windows.Forms.NumericUpDown();
            this.NumericMaxBotTime = new System.Windows.Forms.NumericUpDown();
            this.NumericMinBreakTime = new System.Windows.Forms.NumericUpDown();
            this.NumericMaxBreakTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinBotTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxBotTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinBreakTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxBreakTime)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectMode
            // 
            this.SelectMode.FormattingEnabled = true;
            this.SelectMode.Items.AddRange(new object[] {
            "Default",
            "Questing",
            "PetBattle",
            "Dungeon",
            "Battleground"});
            this.SelectMode.Location = new System.Drawing.Point(22, 32);
            this.SelectMode.Name = "SelectMode";
            this.SelectMode.Size = new System.Drawing.Size(121, 21);
            this.SelectMode.TabIndex = 0;
            this.SelectMode.SelectedIndexChanged += new System.EventHandler(this.SelectMode_SelectedIndexChanged);
            // 
            // LabelModes
            // 
            this.LabelModes.AutoSize = true;
            this.LabelModes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModes.Location = new System.Drawing.Point(19, 9);
            this.LabelModes.Name = "LabelModes";
            this.LabelModes.Size = new System.Drawing.Size(125, 16);
            this.LabelModes.TabIndex = 1;
            this.LabelModes.Text = "Available Modes";
            // 
            // BotTime
            // 
            this.BotTime.AutoSize = true;
            this.BotTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotTime.Location = new System.Drawing.Point(44, 56);
            this.BotTime.Name = "BotTime";
            this.BotTime.Size = new System.Drawing.Size(89, 16);
            this.BotTime.TabIndex = 2;
            this.BotTime.Text = "Botting time";
            // 
            // LabelMinBotTime
            // 
            this.LabelMinBotTime.AutoSize = true;
            this.LabelMinBotTime.Location = new System.Drawing.Point(15, 79);
            this.LabelMinBotTime.Name = "LabelMinBotTime";
            this.LabelMinBotTime.Size = new System.Drawing.Size(26, 13);
            this.LabelMinBotTime.TabIndex = 3;
            this.LabelMinBotTime.Text = "min.";
            // 
            // LabelMaxBotTime
            // 
            this.LabelMaxBotTime.AutoSize = true;
            this.LabelMaxBotTime.Location = new System.Drawing.Point(15, 104);
            this.LabelMaxBotTime.Name = "LabelMaxBotTime";
            this.LabelMaxBotTime.Size = new System.Drawing.Size(29, 13);
            this.LabelMaxBotTime.TabIndex = 4;
            this.LabelMaxBotTime.Text = "max.";
            // 
            // BreakTime
            // 
            this.BreakTime.AutoSize = true;
            this.BreakTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakTime.Location = new System.Drawing.Point(44, 125);
            this.BreakTime.Name = "BreakTime";
            this.BreakTime.Size = new System.Drawing.Size(82, 16);
            this.BreakTime.TabIndex = 5;
            this.BreakTime.Text = "Break time";
            this.BreakTime.Click += new System.EventHandler(this.BreakTime_Click);
            // 
            // LabelMinBreakTime
            // 
            this.LabelMinBreakTime.AutoSize = true;
            this.LabelMinBreakTime.Location = new System.Drawing.Point(15, 143);
            this.LabelMinBreakTime.Name = "LabelMinBreakTime";
            this.LabelMinBreakTime.Size = new System.Drawing.Size(26, 13);
            this.LabelMinBreakTime.TabIndex = 6;
            this.LabelMinBreakTime.Text = "min.";
            // 
            // LabelMaxBreakTime
            // 
            this.LabelMaxBreakTime.AutoSize = true;
            this.LabelMaxBreakTime.Location = new System.Drawing.Point(15, 169);
            this.LabelMaxBreakTime.Name = "LabelMaxBreakTime";
            this.LabelMaxBreakTime.Size = new System.Drawing.Size(29, 13);
            this.LabelMaxBreakTime.TabIndex = 7;
            this.LabelMaxBreakTime.Text = "max.";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(22, 193);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(131, 23);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save & Close";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // NumericMinBotTime
            // 
            this.NumericMinBotTime.Location = new System.Drawing.Point(47, 77);
            this.NumericMinBotTime.Name = "NumericMinBotTime";
            this.NumericMinBotTime.Size = new System.Drawing.Size(92, 20);
            this.NumericMinBotTime.TabIndex = 13;
            this.NumericMinBotTime.ValueChanged += new System.EventHandler(this.NumericMinBotTime_ValueChanged);
            // 
            // NumericMaxBotTime
            // 
            this.NumericMaxBotTime.Location = new System.Drawing.Point(47, 102);
            this.NumericMaxBotTime.Name = "NumericMaxBotTime";
            this.NumericMaxBotTime.Size = new System.Drawing.Size(92, 20);
            this.NumericMaxBotTime.TabIndex = 14;
            this.NumericMaxBotTime.ValueChanged += new System.EventHandler(this.NumericMaxBotTime_ValueChanged);
            // 
            // NumericMinBreakTime
            // 
            this.NumericMinBreakTime.Location = new System.Drawing.Point(47, 141);
            this.NumericMinBreakTime.Name = "NumericMinBreakTime";
            this.NumericMinBreakTime.Size = new System.Drawing.Size(92, 20);
            this.NumericMinBreakTime.TabIndex = 15;
            this.NumericMinBreakTime.ValueChanged += new System.EventHandler(this.NumericMinBreakTime_ValueChanged);
            // 
            // NumericMaxBreakTime
            // 
            this.NumericMaxBreakTime.Location = new System.Drawing.Point(47, 167);
            this.NumericMaxBreakTime.Name = "NumericMaxBreakTime";
            this.NumericMaxBreakTime.Size = new System.Drawing.Size(92, 20);
            this.NumericMaxBreakTime.TabIndex = 16;
            this.NumericMaxBreakTime.ValueChanged += new System.EventHandler(this.NumericMaxBreakTime_ValueChanged);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 227);
            this.Controls.Add(this.NumericMaxBreakTime);
            this.Controls.Add(this.NumericMinBreakTime);
            this.Controls.Add(this.NumericMaxBotTime);
            this.Controls.Add(this.NumericMinBotTime);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelMaxBreakTime);
            this.Controls.Add(this.LabelMinBreakTime);
            this.Controls.Add(this.BreakTime);
            this.Controls.Add(this.LabelMaxBotTime);
            this.Controls.Add(this.LabelMinBotTime);
            this.Controls.Add(this.BotTime);
            this.Controls.Add(this.LabelModes);
            this.Controls.Add(this.SelectMode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gui";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BreakTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinBotTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxBotTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMinBreakTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaxBreakTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SelectMode;
        private System.Windows.Forms.Label LabelModes;
        private System.Windows.Forms.Label BotTime;
        private System.Windows.Forms.Label LabelMinBotTime;
        private System.Windows.Forms.Label LabelMaxBotTime;
        private System.Windows.Forms.Label BreakTime;
        private System.Windows.Forms.Label LabelMinBreakTime;
        private System.Windows.Forms.Label LabelMaxBreakTime;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.NumericUpDown NumericMinBotTime;
        private System.Windows.Forms.NumericUpDown NumericMaxBotTime;
        private System.Windows.Forms.NumericUpDown NumericMinBreakTime;
        private System.Windows.Forms.NumericUpDown NumericMaxBreakTime;
    }
}