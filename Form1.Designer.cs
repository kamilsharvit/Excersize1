
namespace KamilSharvit
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.countOfName = new System.Windows.Forms.NumericUpDown();
            this.countsName = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.addList2 = new System.Windows.Forms.Button();
            this.mizug = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.countOfName)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(836, 66);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(133, 22);
            this.nameTxt.TabIndex = 0;
            // 
            // countOfName
            // 
            this.countOfName.Location = new System.Drawing.Point(836, 113);
            this.countOfName.Margin = new System.Windows.Forms.Padding(4);
            this.countOfName.Name = "countOfName";
            this.countOfName.Size = new System.Drawing.Size(133, 22);
            this.countOfName.TabIndex = 1;
            // 
            // countsName
            // 
            this.countsName.Location = new System.Drawing.Point(851, 170);
            this.countsName.Margin = new System.Windows.Forms.Padding(4);
            this.countsName.Name = "countsName";
            this.countsName.Size = new System.Drawing.Size(100, 28);
            this.countsName.TabIndex = 2;
            this.countsName.Text = "countsNames";
            this.countsName.UseVisualStyleBackColor = true;
            this.countsName.Click += new System.EventHandler(this.addList1_Click);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(413, 66);
            this.name1.Margin = new System.Windows.Forms.Padding(4);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(132, 22);
            this.name1.TabIndex = 3;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(413, 112);
            this.name2.Margin = new System.Windows.Forms.Padding(4);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(132, 22);
            this.name2.TabIndex = 4;
            // 
            // addList2
            // 
            this.addList2.Location = new System.Drawing.Point(428, 170);
            this.addList2.Margin = new System.Windows.Forms.Padding(4);
            this.addList2.Name = "addList2";
            this.addList2.Size = new System.Drawing.Size(100, 28);
            this.addList2.TabIndex = 5;
            this.addList2.Text = "names";
            this.addList2.UseVisualStyleBackColor = true;
            this.addList2.Click += new System.EventHandler(this.addList2_Click);
            // 
            // mizug
            // 
            this.mizug.Location = new System.Drawing.Point(643, 269);
            this.mizug.Margin = new System.Windows.Forms.Padding(4);
            this.mizug.Name = "mizug";
            this.mizug.Size = new System.Drawing.Size(100, 28);
            this.mizug.TabIndex = 6;
            this.mizug.Text = "מיזוג";
            this.mizug.UseVisualStyleBackColor = true;
            this.mizug.Click += new System.EventHandler(this.mizug_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 28);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 180);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.mizug);
            this.Controls.Add(this.addList2);
            this.Controls.Add(this.name2);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.countsName);
            this.Controls.Add(this.countOfName);
            this.Controls.Add(this.nameTxt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.countOfName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.NumericUpDown countOfName;
        private System.Windows.Forms.Button countsName;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.Button addList2;
        private System.Windows.Forms.Button mizug;
        private System.Windows.Forms.ListBox listBox1;
    }
}

