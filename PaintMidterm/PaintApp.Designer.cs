namespace PaintMidterm
{
    partial class PaintApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLineSize = new System.Windows.Forms.TrackBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ptb_Exit = new System.Windows.Forms.PictureBox();
            this.ptbDrawing = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnBezier = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btnEditColor = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnUnGroup = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDrawing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLineSize);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnBezier);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnEditColor);
            this.panel1.Controls.Add(this.btnFill);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPen);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnGroup);
            this.panel1.Controls.Add(this.btnUnGroup);
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1326, 127);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1155, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Size";
            // 
            // btnLineSize
            // 
            this.btnLineSize.Location = new System.Drawing.Point(1083, 47);
            this.btnLineSize.Maximum = 20;
            this.btnLineSize.Name = "btnLineSize";
            this.btnLineSize.Size = new System.Drawing.Size(240, 45);
            this.btnLineSize.TabIndex = 24;
            this.btnLineSize.Scroll += new System.EventHandler(this.btnLineSize_Scroll);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor.Location = new System.Drawing.Point(420, 35);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(57, 57);
            this.btnColor.TabIndex = 17;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Orator Std", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 767);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nguyen Thanh Thien 19110150";
            // 
            // ptb_Exit
            // 
            this.ptb_Exit.Image = global::PaintMidterm.Properties.Resources.x1;
            this.ptb_Exit.Location = new System.Drawing.Point(1312, 2);
            this.ptb_Exit.Name = "ptb_Exit";
            this.ptb_Exit.Size = new System.Drawing.Size(36, 36);
            this.ptb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Exit.TabIndex = 6;
            this.ptb_Exit.TabStop = false;
            this.ptb_Exit.Click += new System.EventHandler(this.ptb_Exit_Click);
            // 
            // ptbDrawing
            // 
            this.ptbDrawing.BackColor = System.Drawing.Color.White;
            this.ptbDrawing.Location = new System.Drawing.Point(12, 174);
            this.ptbDrawing.Name = "ptbDrawing";
            this.ptbDrawing.Size = new System.Drawing.Size(1326, 590);
            this.ptbDrawing.TabIndex = 5;
            this.ptbDrawing.TabStop = false;
            this.ptbDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.ptbDrawing_Paint);
            this.ptbDrawing.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseClick);
            this.ptbDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseDown);
            this.ptbDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseMove);
            this.ptbDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ptbDrawing_MouseUp);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Image = global::PaintMidterm.Properties.Resources.cleaning;
            this.btnClear.Location = new System.Drawing.Point(1020, 66);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 57);
            this.btnClear.TabIndex = 26;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Image = global::PaintMidterm.Properties.Resources.icons8_oval_30;
            this.btnEllipse.Location = new System.Drawing.Point(1020, 3);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(57, 57);
            this.btnEllipse.TabIndex = 23;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Image = global::PaintMidterm.Properties.Resources.icons8_rectangular_30;
            this.btnRectangle.Location = new System.Drawing.Point(957, 3);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(57, 57);
            this.btnRectangle.TabIndex = 21;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnBezier
            // 
            this.btnBezier.BackColor = System.Drawing.Color.Transparent;
            this.btnBezier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBezier.Image = global::PaintMidterm.Properties.Resources.bezier;
            this.btnBezier.Location = new System.Drawing.Point(957, 66);
            this.btnBezier.Name = "btnBezier";
            this.btnBezier.Size = new System.Drawing.Size(57, 57);
            this.btnBezier.TabIndex = 22;
            this.btnBezier.UseVisualStyleBackColor = false;
            this.btnBezier.Click += new System.EventHandler(this.btnBezier_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Image = global::PaintMidterm.Properties.Resources.icons8_line_30;
            this.btnLine.Location = new System.Drawing.Point(894, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(57, 57);
            this.btnLine.TabIndex = 19;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackColor = System.Drawing.Color.Transparent;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Image = global::PaintMidterm.Properties.Resources.icons8_polygon_30;
            this.btnPolygon.Location = new System.Drawing.Point(894, 66);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(57, 57);
            this.btnPolygon.TabIndex = 20;
            this.btnPolygon.UseVisualStyleBackColor = false;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // color_picker
            // 
            this.color_picker.Image = global::PaintMidterm.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(483, 3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(380, 120);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 18;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btnEditColor
            // 
            this.btnEditColor.BackColor = System.Drawing.Color.Transparent;
            this.btnEditColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditColor.Image = global::PaintMidterm.Properties.Resources.paint;
            this.btnEditColor.Location = new System.Drawing.Point(357, 35);
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(57, 57);
            this.btnEditColor.TabIndex = 16;
            this.btnEditColor.UseVisualStyleBackColor = false;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.Image = global::PaintMidterm.Properties.Resources.paint_bucket;
            this.btnFill.Location = new System.Drawing.Point(294, 3);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(57, 57);
            this.btnFill.TabIndex = 14;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Image = global::PaintMidterm.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(294, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 57);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.Transparent;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.Image = global::PaintMidterm.Properties.Resources.pencil1;
            this.btnPen.Location = new System.Drawing.Point(231, 3);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(57, 57);
            this.btnPen.TabIndex = 12;
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Transparent;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEraser.Image = global::PaintMidterm.Properties.Resources.eraser;
            this.btnEraser.Location = new System.Drawing.Point(231, 66);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(57, 57);
            this.btnEraser.TabIndex = 13;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGroup.Image = global::PaintMidterm.Properties.Resources._object;
            this.btnGroup.Location = new System.Drawing.Point(150, 3);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(57, 57);
            this.btnGroup.TabIndex = 10;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnUnGroup
            // 
            this.btnUnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnUnGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUnGroup.Image = global::PaintMidterm.Properties.Resources.ungroup;
            this.btnUnGroup.Location = new System.Drawing.Point(150, 66);
            this.btnUnGroup.Name = "btnUnGroup";
            this.btnUnGroup.Size = new System.Drawing.Size(57, 57);
            this.btnUnGroup.TabIndex = 11;
            this.btnUnGroup.UseVisualStyleBackColor = false;
            this.btnUnGroup.Click += new System.EventHandler(this.btnUnGroup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Image = global::PaintMidterm.Properties.Resources.selection;
            this.btnSelect.Location = new System.Drawing.Point(87, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(57, 57);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.Image = global::PaintMidterm.Properties.Resources.folder;
            this.btnOpen.Location = new System.Drawing.Point(87, 66);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(57, 57);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Image = global::PaintMidterm.Properties.Resources.add_file;
            this.btnNew.Location = new System.Drawing.Point(24, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 57);
            this.btnNew.TabIndex = 6;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Image = global::PaintMidterm.Properties.Resources.diskette;
            this.btnSave.Location = new System.Drawing.Point(24, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(57, 57);
            this.btnSave.TabIndex = 7;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Orator Std", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paint Application Midterm Project";
            // 
            // PaintApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 793);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbDrawing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ptb_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PaintApp";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PaintApp_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbDrawing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUnGroup;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnBezier;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar btnLineSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox ptbDrawing;
        private System.Windows.Forms.PictureBox ptb_Exit;
        private System.Windows.Forms.Label label2;
    }
}

