
namespace sms_read
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.listAttachments = new System.Windows.Forms.TreeView();
            this.attachmentPanel = new System.Windows.Forms.Panel();
            this.labelAttachments = new System.Windows.Forms.Label();
            this.labelMessageNumber = new System.Windows.Forms.Label();
            this.menuViewSource = new System.Windows.Forms.MenuItem();
            this.menuDeleteMessage = new System.Windows.Forms.MenuItem();
            this.contextMenuMessages = new System.Windows.Forms.ContextMenu();
            this.panelMessagesView = new System.Windows.Forms.Panel();
            this.listMessages = new System.Windows.Forms.TreeView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.labelMessageBody = new System.Windows.Forms.Label();
            this.panelMessageBody = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.uidlButton = new System.Windows.Forms.Button();
            this.totalMessagesTextBox = new System.Windows.Forms.TextBox();
            this.labelTotalMessages = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.useSslCheckBox = new System.Windows.Forms.CheckBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.connectAndRetrieveButton = new System.Windows.Forms.Button();
            this.labelServerPort = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.labelServerAddress = new System.Windows.Forms.Label();
            this.popServerTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.attachmentPanel.SuspendLayout();
            this.panelMessagesView.SuspendLayout();
            this.panelMessageBody.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFile
            // 
            this.saveFile.Title = "Save Attachment";
            // 
            // listAttachments
            // 
            this.listAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAttachments.Location = new System.Drawing.Point(8, 24);
            this.listAttachments.Name = "listAttachments";
            this.listAttachments.ShowLines = false;
            this.listAttachments.ShowRootLines = false;
            this.listAttachments.Size = new System.Drawing.Size(192, 200);
            this.listAttachments.TabIndex = 10;
            // 
            // attachmentPanel
            // 
            this.attachmentPanel.Controls.Add(this.listAttachments);
            this.attachmentPanel.Controls.Add(this.labelAttachments);
            this.attachmentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.attachmentPanel.Location = new System.Drawing.Point(650, 0);
            this.attachmentPanel.Name = "attachmentPanel";
            this.attachmentPanel.Size = new System.Drawing.Size(208, 236);
            this.attachmentPanel.TabIndex = 4;
            this.attachmentPanel.Visible = false;
            // 
            // labelAttachments
            // 
            this.labelAttachments.Location = new System.Drawing.Point(12, 8);
            this.labelAttachments.Name = "labelAttachments";
            this.labelAttachments.Size = new System.Drawing.Size(136, 16);
            this.labelAttachments.TabIndex = 3;
            this.labelAttachments.Text = "Attachments";
            // 
            // labelMessageNumber
            // 
            this.labelMessageNumber.Location = new System.Drawing.Point(8, 8);
            this.labelMessageNumber.Name = "labelMessageNumber";
            this.labelMessageNumber.Size = new System.Drawing.Size(136, 16);
            this.labelMessageNumber.TabIndex = 1;
            this.labelMessageNumber.Text = "Messages";
            // 
            // menuViewSource
            // 
            this.menuViewSource.Index = 1;
            this.menuViewSource.Text = "View source";
            // 
            // menuDeleteMessage
            // 
            this.menuDeleteMessage.Index = 0;
            this.menuDeleteMessage.Text = "Delete Mail";
            this.menuDeleteMessage.Click += new System.EventHandler(this.menuDeleteMessage_Click);
            // 
            // contextMenuMessages
            // 
            this.contextMenuMessages.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuDeleteMessage,
            this.menuViewSource});
            this.contextMenuMessages.Popup += new System.EventHandler(this.contextMenuMessages_Popup);
            // 
            // panelMessagesView
            // 
            this.panelMessagesView.Controls.Add(this.listMessages);
            this.panelMessagesView.Controls.Add(this.labelMessageNumber);
            this.panelMessagesView.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMessagesView.Location = new System.Drawing.Point(0, 0);
            this.panelMessagesView.Name = "panelMessagesView";
            this.panelMessagesView.Size = new System.Drawing.Size(281, 236);
            this.panelMessagesView.TabIndex = 5;
            // 
            // listMessages
            // 
            this.listMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listMessages.ContextMenu = this.contextMenuMessages;
            this.listMessages.Location = new System.Drawing.Point(8, 24);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(266, 200);
            this.listMessages.TabIndex = 8;
            this.listMessages.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ListMessagesMessageSelected);
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(7, 212);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(353, 12);
            this.progressBar.TabIndex = 10;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Location = new System.Drawing.Point(7, 22);
            this.messageTextBox.MaxLength = 999999999;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.messageTextBox.Size = new System.Drawing.Size(353, 183);
            this.messageTextBox.TabIndex = 9;
            // 
            // labelMessageBody
            // 
            this.labelMessageBody.Location = new System.Drawing.Point(8, 8);
            this.labelMessageBody.Name = "labelMessageBody";
            this.labelMessageBody.Size = new System.Drawing.Size(136, 16);
            this.labelMessageBody.TabIndex = 5;
            this.labelMessageBody.Text = "Message Body";
            // 
            // panelMessageBody
            // 
            this.panelMessageBody.Controls.Add(this.progressBar);
            this.panelMessageBody.Controls.Add(this.messageTextBox);
            this.panelMessageBody.Controls.Add(this.labelMessageBody);
            this.panelMessageBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessageBody.Location = new System.Drawing.Point(281, 0);
            this.panelMessageBody.Name = "panelMessageBody";
            this.panelMessageBody.Size = new System.Drawing.Size(369, 236);
            this.panelMessageBody.TabIndex = 6;
            // 
            // panelMiddle
            // 
            this.panelMiddle.Controls.Add(this.panelMessageBody);
            this.panelMiddle.Controls.Add(this.panelMessagesView);
            this.panelMiddle.Controls.Add(this.attachmentPanel);
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(0, 64);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(858, 236);
            this.panelMiddle.TabIndex = 5;
            // 
            // uidlButton
            // 
            this.uidlButton.Enabled = false;
            this.uidlButton.Location = new System.Drawing.Point(460, 42);
            this.uidlButton.Name = "uidlButton";
            this.uidlButton.Size = new System.Drawing.Size(82, 21);
            this.uidlButton.TabIndex = 6;
            this.uidlButton.Text = "UIDL";
            this.uidlButton.Click += new System.EventHandler(this.uidlButton_Click);
            // 
            // totalMessagesTextBox
            // 
            this.totalMessagesTextBox.Location = new System.Drawing.Point(553, 30);
            this.totalMessagesTextBox.Name = "totalMessagesTextBox";
            this.totalMessagesTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalMessagesTextBox.TabIndex = 7;
            // 
            // labelTotalMessages
            // 
            this.labelTotalMessages.Location = new System.Drawing.Point(553, 7);
            this.labelTotalMessages.Name = "labelTotalMessages";
            this.labelTotalMessages.Size = new System.Drawing.Size(100, 23);
            this.labelTotalMessages.TabIndex = 9;
            this.labelTotalMessages.Text = "Total Messages";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.comboBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.useSslCheckBox);
            this.panelTop.Controls.Add(this.uidlButton);
            this.panelTop.Controls.Add(this.totalMessagesTextBox);
            this.panelTop.Controls.Add(this.labelTotalMessages);
            this.panelTop.Controls.Add(this.labelPassword);
            this.panelTop.Controls.Add(this.passwordTextBox);
            this.panelTop.Controls.Add(this.labelUsername);
            this.panelTop.Controls.Add(this.loginTextBox);
            this.panelTop.Controls.Add(this.connectAndRetrieveButton);
            this.panelTop.Controls.Add(this.labelServerPort);
            this.panelTop.Controls.Add(this.portTextBox);
            this.panelTop.Controls.Add(this.labelServerAddress);
            this.panelTop.Controls.Add(this.popServerTextBox);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(858, 64);
            this.panelTop.TabIndex = 3;
            // 
            // useSslCheckBox
            // 
            this.useSslCheckBox.AutoSize = true;
            this.useSslCheckBox.Checked = true;
            this.useSslCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSslCheckBox.Location = new System.Drawing.Point(19, 38);
            this.useSslCheckBox.Name = "useSslCheckBox";
            this.useSslCheckBox.Size = new System.Drawing.Size(68, 17);
            this.useSslCheckBox.TabIndex = 4;
            this.useSslCheckBox.Text = "Use SSL";
            this.useSslCheckBox.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Location = new System.Drawing.Point(264, 36);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 23);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(328, 36);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(128, 20);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.Text = "timur895";
            // 
            // labelUsername
            // 
            this.labelUsername.Location = new System.Drawing.Point(264, 5);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(64, 23);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "Username";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(328, 5);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(128, 20);
            this.loginTextBox.TabIndex = 1;
            this.loginTextBox.Text = "cihangir.ozdemir@timurlarsigorta.com";
            // 
            // connectAndRetrieveButton
            // 
            this.connectAndRetrieveButton.Location = new System.Drawing.Point(460, 0);
            this.connectAndRetrieveButton.Name = "connectAndRetrieveButton";
            this.connectAndRetrieveButton.Size = new System.Drawing.Size(82, 39);
            this.connectAndRetrieveButton.TabIndex = 5;
            this.connectAndRetrieveButton.Text = "Connect and Retreive";
            this.connectAndRetrieveButton.Click += new System.EventHandler(this.connectAndRetrieveButton_Click);
            // 
            // labelServerPort
            // 
            this.labelServerPort.Location = new System.Drawing.Point(97, 39);
            this.labelServerPort.Name = "labelServerPort";
            this.labelServerPort.Size = new System.Drawing.Size(31, 23);
            this.labelServerPort.TabIndex = 3;
            this.labelServerPort.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(128, 39);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(128, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "995";
            // 
            // labelServerAddress
            // 
            this.labelServerAddress.Location = new System.Drawing.Point(16, 8);
            this.labelServerAddress.Name = "labelServerAddress";
            this.labelServerAddress.Size = new System.Drawing.Size(112, 23);
            this.labelServerAddress.TabIndex = 1;
            this.labelServerAddress.Text = "POP Server Address";
            // 
            // popServerTextBox
            // 
            this.popServerTextBox.Location = new System.Drawing.Point(128, 8);
            this.popServerTextBox.Name = "popServerTextBox";
            this.popServerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.popServerTextBox.Size = new System.Drawing.Size(128, 20);
            this.popServerTextBox.TabIndex = 0;
            this.popServerTextBox.Text = "pop.yandex.ru";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "AXA SİGORTA",
            "ANADOLU SİGORTA",
            "ALLIANZ SİGORTA",
            "UNICO SİGORTA"});
            this.comboBox1.Location = new System.Drawing.Point(683, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(680, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hangi Şirketin Maili Kontrol edilcek";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 300);
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.attachmentPanel.ResumeLayout(false);
            this.panelMessagesView.ResumeLayout(false);
            this.panelMessageBody.ResumeLayout(false);
            this.panelMessageBody.PerformLayout();
            this.panelMiddle.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.TreeView listAttachments;
        private System.Windows.Forms.Panel attachmentPanel;
        private System.Windows.Forms.Label labelAttachments;
        private System.Windows.Forms.Label labelMessageNumber;
        private System.Windows.Forms.MenuItem menuViewSource;
        private System.Windows.Forms.MenuItem menuDeleteMessage;
        private System.Windows.Forms.ContextMenu contextMenuMessages;
        private System.Windows.Forms.Panel panelMessagesView;
        private System.Windows.Forms.TreeView listMessages;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label labelMessageBody;
        private System.Windows.Forms.Panel panelMessageBody;
        private System.Windows.Forms.Panel panelMiddle;
        private System.Windows.Forms.Button uidlButton;
        private System.Windows.Forms.TextBox totalMessagesTextBox;
        private System.Windows.Forms.Label labelTotalMessages;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.CheckBox useSslCheckBox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button connectAndRetrieveButton;
        private System.Windows.Forms.Label labelServerPort;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label labelServerAddress;
        private System.Windows.Forms.TextBox popServerTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

