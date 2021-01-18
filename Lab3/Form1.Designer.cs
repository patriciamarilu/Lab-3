namespace Lab3
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
            this.radius = new System.Windows.Forms.Label();
            this.radiusinput = new System.Windows.Forms.TextBox();
            this.diameter = new System.Windows.Forms.Label();
            this.area = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.diameterinput = new System.Windows.Forms.Label();
            this.areainput = new System.Windows.Forms.Label();
            this.volumeinput = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.picturesphere1 = new System.Windows.Forms.PictureBox();
            this.picturesphere2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturesphere1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesphere2)).BeginInit();
            this.SuspendLayout();
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(297, 83);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(90, 13);
            this.radius.TabIndex = 0;
            this.radius.Text = "Radius of sphere:";
            // 
            // radiusinput
            // 
            this.radiusinput.Location = new System.Drawing.Point(393, 80);
            this.radiusinput.Name = "radiusinput";
            this.radiusinput.Size = new System.Drawing.Size(122, 20);
            this.radiusinput.TabIndex = 1;
            // 
            // diameter
            // 
            this.diameter.AutoSize = true;
            this.diameter.Location = new System.Drawing.Point(57, 260);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(49, 13);
            this.diameter.TabIndex = 2;
            this.diameter.Text = "Diameter";
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(37, 299);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(69, 13);
            this.area.TabIndex = 3;
            this.area.Text = "Surface Area";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Location = new System.Drawing.Point(64, 331);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(42, 13);
            this.volume.TabIndex = 4;
            this.volume.Text = "Volume";
            // 
            // diameterinput
            // 
            this.diameterinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameterinput.Location = new System.Drawing.Point(126, 259);
            this.diameterinput.Name = "diameterinput";
            this.diameterinput.Size = new System.Drawing.Size(70, 18);
            this.diameterinput.TabIndex = 5;
            // 
            // areainput
            // 
            this.areainput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.areainput.Location = new System.Drawing.Point(126, 294);
            this.areainput.Name = "areainput";
            this.areainput.Size = new System.Drawing.Size(70, 18);
            this.areainput.TabIndex = 6;
            // 
            // volumeinput
            // 
            this.volumeinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volumeinput.Location = new System.Drawing.Point(126, 331);
            this.volumeinput.Name = "volumeinput";
            this.volumeinput.Size = new System.Drawing.Size(70, 18);
            this.volumeinput.TabIndex = 7;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(420, 125);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // picturesphere1
            // 
            this.picturesphere1.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.picturesphere1.Location = new System.Drawing.Point(79, 31);
            this.picturesphere1.Name = "picturesphere1";
            this.picturesphere1.Size = new System.Drawing.Size(150, 150);
            this.picturesphere1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturesphere1.TabIndex = 9;
            this.picturesphere1.TabStop = false;
            // 
            // picturesphere2
            // 
            this.picturesphere2.Image = global::Lab3.Properties.Resources.Sphere_and_Ball;
            this.picturesphere2.Location = new System.Drawing.Point(365, 218);
            this.picturesphere2.Name = "picturesphere2";
            this.picturesphere2.Size = new System.Drawing.Size(150, 150);
            this.picturesphere2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturesphere2.TabIndex = 10;
            this.picturesphere2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 402);
            this.Controls.Add(this.picturesphere2);
            this.Controls.Add(this.picturesphere1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.volumeinput);
            this.Controls.Add(this.areainput);
            this.Controls.Add(this.diameterinput);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.area);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.radiusinput);
            this.Controls.Add(this.radius);
            this.Name = "Form1";
            this.Text = "Lab 3";
            ((System.ComponentModel.ISupportInitialize)(this.picturesphere1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturesphere2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radius;
        private System.Windows.Forms.TextBox radiusinput;
        private System.Windows.Forms.Label diameter;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label diameterinput;
        private System.Windows.Forms.Label areainput;
        private System.Windows.Forms.Label volumeinput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.PictureBox picturesphere1;
        private System.Windows.Forms.PictureBox picturesphere2;
    }
}

