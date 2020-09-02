namespace Kalkulator
{
    partial class Kalkulator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalkulator));
            this.tbWyswietlacz = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMnoz = new System.Windows.Forms.Button();
            this.btnDziel = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.btnPrzecinek = new System.Windows.Forms.Button();
            this.btnSilnia = new System.Windows.Forms.Button();
            this.lbWykonywanaOperacja = new System.Windows.Forms.Label();
            this.btnWyzeruj = new System.Windows.Forms.Button();
            this.btnWyczyscTb = new System.Windows.Forms.Button();
            this.btnPotega = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbWyswietlacz
            // 
            this.tbWyswietlacz.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWyswietlacz.Location = new System.Drawing.Point(11, 41);
            this.tbWyswietlacz.Name = "tbWyswietlacz";
            this.tbWyswietlacz.Size = new System.Drawing.Size(312, 38);
            this.tbWyswietlacz.TabIndex = 0;
            this.tbWyswietlacz.Text = "0";
            this.tbWyswietlacz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(10, 149);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(63, 48);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.num_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(79, 149);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(63, 48);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.num_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(148, 149);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(63, 48);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.num_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(10, 203);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(63, 48);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.num_click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(79, 203);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(63, 48);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.num_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(10, 311);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(132, 48);
            this.btn0.TabIndex = 6;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.num_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(148, 203);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(63, 48);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.num_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(10, 257);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(63, 48);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.num_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(79, 257);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(63, 48);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.num_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(148, 257);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(63, 48);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.num_click);
            // 
            // btnOblicz
            // 
            this.btnOblicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOblicz.Location = new System.Drawing.Point(273, 257);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(50, 101);
            this.btnOblicz.TabIndex = 10;
            this.btnOblicz.Text = "=";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(273, 95);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMinus.TabIndex = 14;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(217, 258);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(50, 101);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.operator_click);
            // 
            // btnMnoz
            // 
            this.btnMnoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMnoz.Location = new System.Drawing.Point(273, 203);
            this.btnMnoz.Name = "btnMnoz";
            this.btnMnoz.Size = new System.Drawing.Size(50, 48);
            this.btnMnoz.TabIndex = 12;
            this.btnMnoz.Text = "×";
            this.btnMnoz.UseVisualStyleBackColor = true;
            this.btnMnoz.Click += new System.EventHandler(this.operator_click);
            // 
            // btnDziel
            // 
            this.btnDziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDziel.Location = new System.Drawing.Point(217, 203);
            this.btnDziel.Name = "btnDziel";
            this.btnDziel.Size = new System.Drawing.Size(50, 48);
            this.btnDziel.TabIndex = 11;
            this.btnDziel.Text = "÷";
            this.btnDziel.UseVisualStyleBackColor = true;
            this.btnDziel.Click += new System.EventHandler(this.operator_click);
            // 
            // btnProcent
            // 
            this.btnProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcent.Location = new System.Drawing.Point(217, 95);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(50, 50);
            this.btnProcent.TabIndex = 17;
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = true;
            this.btnProcent.Click += new System.EventHandler(this.operator_click);
            // 
            // btnPrzecinek
            // 
            this.btnPrzecinek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrzecinek.Location = new System.Drawing.Point(148, 310);
            this.btnPrzecinek.Name = "btnPrzecinek";
            this.btnPrzecinek.Size = new System.Drawing.Size(63, 48);
            this.btnPrzecinek.TabIndex = 19;
            this.btnPrzecinek.Text = ",";
            this.btnPrzecinek.UseVisualStyleBackColor = true;
            this.btnPrzecinek.Click += new System.EventHandler(this.num_click);
            // 
            // btnSilnia
            // 
            this.btnSilnia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSilnia.Location = new System.Drawing.Point(217, 149);
            this.btnSilnia.Name = "btnSilnia";
            this.btnSilnia.Size = new System.Drawing.Size(50, 48);
            this.btnSilnia.TabIndex = 21;
            this.btnSilnia.Text = "n!";
            this.btnSilnia.UseVisualStyleBackColor = true;
            this.btnSilnia.Click += new System.EventHandler(this.operator_click);
            // 
            // lbWykonywanaOperacja
            // 
            this.lbWykonywanaOperacja.AutoSize = true;
            this.lbWykonywanaOperacja.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbWykonywanaOperacja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWykonywanaOperacja.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbWykonywanaOperacja.Location = new System.Drawing.Point(6, 9);
            this.lbWykonywanaOperacja.Name = "lbWykonywanaOperacja";
            this.lbWykonywanaOperacja.Size = new System.Drawing.Size(0, 29);
            this.lbWykonywanaOperacja.TabIndex = 22;
            // 
            // btnWyzeruj
            // 
            this.btnWyzeruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWyzeruj.Location = new System.Drawing.Point(10, 95);
            this.btnWyzeruj.Name = "btnWyzeruj";
            this.btnWyzeruj.Size = new System.Drawing.Size(102, 50);
            this.btnWyzeruj.TabIndex = 23;
            this.btnWyzeruj.Text = "C";
            this.btnWyzeruj.UseVisualStyleBackColor = true;
            this.btnWyzeruj.Click += new System.EventHandler(this.wyzeruj_Click);
            // 
            // btnWyczyscTb
            // 
            this.btnWyczyscTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWyczyscTb.Location = new System.Drawing.Point(118, 95);
            this.btnWyczyscTb.Name = "btnWyczyscTb";
            this.btnWyczyscTb.Size = new System.Drawing.Size(93, 50);
            this.btnWyczyscTb.TabIndex = 24;
            this.btnWyczyscTb.Text = "←";
            this.btnWyczyscTb.UseVisualStyleBackColor = true;
            this.btnWyczyscTb.Click += new System.EventHandler(this.popraw_Click);
            // 
            // btnPotega
            // 
            this.btnPotega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotega.Location = new System.Drawing.Point(273, 151);
            this.btnPotega.Name = "btnPotega";
            this.btnPotega.Size = new System.Drawing.Size(50, 48);
            this.btnPotega.TabIndex = 25;
            this.btnPotega.Text = "x^y";
            this.btnPotega.UseVisualStyleBackColor = true;
            this.btnPotega.Click += new System.EventHandler(this.operator_click);
            // 
            // Kalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(330, 369);
            this.Controls.Add(this.btnPotega);
            this.Controls.Add(this.btnWyczyscTb);
            this.Controls.Add(this.btnWyzeruj);
            this.Controls.Add(this.lbWykonywanaOperacja);
            this.Controls.Add(this.btnSilnia);
            this.Controls.Add(this.btnPrzecinek);
            this.Controls.Add(this.btnProcent);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMnoz);
            this.Controls.Add(this.btnDziel);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.tbWyswietlacz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kalkulator";
            this.Opacity = 0.88D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWyswietlacz;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMnoz;
        private System.Windows.Forms.Button btnDziel;
        private System.Windows.Forms.Button btnProcent;
        private System.Windows.Forms.Button btnPrzecinek;
        private System.Windows.Forms.Button btnSilnia;
        private System.Windows.Forms.Label lbWykonywanaOperacja;
        private System.Windows.Forms.Button btnWyzeruj;
        private System.Windows.Forms.Button btnWyczyscTb;
        private System.Windows.Forms.Button btnPotega;
    }
}

