namespace LifeGame
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
            pictureBox1 = new PictureBox();
            btnStart = new Button();
            btnStop = new Button();
            btnClear = new Button();
            btnPreset01 = new Button();
            btnPreset02 = new Button();
            btnPreset03 = new Button();
            btnPreset04 = new Button();
            timNextGeneration = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 400);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(424, 16);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(192, 23);
            btnStart.TabIndex = 1;
            btnStart.Text = "開始";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(424, 48);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(192, 23);
            btnStop.TabIndex = 2;
            btnStop.Text = "停止";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(424, 80);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(192, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "クリア";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPreset01
            // 
            btnPreset01.Location = new Point(424, 112);
            btnPreset01.Name = "btnPreset01";
            btnPreset01.Size = new Size(192, 23);
            btnPreset01.TabIndex = 4;
            btnPreset01.Text = "プリセット1 - 基本";
            btnPreset01.UseVisualStyleBackColor = true;
            btnPreset01.Click += btnPreset01_Click;
            // 
            // btnPreset02
            // 
            btnPreset02.Location = new Point(424, 144);
            btnPreset02.Name = "btnPreset02";
            btnPreset02.Size = new Size(192, 23);
            btnPreset02.TabIndex = 5;
            btnPreset02.Text = "プリセット2 - 移動物体";
            btnPreset02.UseVisualStyleBackColor = true;
            btnPreset02.Click += btnPreset02_Click;
            // 
            // btnPreset03
            // 
            btnPreset03.Location = new Point(424, 176);
            btnPreset03.Name = "btnPreset03";
            btnPreset03.Size = new Size(192, 23);
            btnPreset03.TabIndex = 6;
            btnPreset03.Text = "プリセット3 - グライダー銃";
            btnPreset03.UseVisualStyleBackColor = true;
            btnPreset03.Click += btnPreset03_Click;
            // 
            // btnPreset04
            // 
            btnPreset04.Location = new Point(424, 208);
            btnPreset04.Name = "btnPreset04";
            btnPreset04.Size = new Size(192, 23);
            btnPreset04.TabIndex = 7;
            btnPreset04.Text = "プリセット4 - GEEX";
            btnPreset04.UseVisualStyleBackColor = true;
            btnPreset04.Click += btnPreset04_Click;
            // 
            // timNextGeneration
            // 
            timNextGeneration.Tick += timNextGeneration_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(btnPreset04);
            Controls.Add(btnPreset03);
            Controls.Add(btnPreset02);
            Controls.Add(btnPreset01);
            Controls.Add(btnClear);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnStart;
        private Button btnStop;
        private Button btnClear;
        private Button btnPreset01;
        private Button btnPreset02;
        private Button btnPreset03;
        private Button btnPreset04;
        private System.Windows.Forms.Timer timNextGeneration;
    }
}