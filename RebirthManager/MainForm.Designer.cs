namespace RebirthManager
{
    partial class MainForm
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
            this.RebirthManagerLabel = new System.Windows.Forms.Label();
            this.ReadLastRun = new System.Windows.Forms.Button();
            this.UpdateItemTables = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RebirthManagerLabel
            // 
            this.RebirthManagerLabel.AutoSize = true;
            this.RebirthManagerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RebirthManagerLabel.Location = new System.Drawing.Point(136, 19);
            this.RebirthManagerLabel.Name = "RebirthManagerLabel";
            this.RebirthManagerLabel.Size = new System.Drawing.Size(296, 42);
            this.RebirthManagerLabel.TabIndex = 0;
            this.RebirthManagerLabel.Text = "Rebirth Manager";
            // 
            // ReadLastRun
            // 
            this.ReadLastRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.ReadLastRun.Location = new System.Drawing.Point(12, 19);
            this.ReadLastRun.Name = "ReadLastRun";
            this.ReadLastRun.Size = new System.Drawing.Size(95, 55);
            this.ReadLastRun.TabIndex = 1;
            this.ReadLastRun.Text = "Read Last Run";
            this.ReadLastRun.UseVisualStyleBackColor = true;
            this.ReadLastRun.Click += new System.EventHandler(this.ReadLastRun_Click);
            // 
            // UpdateItemTables
            // 
            this.UpdateItemTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.UpdateItemTables.Location = new System.Drawing.Point(438, 19);
            this.UpdateItemTables.Name = "UpdateItemTables";
            this.UpdateItemTables.Size = new System.Drawing.Size(143, 55);
            this.UpdateItemTables.TabIndex = 2;
            this.UpdateItemTables.Text = "Update Database ";
            this.UpdateItemTables.UseVisualStyleBackColor = true;
            this.UpdateItemTables.Click += new System.EventHandler(this.UpdateItemTables_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 761);
            this.Controls.Add(this.UpdateItemTables);
            this.Controls.Add(this.ReadLastRun);
            this.Controls.Add(this.RebirthManagerLabel);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rebirth Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RebirthManagerLabel;
        private System.Windows.Forms.Button ReadLastRun;
        private System.Windows.Forms.Button UpdateItemTables;
    }
}

