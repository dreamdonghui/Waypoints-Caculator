namespace Waypoints
{
    partial class GPSTOUTM
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
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.buttonCaculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelLat = new System.Windows.Forms.Label();
            this.labelLong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(65, 18);
            this.textBoxLat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(242, 28);
            this.textBoxLat.TabIndex = 0;
            // 
            // textBoxLong
            // 
            this.textBoxLong.Location = new System.Drawing.Point(65, 58);
            this.textBoxLong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(242, 28);
            this.textBoxLong.TabIndex = 1;
            // 
            // buttonCaculate
            // 
            this.buttonCaculate.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCaculate.Location = new System.Drawing.Point(6, 99);
            this.buttonCaculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCaculate.Name = "buttonCaculate";
            this.buttonCaculate.Size = new System.Drawing.Size(303, 88);
            this.buttonCaculate.TabIndex = 2;
            this.buttonCaculate.Text = "Caculate";
            this.buttonCaculate.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 237);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 28);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 196);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 28);
            this.textBox2.TabIndex = 3;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(6, 278);
            this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(303, 34);
            this.buttonCopy.TabIndex = 5;
            this.buttonCopy.Text = "Copy To Clip";
            this.buttonCopy.UseVisualStyleBackColor = true;
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(21, 21);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(44, 18);
            this.labelLat.TabIndex = 6;
            this.labelLat.Text = "Lat:";
            // 
            // labelLong
            // 
            this.labelLong.AutoSize = true;
            this.labelLong.BackColor = System.Drawing.Color.Transparent;
            this.labelLong.Location = new System.Drawing.Point(12, 61);
            this.labelLong.Name = "labelLong";
            this.labelLong.Size = new System.Drawing.Size(53, 18);
            this.labelLong.TabIndex = 7;
            this.labelLong.Text = "Long:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Long:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lat:";
            // 
            // GPSTOUTM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelLong);
            this.Controls.Add(this.labelLat);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonCaculate);
            this.Controls.Add(this.textBoxLong);
            this.Controls.Add(this.textBoxLat);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GPSTOUTM";
            this.Text = "GPS To UTM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLat;
        private System.Windows.Forms.TextBox textBoxLong;
        private System.Windows.Forms.Button buttonCaculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelLat;
        private System.Windows.Forms.Label labelLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}