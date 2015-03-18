namespace RechnerPrototype.BusinessStyle
{
    partial class Prozentrechnung
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logSpeichernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nebenrechnungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hauptfensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rückschrittToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allgemeineHilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überRechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "555";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Brutto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Netto";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "555";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prozentsatz";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(6, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(256, 38);
            this.textBox3.TabIndex = 1;
            this.textBox3.Text = "555";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(18, 255);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(80, 23);
            this.button12.TabIndex = 6;
            this.button12.Text = "%davon";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(104, 255);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(80, 23);
            this.button13.TabIndex = 7;
            this.button13.Text = "%dazu";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(190, 255);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(80, 23);
            this.button14.TabIndex = 8;
            this.button14.Text = "%weniger";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(18, 284);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(80, 23);
            this.button15.TabIndex = 9;
            this.button15.Text = "Prozentsatz";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(104, 284);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(80, 23);
            this.button16.TabIndex = 10;
            this.button16.Text = "Brutto";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(190, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Netto";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logSpeichernToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // logSpeichernToolStripMenuItem
            // 
            this.logSpeichernToolStripMenuItem.Name = "logSpeichernToolStripMenuItem";
            this.logSpeichernToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.logSpeichernToolStripMenuItem.Text = "Log speichern";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nebenrechnungenToolStripMenuItem,
            this.hauptfensterToolStripMenuItem,
            this.rückschrittToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // nebenrechnungenToolStripMenuItem
            // 
            this.nebenrechnungenToolStripMenuItem.Name = "nebenrechnungenToolStripMenuItem";
            this.nebenrechnungenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nebenrechnungenToolStripMenuItem.Text = "Nebenrechnungen";
            // 
            // hauptfensterToolStripMenuItem
            // 
            this.hauptfensterToolStripMenuItem.Name = "hauptfensterToolStripMenuItem";
            this.hauptfensterToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.hauptfensterToolStripMenuItem.Text = "Hauptfenster";
            // 
            // rückschrittToolStripMenuItem
            // 
            this.rückschrittToolStripMenuItem.Name = "rückschrittToolStripMenuItem";
            this.rückschrittToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rückschrittToolStripMenuItem.Text = "Rückschritt";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allgemeineHilfeToolStripMenuItem,
            this.überRechnerToolStripMenuItem});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.hilfeToolStripMenuItem.Text = "Über";
            // 
            // allgemeineHilfeToolStripMenuItem
            // 
            this.allgemeineHilfeToolStripMenuItem.Name = "allgemeineHilfeToolStripMenuItem";
            this.allgemeineHilfeToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.allgemeineHilfeToolStripMenuItem.Text = "Allgemeine Hilfe";
            // 
            // überRechnerToolStripMenuItem
            // 
            this.überRechnerToolStripMenuItem.Name = "überRechnerToolStripMenuItem";
            this.überRechnerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.überRechnerToolStripMenuItem.Text = "Über Rechner";
            // 
            // Prozentrechnung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 325);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Prozentrechnung";
            this.Text = "Prozentrechnung";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logSpeichernToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nebenrechnungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hauptfensterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rückschrittToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allgemeineHilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überRechnerToolStripMenuItem;
    }
}
