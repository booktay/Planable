namespace Planable
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.pbBg = new System.Windows.Forms.PictureBox();
            this.timeBg = new System.Windows.Forms.Timer(this.components);
            this.pbPlay3 = new System.Windows.Forms.PictureBox();
            this.pbPlay2 = new System.Windows.Forms.PictureBox();
            this.pbPlay1 = new System.Windows.Forms.PictureBox();
            this.timePlay1 = new System.Windows.Forms.Timer(this.components);
            this.timePlay2 = new System.Windows.Forms.Timer(this.components);
            this.timePlay3 = new System.Windows.Forms.Timer(this.components);
            this.mlP = new MaterialSkin.Controls.MaterialLabel();
            this.pbFlag = new System.Windows.Forms.PictureBox();
            this.bStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.timeRace = new System.Windows.Forms.Timer(this.components);
            this.cbPl2 = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbPl3 = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbPl1 = new MaterialSkin.Controls.MaterialCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBg
            // 
            this.pbBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBg.Image = global::Planable.Properties.Resources.bg;
            this.pbBg.Location = new System.Drawing.Point(0, 63);
            this.pbBg.Name = "pbBg";
            this.pbBg.Size = new System.Drawing.Size(1144, 368);
            this.pbBg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBg.TabIndex = 0;
            this.pbBg.TabStop = false;
            // 
            // timeBg
            // 
            this.timeBg.Enabled = true;
            this.timeBg.Interval = 600;
            this.timeBg.Tick += new System.EventHandler(this.timeBg_Tick);
            // 
            // pbPlay3
            // 
            this.pbPlay3.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlay3.Image = global::Planable.Properties.Resources.plane1;
            this.pbPlay3.Location = new System.Drawing.Point(12, 176);
            this.pbPlay3.Name = "pbPlay3";
            this.pbPlay3.Size = new System.Drawing.Size(90, 90);
            this.pbPlay3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay3.TabIndex = 1;
            this.pbPlay3.TabStop = false;
            // 
            // pbPlay2
            // 
            this.pbPlay2.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlay2.Image = global::Planable.Properties.Resources.plane1;
            this.pbPlay2.Location = new System.Drawing.Point(12, 100);
            this.pbPlay2.Name = "pbPlay2";
            this.pbPlay2.Size = new System.Drawing.Size(90, 90);
            this.pbPlay2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay2.TabIndex = 2;
            this.pbPlay2.TabStop = false;
            // 
            // pbPlay1
            // 
            this.pbPlay1.BackColor = System.Drawing.Color.Transparent;
            this.pbPlay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPlay1.Image = global::Planable.Properties.Resources.plane1;
            this.pbPlay1.Location = new System.Drawing.Point(12, 27);
            this.pbPlay1.Name = "pbPlay1";
            this.pbPlay1.Size = new System.Drawing.Size(90, 90);
            this.pbPlay1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlay1.TabIndex = 3;
            this.pbPlay1.TabStop = false;
            // 
            // timePlay1
            // 
            this.timePlay1.Enabled = true;
            this.timePlay1.Interval = 200;
            this.timePlay1.Tick += new System.EventHandler(this.timePlay1_Tick);
            // 
            // timePlay2
            // 
            this.timePlay2.Enabled = true;
            this.timePlay2.Interval = 250;
            this.timePlay2.Tick += new System.EventHandler(this.timePlay2_Tick);
            // 
            // timePlay3
            // 
            this.timePlay3.Enabled = true;
            this.timePlay3.Interval = 300;
            this.timePlay3.Tick += new System.EventHandler(this.timePlay3_Tick);
            // 
            // mlP
            // 
            this.mlP.BackColor = System.Drawing.Color.Transparent;
            this.mlP.Depth = 0;
            this.mlP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mlP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mlP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlP.Location = new System.Drawing.Point(472, 436);
            this.mlP.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlP.Name = "mlP";
            this.mlP.Size = new System.Drawing.Size(377, 29);
            this.mlP.TabIndex = 4;
            this.mlP.Text = "Plane State";
            this.mlP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFlag
            // 
            this.pbFlag.BackColor = System.Drawing.Color.Transparent;
            this.pbFlag.Image = global::Planable.Properties.Resources.flag;
            this.pbFlag.Location = new System.Drawing.Point(1059, 275);
            this.pbFlag.Name = "pbFlag";
            this.pbFlag.Size = new System.Drawing.Size(85, 81);
            this.pbFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFlag.TabIndex = 5;
            this.pbFlag.TabStop = false;
            // 
            // bStart
            // 
            this.bStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bStart.BackColor = System.Drawing.SystemColors.HighlightText;
            this.bStart.Depth = 0;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bStart.ForeColor = System.Drawing.Color.Transparent;
            this.bStart.Location = new System.Drawing.Point(19, 434);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.bStart.Name = "bStart";
            this.bStart.Primary = true;
            this.bStart.Size = new System.Drawing.Size(90, 40);
            this.bStart.TabIndex = 6;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timeRace
            // 
            this.timeRace.Tick += new System.EventHandler(this.timeRace_Tick);
            // 
            // cbPl2
            // 
            this.cbPl2.BackColor = System.Drawing.Color.Transparent;
            this.cbPl2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPl2.Checked = true;
            this.cbPl2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPl2.Depth = 0;
            this.cbPl2.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPl2.Location = new System.Drawing.Point(219, 431);
            this.cbPl2.Margin = new System.Windows.Forms.Padding(0);
            this.cbPl2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPl2.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPl2.Name = "cbPl2";
            this.cbPl2.Ripple = true;
            this.cbPl2.Size = new System.Drawing.Size(97, 40);
            this.cbPl2.TabIndex = 9;
            this.cbPl2.Text = "Com 2";
            this.cbPl2.UseVisualStyleBackColor = false;
            // 
            // cbPl3
            // 
            this.cbPl3.BackColor = System.Drawing.Color.Transparent;
            this.cbPl3.Checked = true;
            this.cbPl3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPl3.Depth = 0;
            this.cbPl3.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPl3.Location = new System.Drawing.Point(324, 431);
            this.cbPl3.Margin = new System.Windows.Forms.Padding(0);
            this.cbPl3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPl3.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPl3.Name = "cbPl3";
            this.cbPl3.Ripple = true;
            this.cbPl3.Size = new System.Drawing.Size(100, 40);
            this.cbPl3.TabIndex = 10;
            this.cbPl3.Text = "Com 3";
            this.cbPl3.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(934, 440);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(198, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Create by Siwanont Sittinam";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // cbPl1
            // 
            this.cbPl1.BackColor = System.Drawing.Color.Transparent;
            this.cbPl1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbPl1.Checked = true;
            this.cbPl1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbPl1.Depth = 0;
            this.cbPl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPl1.Location = new System.Drawing.Point(113, 431);
            this.cbPl1.Margin = new System.Windows.Forms.Padding(0);
            this.cbPl1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPl1.Name = "cbPl1";
            this.cbPl1.Ripple = true;
            this.cbPl1.Size = new System.Drawing.Size(97, 40);
            this.cbPl1.TabIndex = 12;
            this.cbPl1.Text = "Com 1";
            this.cbPl1.UseVisualStyleBackColor = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1144, 471);
            this.Controls.Add(this.cbPl1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbPl3);
            this.Controls.Add(this.cbPl2);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.pbFlag);
            this.Controls.Add(this.mlP);
            this.Controls.Add(this.pbPlay1);
            this.Controls.Add(this.pbPlay2);
            this.Controls.Add(this.pbPlay3);
            this.Controls.Add(this.pbBg);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.Sizable = false;
            this.Text = "Planable";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Index_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timeBg;
        public System.Windows.Forms.PictureBox pbBg;
        private System.Windows.Forms.PictureBox pbPlay3;
        private System.Windows.Forms.PictureBox pbPlay2;
        private System.Windows.Forms.PictureBox pbPlay1;
        private System.Windows.Forms.Timer timePlay1;
        private System.Windows.Forms.Timer timePlay2;
        private System.Windows.Forms.Timer timePlay3;
        private MaterialSkin.Controls.MaterialLabel mlP;
        private System.Windows.Forms.PictureBox pbFlag;
        private MaterialSkin.Controls.MaterialFlatButton bStart;
        private System.Windows.Forms.Timer timeRace;
        private MaterialSkin.Controls.MaterialCheckBox cbPl2;
        private MaterialSkin.Controls.MaterialCheckBox cbPl3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox cbPl1;
    }
}

