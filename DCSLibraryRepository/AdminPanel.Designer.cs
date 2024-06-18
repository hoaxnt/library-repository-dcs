namespace DCSLibraryRepository
{
    partial class AdminPanel
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
            UserListPanel = new MaterialSkin.Controls.MaterialListBox();
            EditBtn = new MaterialSkin.Controls.MaterialButton();
            AdminUsersPanel = new MaterialSkin.Controls.MaterialCard();
            DeleteBtn = new MaterialSkin.Controls.MaterialButton();
            AdminUsersPanel.SuspendLayout();
            SuspendLayout();
            // 
            // UserListPanel
            // 
            UserListPanel.Anchor = AnchorStyles.Top;
            UserListPanel.BackColor = Color.White;
            UserListPanel.BorderColor = Color.LightGray;
            UserListPanel.Depth = 0;
            UserListPanel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserListPanel.Location = new Point(227, 17);
            UserListPanel.MouseState = MaterialSkin.MouseState.HOVER;
            UserListPanel.Name = "UserListPanel";
            UserListPanel.SelectedIndex = -1;
            UserListPanel.SelectedItem = null;
            UserListPanel.Size = new Size(678, 361);
            UserListPanel.TabIndex = 0;
            // 
            // EditBtn
            // 
            EditBtn.AutoSize = false;
            EditBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            EditBtn.Depth = 0;
            EditBtn.HighEmphasis = true;
            EditBtn.Icon = null;
            EditBtn.Location = new Point(18, 20);
            EditBtn.Margin = new Padding(4, 6, 4, 6);
            EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            EditBtn.Name = "EditBtn";
            EditBtn.NoAccentTextColor = Color.Empty;
            EditBtn.Size = new Size(124, 36);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "Edit";
            EditBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            EditBtn.UseAccentColor = false;
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // AdminUsersPanel
            // 
            AdminUsersPanel.BackColor = Color.FromArgb(255, 255, 255);
            AdminUsersPanel.Controls.Add(DeleteBtn);
            AdminUsersPanel.Controls.Add(EditBtn);
            AdminUsersPanel.Controls.Add(UserListPanel);
            AdminUsersPanel.Depth = 0;
            AdminUsersPanel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            AdminUsersPanel.Location = new Point(17, 78);
            AdminUsersPanel.Margin = new Padding(14);
            AdminUsersPanel.MouseState = MaterialSkin.MouseState.HOVER;
            AdminUsersPanel.Name = "AdminUsersPanel";
            AdminUsersPanel.Padding = new Padding(14);
            AdminUsersPanel.Size = new Size(922, 395);
            AdminUsersPanel.TabIndex = 2;
            // 
            // DeleteBtn
            // 
            DeleteBtn.AutoSize = false;
            DeleteBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            DeleteBtn.Depth = 0;
            DeleteBtn.HighEmphasis = true;
            DeleteBtn.Icon = null;
            DeleteBtn.Location = new Point(18, 82);
            DeleteBtn.Margin = new Padding(4, 6, 4, 6);
            DeleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.NoAccentTextColor = Color.Empty;
            DeleteBtn.Size = new Size(124, 36);
            DeleteBtn.TabIndex = 2;
            DeleteBtn.Text = "Delete";
            DeleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            DeleteBtn.UseAccentColor = false;
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 490);
            Controls.Add(AdminUsersPanel);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            AdminUsersPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox UserListPanel;
        private MaterialSkin.Controls.MaterialButton EditBtn;
        private MaterialSkin.Controls.MaterialCard AdminUsersPanel;
        private MaterialSkin.Controls.MaterialButton DeleteBtn;
    }
}