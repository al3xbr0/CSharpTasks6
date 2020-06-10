namespace BinCalc
{
    partial class MainForm
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
            this.input = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRes = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonLeftP = new System.Windows.Forms.Button();
            this.buttonRightP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Name = "input";
            this.input.ReadOnly = true;
            this.input.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.input.ShortcutsEnabled = false;
            this.input.Size = new System.Drawing.Size(228, 39);
            this.input.TabIndex = 5;
            this.input.TabStop = false;
            this.input.Text = "0";
            this.input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.input.WordWrap = false;
            this.input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.White;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button0.Location = new System.Drawing.Point(58, 125);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 50);
            this.button0.TabIndex = 0;
            this.button0.TabStop = false;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.ButtonClick);
            this.button0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(144, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonRes
            // 
            this.buttonRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonRes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.buttonRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(252)))));
            this.buttonRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRes.Location = new System.Drawing.Point(12, 231);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(230, 35);
            this.buttonRes.TabIndex = 0;
            this.buttonRes.TabStop = false;
            this.buttonRes.Text = "=";
            this.buttonRes.UseVisualStyleBackColor = false;
            this.buttonRes.Click += new System.EventHandler(this.ButtonClick);
            this.buttonRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.White;
            this.buttonC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonC.Location = new System.Drawing.Point(12, 57);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(96, 40);
            this.buttonC.TabIndex = 0;
            this.buttonC.TabStop = false;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.ButtonClick);
            this.buttonC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.Color.White;
            this.buttonDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDel.Location = new System.Drawing.Point(189, 67);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(53, 40);
            this.buttonDel.TabIndex = 0;
            this.buttonDel.TabStop = false;
            this.buttonDel.Text = "⌫";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.ButtonClick);
            this.buttonDel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.White;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlus.Location = new System.Drawing.Point(12, 190);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(53, 35);
            this.buttonPlus.TabIndex = 0;
            this.buttonPlus.TabStop = false;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.ButtonClick);
            this.buttonPlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.White;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMinus.Location = new System.Drawing.Point(71, 190);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(53, 35);
            this.buttonMinus.TabIndex = 0;
            this.buttonMinus.TabStop = false;
            this.buttonMinus.Text = "−";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.ButtonClick);
            this.buttonMinus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.White;
            this.buttonMult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMult.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonMult.Location = new System.Drawing.Point(130, 190);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(53, 35);
            this.buttonMult.TabIndex = 0;
            this.buttonMult.TabStop = false;
            this.buttonMult.Text = "×";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.ButtonClick);
            this.buttonMult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.White;
            this.buttonDiv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiv.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDiv.Location = new System.Drawing.Point(189, 190);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(53, 35);
            this.buttonDiv.TabIndex = 0;
            this.buttonDiv.TabStop = false;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.ButtonClick);
            this.buttonDiv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonLeftP
            // 
            this.buttonLeftP.BackColor = System.Drawing.Color.White;
            this.buttonLeftP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonLeftP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonLeftP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonLeftP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLeftP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLeftP.Location = new System.Drawing.Point(12, 125);
            this.buttonLeftP.Name = "buttonLeftP";
            this.buttonLeftP.Size = new System.Drawing.Size(40, 50);
            this.buttonLeftP.TabIndex = 0;
            this.buttonLeftP.TabStop = false;
            this.buttonLeftP.Text = "(";
            this.buttonLeftP.UseVisualStyleBackColor = false;
            this.buttonLeftP.Click += new System.EventHandler(this.ButtonClick);
            this.buttonLeftP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // buttonRightP
            // 
            this.buttonRightP.BackColor = System.Drawing.Color.White;
            this.buttonRightP.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonRightP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.buttonRightP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRightP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRightP.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRightP.Location = new System.Drawing.Point(200, 125);
            this.buttonRightP.Name = "buttonRightP";
            this.buttonRightP.Size = new System.Drawing.Size(40, 50);
            this.buttonRightP.TabIndex = 0;
            this.buttonRightP.TabStop = false;
            this.buttonRightP.Text = ")";
            this.buttonRightP.UseVisualStyleBackColor = false;
            this.buttonRightP.Click += new System.EventHandler(this.ButtonClick);
            this.buttonRightP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            // 
            // MainForm
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(252, 273);
            this.Controls.Add(this.buttonRightP);
            this.Controls.Add(this.buttonLeftP);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.input);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BinCalc";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonLeftP;
        private System.Windows.Forms.Button buttonRightP;
    }
}

