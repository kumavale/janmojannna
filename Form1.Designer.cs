namespace janmojannna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_remaining = new System.Windows.Forms.Label();
            this.label_hint = new System.Windows.Forms.Label();
            this.pictureBox_main = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_turn = new System.Windows.Forms.Button();
            this.label_accumulated = new System.Windows.Forms.Label();
            this.button_get = new System.Windows.Forms.Button();
            this.pictureBox_sub = new System.Windows.Forms.PictureBox();
            this.timer_anime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sub)).BeginInit();
            this.SuspendLayout();
            // 
            // label_remaining
            // 
            this.label_remaining.AutoSize = true;
            this.label_remaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_remaining.Location = new System.Drawing.Point(13, 13);
            this.label_remaining.Name = "label_remaining";
            this.label_remaining.Size = new System.Drawing.Size(136, 26);
            this.label_remaining.TabIndex = 0;
            this.label_remaining.Text = "のこり: 00 まい";
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.Location = new System.Drawing.Point(357, 448);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(111, 13);
            this.label_hint.TabIndex = 1;
            this.label_hint.Text = "※ スペースキーでめくる";
            // 
            // pictureBox_main
            // 
            this.pictureBox_main.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_main.Location = new System.Drawing.Point(32, 52);
            this.pictureBox_main.Name = "pictureBox_main";
            this.pictureBox_main.Size = new System.Drawing.Size(436, 348);
            this.pictureBox_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_main.TabIndex = 2;
            this.pictureBox_main.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(391, 13);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(93, 26);
            this.button_start.TabIndex = 3;
            this.button_start.TabStop = false;
            this.button_start.Text = "はじめから";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Button_start_Click);
            // 
            // button_turn
            // 
            this.button_turn.Location = new System.Drawing.Point(240, 420);
            this.button_turn.Name = "button_turn";
            this.button_turn.Size = new System.Drawing.Size(111, 41);
            this.button_turn.TabIndex = 4;
            this.button_turn.Text = "めくる";
            this.button_turn.UseVisualStyleBackColor = true;
            this.button_turn.Click += new System.EventHandler(this.Button_turn_Click);
            // 
            // label_accumulated
            // 
            this.label_accumulated.AutoSize = true;
            this.label_accumulated.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_accumulated.Location = new System.Drawing.Point(12, 420);
            this.label_accumulated.Name = "label_accumulated";
            this.label_accumulated.Size = new System.Drawing.Size(43, 13);
            this.label_accumulated.TabIndex = 5;
            this.label_accumulated.Text = "XX まい";
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(62, 420);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(111, 41);
            this.button_get.TabIndex = 6;
            this.button_get.TabStop = false;
            this.button_get.Text = "かくとく";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.Button_get_Click);
            // 
            // pictureBox_sub
            // 
            this.pictureBox_sub.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_sub.Location = new System.Drawing.Point(32, 52);
            this.pictureBox_sub.Name = "pictureBox_sub";
            this.pictureBox_sub.Size = new System.Drawing.Size(436, 348);
            this.pictureBox_sub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_sub.TabIndex = 7;
            this.pictureBox_sub.TabStop = false;
            // 
            // timer_anime
            // 
            this.timer_anime.Interval = 10;
            this.timer_anime.Tick += new System.EventHandler(this.Timer_anime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.label_remaining);
            this.Controls.Add(this.label_hint);
            this.Controls.Add(this.button_turn);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.label_accumulated);
            this.Controls.Add(this.pictureBox_sub);
            this.Controls.Add(this.pictureBox_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ジャンモジャンナ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_sub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_remaining;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.PictureBox pictureBox_main;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_turn;
        private System.Windows.Forms.Label label_accumulated;
        private System.Windows.Forms.Button button_get;
        private System.Windows.Forms.PictureBox pictureBox_sub;
        private System.Windows.Forms.Timer timer_anime;
    }
}

