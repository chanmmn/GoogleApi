namespace WinFormsAppGmailLabel
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            gmailFolderListBindingSource = new BindingSource(components);
            btnLabel = new Button();
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            txtSecret = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtLabelId = new TextBox();
            btnAttach = new Button();
            label5 = new Label();
            txtDir = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gmailFolderListBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 241);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(449, 178);
            dataGridView1.TabIndex = 0;
            // 
            // gmailFolderListBindingSource
            // 
            gmailFolderListBindingSource.DataSource = typeof(GmailFolderList);
            // 
            // btnLabel
            // 
            btnLabel.Location = new Point(30, 202);
            btnLabel.Name = "btnLabel";
            btnLabel.Size = new Size(75, 23);
            btnLabel.TabIndex = 1;
            btnLabel.Text = "Find Label";
            btnLabel.UseVisualStyleBackColor = true;
            btnLabel.Click += btnLabel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Client Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Client Secret";
            // 
            // txtId
            // 
            txtId.Location = new Point(133, 22);
            txtId.Name = "txtId";
            txtId.Size = new Size(311, 23);
            txtId.TabIndex = 4;
            // 
            // txtSecret
            // 
            txtSecret.Location = new Point(133, 51);
            txtSecret.Name = "txtSecret";
            txtSecret.Size = new Size(311, 23);
            txtSecret.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 7;
            label4.Text = "Label Id";
            // 
            // txtLabelId
            // 
            txtLabelId.Location = new Point(133, 152);
            txtLabelId.Name = "txtLabelId";
            txtLabelId.Size = new Size(311, 23);
            txtLabelId.TabIndex = 8;
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(133, 202);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(153, 23);
            btnAttach.TabIndex = 9;
            btnAttach.Text = "Get Attachment";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 83);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 10;
            label5.Text = "Folder";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(133, 80);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(311, 23);
            txtDir.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDir);
            Controls.Add(label5);
            Controls.Add(btnAttach);
            Controls.Add(txtLabelId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSecret);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLabel);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gmailFolderListBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLabel;
        private Label label1;
        private Label label2;
        private TextBox txtId;
        private TextBox txtSecret;
        private Label label3;
        private Label label4;
        private TextBox txtLabelId;
        private Button btnAttach;
        private BindingSource gmailFolderListBindingSource;
        private Label label5;
        private TextBox txtDir;
    }
}
