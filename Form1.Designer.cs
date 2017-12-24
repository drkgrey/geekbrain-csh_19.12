namespace csh_19._12
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
            this.labi = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.pathFindButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labi.SuspendLayout();
            this.SuspendLayout();
            // 
            // labi
            // 
            this.labi.BackColor = System.Drawing.Color.White;
            this.labi.Controls.Add(this.label2);
            this.labi.Controls.Add(this.label1);
            this.labi.Location = new System.Drawing.Point(176, 50);
            this.labi.Name = "labi";
            this.labi.Size = new System.Drawing.Size(200, 200);
            this.labi.TabIndex = 0;
            this.labi.Paint += new System.Windows.Forms.PaintEventHandler(this.labi_Paint);
            this.labi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labi_MouseDown);
            this.labi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.labi_MouseMove);
            this.labi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.labi_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 10);
            this.label1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(190, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 10);
            this.label2.TabIndex = 4;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(50, 133);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pathFindButton
            // 
            this.pathFindButton.Location = new System.Drawing.Point(50, 50);
            this.pathFindButton.Name = "pathFindButton";
            this.pathFindButton.Size = new System.Drawing.Size(75, 23);
            this.pathFindButton.TabIndex = 2;
            this.pathFindButton.Text = "поиск пути";
            this.pathFindButton.UseVisualStyleBackColor = true;
            this.pathFindButton.Click += new System.EventHandler(this.pathFindButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(50, 206);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 285);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.pathFindButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.labi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.labi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel labi;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button pathFindButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitButton;
    }
}

