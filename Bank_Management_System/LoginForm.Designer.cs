
namespace Bank_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.NotRegisteredLbl1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LoginSwapRolesCB1 = new System.Windows.Forms.ComboBox();
            this.PasswordTB1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserFieldTB1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LogInBtn1 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PasswordFieldPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.UserFieldPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginFormExitPB1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.PasswordPB1 = new FontAwesome.Sharp.IconPictureBox();
            this.UserNamePB1 = new FontAwesome.Sharp.IconPictureBox();
            this.CreateAccLinkLbl1 = new System.Windows.Forms.LinkLabel();
            this.PicturePanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.LoginPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormExitPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePB1)).BeginInit();
            this.PicturePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NotRegisteredLbl1
            // 
            this.NotRegisteredLbl1.AllowParentOverrides = false;
            this.NotRegisteredLbl1.AutoEllipsis = false;
            this.NotRegisteredLbl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.NotRegisteredLbl1.CursorType = System.Windows.Forms.Cursors.Default;
            this.NotRegisteredLbl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NotRegisteredLbl1.Location = new System.Drawing.Point(496, 459);
            this.NotRegisteredLbl1.Name = "NotRegisteredLbl1";
            this.NotRegisteredLbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NotRegisteredLbl1.Size = new System.Drawing.Size(78, 15);
            this.NotRegisteredLbl1.TabIndex = 9;
            this.NotRegisteredLbl1.Text = "Not Registered";
            this.NotRegisteredLbl1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.NotRegisteredLbl1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuToolTip1.SetToolTip(this.NotRegisteredLbl1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.NotRegisteredLbl1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.NotRegisteredLbl1, "");
            // 
            // LoginSwapRolesCB1
            // 
            this.LoginSwapRolesCB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginSwapRolesCB1.ForeColor = System.Drawing.Color.Blue;
            this.LoginSwapRolesCB1.FormattingEnabled = true;
            this.LoginSwapRolesCB1.Items.AddRange(new object[] {
            "User",
            "Admin",
            "Employee"});
            this.LoginSwapRolesCB1.Location = new System.Drawing.Point(515, 386);
            this.LoginSwapRolesCB1.Name = "LoginSwapRolesCB1";
            this.LoginSwapRolesCB1.Size = new System.Drawing.Size(121, 21);
            this.LoginSwapRolesCB1.TabIndex = 13;
            this.LoginSwapRolesCB1.Text = "User";
            this.bunifuToolTip1.SetToolTip(this.LoginSwapRolesCB1, "Change the role of login mode by selecting the correct role");
            this.bunifuToolTip1.SetToolTipIcon(this.LoginSwapRolesCB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.LoginSwapRolesCB1, "Swap Role Combo Box");
            this.LoginSwapRolesCB1.SelectedIndexChanged += new System.EventHandler(this.LoginSwapRolesCB1_SelectedIndexChanged);
            // 
            // PasswordTB1
            // 
            this.PasswordTB1.AcceptsReturn = false;
            this.PasswordTB1.AcceptsTab = false;
            this.PasswordTB1.AnimationSpeed = 200;
            this.PasswordTB1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTB1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTB1.AutoSizeHeight = true;
            this.PasswordTB1.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTB1.BackgroundImage")));
            this.PasswordTB1.BorderColorActive = System.Drawing.Color.Transparent;
            this.PasswordTB1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordTB1.BorderColorHover = System.Drawing.Color.Transparent;
            this.PasswordTB1.BorderColorIdle = System.Drawing.Color.Transparent;
            this.PasswordTB1.BorderRadius = 1;
            this.PasswordTB1.BorderThickness = 1;
            this.PasswordTB1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PasswordTB1.DefaultText = "";
            this.PasswordTB1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.PasswordTB1.HideSelection = true;
            this.PasswordTB1.IconLeft = null;
            this.PasswordTB1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB1.IconPadding = 10;
            this.PasswordTB1.IconRight = null;
            this.PasswordTB1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTB1.Lines = new string[0];
            this.PasswordTB1.Location = new System.Drawing.Point(472, 263);
            this.PasswordTB1.MaxLength = 32767;
            this.PasswordTB1.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTB1.Modified = false;
            this.PasswordTB1.Multiline = false;
            this.PasswordTB1.Name = "PasswordTB1";
            stateProperties9.BorderColor = System.Drawing.Color.Transparent;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB1.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTB1.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.Transparent;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB1.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Transparent;
            stateProperties12.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTB1.OnIdleState = stateProperties12;
            this.PasswordTB1.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordTB1.PasswordChar = 'x';
            this.PasswordTB1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordTB1.PlaceholderText = "Password";
            this.PasswordTB1.ReadOnly = false;
            this.PasswordTB1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTB1.SelectedText = "";
            this.PasswordTB1.SelectionLength = 0;
            this.PasswordTB1.SelectionStart = 0;
            this.PasswordTB1.ShortcutsEnabled = true;
            this.PasswordTB1.Size = new System.Drawing.Size(219, 39);
            this.PasswordTB1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordTB1.TabIndex = 12;
            this.PasswordTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTB1.TextMarginBottom = 0;
            this.PasswordTB1.TextMarginLeft = 3;
            this.PasswordTB1.TextMarginTop = 1;
            this.PasswordTB1.TextPlaceholder = "Password";
            this.bunifuToolTip1.SetToolTip(this.PasswordTB1, "Insert given Account Password in this field");
            this.bunifuToolTip1.SetToolTipIcon(this.PasswordTB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.PasswordTB1, "Account Password Text Box");
            this.PasswordTB1.UseSystemPasswordChar = false;
            this.PasswordTB1.WordWrap = true;
            // 
            // UserFieldTB1
            // 
            this.UserFieldTB1.AcceptsReturn = false;
            this.UserFieldTB1.AcceptsTab = false;
            this.UserFieldTB1.AnimationSpeed = 200;
            this.UserFieldTB1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserFieldTB1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserFieldTB1.AutoSizeHeight = true;
            this.UserFieldTB1.BackColor = System.Drawing.Color.Transparent;
            this.UserFieldTB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserFieldTB1.BackgroundImage")));
            this.UserFieldTB1.BorderColorActive = System.Drawing.Color.Transparent;
            this.UserFieldTB1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserFieldTB1.BorderColorHover = System.Drawing.Color.Transparent;
            this.UserFieldTB1.BorderColorIdle = System.Drawing.Color.Transparent;
            this.UserFieldTB1.BorderRadius = 1;
            this.UserFieldTB1.BorderThickness = 1;
            this.UserFieldTB1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserFieldTB1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserFieldTB1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.UserFieldTB1.DefaultText = "";
            this.UserFieldTB1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.UserFieldTB1.HideSelection = true;
            this.UserFieldTB1.IconLeft = null;
            this.UserFieldTB1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserFieldTB1.IconPadding = 10;
            this.UserFieldTB1.IconRight = null;
            this.UserFieldTB1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.UserFieldTB1.Lines = new string[0];
            this.UserFieldTB1.Location = new System.Drawing.Point(472, 190);
            this.UserFieldTB1.MaxLength = 32767;
            this.UserFieldTB1.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserFieldTB1.Modified = false;
            this.UserFieldTB1.Multiline = false;
            this.UserFieldTB1.Name = "UserFieldTB1";
            stateProperties13.BorderColor = System.Drawing.Color.Transparent;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserFieldTB1.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.UserFieldTB1.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.Transparent;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserFieldTB1.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Transparent;
            stateProperties16.FillColor = System.Drawing.Color.WhiteSmoke;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.UserFieldTB1.OnIdleState = stateProperties16;
            this.UserFieldTB1.Padding = new System.Windows.Forms.Padding(3);
            this.UserFieldTB1.PasswordChar = '\0';
            this.UserFieldTB1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.UserFieldTB1.PlaceholderText = "Account Name";
            this.UserFieldTB1.ReadOnly = false;
            this.UserFieldTB1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UserFieldTB1.SelectedText = "";
            this.UserFieldTB1.SelectionLength = 0;
            this.UserFieldTB1.SelectionStart = 0;
            this.UserFieldTB1.ShortcutsEnabled = true;
            this.UserFieldTB1.Size = new System.Drawing.Size(219, 39);
            this.UserFieldTB1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.UserFieldTB1.TabIndex = 11;
            this.UserFieldTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserFieldTB1.TextMarginBottom = 0;
            this.UserFieldTB1.TextMarginLeft = 3;
            this.UserFieldTB1.TextMarginTop = 1;
            this.UserFieldTB1.TextPlaceholder = "Account Name";
            this.bunifuToolTip1.SetToolTip(this.UserFieldTB1, "Insert Account Name in this field");
            this.bunifuToolTip1.SetToolTipIcon(this.UserFieldTB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.UserFieldTB1, "Account Name Text Box");
            this.UserFieldTB1.UseSystemPasswordChar = false;
            this.UserFieldTB1.WordWrap = true;
            // 
            // LogInBtn1
            // 
            this.LogInBtn1.ActiveBorderThickness = 1;
            this.LogInBtn1.ActiveCornerRadius = 20;
            this.LogInBtn1.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LogInBtn1.ActiveForecolor = System.Drawing.Color.White;
            this.LogInBtn1.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LogInBtn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LogInBtn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInBtn1.BackgroundImage")));
            this.LogInBtn1.ButtonText = "LogIn";
            this.LogInBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInBtn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInBtn1.ForeColor = System.Drawing.Color.Black;
            this.LogInBtn1.IdleBorderThickness = 5;
            this.LogInBtn1.IdleCornerRadius = 20;
            this.LogInBtn1.IdleFillColor = System.Drawing.Color.Blue;
            this.LogInBtn1.IdleForecolor = System.Drawing.Color.White;
            this.LogInBtn1.IdleLineColor = System.Drawing.Color.Transparent;
            this.LogInBtn1.Location = new System.Drawing.Point(452, 330);
            this.LogInBtn1.Margin = new System.Windows.Forms.Padding(5);
            this.LogInBtn1.Name = "LogInBtn1";
            this.LogInBtn1.Size = new System.Drawing.Size(239, 48);
            this.LogInBtn1.TabIndex = 8;
            this.LogInBtn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.LogInBtn1, "Logs In the role portal selected by user ");
            this.bunifuToolTip1.SetToolTipIcon(this.LogInBtn1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.LogInBtn1, "LogIn Button");
            this.LogInBtn1.Click += new System.EventHandler(this.LogInBtn1_Click);
            // 
            // PasswordFieldPanel
            // 
            this.PasswordFieldPanel.BackgroundColor = System.Drawing.Color.Blue;
            this.PasswordFieldPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordFieldPanel.BackgroundImage")));
            this.PasswordFieldPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PasswordFieldPanel.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordFieldPanel.BorderRadius = 3;
            this.PasswordFieldPanel.BorderThickness = 1;
            this.PasswordFieldPanel.Location = new System.Drawing.Point(434, 301);
            this.PasswordFieldPanel.Name = "PasswordFieldPanel";
            this.PasswordFieldPanel.ShowBorders = true;
            this.PasswordFieldPanel.Size = new System.Drawing.Size(272, 10);
            this.PasswordFieldPanel.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.PasswordFieldPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.PasswordFieldPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.PasswordFieldPanel, "");
            // 
            // UserFieldPanel
            // 
            this.UserFieldPanel.BackgroundColor = System.Drawing.Color.Blue;
            this.UserFieldPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UserFieldPanel.BackgroundImage")));
            this.UserFieldPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserFieldPanel.BorderColor = System.Drawing.Color.Transparent;
            this.UserFieldPanel.BorderRadius = 3;
            this.UserFieldPanel.BorderThickness = 1;
            this.UserFieldPanel.Location = new System.Drawing.Point(434, 228);
            this.UserFieldPanel.Name = "UserFieldPanel";
            this.UserFieldPanel.ShowBorders = true;
            this.UserFieldPanel.Size = new System.Drawing.Size(272, 10);
            this.UserFieldPanel.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.UserFieldPanel, "");
            this.bunifuToolTip1.SetToolTipIcon(this.UserFieldPanel, null);
            this.bunifuToolTip1.SetToolTipTitle(this.UserFieldPanel, "");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 480);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            // 
            // LoginFormExitPB1
            // 
            this.LoginFormExitPB1.AllowFocused = false;
            this.LoginFormExitPB1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginFormExitPB1.AutoSizeHeight = false;
            this.LoginFormExitPB1.BorderRadius = 22;
            this.LoginFormExitPB1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFormExitPB1.Image = ((System.Drawing.Image)(resources.GetObject("LoginFormExitPB1.Image")));
            this.LoginFormExitPB1.IsCircle = true;
            this.LoginFormExitPB1.Location = new System.Drawing.Point(704, 12);
            this.LoginFormExitPB1.Name = "LoginFormExitPB1";
            this.LoginFormExitPB1.Size = new System.Drawing.Size(44, 44);
            this.LoginFormExitPB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoginFormExitPB1.TabIndex = 3;
            this.LoginFormExitPB1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.LoginFormExitPB1, "Exit the application");
            this.bunifuToolTip1.SetToolTipIcon(this.LoginFormExitPB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.LoginFormExitPB1, "Exit Button");
            this.LoginFormExitPB1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.LoginFormExitPB1.Click += new System.EventHandler(this.LoginFormExitPB1_Click);
            // 
            // PasswordPB1
            // 
            this.PasswordPB1.BackColor = System.Drawing.Color.Transparent;
            this.PasswordPB1.ForeColor = System.Drawing.Color.Blue;
            this.PasswordPB1.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.PasswordPB1.IconColor = System.Drawing.Color.Blue;
            this.PasswordPB1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.PasswordPB1.Location = new System.Drawing.Point(434, 263);
            this.PasswordPB1.Name = "PasswordPB1";
            this.PasswordPB1.Size = new System.Drawing.Size(32, 32);
            this.PasswordPB1.TabIndex = 1;
            this.PasswordPB1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.PasswordPB1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.PasswordPB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.PasswordPB1, "");
            // 
            // UserNamePB1
            // 
            this.UserNamePB1.BackColor = System.Drawing.Color.Transparent;
            this.UserNamePB1.ForeColor = System.Drawing.Color.Blue;
            this.UserNamePB1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.UserNamePB1.IconColor = System.Drawing.Color.Blue;
            this.UserNamePB1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserNamePB1.Location = new System.Drawing.Point(434, 190);
            this.UserNamePB1.Name = "UserNamePB1";
            this.UserNamePB1.Size = new System.Drawing.Size(32, 32);
            this.UserNamePB1.TabIndex = 0;
            this.UserNamePB1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.UserNamePB1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.UserNamePB1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.UserNamePB1, "");
            // 
            // CreateAccLinkLbl1
            // 
            this.CreateAccLinkLbl1.AutoSize = true;
            this.CreateAccLinkLbl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CreateAccLinkLbl1.Location = new System.Drawing.Point(580, 459);
            this.CreateAccLinkLbl1.Name = "CreateAccLinkLbl1";
            this.CreateAccLinkLbl1.Size = new System.Drawing.Size(89, 15);
            this.CreateAccLinkLbl1.TabIndex = 14;
            this.CreateAccLinkLbl1.TabStop = true;
            this.CreateAccLinkLbl1.Text = "Create Account";
            this.bunifuToolTip1.SetToolTip(this.CreateAccLinkLbl1, "Loads the create Account Form");
            this.bunifuToolTip1.SetToolTipIcon(this.CreateAccLinkLbl1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.CreateAccLinkLbl1, "Create Account HyperLink");
            this.CreateAccLinkLbl1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PicturePanel1
            // 
            this.PicturePanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.PicturePanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicturePanel1.BackgroundImage")));
            this.PicturePanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicturePanel1.BorderColor = System.Drawing.Color.Blue;
            this.PicturePanel1.BorderRadius = 3;
            this.PicturePanel1.BorderThickness = 1;
            this.PicturePanel1.Controls.Add(this.pictureBox1);
            this.PicturePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicturePanel1.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel1.Name = "PicturePanel1";
            this.PicturePanel1.ShowBorders = true;
            this.PicturePanel1.Size = new System.Drawing.Size(402, 486);
            this.PicturePanel1.TabIndex = 15;
            this.bunifuToolTip1.SetToolTip(this.PicturePanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.PicturePanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.PicturePanel1, "");
            // 
            // LoginPanel1
            // 
            this.LoginPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.LoginPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginPanel1.BackgroundImage")));
            this.LoginPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginPanel1.BorderColor = System.Drawing.Color.Blue;
            this.LoginPanel1.BorderRadius = 3;
            this.LoginPanel1.BorderThickness = 1;
            this.LoginPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.LoginPanel1.Location = new System.Drawing.Point(396, 0);
            this.LoginPanel1.Name = "LoginPanel1";
            this.LoginPanel1.ShowBorders = true;
            this.LoginPanel1.Size = new System.Drawing.Size(364, 486);
            this.LoginPanel1.TabIndex = 16;
            this.bunifuToolTip1.SetToolTip(this.LoginPanel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.LoginPanel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.LoginPanel1, "");
            this.LoginPanel1.Click += new System.EventHandler(this.LoginPanel1_Click);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Blue;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(760, 486);
            this.Controls.Add(this.PicturePanel1);
            this.Controls.Add(this.CreateAccLinkLbl1);
            this.Controls.Add(this.LoginSwapRolesCB1);
            this.Controls.Add(this.PasswordTB1);
            this.Controls.Add(this.UserFieldTB1);
            this.Controls.Add(this.NotRegisteredLbl1);
            this.Controls.Add(this.LogInBtn1);
            this.Controls.Add(this.PasswordFieldPanel);
            this.Controls.Add(this.UserFieldPanel);
            this.Controls.Add(this.LoginFormExitPB1);
            this.Controls.Add(this.PasswordPB1);
            this.Controls.Add(this.UserNamePB1);
            this.Controls.Add(this.LoginPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormExitPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePB1)).EndInit();
            this.PicturePanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox UserNamePB1;
        private FontAwesome.Sharp.IconPictureBox PasswordPB1;
        private Bunifu.UI.WinForms.BunifuPictureBox LoginFormExitPB1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuPanel UserFieldPanel;
        private Bunifu.UI.WinForms.BunifuPanel PasswordFieldPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 LogInBtn1;
        private Bunifu.UI.WinForms.BunifuLabel NotRegisteredLbl1;
        private Bunifu.UI.WinForms.BunifuTextBox UserFieldTB1;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTB1;
        private System.Windows.Forms.ComboBox LoginSwapRolesCB1;
        private System.Windows.Forms.LinkLabel CreateAccLinkLbl1;
        private Bunifu.UI.WinForms.BunifuPanel PicturePanel1;
        private Bunifu.UI.WinForms.BunifuPanel LoginPanel1;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}