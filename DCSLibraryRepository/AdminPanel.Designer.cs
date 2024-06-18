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
            SuspendLayout();
            // 
            // UserListPanel
            // 
            UserListPanel.Anchor = AnchorStyles.Top;
            UserListPanel.BackColor = Color.White;
            UserListPanel.BorderColor = Color.LightGray;
            UserListPanel.Depth = 0;
            UserListPanel.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            UserListPanel.Location = new Point(190, 80);
            UserListPanel.MouseState = MaterialSkin.MouseState.HOVER;
            UserListPanel.Name = "UserListPanel";
            UserListPanel.SelectedIndex = -1;
            UserListPanel.SelectedItem = null;
            UserListPanel.Size = new Size(590, 278);
            UserListPanel.TabIndex = 0;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(UserListPanel);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox UserListPanel;
    }
}