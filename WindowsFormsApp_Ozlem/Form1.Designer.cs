namespace WindowsFormsApp_Ozlem
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
            this.but_line = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.but_rect = new System.Windows.Forms.Button();
            this.but_ellipse = new System.Windows.Forms.Button();
            this.but_eraser = new System.Windows.Forms.Button();
            this.but_color = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // but_line
            // 
            this.but_line.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_line.ForeColor = System.Drawing.SystemColors.ControlText;
            this.but_line.Image = global::WindowsFormsApp_Ozlem.Properties.Resources.line;
            this.but_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_line.Location = new System.Drawing.Point(21, 15);
            this.but_line.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_line.Name = "but_line";
            this.but_line.Size = new System.Drawing.Size(136, 81);
            this.but_line.TabIndex = 0;
            this.but_line.Text = "Line";
            this.but_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_line.UseVisualStyleBackColor = false;
            this.but_line.Click += new System.EventHandler(this.but_line_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.Location = new System.Drawing.Point(16, 148);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1133, 644);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Iclal Ozlem Akgul 64641";
            // 
            // but_rect
            // 
            this.but_rect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_rect.Image = global::WindowsFormsApp_Ozlem.Properties.Resources.rectangle;
            this.but_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_rect.Location = new System.Drawing.Point(176, 15);
            this.but_rect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_rect.Name = "but_rect";
            this.but_rect.Size = new System.Drawing.Size(136, 81);
            this.but_rect.TabIndex = 4;
            this.but_rect.Text = "Rectangle";
            this.but_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_rect.UseVisualStyleBackColor = false;
            this.but_rect.Click += new System.EventHandler(this.but_rect_Click);
            // 
            // but_ellipse
            // 
            this.but_ellipse.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ellipse.Image = global::WindowsFormsApp_Ozlem.Properties.Resources.circle;
            this.but_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_ellipse.Location = new System.Drawing.Point(332, 15);
            this.but_ellipse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_ellipse.Name = "but_ellipse";
            this.but_ellipse.Size = new System.Drawing.Size(136, 80);
            this.but_ellipse.TabIndex = 5;
            this.but_ellipse.Text = "Ellipse";
            this.but_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_ellipse.UseVisualStyleBackColor = false;
            this.but_ellipse.Click += new System.EventHandler(this.but_ellipse_Click);
            // 
            // but_eraser
            // 
            this.but_eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.but_eraser.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eraser.Location = new System.Drawing.Point(1008, 304);
            this.but_eraser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_eraser.Name = "but_eraser";
            this.but_eraser.Size = new System.Drawing.Size(121, 46);
            this.but_eraser.TabIndex = 6;
            this.but_eraser.Text = "Eraser";
            this.but_eraser.UseVisualStyleBackColor = false;
            this.but_eraser.Click += new System.EventHandler(this.but_eraser_Click);
            // 
            // but_color
            // 
            this.but_color.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.but_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_color.Image = global::WindowsFormsApp_Ozlem.Properties.Resources.color;
            this.but_color.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.but_color.Location = new System.Drawing.Point(492, 16);
            this.but_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.but_color.Name = "but_color";
            this.but_color.Size = new System.Drawing.Size(136, 80);
            this.but_color.TabIndex = 7;
            this.but_color.Text = "Color";
            this.but_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.but_color.UseVisualStyleBackColor = false;
            this.but_color.Click += new System.EventHandler(this.but_color_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.clear.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1013, 14);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(136, 81);
            this.clear.TabIndex = 8;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pencil.Location = new System.Drawing.Point(1008, 239);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(121, 46);
            this.btn_pencil.TabIndex = 9;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1165, 804);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.but_color);
            this.Controls.Add(this.but_ellipse);
            this.Controls.Add(this.but_rect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.but_line);
            this.Controls.Add(this.but_eraser);
            this.Controls.Add(this.btn_pencil);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Ozlem s Draw Table";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_line;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_rect;
        private System.Windows.Forms.Button but_ellipse;
        private System.Windows.Forms.Button but_eraser;
        private System.Windows.Forms.Button but_color;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btn_pencil;
    }
}

