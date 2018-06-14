namespace M9_CalculatorMVP.Forms
{
    partial class CalcForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstArg = new System.Windows.Forms.TextBox();
            this.SecondArg = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.DifferenceBtn = new System.Windows.Forms.Button();
            this.MultiplicationBtn = new System.Windows.Forms.Button();
            this.DevisionBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "First argument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second argument";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // FirstArg
            // 
            this.FirstArg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstArg.Location = new System.Drawing.Point(17, 38);
            this.FirstArg.Name = "FirstArg";
            this.FirstArg.Size = new System.Drawing.Size(179, 32);
            this.FirstArg.TabIndex = 3;
            this.FirstArg.Text = "0";
            this.FirstArg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FirstArg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstArg_KeyPress);
            // 
            // SecondArg
            // 
            this.SecondArg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondArg.Location = new System.Drawing.Point(17, 102);
            this.SecondArg.Name = "SecondArg";
            this.SecondArg.Size = new System.Drawing.Size(179, 32);
            this.SecondArg.TabIndex = 4;
            this.SecondArg.Text = "0";
            this.SecondArg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SecondArg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondArg_KeyPress);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Result.Location = new System.Drawing.Point(17, 166);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(179, 32);
            this.Result.TabIndex = 5;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionBtn.Location = new System.Drawing.Point(231, 12);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(184, 37);
            this.AdditionBtn.TabIndex = 6;
            this.AdditionBtn.Text = "Addition \"+\"";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // DifferenceBtn
            // 
            this.DifferenceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DifferenceBtn.Location = new System.Drawing.Point(231, 62);
            this.DifferenceBtn.Name = "DifferenceBtn";
            this.DifferenceBtn.Size = new System.Drawing.Size(184, 37);
            this.DifferenceBtn.TabIndex = 7;
            this.DifferenceBtn.Text = "Difference \"-\"";
            this.DifferenceBtn.UseVisualStyleBackColor = true;
            this.DifferenceBtn.Click += new System.EventHandler(this.DifferenceBtn_Click);
            // 
            // MultiplicationBtn
            // 
            this.MultiplicationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultiplicationBtn.Location = new System.Drawing.Point(231, 114);
            this.MultiplicationBtn.Name = "MultiplicationBtn";
            this.MultiplicationBtn.Size = new System.Drawing.Size(184, 37);
            this.MultiplicationBtn.TabIndex = 8;
            this.MultiplicationBtn.Text = "Multiplication \"*\"";
            this.MultiplicationBtn.UseVisualStyleBackColor = true;
            this.MultiplicationBtn.Click += new System.EventHandler(this.MultiplicationBtn_Click);
            // 
            // DevisionBtn
            // 
            this.DevisionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevisionBtn.Location = new System.Drawing.Point(231, 163);
            this.DevisionBtn.Name = "DevisionBtn";
            this.DevisionBtn.Size = new System.Drawing.Size(184, 37);
            this.DevisionBtn.TabIndex = 9;
            this.DevisionBtn.Text = "Division \"/\"";
            this.DevisionBtn.UseVisualStyleBackColor = true;
            this.DevisionBtn.Click += new System.EventHandler(this.DevisionBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBtn.Location = new System.Drawing.Point(17, 215);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(398, 37);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 264);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.DevisionBtn);
            this.Controls.Add(this.MultiplicationBtn);
            this.Controls.Add(this.DifferenceBtn);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.SecondArg);
            this.Controls.Add(this.FirstArg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calulator MVP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstArg;
        private System.Windows.Forms.TextBox SecondArg;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button AdditionBtn;
        private System.Windows.Forms.Button DifferenceBtn;
        private System.Windows.Forms.Button MultiplicationBtn;
        private System.Windows.Forms.Button DevisionBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

