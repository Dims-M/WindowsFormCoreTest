namespace WindowsFormsApp1
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
            this.bSave = new System.Windows.Forms.Button();
            this.bLoad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(15, 244);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(75, 34);
            this.bSave.TabIndex = 0;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(162, 244);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 34);
            this.bLoad.TabIndex = 0;
            this.bLoad.Text = "Загрузить";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(332, 244);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 34);
            this.bExit.TabIndex = 0;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(15, 46);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(392, 161);
            this.textBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 296);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bLoad);
            this.Controls.Add(this.bExit);
            this.MaximumSize = new System.Drawing.Size(445, 335);
            this.MinimumSize = new System.Drawing.Size(445, 335);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";

        }

        #endregion

        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.TextBox textBox;
    }
}

