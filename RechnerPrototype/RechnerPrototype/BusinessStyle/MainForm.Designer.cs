namespace RechnerPrototype
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Grundrechenarten";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Prozentrechnung";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kreditberechnung";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(207, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Mathematische/Technische Funktionen";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 144);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(207, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Flächen- und Körperbrechnungen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(240, 144);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(207, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Leistungsverteilung";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 187);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "[?] Hilfe";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Willkommen beim Rechner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wählen Sie im unteren Menü den gewünschten Teilbereich aus. ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 217);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Rechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

