namespace paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.line_b = new System.Windows.Forms.RadioButton();
            this.triangle_b = new System.Windows.Forms.RadioButton();
            this.elastic_b = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fill_b = new System.Windows.Forms.RadioButton();
            this.circle_b = new System.Windows.Forms.RadioButton();
            this.rectangle_b = new System.Windows.Forms.RadioButton();
            this.pen_b = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naxteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marcker_b = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.marcker_b);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.line_b);
            this.groupBox1.Controls.Add(this.triangle_b);
            this.groupBox1.Controls.Add(this.elastic_b);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fill_b);
            this.groupBox1.Controls.Add(this.circle_b);
            this.groupBox1.Controls.Add(this.rectangle_b);
            this.groupBox1.Controls.Add(this.pen_b);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 607);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Width border / line";
            // 
            // line_b
            // 
            this.line_b.AutoSize = true;
            this.line_b.Location = new System.Drawing.Point(9, 225);
            this.line_b.Name = "line_b";
            this.line_b.Size = new System.Drawing.Size(45, 17);
            this.line_b.TabIndex = 11;
            this.line_b.TabStop = true;
            this.line_b.Text = "Line";
            this.line_b.UseVisualStyleBackColor = true;
            // 
            // triangle_b
            // 
            this.triangle_b.AutoSize = true;
            this.triangle_b.Location = new System.Drawing.Point(9, 319);
            this.triangle_b.Name = "triangle_b";
            this.triangle_b.Size = new System.Drawing.Size(63, 17);
            this.triangle_b.TabIndex = 10;
            this.triangle_b.TabStop = true;
            this.triangle_b.Text = "Triangle";
            this.triangle_b.UseVisualStyleBackColor = true;
            // 
            // elastic_b
            // 
            this.elastic_b.AutoSize = true;
            this.elastic_b.Location = new System.Drawing.Point(9, 423);
            this.elastic_b.Name = "elastic_b";
            this.elastic_b.Size = new System.Drawing.Size(56, 17);
            this.elastic_b.TabIndex = 9;
            this.elastic_b.TabStop = true;
            this.elastic_b.Text = "Elastic";
            this.elastic_b.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // fill_b
            // 
            this.fill_b.AutoSize = true;
            this.fill_b.Location = new System.Drawing.Point(9, 400);
            this.fill_b.Name = "fill_b";
            this.fill_b.Size = new System.Drawing.Size(37, 17);
            this.fill_b.TabIndex = 7;
            this.fill_b.TabStop = true;
            this.fill_b.Text = "Fill";
            this.fill_b.UseVisualStyleBackColor = true;
            // 
            // circle_b
            // 
            this.circle_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle_b.Location = new System.Drawing.Point(9, 279);
            this.circle_b.Name = "circle_b";
            this.circle_b.Size = new System.Drawing.Size(58, 34);
            this.circle_b.TabIndex = 6;
            this.circle_b.Text = "Сircle";
            this.circle_b.UseVisualStyleBackColor = true;
            // 
            // rectangle_b
            // 
            this.rectangle_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle_b.Location = new System.Drawing.Point(9, 248);
            this.rectangle_b.Name = "rectangle_b";
            this.rectangle_b.Size = new System.Drawing.Size(81, 34);
            this.rectangle_b.TabIndex = 5;
            this.rectangle_b.Text = "Rectangle";
            this.rectangle_b.UseVisualStyleBackColor = true;
            // 
            // pen_b
            // 
            this.pen_b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pen_b.Checked = true;
            this.pen_b.Location = new System.Drawing.Point(9, 186);
            this.pen_b.Name = "pen_b";
            this.pen_b.Size = new System.Drawing.Size(56, 33);
            this.pen_b.TabIndex = 4;
            this.pen_b.TabStop = true;
            this.pen_b.Text = "Pen";
            this.pen_b.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(6, 59);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(90, 21);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Location = new System.Drawing.Point(12, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 21);
            this.panel2.TabIndex = 0;
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.createToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.backToolStripMenuItem,
            this.naxteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.createToolStripMenuItem.Text = "Create new";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.backToolStripMenuItem.Text = "Previous";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // naxteToolStripMenuItem
            // 
            this.naxteToolStripMenuItem.Name = "naxteToolStripMenuItem";
            this.naxteToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.naxteToolStripMenuItem.Text = "Next";
            this.naxteToolStripMenuItem.Click += new System.EventHandler(this.naxteToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(123, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 602);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(924, 588);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // marcker_b
            // 
            this.marcker_b.AutoSize = true;
            this.marcker_b.Location = new System.Drawing.Point(9, 163);
            this.marcker_b.Name = "marcker_b";
            this.marcker_b.Size = new System.Drawing.Size(58, 17);
            this.marcker_b.TabIndex = 13;
            this.marcker_b.TabStop = true;
            this.marcker_b.Text = "Marker";
            this.marcker_b.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1063, 631);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Paint";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton rectangle_b;
        private System.Windows.Forms.RadioButton pen_b;
        private System.Windows.Forms.RadioButton circle_b;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naxteToolStripMenuItem;
        private System.Windows.Forms.RadioButton fill_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton elastic_b;
        private System.Windows.Forms.RadioButton triangle_b;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.RadioButton line_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton marcker_b;
    }
}

