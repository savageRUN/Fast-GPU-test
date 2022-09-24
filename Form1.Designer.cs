
namespace Fast_GPU_test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openGLControl1 = new SharpGL.OpenGLControl();
            this.buttonStartORStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInputX = new System.Windows.Forms.TextBox();
            this.textBoxInputY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInoutZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 50);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast GPU test";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(855, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(809, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // openGLControl1
            // 
            this.openGLControl1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.openGLControl1.DrawFPS = true;
            this.openGLControl1.FrameRate = 60;
            this.openGLControl1.Location = new System.Drawing.Point(0, 50);
            this.openGLControl1.Name = "openGLControl1";
            this.openGLControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL4_4;
            this.openGLControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl1.Size = new System.Drawing.Size(600, 450);
            this.openGLControl1.TabIndex = 1;
            this.openGLControl1.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl1_OpenGLDraw);
            this.openGLControl1.Load += new System.EventHandler(this.openGLControl1_Load);
            // 
            // buttonStartORStop
            // 
            this.buttonStartORStop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonStartORStop.FlatAppearance.BorderSize = 0;
            this.buttonStartORStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartORStop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartORStop.Location = new System.Drawing.Point(606, 56);
            this.buttonStartORStop.Name = "buttonStartORStop";
            this.buttonStartORStop.Size = new System.Drawing.Size(100, 30);
            this.buttonStartORStop.TabIndex = 2;
            this.buttonStartORStop.Text = "Пуск";
            this.buttonStartORStop.UseVisualStyleBackColor = false;
            this.buttonStartORStop.Click += new System.EventHandler(this.buttonStartORStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(611, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "X :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxInputX
            // 
            this.textBoxInputX.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputX.Location = new System.Drawing.Point(649, 102);
            this.textBoxInputX.Name = "textBoxInputX";
            this.textBoxInputX.Size = new System.Drawing.Size(239, 25);
            this.textBoxInputX.TabIndex = 4;
            this.textBoxInputX.Text = "1";
            this.textBoxInputX.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxInputY
            // 
            this.textBoxInputY.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputY.Location = new System.Drawing.Point(649, 133);
            this.textBoxInputY.Name = "textBoxInputY";
            this.textBoxInputY.Size = new System.Drawing.Size(239, 25);
            this.textBoxInputY.TabIndex = 6;
            this.textBoxInputY.Text = "1";
            this.textBoxInputY.TextChanged += new System.EventHandler(this.textBoxInputY_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(611, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y :";
            // 
            // textBoxInoutZ
            // 
            this.textBoxInoutZ.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInoutZ.Location = new System.Drawing.Point(649, 164);
            this.textBoxInoutZ.Name = "textBoxInoutZ";
            this.textBoxInoutZ.Size = new System.Drawing.Size(239, 25);
            this.textBoxInoutZ.TabIndex = 8;
            this.textBoxInoutZ.Text = "1";
            this.textBoxInoutZ.TextChanged += new System.EventHandler(this.textBoxInoutZ_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(611, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Z :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.textBoxInoutZ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInputY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxInputX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStartORStop);
            this.Controls.Add(this.openGLControl1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private SharpGL.OpenGLControl openGLControl1;
        private System.Windows.Forms.Button buttonStartORStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInputX;
        private System.Windows.Forms.TextBox textBoxInputY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInoutZ;
        private System.Windows.Forms.Label label4;
    }
}

