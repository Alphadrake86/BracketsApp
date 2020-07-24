namespace BracketsApp
{
    partial class Form2
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
            this.Round1Box1 = new System.Windows.Forms.TextBox();
            this.SecondPlace = new System.Windows.Forms.TextBox();
            this.Round2Box2 = new System.Windows.Forms.TextBox();
            this.Round1Box4 = new System.Windows.Forms.TextBox();
            this.FirstPlace = new System.Windows.Forms.TextBox();
            this.Round1Box3 = new System.Windows.Forms.TextBox();
            this.Round2Box1 = new System.Windows.Forms.TextBox();
            this.Round1Box2 = new System.Windows.Forms.TextBox();
            this.Page = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.forward1 = new System.Windows.Forms.Button();
            this.forwardAll = new System.Windows.Forms.Button();
            this.back1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Page)).BeginInit();
            this.SuspendLayout();
            // 
            // Round1Box1
            // 
            this.Round1Box1.Location = new System.Drawing.Point(12, 12);
            this.Round1Box1.Name = "Round1Box1";
            this.Round1Box1.ReadOnly = true;
            this.Round1Box1.Size = new System.Drawing.Size(100, 20);
            this.Round1Box1.TabIndex = 0;
            this.Round1Box1.TabStop = false;
            // 
            // SecondPlace
            // 
            this.SecondPlace.Location = new System.Drawing.Point(224, 116);
            this.SecondPlace.Name = "SecondPlace";
            this.SecondPlace.ReadOnly = true;
            this.SecondPlace.Size = new System.Drawing.Size(100, 20);
            this.SecondPlace.TabIndex = 1;
            this.SecondPlace.TabStop = false;
            // 
            // Round2Box2
            // 
            this.Round2Box2.Location = new System.Drawing.Point(118, 142);
            this.Round2Box2.Name = "Round2Box2";
            this.Round2Box2.ReadOnly = true;
            this.Round2Box2.Size = new System.Drawing.Size(100, 20);
            this.Round2Box2.TabIndex = 2;
            this.Round2Box2.TabStop = false;
            // 
            // Round1Box4
            // 
            this.Round1Box4.Location = new System.Drawing.Point(12, 168);
            this.Round1Box4.Name = "Round1Box4";
            this.Round1Box4.ReadOnly = true;
            this.Round1Box4.Size = new System.Drawing.Size(100, 20);
            this.Round1Box4.TabIndex = 11;
            this.Round1Box4.TabStop = false;
            // 
            // FirstPlace
            // 
            this.FirstPlace.Location = new System.Drawing.Point(224, 64);
            this.FirstPlace.Name = "FirstPlace";
            this.FirstPlace.ReadOnly = true;
            this.FirstPlace.Size = new System.Drawing.Size(100, 20);
            this.FirstPlace.TabIndex = 12;
            this.FirstPlace.TabStop = false;
            // 
            // Round1Box3
            // 
            this.Round1Box3.Location = new System.Drawing.Point(12, 116);
            this.Round1Box3.Name = "Round1Box3";
            this.Round1Box3.ReadOnly = true;
            this.Round1Box3.Size = new System.Drawing.Size(100, 20);
            this.Round1Box3.TabIndex = 13;
            this.Round1Box3.TabStop = false;
            // 
            // Round2Box1
            // 
            this.Round2Box1.Location = new System.Drawing.Point(118, 38);
            this.Round2Box1.Name = "Round2Box1";
            this.Round2Box1.ReadOnly = true;
            this.Round2Box1.Size = new System.Drawing.Size(100, 20);
            this.Round2Box1.TabIndex = 15;
            this.Round2Box1.TabStop = false;
            // 
            // Round1Box2
            // 
            this.Round1Box2.Location = new System.Drawing.Point(12, 64);
            this.Round1Box2.Name = "Round1Box2";
            this.Round1Box2.ReadOnly = true;
            this.Round1Box2.Size = new System.Drawing.Size(100, 20);
            this.Round1Box2.TabIndex = 16;
            this.Round1Box2.TabStop = false;
            // 
            // Page
            // 
            this.Page.Location = new System.Drawing.Point(195, 187);
            this.Page.Name = "Page";
            this.Page.Size = new System.Drawing.Size(52, 20);
            this.Page.TabIndex = 29;
            this.Page.ValueChanged += new System.EventHandler(this.Page_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "of xx";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 20);
            this.button3.TabIndex = 27;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // forward1
            // 
            this.forward1.Location = new System.Drawing.Point(294, 187);
            this.forward1.Name = "forward1";
            this.forward1.Size = new System.Drawing.Size(20, 20);
            this.forward1.TabIndex = 26;
            this.forward1.Text = ">";
            this.forward1.UseVisualStyleBackColor = true;
            this.forward1.Click += new System.EventHandler(this.forward1_Click);
            // 
            // forwardAll
            // 
            this.forwardAll.Location = new System.Drawing.Point(322, 187);
            this.forwardAll.Name = "forwardAll";
            this.forwardAll.Size = new System.Drawing.Size(30, 20);
            this.forwardAll.TabIndex = 25;
            this.forwardAll.Text = ">>";
            this.forwardAll.UseVisualStyleBackColor = true;
            this.forwardAll.Click += new System.EventHandler(this.forwardAll_Click);
            // 
            // back1
            // 
            this.back1.Location = new System.Drawing.Point(169, 187);
            this.back1.Name = "back1";
            this.back1.Size = new System.Drawing.Size(20, 20);
            this.back1.TabIndex = 24;
            this.back1.Text = "<";
            this.back1.UseVisualStyleBackColor = true;
            this.back1.Click += new System.EventHandler(this.back1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 219);
            this.Controls.Add(this.Page);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.forward1);
            this.Controls.Add(this.forwardAll);
            this.Controls.Add(this.back1);
            this.Controls.Add(this.Round1Box2);
            this.Controls.Add(this.Round2Box1);
            this.Controls.Add(this.Round1Box3);
            this.Controls.Add(this.FirstPlace);
            this.Controls.Add(this.Round1Box4);
            this.Controls.Add(this.Round2Box2);
            this.Controls.Add(this.SecondPlace);
            this.Controls.Add(this.Round1Box1);
            this.Name = "Form2";
            this.Text = "Tournament Results";
            ((System.ComponentModel.ISupportInitialize)(this.Page)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Round1Box1;
        private System.Windows.Forms.TextBox SecondPlace;
        private System.Windows.Forms.TextBox Round2Box2;
        private System.Windows.Forms.TextBox Round1Box4;
        private System.Windows.Forms.TextBox FirstPlace;
        private System.Windows.Forms.TextBox Round1Box3;
        private System.Windows.Forms.TextBox Round2Box1;
        private System.Windows.Forms.TextBox Round1Box2;
        private System.Windows.Forms.NumericUpDown Page;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button forward1;
        private System.Windows.Forms.Button forwardAll;
        private System.Windows.Forms.Button back1;
    }
}