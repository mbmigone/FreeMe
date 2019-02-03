namespace FreeMe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbMensaje = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbAutoRun = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbDisable = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbRestante = new System.Windows.Forms.GroupBox();
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.contextMenuStrip1.SuspendLayout();
            this.gbRestante.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMensaje
            // 
            this.lbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.ForeColor = System.Drawing.Color.DarkRed;
            this.lbMensaje.Location = new System.Drawing.Point(12, 197);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(245, 139);
            this.lbMensaje.TabIndex = 2;
            this.lbMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // cbAutoRun
            // 
            this.cbAutoRun.AutoSize = true;
            this.cbAutoRun.Location = new System.Drawing.Point(12, 351);
            this.cbAutoRun.Name = "cbAutoRun";
            this.cbAutoRun.Size = new System.Drawing.Size(104, 17);
            this.cbAutoRun.TabIndex = 3;
            this.cbAutoRun.Text = "Arrancar al inicio";
            this.cbAutoRun.UseVisualStyleBackColor = true;
            this.cbAutoRun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbAutoRun_MouseClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(82, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 1);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbDisable
            // 
            this.cbDisable.AutoSize = true;
            this.cbDisable.Location = new System.Drawing.Point(12, 372);
            this.cbDisable.Name = "cbDisable";
            this.cbDisable.Size = new System.Drawing.Size(78, 17);
            this.cbDisable.TabIndex = 5;
            this.cbDisable.Text = "Modo piola";
            this.cbDisable.UseVisualStyleBackColor = true;
            this.cbDisable.CheckedChanged += new System.EventHandler(this.cbDisable_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(180, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Recordatorio";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gbRestante
            // 
            this.gbRestante.Controls.Add(this.button1);
            this.gbRestante.Controls.Add(this.circularProgressBar);
            this.gbRestante.Location = new System.Drawing.Point(12, 12);
            this.gbRestante.Name = "gbRestante";
            this.gbRestante.Size = new System.Drawing.Size(245, 182);
            this.gbRestante.TabIndex = 7;
            this.gbRestante.TabStop = false;
            this.gbRestante.Text = "Todavía falta:";
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar.AnimationSpeed = 5000;
            this.circularProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.circularProgressBar.InnerColor = System.Drawing.Color.SlateGray;
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(32, 8);
            this.circularProgressBar.MarqueeAnimationSpeed = 5000;
            this.circularProgressBar.Maximum = 43200;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.DimGray;
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.LimeGreen;
            this.circularProgressBar.ProgressWidth = 15;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.Size = new System.Drawing.Size(170, 170);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Step = 1000;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 8;
            this.circularProgressBar.Text = "00:00:00";
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar.Value = 68;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 397);
            this.Controls.Add(this.gbRestante);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbDisable);
            this.Controls.Add(this.cbAutoRun);
            this.Controls.Add(this.lbMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FreeMe v1.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbRestante.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbAutoRun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbDisable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbRestante;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
    }
}

