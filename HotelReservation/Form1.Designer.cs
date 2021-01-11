namespace HotelReservation
{
    partial class MainPage
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
            this.AgeBox = new System.Windows.Forms.TextBox();
            this.topMenuName = new System.Windows.Forms.Label();
            this.panelContentHolder = new System.Windows.Forms.Panel();
            this.picArrow = new System.Windows.Forms.PictureBox();
            this.panelContent = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxSmoke = new System.Windows.Forms.TextBox();
            this.txtBoxDuration = new System.Windows.Forms.TextBox();
            this.txtBoxRoomType = new System.Windows.Forms.TextBox();
            this.txtBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxNameOfReservation = new System.Windows.Forms.TextBox();
            this.panelAdvert = new System.Windows.Forms.Panel();
            this.panelAdvertLeft = new System.Windows.Forms.Panel();
            this.picFreeRoomsIcon = new System.Windows.Forms.PictureBox();
            this.lblFreeRooms = new System.Windows.Forms.Label();
            this.lblCountOfFreeRooms = new System.Windows.Forms.Label();
            this.panelTopMenu = new System.Windows.Forms.Panel();
            this.btnMinimizeProgram = new System.Windows.Forms.Button();
            this.btnExpandProgram = new System.Windows.Forms.Button();
            this.btnExitProgram = new System.Windows.Forms.Button();
            this.pnlRedLine = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnContactUs = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnPrices = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSideNav = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelContentHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).BeginInit();
            this.panelContent.SuspendLayout();
            this.panelAdvert.SuspendLayout();
            this.panelAdvertLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFreeRoomsIcon)).BeginInit();
            this.panelTopMenu.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelSideNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // AgeBox
            // 
            this.AgeBox.Location = new System.Drawing.Point(187, 93);
            this.AgeBox.Margin = new System.Windows.Forms.Padding(2);
            this.AgeBox.Name = "AgeBox";
            this.AgeBox.Size = new System.Drawing.Size(76, 20);
            this.AgeBox.TabIndex = 1;
            // 
            // topMenuName
            // 
            this.topMenuName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topMenuName.AutoSize = true;
            this.topMenuName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topMenuName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.topMenuName.Location = new System.Drawing.Point(287, 5);
            this.topMenuName.Name = "topMenuName";
            this.topMenuName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topMenuName.Size = new System.Drawing.Size(77, 15);
            this.topMenuName.TabIndex = 3;
            this.topMenuName.Text = "FiveStarHotel";
            this.topMenuName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topMenuName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topMenuName_MouseDown);
            // 
            // panelContentHolder
            // 
            this.panelContentHolder.BackColor = System.Drawing.Color.Transparent;
            this.panelContentHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelContentHolder.Controls.Add(this.picArrow);
            this.panelContentHolder.Controls.Add(this.panelContent);
            this.panelContentHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentHolder.Location = new System.Drawing.Point(127, 25);
            this.panelContentHolder.Name = "panelContentHolder";
            this.panelContentHolder.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.panelContentHolder.Size = new System.Drawing.Size(657, 436);
            this.panelContentHolder.TabIndex = 18;
            this.panelContentHolder.MouseHover += new System.EventHandler(this.panelContentHolder_MouseHover);
            // 
            // picArrow
            // 
            this.picArrow.BackColor = System.Drawing.Color.Transparent;
            this.picArrow.Image = global::HotelReservation.Properties.Resources.Arrow;
            this.picArrow.Location = new System.Drawing.Point(0, 63);
            this.picArrow.Name = "picArrow";
            this.picArrow.Size = new System.Drawing.Size(23, 43);
            this.picArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picArrow.TabIndex = 17;
            this.picArrow.TabStop = false;
            // 
            // panelContent
            // 
            this.panelContent.BackgroundImage = global::HotelReservation.Properties.Resources.ContentHolder;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContent.Controls.Add(this.button2);
            this.panelContent.Controls.Add(this.txtBoxSmoke);
            this.panelContent.Controls.Add(this.txtBoxDuration);
            this.panelContent.Controls.Add(this.txtBoxRoomType);
            this.panelContent.Controls.Add(this.txtBoxRoomNumber);
            this.panelContent.Controls.Add(this.txtBoxAge);
            this.panelContent.Controls.Add(this.txtBoxNameOfReservation);
            this.panelContent.Controls.Add(this.panelAdvert);
            this.panelContent.Location = new System.Drawing.Point(40, 27);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(575, 398);
            this.panelContent.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtBoxSmoke
            // 
            this.txtBoxSmoke.Location = new System.Drawing.Point(228, 220);
            this.txtBoxSmoke.Name = "txtBoxSmoke";
            this.txtBoxSmoke.Size = new System.Drawing.Size(115, 20);
            this.txtBoxSmoke.TabIndex = 6;
            // 
            // txtBoxDuration
            // 
            this.txtBoxDuration.Location = new System.Drawing.Point(389, 220);
            this.txtBoxDuration.Name = "txtBoxDuration";
            this.txtBoxDuration.Size = new System.Drawing.Size(115, 20);
            this.txtBoxDuration.TabIndex = 5;
            // 
            // txtBoxRoomType
            // 
            this.txtBoxRoomType.Location = new System.Drawing.Point(70, 220);
            this.txtBoxRoomType.Name = "txtBoxRoomType";
            this.txtBoxRoomType.Size = new System.Drawing.Size(115, 20);
            this.txtBoxRoomType.TabIndex = 4;
            // 
            // txtBoxRoomNumber
            // 
            this.txtBoxRoomNumber.Location = new System.Drawing.Point(389, 153);
            this.txtBoxRoomNumber.Name = "txtBoxRoomNumber";
            this.txtBoxRoomNumber.Size = new System.Drawing.Size(115, 20);
            this.txtBoxRoomNumber.TabIndex = 3;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(228, 153);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(115, 20);
            this.txtBoxAge.TabIndex = 2;
            // 
            // txtBoxNameOfReservation
            // 
            this.txtBoxNameOfReservation.Location = new System.Drawing.Point(70, 153);
            this.txtBoxNameOfReservation.Name = "txtBoxNameOfReservation";
            this.txtBoxNameOfReservation.Size = new System.Drawing.Size(115, 20);
            this.txtBoxNameOfReservation.TabIndex = 1;
            // 
            // panelAdvert
            // 
            this.panelAdvert.BackgroundImage = global::HotelReservation.Properties.Resources.AdvertBackground;
            this.panelAdvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAdvert.Controls.Add(this.panelAdvertLeft);
            this.panelAdvert.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelAdvert.ForeColor = System.Drawing.Color.Transparent;
            this.panelAdvert.Location = new System.Drawing.Point(50, 36);
            this.panelAdvert.Margin = new System.Windows.Forms.Padding(30, 3, 3, 10);
            this.panelAdvert.Name = "panelAdvert";
            this.panelAdvert.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.panelAdvert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelAdvert.Size = new System.Drawing.Size(479, 85);
            this.panelAdvert.TabIndex = 0;
            // 
            // panelAdvertLeft
            // 
            this.panelAdvertLeft.Controls.Add(this.picFreeRoomsIcon);
            this.panelAdvertLeft.Controls.Add(this.lblFreeRooms);
            this.panelAdvertLeft.Controls.Add(this.lblCountOfFreeRooms);
            this.panelAdvertLeft.Location = new System.Drawing.Point(0, 0);
            this.panelAdvertLeft.Name = "panelAdvertLeft";
            this.panelAdvertLeft.Size = new System.Drawing.Size(124, 88);
            this.panelAdvertLeft.TabIndex = 0;
            // 
            // picFreeRoomsIcon
            // 
            this.picFreeRoomsIcon.Image = global::HotelReservation.Properties.Resources.CurrentGuestsIcon;
            this.picFreeRoomsIcon.ImageLocation = "";
            this.picFreeRoomsIcon.Location = new System.Drawing.Point(44, 56);
            this.picFreeRoomsIcon.Name = "picFreeRoomsIcon";
            this.picFreeRoomsIcon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.picFreeRoomsIcon.Size = new System.Drawing.Size(38, 36);
            this.picFreeRoomsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFreeRoomsIcon.TabIndex = 2;
            this.picFreeRoomsIcon.TabStop = false;
            // 
            // lblFreeRooms
            // 
            this.lblFreeRooms.Location = new System.Drawing.Point(33, 38);
            this.lblFreeRooms.Name = "lblFreeRooms";
            this.lblFreeRooms.Size = new System.Drawing.Size(62, 15);
            this.lblFreeRooms.TabIndex = 1;
            this.lblFreeRooms.Text = "Free rooms";
            this.lblFreeRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCountOfFreeRooms
            // 
            this.lblCountOfFreeRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCountOfFreeRooms.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountOfFreeRooms.ForeColor = System.Drawing.Color.White;
            this.lblCountOfFreeRooms.Location = new System.Drawing.Point(0, 0);
            this.lblCountOfFreeRooms.Name = "lblCountOfFreeRooms";
            this.lblCountOfFreeRooms.Padding = new System.Windows.Forms.Padding(0, 0, 0, 35);
            this.lblCountOfFreeRooms.Size = new System.Drawing.Size(124, 88);
            this.lblCountOfFreeRooms.TabIndex = 0;
            this.lblCountOfFreeRooms.Text = "49";
            this.lblCountOfFreeRooms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelTopMenu.Size = new System.Drawing.Size(657, 25);
            this.panelTopMenu.TabIndex = 17;
            this.panelTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopMenu_MouseDown);
            // 
            // btnMinimizeProgram
            // 
            this.btnMinimizeProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeProgram.FlatAppearance.BorderSize = 0;
            this.btnMinimizeProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeProgram.Image = global::HotelReservation.Properties.Resources.MinimizeButton;
            this.btnMinimizeProgram.Location = new System.Drawing.Point(552, 0);
            this.btnMinimizeProgram.Name = "btnMinimizeProgram";
            this.btnMinimizeProgram.Size = new System.Drawing.Size(35, 25);
            this.btnMinimizeProgram.TabIndex = 1;
            this.btnMinimizeProgram.UseVisualStyleBackColor = true;
            this.btnMinimizeProgram.Click += new System.EventHandler(this.btnMinimizeProgram_Click);
            // 
            // btnExpandProgram
            // 
            this.btnExpandProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExpandProgram.FlatAppearance.BorderSize = 0;
            this.btnExpandProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandProgram.Image = global::HotelReservation.Properties.Resources.ResizeButton;
            this.btnExpandProgram.Location = new System.Drawing.Point(587, 0);
            this.btnExpandProgram.Name = "btnExpandProgram";
            this.btnExpandProgram.Size = new System.Drawing.Size(35, 25);
            this.btnExpandProgram.TabIndex = 0;
            this.btnExpandProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExpandProgram.UseVisualStyleBackColor = true;
            this.btnExpandProgram.Click += new System.EventHandler(this.btnExpandProgram_Click);
            // 
            // btnExitProgram
            // 
            this.btnExitProgram.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExitProgram.FlatAppearance.BorderSize = 0;
            this.btnExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitProgram.Image = global::HotelReservation.Properties.Resources.exitButton;
            this.btnExitProgram.Location = new System.Drawing.Point(622, 0);
            this.btnExitProgram.Name = "btnExitProgram";
            this.btnExitProgram.Size = new System.Drawing.Size(35, 25);
            this.btnExitProgram.TabIndex = 2;
            this.btnExitProgram.UseVisualStyleBackColor = true;
            this.btnExitProgram.Click += new System.EventHandler(this.btnExitProgram_Click);
            // 
            // pnlRedLine
            // 
            this.pnlRedLine.BackColor = System.Drawing.Color.Red;
            this.pnlRedLine.Location = new System.Drawing.Point(2, 2);
            this.pnlRedLine.Name = "pnlRedLine";
            this.pnlRedLine.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlRedLine.Size = new System.Drawing.Size(3, 39);
            this.pnlRedLine.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelMenu.Controls.Add(this.pnlRedLine);
            this.panelMenu.Controls.Add(this.btnContactUs);
            this.panelMenu.Controls.Add(this.btnAboutUs);
            this.panelMenu.Controls.Add(this.btnPrices);
            this.panelMenu.Controls.Add(this.btnReserve);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Location = new System.Drawing.Point(0, 84);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(127, 239);
            this.panelMenu.TabIndex = 15;
            this.panelMenu.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave_1);
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
            this.btnContactUs.Image = global::HotelReservation.Properties.Resources.ContactUsIcon;
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
            this.btnContactUs.MouseHover += new System.EventHandler(this.btnContactUs_MouseHover);
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
            this.btnAboutUs.Image = global::HotelReservation.Properties.Resources.AboutUsIcon;
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
            this.btnAboutUs.MouseHover += new System.EventHandler(this.btnAboutUs_MouseHover);
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
            this.btnPrices.Image = global::HotelReservation.Properties.Resources.PriceIcon;
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
            this.btnPrices.MouseHover += new System.EventHandler(this.btnPrices_MouseHover);
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
            this.btnReserve.Image = global::HotelReservation.Properties.Resources.ReserveIcon;
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
            this.btnReserve.MouseHover += new System.EventHandler(this.btnReserve_MouseHover);
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
            this.btnHome.Image = global::HotelReservation.Properties.Resources.HomeIcon2;
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
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // panelSideNav
            // 
            this.panelSideNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.panelSideNav.Controls.Add(this.picLogo);
            this.panelSideNav.Controls.Add(this.panelMenu);
            this.panelSideNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideNav.Location = new System.Drawing.Point(0, 0);
            this.panelSideNav.Name = "panelSideNav";
            this.panelSideNav.Size = new System.Drawing.Size(127, 461);
            this.panelSideNav.TabIndex = 14;
            this.panelSideNav.MouseLeave += new System.EventHandler(this.panelSideNav_MouseLeave);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::HotelReservation.Properties.Resources.Logo;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 64);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(46)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panelContentHolder);
            this.Controls.Add(this.panelTopMenu);
            this.Controls.Add(this.panelSideNav);
            this.Controls.Add(this.AgeBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.panelContentHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picArrow)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelAdvert.ResumeLayout(false);
            this.panelAdvertLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFreeRoomsIcon)).EndInit();
            this.panelTopMenu.ResumeLayout(false);
            this.panelTopMenu.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelSideNav.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AgeBox;
        private System.Windows.Forms.PictureBox picFreeRoomsIcon;
        private System.Windows.Forms.Label lblCountOfFreeRooms;
        private System.Windows.Forms.Panel panelAdvertLeft;
        private System.Windows.Forms.Label lblFreeRooms;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxSmoke;
        private System.Windows.Forms.TextBox txtBoxDuration;
        private System.Windows.Forms.TextBox txtBoxRoomType;
        private System.Windows.Forms.TextBox txtBoxRoomNumber;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxNameOfReservation;
        private System.Windows.Forms.Panel panelAdvert;
        private System.Windows.Forms.Label topMenuName;
        private System.Windows.Forms.Button btnMinimizeProgram;
        private System.Windows.Forms.Button btnExpandProgram;
        private System.Windows.Forms.Panel panelContentHolder;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btnExitProgram;
        private System.Windows.Forms.Panel panelTopMenu;
        private System.Windows.Forms.Panel pnlRedLine;
        private System.Windows.Forms.Button btnContactUs;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnPrices;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel panelSideNav;
        private System.Windows.Forms.PictureBox picArrow;
    }
}

