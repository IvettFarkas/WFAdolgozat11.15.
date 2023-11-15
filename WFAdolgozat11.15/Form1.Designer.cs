namespace WFAdolgozat11._15_
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
            label1 = new Label();
            KoszonjButton = new Button();
            nevTextBox = new TextBox();
            pirosLabel = new Label();
            zoldLabel = new Label();
            kekLabel = new Label();
            UdvozlesLabel = new Label();
            button2 = new Button();
            alaphelyzetButton = new Button();
            kilepesButton = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            button5 = new Button();
            label7 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(44, 23);
            label1.TabIndex = 0;
            label1.Text = "név:";
            // 
            // KoszonjButton
            // 
            KoszonjButton.Location = new Point(254, 30);
            KoszonjButton.Name = "KoszonjButton";
            KoszonjButton.Size = new Size(95, 25);
            KoszonjButton.TabIndex = 1;
            KoszonjButton.Text = "Köszönj!";
            KoszonjButton.UseVisualStyleBackColor = true;
            KoszonjButton.Click += KoszonjButton_Click;
            // 
            // nevTextBox
            // 
            nevTextBox.Location = new Point(77, 31);
            nevTextBox.Name = "nevTextBox";
            nevTextBox.Size = new Size(171, 23);
            nevTextBox.TabIndex = 2;
            // 
            // pirosLabel
            // 
            pirosLabel.BackColor = Color.FromArgb(192, 0, 0);
            pirosLabel.Location = new Point(414, 30);
            pirosLabel.Name = "pirosLabel";
            pirosLabel.Size = new Size(68, 63);
            pirosLabel.TabIndex = 3;
            pirosLabel.Text = "Piros";
            // 
            // zoldLabel
            // 
            zoldLabel.BackColor = Color.FromArgb(0, 192, 0);
            zoldLabel.Location = new Point(488, 30);
            zoldLabel.Name = "zoldLabel";
            zoldLabel.Size = new Size(68, 63);
            zoldLabel.TabIndex = 4;
            zoldLabel.Text = "Zöld";
            // 
            // kekLabel
            // 
            kekLabel.BackColor = Color.Blue;
            kekLabel.Location = new Point(562, 30);
            kekLabel.Name = "kekLabel";
            kekLabel.Size = new Size(68, 63);
            kekLabel.TabIndex = 5;
            kekLabel.Text = "Kék";
            // 
            // UdvozlesLabel
            // 
            UdvozlesLabel.BackColor = Color.FromArgb(255, 255, 128);
            UdvozlesLabel.Font = new Font("Engravers MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UdvozlesLabel.Location = new Point(27, 76);
            UdvozlesLabel.Name = "UdvozlesLabel";
            UdvozlesLabel.Size = new Size(322, 50);
            UdvozlesLabel.TabIndex = 6;
            UdvozlesLabel.Text = "###Udvozles###";
            UdvozlesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.Location = new Point(27, 215);
            button2.Name = "button2";
            button2.Size = new Size(603, 40);
            button2.TabIndex = 7;
            button2.Text = "Számolj!";
            button2.UseVisualStyleBackColor = true;
            // 
            // alaphelyzetButton
            // 
            alaphelyzetButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            alaphelyzetButton.ForeColor = Color.SteelBlue;
            alaphelyzetButton.Location = new Point(254, 261);
            alaphelyzetButton.Name = "alaphelyzetButton";
            alaphelyzetButton.Size = new Size(180, 40);
            alaphelyzetButton.TabIndex = 8;
            alaphelyzetButton.Text = "Alaphelyzet";
            alaphelyzetButton.UseVisualStyleBackColor = true;
            alaphelyzetButton.Click += alaphelyzetButton_Click;
            // 
            // kilepesButton
            // 
            kilepesButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            kilepesButton.ForeColor = Color.Red;
            kilepesButton.Location = new Point(450, 261);
            kilepesButton.Name = "kilepesButton";
            kilepesButton.Size = new Size(180, 40);
            kilepesButton.TabIndex = 9;
            kilepesButton.Text = "Kilépés";
            kilepesButton.UseVisualStyleBackColor = true;
            kilepesButton.Click += kilepesButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 147);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(77, 51);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(272, 147);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(77, 51);
            textBox3.TabIndex = 11;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(364, 159);
            label6.Name = "label6";
            label6.Size = new Size(30, 30);
            label6.TabIndex = 12;
            label6.Text = "=";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button5
            // 
            button5.Location = new Point(126, 142);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 13;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Location = new Point(414, 159);
            label7.Name = "label7";
            label7.Size = new Size(190, 38);
            label7.TabIndex = 14;
            label7.Text = "label7";
            // 
            // button6
            // 
            button6.Location = new Point(162, 142);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 15;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(126, 178);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 16;
            button7.Text = "*";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(162, 178);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 17;
            button8.Text = "/";
            button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(kilepesButton);
            Controls.Add(alaphelyzetButton);
            Controls.Add(button2);
            Controls.Add(UdvozlesLabel);
            Controls.Add(kekLabel);
            Controls.Add(zoldLabel);
            Controls.Add(pirosLabel);
            Controls.Add(nevTextBox);
            Controls.Add(KoszonjButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button KoszonjButton;
        private TextBox nevTextBox;
        private Label pirosLabel;
        private Label zoldLabel;
        private Label kekLabel;
        private Label UdvozlesLabel;
        private Button button2;
        private Button alaphelyzetButton;
        private Button kilepesButton;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label6;
        private Button button5;
        private Label label7;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}