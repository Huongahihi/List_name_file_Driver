namespace T
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
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.lbDirectory = new System.Windows.Forms.Label();
            this.lblHien = new System.Windows.Forms.Label();
            this.btnLietKe = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbKeyword = new System.Windows.Forms.TextBox();
            this.lbKeyword = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(14, 62);
            this.tbDirectory.Multiline = true;
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.Size = new System.Drawing.Size(156, 35);
            this.tbDirectory.TabIndex = 0;
            // 
            // lbDirectory
            // 
            this.lbDirectory.AutoSize = true;
            this.lbDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirectory.Location = new System.Drawing.Point(10, 27);
            this.lbDirectory.Name = "lbDirectory";
            this.lbDirectory.Size = new System.Drawing.Size(159, 20);
            this.lbDirectory.TabIndex = 1;
            this.lbDirectory.Text = "Enter file Directory";
            // 
            // lblHien
            // 
            this.lblHien.AutoSize = true;
            this.lblHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHien.Location = new System.Drawing.Point(251, 27);
            this.lblHien.Name = "lblHien";
            this.lblHien.Size = new System.Drawing.Size(77, 20);
            this.lblHien.TabIndex = 3;
            this.lblHien.Text = "List File:";
            // 
            // btnLietKe
            // 
            this.btnLietKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLietKe.Location = new System.Drawing.Point(12, 344);
            this.btnLietKe.Name = "btnLietKe";
            this.btnLietKe.Size = new System.Drawing.Size(99, 52);
            this.btnLietKe.TabIndex = 4;
            this.btnLietKe.Text = "Start";
            this.btnLietKe.UseVisualStyleBackColor = true;
            this.btnLietKe.Click += new System.EventHandler(this.btnLietKe_Click);
            this.btnLietKe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnLietKe_KeyDown);
            this.btnLietKe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLietKe_KeyPress);
            // 
            // lblKQ
            // 
            this.lblKQ.BackColor = System.Drawing.SystemColors.Control;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblKQ.Location = new System.Drawing.Point(12, 258);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(117, 63);
            this.lblKQ.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count File";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(123, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // tbKeyword
            // 
            this.tbKeyword.Location = new System.Drawing.Point(11, 154);
            this.tbKeyword.Multiline = true;
            this.tbKeyword.Name = "tbKeyword";
            this.tbKeyword.Size = new System.Drawing.Size(158, 35);
            this.tbKeyword.TabIndex = 8;
            // 
            // lbKeyword
            // 
            this.lbKeyword.AutoSize = true;
            this.lbKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKeyword.Location = new System.Drawing.Point(11, 119);
            this.lbKeyword.Name = "lbKeyword";
            this.lbKeyword.Size = new System.Drawing.Size(125, 20);
            this.lbKeyword.TabIndex = 9;
            this.lbKeyword.Text = "Enter Keyword";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(246, 62);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(433, 370);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOutput_KeyDown);
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutput_KeyPress);
            this.txtOutput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOutput_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 460);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lbKeyword);
            this.Controls.Add(this.tbKeyword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnLietKe);
            this.Controls.Add(this.lblHien);
            this.Controls.Add(this.lbDirectory);
            this.Controls.Add(this.tbDirectory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Label lbDirectory;
        private System.Windows.Forms.Label lblHien;
        private System.Windows.Forms.Button btnLietKe;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbKeyword;
        private System.Windows.Forms.Label lbKeyword;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

