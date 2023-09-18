namespace SCharp_bai12
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyn = new System.Windows.Forms.TextBox();
            this.txtyob = new System.Windows.Forms.TextBox();
            this.btshow = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year of birth";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtyn
            // 
            this.txtyn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyn.Location = new System.Drawing.Point(320, 96);
            this.txtyn.Name = "txtyn";
            this.txtyn.Size = new System.Drawing.Size(392, 38);
            this.txtyn.TabIndex = 2;
            this.txtyn.Leave += new System.EventHandler(this.txtyn_Leave);
            // 
            // txtyob
            // 
            this.txtyob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtyob.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtyob.Location = new System.Drawing.Point(320, 209);
            this.txtyob.Name = "txtyob";
            this.txtyob.Size = new System.Drawing.Size(392, 38);
            this.txtyob.TabIndex = 3;
            // 
            // btshow
            // 
            this.btshow.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btshow.Location = new System.Drawing.Point(202, 343);
            this.btshow.Name = "btshow";
            this.btshow.Size = new System.Drawing.Size(109, 49);
            this.btshow.TabIndex = 4;
            this.btshow.Text = "&Show";
            this.btshow.UseVisualStyleBackColor = true;
            // 
            // btclear
            // 
            this.btclear.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btclear.Location = new System.Drawing.Point(476, 343);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(108, 49);
            this.btclear.TabIndex = 5;
            this.btclear.Text = "&Clear";
            this.btclear.UseVisualStyleBackColor = true;
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Location = new System.Drawing.Point(721, 343);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(105, 49);
            this.btexit.TabIndex = 6;
            this.btexit.Text = "E&xit";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 637);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btclear);
            this.Controls.Add(this.btshow);
            this.Controls.Add(this.txtyob);
            this.Controls.Add(this.txtyn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "year of birth";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyn;
        private System.Windows.Forms.TextBox txtyob;
        private System.Windows.Forms.Button btshow;
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

