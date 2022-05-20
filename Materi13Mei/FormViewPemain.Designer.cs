namespace Materi13Mei
{
    partial class FormViewPemain
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
            this.btn_Last = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Prev = new System.Windows.Forms.Button();
            this.btn_First = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_ID = new System.Windows.Forms.TextBox();
            this.tBox_Nama = new System.Windows.Forms.TextBox();
            this.tBox_Goal = new System.Windows.Forms.TextBox();
            this.tBox_GoalPenalty = new System.Windows.Forms.TextBox();
            this.tBox_KartuKuning = new System.Windows.Forms.TextBox();
            this.tBox_KartuMerah = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Last
            // 
            this.btn_Last.Location = new System.Drawing.Point(246, 12);
            this.btn_Last.Name = "btn_Last";
            this.btn_Last.Size = new System.Drawing.Size(75, 23);
            this.btn_Last.TabIndex = 51;
            this.btn_Last.Text = ">>";
            this.btn_Last.UseVisualStyleBackColor = true;
            this.btn_Last.Click += new System.EventHandler(this.btn_Last_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(167, 12);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 50;
            this.btn_Next.Text = ">";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Prev
            // 
            this.btn_Prev.Location = new System.Drawing.Point(89, 12);
            this.btn_Prev.Name = "btn_Prev";
            this.btn_Prev.Size = new System.Drawing.Size(75, 23);
            this.btn_Prev.TabIndex = 49;
            this.btn_Prev.Text = "<";
            this.btn_Prev.UseVisualStyleBackColor = true;
            this.btn_Prev.Click += new System.EventHandler(this.btn_Prev_Click);
            // 
            // btn_First
            // 
            this.btn_First.Location = new System.Drawing.Point(8, 12);
            this.btn_First.Name = "btn_First";
            this.btn_First.Size = new System.Drawing.Size(75, 23);
            this.btn_First.TabIndex = 48;
            this.btn_First.Text = "<<";
            this.btn_First.UseVisualStyleBackColor = true;
            this.btn_First.Click += new System.EventHandler(this.btn_First_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "ID Pemain";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nama Pemain";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Jumlah GOal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Jumlah Goal Penalty";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Jumlah Kartu Kuning";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Jumlah Kartu Merah";
            // 
            // tBox_ID
            // 
            this.tBox_ID.Enabled = false;
            this.tBox_ID.Location = new System.Drawing.Point(110, 55);
            this.tBox_ID.Name = "tBox_ID";
            this.tBox_ID.Size = new System.Drawing.Size(100, 20);
            this.tBox_ID.TabIndex = 58;
            // 
            // tBox_Nama
            // 
            this.tBox_Nama.Location = new System.Drawing.Point(110, 81);
            this.tBox_Nama.Name = "tBox_Nama";
            this.tBox_Nama.Size = new System.Drawing.Size(168, 20);
            this.tBox_Nama.TabIndex = 59;
            // 
            // tBox_Goal
            // 
            this.tBox_Goal.Location = new System.Drawing.Point(110, 107);
            this.tBox_Goal.Name = "tBox_Goal";
            this.tBox_Goal.Size = new System.Drawing.Size(100, 20);
            this.tBox_Goal.TabIndex = 60;
            // 
            // tBox_GoalPenalty
            // 
            this.tBox_GoalPenalty.Location = new System.Drawing.Point(110, 133);
            this.tBox_GoalPenalty.Name = "tBox_GoalPenalty";
            this.tBox_GoalPenalty.Size = new System.Drawing.Size(100, 20);
            this.tBox_GoalPenalty.TabIndex = 61;
            // 
            // tBox_KartuKuning
            // 
            this.tBox_KartuKuning.Location = new System.Drawing.Point(110, 159);
            this.tBox_KartuKuning.Name = "tBox_KartuKuning";
            this.tBox_KartuKuning.Size = new System.Drawing.Size(100, 20);
            this.tBox_KartuKuning.TabIndex = 62;
            // 
            // tBox_KartuMerah
            // 
            this.tBox_KartuMerah.Location = new System.Drawing.Point(110, 185);
            this.tBox_KartuMerah.Name = "tBox_KartuMerah";
            this.tBox_KartuMerah.Size = new System.Drawing.Size(100, 20);
            this.tBox_KartuMerah.TabIndex = 63;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(8, 217);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 64;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            // 
            // FormViewPemain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tBox_KartuMerah);
            this.Controls.Add(this.tBox_KartuKuning);
            this.Controls.Add(this.tBox_GoalPenalty);
            this.Controls.Add(this.tBox_Goal);
            this.Controls.Add(this.tBox_Nama);
            this.Controls.Add(this.tBox_ID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Last);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Prev);
            this.Controls.Add(this.btn_First);
            this.Name = "FormViewPemain";
            this.Text = "FormViewPemain";
            this.Load += new System.EventHandler(this.FormViewPemain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Last;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Prev;
        private System.Windows.Forms.Button btn_First;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBox_ID;
        private System.Windows.Forms.TextBox tBox_Nama;
        private System.Windows.Forms.TextBox tBox_Goal;
        private System.Windows.Forms.TextBox tBox_GoalPenalty;
        private System.Windows.Forms.TextBox tBox_KartuKuning;
        private System.Windows.Forms.TextBox tBox_KartuMerah;
        private System.Windows.Forms.Button btn_Update;
    }
}