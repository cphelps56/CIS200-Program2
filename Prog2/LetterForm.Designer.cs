namespace Prog2
{
    partial class LetterForm
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
            this.originAddressLabel = new System.Windows.Forms.Label();
            this.destinationAddressLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.originAddressComboBox = new System.Windows.Forms.ComboBox();
            this.destinationAddressComboBox = new System.Windows.Forms.ComboBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.letterErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddressLabel
            // 
            this.originAddressLabel.AutoSize = true;
            this.originAddressLabel.Location = new System.Drawing.Point(48, 22);
            this.originAddressLabel.Name = "originAddressLabel";
            this.originAddressLabel.Size = new System.Drawing.Size(78, 13);
            this.originAddressLabel.TabIndex = 5;
            this.originAddressLabel.Text = "Origin Address:";
            // 
            // destinationAddressLabel
            // 
            this.destinationAddressLabel.AutoSize = true;
            this.destinationAddressLabel.Location = new System.Drawing.Point(25, 49);
            this.destinationAddressLabel.Name = "destinationAddressLabel";
            this.destinationAddressLabel.Size = new System.Drawing.Size(104, 13);
            this.destinationAddressLabel.TabIndex = 6;
            this.destinationAddressLabel.Text = "Destination Address:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(67, 76);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(59, 13);
            this.costLabel.TabIndex = 7;
            this.costLabel.Text = "Fixed Cost:";
            // 
            // originAddressComboBox
            // 
            this.originAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddressComboBox.FormattingEnabled = true;
            this.originAddressComboBox.Location = new System.Drawing.Point(135, 19);
            this.originAddressComboBox.Name = "originAddressComboBox";
            this.originAddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.originAddressComboBox.TabIndex = 0;
            this.originAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.originAddressComboBox_Validating);
            this.originAddressComboBox.Validated += new System.EventHandler(this.originAddressComboBox_Validated);
            // 
            // destinationAddressComboBox
            // 
            this.destinationAddressComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationAddressComboBox.FormattingEnabled = true;
            this.destinationAddressComboBox.Location = new System.Drawing.Point(135, 46);
            this.destinationAddressComboBox.Name = "destinationAddressComboBox";
            this.destinationAddressComboBox.Size = new System.Drawing.Size(121, 21);
            this.destinationAddressComboBox.TabIndex = 1;
            this.destinationAddressComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.destinationAddressComboBox_Validating);
            this.destinationAddressComboBox.Validated += new System.EventHandler(this.destinationAddressComboBox_Validated);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(135, 73);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(121, 20);
            this.costTextBox.TabIndex = 2;
            this.costTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.costTextBox_Validating);
            this.costTextBox.Validated += new System.EventHandler(this.costTextBox_Validated);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(31, 119);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 3;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.CausesValidation = false;
            this.cancelBtn.Location = new System.Drawing.Point(181, 119);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // letterErrorProvider
            // 
            this.letterErrorProvider.ContainerControl = this;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 154);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.destinationAddressComboBox);
            this.Controls.Add(this.originAddressComboBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.destinationAddressLabel);
            this.Controls.Add(this.originAddressLabel);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)(this.letterErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originAddressLabel;
        private System.Windows.Forms.Label destinationAddressLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ComboBox originAddressComboBox;
        private System.Windows.Forms.ComboBox destinationAddressComboBox;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ErrorProvider letterErrorProvider;
    }
}