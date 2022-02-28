
namespace Drawing_app
{
    partial class WhiteBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteBoard));
            this.topPanel = new System.Windows.Forms.Panel();
            this.btnBrush = new System.Windows.Forms.PictureBox();
            this.btnEraser = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.paintbrushSize = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.canvasPanel = new System.Windows.Forms.Panel();
            this.hidePictureBox = new System.Windows.Forms.PictureBox();
            this.showPictureBox = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrushSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.canvasPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.topPanel.Controls.Add(this.btnBrush);
            this.topPanel.Controls.Add(this.btnEraser);
            this.topPanel.Controls.Add(this.btnMinimize);
            this.topPanel.Controls.Add(this.paintbrushSize);
            this.topPanel.Controls.Add(this.btnExit);
            this.topPanel.Controls.Add(this.btnClear);
            this.topPanel.Controls.Add(this.btnSave);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1121, 40);
            this.topPanel.TabIndex = 0;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanelMouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanelMouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanelMouseUp);
            // 
            // btnBrush
            // 
            this.btnBrush.Image = ((System.Drawing.Image)(resources.GetObject("btnBrush.Image")));
            this.btnBrush.Location = new System.Drawing.Point(291, 0);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(46, 41);
            this.btnBrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBrush.TabIndex = 0;
            this.btnBrush.TabStop = false;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.Location = new System.Drawing.Point(343, 0);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(40, 34);
            this.btnEraser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEraser.TabIndex = 1;
            this.btnEraser.TabStop = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(156)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Location = new System.Drawing.Point(1099, -2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(10, 41);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // paintbrushSize
            // 
            this.paintbrushSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(224)))), ((int)(((byte)(198)))));
            this.paintbrushSize.Cursor = System.Windows.Forms.Cursors.Default;
            this.paintbrushSize.Location = new System.Drawing.Point(389, 9);
            this.paintbrushSize.Name = "paintbrushSize";
            this.paintbrushSize.Size = new System.Drawing.Size(40, 20);
            this.paintbrushSize.TabIndex = 2;
            this.paintbrushSize.ValueChanged += new System.EventHandler(this.paintbrushSizeChange);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1113, -2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(10, 48);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(210, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear board";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(129, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(44, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "WhiteBoard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // canvasPanel
            // 
            this.canvasPanel.AutoSize = true;
            this.canvasPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canvasPanel.Controls.Add(this.hidePictureBox);
            this.canvasPanel.Controls.Add(this.showPictureBox);
            this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasPanel.Location = new System.Drawing.Point(0, 40);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(1121, 490);
            this.canvasPanel.TabIndex = 1;
            this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
            this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasMouseDown);
            this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasMouseMove);
            // 
            // hidePictureBox
            // 
            this.hidePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hidePictureBox.Image")));
            this.hidePictureBox.Location = new System.Drawing.Point(5, 3);
            this.hidePictureBox.Name = "hidePictureBox";
            this.hidePictureBox.Size = new System.Drawing.Size(22, 23);
            this.hidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePictureBox.TabIndex = 1;
            this.hidePictureBox.TabStop = false;
            this.hidePictureBox.Click += new System.EventHandler(this.hidePictureBox_Click);
            // 
            // showPictureBox
            // 
            this.showPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("showPictureBox.Image")));
            this.showPictureBox.Location = new System.Drawing.Point(5, 3);
            this.showPictureBox.Name = "showPictureBox";
            this.showPictureBox.Size = new System.Drawing.Size(22, 23);
            this.showPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showPictureBox.TabIndex = 0;
            this.showPictureBox.TabStop = false;
            this.showPictureBox.Visible = false;
            this.showPictureBox.Click += new System.EventHandler(this.showPictureBox_Click);
            // 
            // WhiteBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1121, 530);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhiteBoard";
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEraser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paintbrushSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.canvasPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.PictureBox btnBrush;
        private System.Windows.Forms.PictureBox btnEraser;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.NumericUpDown paintbrushSize;
        private System.Windows.Forms.PictureBox hidePictureBox;
        private System.Windows.Forms.PictureBox showPictureBox;
    }
}

