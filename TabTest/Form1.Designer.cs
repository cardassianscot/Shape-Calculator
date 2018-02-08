namespace TabTest
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cone = new System.Windows.Forms.TabPage();
            this.Sphere = new System.Windows.Forms.TabPage();
            this.Cube = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Cone.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cone);
            this.tabControl1.Controls.Add(this.Sphere);
            this.tabControl1.Controls.Add(this.Cube);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1542, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // Cone
            // 
            this.Cone.Controls.Add(this.label4);
            this.Cone.Controls.Add(this.label3);
            this.Cone.Controls.Add(this.label2);
            this.Cone.Controls.Add(this.label1);
            this.Cone.Controls.Add(this.textBox2);
            this.Cone.Controls.Add(this.textBox1);
            this.Cone.ImageIndex = 0;
            this.Cone.Location = new System.Drawing.Point(10, 62);
            this.Cone.Name = "Cone";
            this.Cone.Padding = new System.Windows.Forms.Padding(3);
            this.Cone.Size = new System.Drawing.Size(1522, 570);
            this.Cone.TabIndex = 0;
            this.Cone.Text = "Cone";
            this.Cone.UseVisualStyleBackColor = true;
            // 
            // Sphere
            // 
            this.Sphere.ImageIndex = 2;
            this.Sphere.Location = new System.Drawing.Point(10, 62);
            this.Sphere.Name = "Sphere";
            this.Sphere.Padding = new System.Windows.Forms.Padding(3);
            this.Sphere.Size = new System.Drawing.Size(1522, 570);
            this.Sphere.TabIndex = 1;
            this.Sphere.Text = "Sphere";
            this.Sphere.UseVisualStyleBackColor = true;
            // 
            // Cube
            // 
            this.Cube.ImageIndex = 1;
            this.Cube.Location = new System.Drawing.Point(10, 62);
            this.Cube.Name = "Cube";
            this.Cube.Padding = new System.Windows.Forms.Padding(3);
            this.Cube.Size = new System.Drawing.Size(1522, 570);
            this.Cube.TabIndex = 2;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "conebnw.jpg");
            this.imageList1.Images.SetKeyName(1, "cube.jpg");
            this.imageList1.Images.SetKeyName(2, "sphere.png");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 38);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Volume =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 642);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Cone.ResumeLayout(false);
            this.Cone.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cone;
        private System.Windows.Forms.TabPage Sphere;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage Cube;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

