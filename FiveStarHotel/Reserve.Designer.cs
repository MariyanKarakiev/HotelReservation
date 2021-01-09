namespace FiveStarHotel
{
    partial class Reserve
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topMenuName = new System.Windows.Forms.Label();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSideNav = new System.Windows.Forms.Panel();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.btnMinimizeProgram = new System.Windows.Forms.Button();
            this.btnExpandProgram = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnPrices = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelContentHolder = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // topMenuName
            // 
            this.topMenuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topMenuName.AutoSize = true;
            this.topMenuName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMenuName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topMenuName.Location = new System.Drawing.Point(303, 5);
            this.topMenuName.Name = "topMenuName";
            this.topMenuName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topMenuName.Size = new System.Drawing.Size(77, 15);
            this.topMenuName.TabIndex = 3;
            this.topMenuName.Text = "FiveStarHotel";
            this.topMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelTopMenu.Controls.Add(this.topMenuName);
            this.panelTopMenu.Controls.Add(this.btnMinimizeProgram);
            this.panelTopMenu.Controls.Add(this.btnExpandProgram);
            this.panelTopMenu.Controls.Add(this.btnExitProgram);
            this.panelTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopMenu.Location = new System.Drawing.Point(127, 0);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(689, 25);
            this.panelTopMenu.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelMenu.Controls.Add(this.btnContactUs);
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnPrices);
            this.panelMenu.Controls.Add(this.btnReserve);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(0, 83);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(127, 388);
            this.panelMenu.TabIndex = 6;
            // 
            // panelSideNav
            // 
            this.panelSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSideNav.Controls.Add(this.picLogo);
            this.panelSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideNav.Location = new System.Drawing.Point(0, 0);
            this.panelSideNav.Name = "panelSideNav";
            this.panelSideNav.Size = new System.Drawing.Size(127, 510);
            this.panelSideNav.TabIndex = 5;
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = global::FiveStarHotel.Properties.Resources.Arrow;
            this.picArrow.Location = new System.Drawing.Point(127, 128);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(23, 43);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrow.TabIndex = 7;
            this.picArrow.TabStop = false;
            // 
            // btnMinimizeProgram
            // 
            this.btnMinimizeProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeProgram.FlatAppearance.BorderSize = 0;
            this.btnMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeProgram.Image = global::FiveStarHotel.Properties.Resources.MinimizeButton1;
            this.btnMinimizeProgram.Location = new System.Drawing.Point(584, 0);
            this.btnMinimizeProgram.Name = "btnMinimizeProgram";
            this.btnMinimizeProgram.Size = new System.Drawing.Size(35, 25);
            this.btnMinimizeProgram.TabIndex = 1;
            this.btnMinimizeProgram.UseVisualStyleBackColor = true;
            // 
            // btnExpandProgram
            // 
            this.btnExpandProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExpandProgram.FlatAppearance.BorderSize = 0;
            this.btnExpandProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandProgram.Image = global::FiveStarHotel.Properties.Resources.ResizeButton3;
            this.btnExpandProgram.Location = new System.Drawing.Point(619, 0);
            this.btnExpandProgram.Name = "btnExpandProgram";
            this.btnExpandProgram.Size = new System.Drawing.Size(35, 25);
            this.btnExpandProgram.TabIndex = 0;
            this.btnExpandProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpandProgram.UseVisualStyleBackColor = true;
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitProgram.FlatAppearance.BorderSize = 0;
            this.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgram.Image = global::FiveStarHotel.Properties.Resources.exitButton1;
            this.btnExitProgram.Location = new System.Drawing.Point(654, 0);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(35, 25);
            this.btnExitProgram.TabIndex = 2;
            this.btnExitProgram.UseVisualStyleBackColor = true;
            // 
            // btnContactUs
            // 
            this.btnContactUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContactUs.FlatAppearance.BorderSize = 0;
            this.btnContactUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnContactUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnContactUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactUs.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContactUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnContactUs.Image = global::FiveStarHotel.Properties.Resources.ContactUsIcon1;
            this.btnContactUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContactUs.Location = new System.Drawing.Point(0, 188);
            this.btnContactUs.Name = "btnContactUs";
            this.btnContactUs.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnContactUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnContactUs.Size = new System.Drawing.Size(127, 47);
            this.btnContactUs.TabIndex = 3;
            this.btnContactUs.Text = "Contact Us";
            this.btnContactUs.UseMnemonic = false;
            this.btnContactUs.UseVisualStyleBackColor = true;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAboutUs.Image = global::FiveStarHotel.Properties.Resources.AboutUsIcon;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 141);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnAboutUs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAboutUs.Size = new System.Drawing.Size(127, 47);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "About us";
            this.btnAboutUs.UseMnemonic = false;
            this.btnAboutUs.UseVisualStyleBackColor = true;
            // 
            // btnPrices
            // 
            this.btnPrices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrices.FlatAppearance.BorderSize = 0;
            this.btnPrices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnPrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrices.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPrices.Image = global::FiveStarHotel.Properties.Resources.PriceIcon1;
            this.btnPrices.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrices.Location = new System.Drawing.Point(0, 94);
            this.btnPrices.Name = "btnPrices";
            this.btnPrices.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnPrices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPrices.Size = new System.Drawing.Size(127, 47);
            this.btnPrices.TabIndex = 1;
            this.btnPrices.Text = "Prices";
            this.btnPrices.UseMnemonic = false;
            this.btnPrices.UseVisualStyleBackColor = true;
            // 
            // btnReserve
            // 
            this.btnReserve.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReserve.FlatAppearance.BorderSize = 0;
            this.btnReserve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnReserve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReserve.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnReserve.Image = global::FiveStarHotel.Properties.Resources.ReserveIcon;
            this.btnReserve.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReserve.Location = new System.Drawing.Point(0, 47);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnReserve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReserve.Size = new System.Drawing.Size(127, 47);
            this.btnReserve.TabIndex = 0;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseMnemonic = false;
            this.btnReserve.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnHome.Image = global::FiveStarHotel.Properties.Resources.HomeIcon2;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.btnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHome.Size = new System.Drawing.Size(127, 47);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseMnemonic = false;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::FiveStarHotel.Properties.Resources.Logo1;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // panelContentHolder
            // 
            this.panelContentHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelContentHolder.BackgroundImage = global::FiveStarHotel.Properties.Resources.ContentHolder2;
            this.panelContentHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContentHolder.Location = new System.Drawing.Point(156, 47);
            this.panelContentHolder.Name = "panelContentHolder";
            this.panelContentHolder.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelContentHolder.Size = new System.Drawing.Size(625, 460);
            this.panelContentHolder.TabIndex = 9;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.picArrow);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelSideNav);
            this.Controls.Add(this.panelContentHolder);
            this.Name = "Reserve";
            this.Size = new System.Drawing.Size(816, 510);
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelSideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnPrices;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnMinimizeProgram;
        private System.Windows.Forms.Button btnExpandProgram;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox picArrow;
        private System.Windows.Forms.Label topMenuName;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelSideNav;
        private System.Windows.Forms.Panel panelContentHolder;
    }
}
