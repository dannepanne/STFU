using System.Runtime.InteropServices;

namespace winformkeys
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(38, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(348, 43);
            textBox1.TabIndex = 0;
            textBox1.KeyUp += textBox1_KeyUp;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(428, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(166, 169);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arcade_font_writer;
            pictureBox1.Location = new Point(12, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 101);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(616, 203);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Super Type Fighter Turbo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string className, string windowName);

        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hWnd);
        #endregion




        const int VK_Q = 0x51; //L punch/Q
        const int VK_W = 0x57; //M punch/W
        const int VK_E = 0x45; //H punch/E
        const int VK_A = 0x41; //L kick/A
        const int VK_S = 0x53; //M kick/S
        const int VK_D = 0x44; //H kick/D
        const int VK_LEFT = 0x25; //LEFT ARROW key
        const int VK_UP = 0x26;  //UP ARROW key
        const int VK_RIGHT = 0x27; //RIGHT ARROW key
        const int VK_DOWN = 0x28; //DOWN ARROW key
        const int VK_RETURN = 0x0D; //ENTER key
        const int VK_ESCAPE = 0x1B; //ESC key

        private TextBox textBox1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
    }

}