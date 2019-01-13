namespace FreeMe
{
    partial class Reminders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminders));
            this.tbRecordatorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudHora = new System.Windows.Forms.NumericUpDown();
            this.nudMinutos = new System.Windows.Forms.NumericUpDown();
            this.btAvisame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRecordatorio
            // 
            this.tbRecordatorio.Location = new System.Drawing.Point(12, 32);
            this.tbRecordatorio.Multiline = true;
            this.tbRecordatorio.Name = "tbRecordatorio";
            this.tbRecordatorio.Size = new System.Drawing.Size(443, 103);
            this.tbRecordatorio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A las:";
            // 
            // nudHora
            // 
            this.nudHora.Location = new System.Drawing.Point(51, 7);
            this.nudHora.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHora.Name = "nudHora";
            this.nudHora.Size = new System.Drawing.Size(38, 20);
            this.nudHora.TabIndex = 2;
            // 
            // nudMinutos
            // 
            this.nudMinutos.Location = new System.Drawing.Point(95, 7);
            this.nudMinutos.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutos.Name = "nudMinutos";
            this.nudMinutos.Size = new System.Drawing.Size(38, 20);
            this.nudMinutos.TabIndex = 3;
            // 
            // btAvisame
            // 
            this.btAvisame.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAvisame.Location = new System.Drawing.Point(380, 141);
            this.btAvisame.Name = "btAvisame";
            this.btAvisame.Size = new System.Drawing.Size(75, 23);
            this.btAvisame.TabIndex = 4;
            this.btAvisame.Text = "Avísame";
            this.btAvisame.UseVisualStyleBackColor = true;
            this.btAvisame.Click += new System.EventHandler(this.btAvisame_Click);
            // 
            // Reminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 171);
            this.Controls.Add(this.btAvisame);
            this.Controls.Add(this.nudMinutos);
            this.Controls.Add(this.nudHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRecordatorio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recordatorio";
            this.Load += new System.EventHandler(this.Reminders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRecordatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudHora;
        private System.Windows.Forms.NumericUpDown nudMinutos;
        private System.Windows.Forms.Button btAvisame;
    }
}