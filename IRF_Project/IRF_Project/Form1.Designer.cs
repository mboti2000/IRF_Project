
namespace IRF_Project
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.csvButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.carLabel4 = new IRF_Project.CarLabel();
            this.carLabel3 = new IRF_Project.CarLabel();
            this.carLabel2 = new IRF_Project.CarLabel();
            this.carLabel1 = new IRF_Project.CarLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(72, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 280);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1103, 78);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boti Autókereskedés";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // csvButton
            // 
            this.csvButton.BackColor = System.Drawing.Color.DimGray;
            this.csvButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.csvButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.csvButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.csvButton.ForeColor = System.Drawing.Color.White;
            this.csvButton.Location = new System.Drawing.Point(921, 284);
            this.csvButton.Name = "csvButton";
            this.csvButton.Size = new System.Drawing.Size(136, 47);
            this.csvButton.TabIndex = 4;
            this.csvButton.Text = "Terméklista letöltése";
            this.csvButton.UseVisualStyleBackColor = false;
            this.csvButton.Click += new System.EventHandler(this.csvButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(438, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 40);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DimGray;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(582, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "MODELL:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DimGray;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(622, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "ÁR:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(579, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 23);
            this.label8.TabIndex = 12;
            this.label8.Text = "ÉVJÁRAT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DimGray;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(557, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "KATEGÓRIA:";
            // 
            // carLabel4
            // 
            this.carLabel4.AutoSize = true;
            this.carLabel4.BackColor = System.Drawing.Color.Red;
            this.carLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carLabel4.Location = new System.Drawing.Point(719, 318);
            this.carLabel4.Name = "carLabel4";
            this.carLabel4.Size = new System.Drawing.Size(54, 13);
            this.carLabel4.TabIndex = 17;
            this.carLabel4.Text = "carLabel4";
            // 
            // carLabel3
            // 
            this.carLabel3.AutoSize = true;
            this.carLabel3.BackColor = System.Drawing.Color.Red;
            this.carLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carLabel3.Location = new System.Drawing.Point(719, 261);
            this.carLabel3.Name = "carLabel3";
            this.carLabel3.Size = new System.Drawing.Size(54, 13);
            this.carLabel3.TabIndex = 16;
            this.carLabel3.Text = "carLabel3";
            // 
            // carLabel2
            // 
            this.carLabel2.AutoSize = true;
            this.carLabel2.BackColor = System.Drawing.Color.Red;
            this.carLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carLabel2.Location = new System.Drawing.Point(719, 197);
            this.carLabel2.Name = "carLabel2";
            this.carLabel2.Size = new System.Drawing.Size(54, 13);
            this.carLabel2.TabIndex = 15;
            this.carLabel2.Text = "carLabel2";
            // 
            // carLabel1
            // 
            this.carLabel1.AutoSize = true;
            this.carLabel1.BackColor = System.Drawing.Color.Red;
            this.carLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carLabel1.Location = new System.Drawing.Point(719, 130);
            this.carLabel1.Name = "carLabel1";
            this.carLabel1.Size = new System.Drawing.Size(54, 13);
            this.carLabel1.TabIndex = 14;
            this.carLabel1.Text = "carLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1103, 643);
            this.Controls.Add(this.carLabel4);
            this.Controls.Add(this.carLabel3);
            this.Controls.Add(this.carLabel2);
            this.Controls.Add(this.carLabel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.csvButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button csvButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CarLabel carLabel1;
        private CarLabel carLabel2;
        private CarLabel carLabel3;
        private CarLabel carLabel4;
    }
}

