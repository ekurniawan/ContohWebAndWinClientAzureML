namespace WindowsFormsClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSepalLength = new System.Windows.Forms.TextBox();
            this.txtSepalWidth = new System.Windows.Forms.TextBox();
            this.txtPetalLength = new System.Windows.Forms.TextBox();
            this.txtPetalWidth = new System.Windows.Forms.TextBox();
            this.txtScored = new System.Windows.Forms.TextBox();
            this.txtScoredProbabilities = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sepal Length :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sepal Width :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Petal Length :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Petal Width :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Scored Labels :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Scored Probabilities :";
            // 
            // txtSepalLength
            // 
            this.txtSepalLength.Location = new System.Drawing.Point(237, 19);
            this.txtSepalLength.Name = "txtSepalLength";
            this.txtSepalLength.Size = new System.Drawing.Size(100, 20);
            this.txtSepalLength.TabIndex = 6;
            // 
            // txtSepalWidth
            // 
            this.txtSepalWidth.Location = new System.Drawing.Point(237, 56);
            this.txtSepalWidth.Name = "txtSepalWidth";
            this.txtSepalWidth.Size = new System.Drawing.Size(100, 20);
            this.txtSepalWidth.TabIndex = 7;
            // 
            // txtPetalLength
            // 
            this.txtPetalLength.Location = new System.Drawing.Point(237, 95);
            this.txtPetalLength.Name = "txtPetalLength";
            this.txtPetalLength.Size = new System.Drawing.Size(100, 20);
            this.txtPetalLength.TabIndex = 8;
            // 
            // txtPetalWidth
            // 
            this.txtPetalWidth.Location = new System.Drawing.Point(237, 134);
            this.txtPetalWidth.Name = "txtPetalWidth";
            this.txtPetalWidth.Size = new System.Drawing.Size(100, 20);
            this.txtPetalWidth.TabIndex = 9;
            // 
            // txtScored
            // 
            this.txtScored.Location = new System.Drawing.Point(237, 173);
            this.txtScored.Name = "txtScored";
            this.txtScored.Size = new System.Drawing.Size(100, 20);
            this.txtScored.TabIndex = 10;
            // 
            // txtScoredProbabilities
            // 
            this.txtScoredProbabilities.Location = new System.Drawing.Point(237, 212);
            this.txtScoredProbabilities.Name = "txtScoredProbabilities";
            this.txtScoredProbabilities.Size = new System.Drawing.Size(100, 20);
            this.txtScoredProbabilities.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(237, 250);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScoredProbabilities);
            this.Controls.Add(this.txtScored);
            this.Controls.Add(this.txtPetalWidth);
            this.Controls.Add(this.txtPetalLength);
            this.Controls.Add(this.txtSepalWidth);
            this.Controls.Add(this.txtSepalLength);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSepalLength;
        private System.Windows.Forms.TextBox txtSepalWidth;
        private System.Windows.Forms.TextBox txtPetalLength;
        private System.Windows.Forms.TextBox txtPetalWidth;
        private System.Windows.Forms.TextBox txtScored;
        private System.Windows.Forms.TextBox txtScoredProbabilities;
        private System.Windows.Forms.Button btnSubmit;
    }
}

