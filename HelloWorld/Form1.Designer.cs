namespace HelloWorld
{
    partial class Form1
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
            this.helloWorld = new System.Windows.Forms.Button();
            this.modifiyMe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // helloWorld
            // 
            this.helloWorld.Location = new System.Drawing.Point(12, 12);
            this.helloWorld.Name = "helloWorld";
            this.helloWorld.Size = new System.Drawing.Size(157, 94);
            this.helloWorld.TabIndex = 0;
            this.helloWorld.Text = "Click me, please?";
            this.helloWorld.UseVisualStyleBackColor = true;
            this.helloWorld.Click += new System.EventHandler(this.helloWorld_Click);
            // 
            // modifiyMe
            // 
            this.modifiyMe.AutoSize = true;
            this.modifiyMe.Location = new System.Drawing.Point(12, 133);
            this.modifiyMe.Name = "modifiyMe";
            this.modifiyMe.Size = new System.Drawing.Size(111, 13);
            this.modifiyMe.TabIndex = 1;
            this.modifiyMe.Text = "I will hopefully change";
            this.modifiyMe.Click += new System.EventHandler(this.modifiyMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifiyMe);
            this.Controls.Add(this.helloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button helloWorld;
        private System.Windows.Forms.Label modifiyMe;
    }
}

