namespace DCSLibraryRepository
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UsernameField = new MaterialSkin.Controls.MaterialTextBox2();
            PasswordField = new MaterialSkin.Controls.MaterialTextBox2();
            LoginBtn = new MaterialSkin.Controls.MaterialButton();
            CreateAccountBtn = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            Title = new MaterialSkin.Controls.MaterialLabel();
            pictureBox1 = new PictureBox();
            InvalidLabel = new MaterialSkin.Controls.MaterialLabel();
            ShowPasswordCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameField
            // 
            UsernameField.Anchor = AnchorStyles.Top;
            UsernameField.AnimateReadOnly = false;
            UsernameField.BackgroundImageLayout = ImageLayout.None;
            UsernameField.CharacterCasing = CharacterCasing.Normal;
            UsernameField.Depth = 0;
            UsernameField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UsernameField.HideSelection = true;
            UsernameField.Hint = "Username";
            UsernameField.LeadingIcon = null;
            UsernameField.Location = new Point(42, 189);
            UsernameField.MaxLength = 32767;
            UsernameField.MouseState = MaterialSkin.MouseState.OUT;
            UsernameField.Name = "UsernameField";
            UsernameField.PasswordChar = '\0';
            UsernameField.PrefixSuffixText = null;
            UsernameField.ReadOnly = false;
            UsernameField.RightToLeft = RightToLeft.No;
            UsernameField.SelectedText = "";
            UsernameField.SelectionLength = 0;
            UsernameField.SelectionStart = 0;
            UsernameField.ShortcutsEnabled = true;
            UsernameField.Size = new Size(312, 48);
            UsernameField.TabIndex = 8;
            UsernameField.TabStop = false;
            UsernameField.TextAlign = HorizontalAlignment.Left;
            UsernameField.TrailingIcon = null;
            UsernameField.UseSystemPasswordChar = false;
            // 
            // PasswordField
            // 
            PasswordField.Anchor = AnchorStyles.Top;
            PasswordField.AnimateReadOnly = false;
            PasswordField.BackgroundImageLayout = ImageLayout.None;
            PasswordField.CharacterCasing = CharacterCasing.Normal;
            PasswordField.Depth = 0;
            PasswordField.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordField.HideSelection = true;
            PasswordField.Hint = "Password";
            PasswordField.LeadingIcon = null;
            PasswordField.Location = new Point(42, 266);
            PasswordField.Margin = new Padding(0);
            PasswordField.MaxLength = 32767;
            PasswordField.MouseState = MaterialSkin.MouseState.OUT;
            PasswordField.Name = "PasswordField";
            PasswordField.PasswordChar = '●';
            PasswordField.PrefixSuffixText = null;
            PasswordField.ReadOnly = false;
            PasswordField.RightToLeft = RightToLeft.No;
            PasswordField.SelectedText = "";
            PasswordField.SelectionLength = 0;
            PasswordField.SelectionStart = 0;
            PasswordField.ShortcutsEnabled = true;
            PasswordField.Size = new Size(312, 48);
            PasswordField.TabIndex = 9;
            PasswordField.TabStop = false;
            PasswordField.TextAlign = HorizontalAlignment.Left;
            PasswordField.TrailingIcon = null;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            LoginBtn.Anchor = AnchorStyles.Top;
            LoginBtn.AutoSize = false;
            LoginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginBtn.Depth = 0;
            LoginBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.HighEmphasis = true;
            LoginBtn.Icon = null;
            LoginBtn.Location = new Point(42, 397);
            LoginBtn.Margin = new Padding(4, 6, 4, 6);
            LoginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            LoginBtn.Name = "LoginBtn";
            LoginBtn.NoAccentTextColor = Color.Empty;
            LoginBtn.Size = new Size(312, 36);
            LoginBtn.TabIndex = 10;
            LoginBtn.Text = "Login";
            LoginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginBtn.UseAccentColor = false;
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginPressed;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Anchor = AnchorStyles.Top;
            CreateAccountBtn.AutoSize = true;
            CreateAccountBtn.Depth = 0;
            CreateAccountBtn.Font = new Font("Roboto", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CreateAccountBtn.FontType = MaterialSkin.MaterialSkinManager.fontType.Button;
            CreateAccountBtn.HighEmphasis = true;
            CreateAccountBtn.Location = new Point(137, 485);
            CreateAccountBtn.MouseState = MaterialSkin.MouseState.HOVER;
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(130, 17);
            CreateAccountBtn.TabIndex = 13;
            CreateAccountBtn.Text = "Create New Account";
            CreateAccountBtn.UseAccent = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            materialLabel1.Location = new Point(194, 451);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(14, 17);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "or";
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top;
            Title.AutoSize = true;
            Title.Depth = 0;
            Title.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            Title.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            Title.HighEmphasis = true;
            Title.Location = new Point(27, 112);
            Title.MouseState = MaterialSkin.MouseState.HOVER;
            Title.Name = "Title";
            Title.Size = new Size(346, 41);
            Title.TabIndex = 12;
            Title.Text = "DCS Library Repository";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(412, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // InvalidLabel
            // 
            InvalidLabel.AutoSize = true;
            InvalidLabel.Depth = 0;
            InvalidLabel.Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            InvalidLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            InvalidLabel.HighEmphasis = true;
            InvalidLabel.Location = new Point(42, 314);
            InvalidLabel.MouseState = MaterialSkin.MouseState.HOVER;
            InvalidLabel.Name = "InvalidLabel";
            InvalidLabel.Size = new Size(172, 14);
            InvalidLabel.TabIndex = 14;
            InvalidLabel.Text = "* Invalid username or password";
            InvalidLabel.UseAccent = true;
            InvalidLabel.Visible = false;
            // 
            // ShowPasswordCheckbox
            // 
            ShowPasswordCheckbox.AutoSize = true;
            ShowPasswordCheckbox.Depth = 0;
            ShowPasswordCheckbox.Location = new Point(42, 341);
            ShowPasswordCheckbox.Margin = new Padding(0);
            ShowPasswordCheckbox.MouseLocation = new Point(-1, -1);
            ShowPasswordCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            ShowPasswordCheckbox.ReadOnly = false;
            ShowPasswordCheckbox.Ripple = true;
            ShowPasswordCheckbox.Size = new Size(148, 37);
            ShowPasswordCheckbox.TabIndex = 15;
            ShowPasswordCheckbox.Text = "Show password";
            ShowPasswordCheckbox.UseVisualStyleBackColor = true;
            ShowPasswordCheckbox.CheckedChanged += ShowPasswordCheckbox_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(745, 541);
            Controls.Add(ShowPasswordCheckbox);
            Controls.Add(InvalidLabel);
            Controls.Add(CreateAccountBtn);
            Controls.Add(pictureBox1);
            Controls.Add(materialLabel1);
            Controls.Add(Title);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordField);
            Controls.Add(UsernameField);
            HelpButton = true;
            Name = "LoginForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox2 UsernameField;
        private MaterialSkin.Controls.MaterialTextBox2 PasswordField;
        private MaterialSkin.Controls.MaterialButton LoginBtn;
        private MaterialSkin.Controls.MaterialLabel Title;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel CreateAccountBtn;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel InvalidLabel;
        private MaterialSkin.Controls.MaterialCheckbox ShowPasswordCheckbox;
    }
}
