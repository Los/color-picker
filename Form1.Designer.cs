namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.blueResultLabel = new System.Windows.Forms.Label();
            this.greenResultLabel = new System.Windows.Forms.Label();
            this.redResultLabel = new System.Windows.Forms.Label();
            this.alphaResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.redScroll = new System.Windows.Forms.HScrollBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alphaScroll = new System.Windows.Forms.HScrollBar();
            this.greenScroll = new System.Windows.Forms.HScrollBar();
            this.blueScroll = new System.Windows.Forms.HScrollBar();
            this.getColorTxtBox = new System.Windows.Forms.TextBox();
            this.colorNameTxtBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.embedHexBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.argbTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hexTextBox = new System.Windows.Forms.TextBox();
            this.pawnTextBox = new System.Windows.Forms.TextBox();
            this.embeddTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.keyComboBox = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colorsComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.blueResultLabel);
            this.groupBox1.Controls.Add(this.greenResultLabel);
            this.groupBox1.Controls.Add(this.redResultLabel);
            this.groupBox1.Controls.Add(this.alphaResultLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.redScroll);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.alphaScroll);
            this.groupBox1.Controls.Add(this.greenScroll);
            this.groupBox1.Controls.Add(this.blueScroll);
            this.groupBox1.Controls.Add(this.getColorTxtBox);
            this.groupBox1.Controls.Add(this.colorNameTxtBox);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(305, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Obter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blueResultLabel
            // 
            this.blueResultLabel.AutoSize = true;
            this.blueResultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueResultLabel.Location = new System.Drawing.Point(394, 111);
            this.blueResultLabel.Name = "blueResultLabel";
            this.blueResultLabel.Size = new System.Drawing.Size(15, 16);
            this.blueResultLabel.TabIndex = 31;
            this.blueResultLabel.Text = "0";
            this.blueResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // greenResultLabel
            // 
            this.greenResultLabel.AutoSize = true;
            this.greenResultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greenResultLabel.Location = new System.Drawing.Point(394, 80);
            this.greenResultLabel.Name = "greenResultLabel";
            this.greenResultLabel.Size = new System.Drawing.Size(15, 16);
            this.greenResultLabel.TabIndex = 30;
            this.greenResultLabel.Text = "0";
            this.greenResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redResultLabel
            // 
            this.redResultLabel.AutoSize = true;
            this.redResultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redResultLabel.Location = new System.Drawing.Point(394, 51);
            this.redResultLabel.Name = "redResultLabel";
            this.redResultLabel.Size = new System.Drawing.Size(15, 16);
            this.redResultLabel.TabIndex = 29;
            this.redResultLabel.Text = "0";
            this.redResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaResultLabel
            // 
            this.alphaResultLabel.AutoSize = true;
            this.alphaResultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alphaResultLabel.Location = new System.Drawing.Point(394, 24);
            this.alphaResultLabel.Name = "alphaResultLabel";
            this.alphaResultLabel.Size = new System.Drawing.Size(15, 16);
            this.alphaResultLabel.TabIndex = 28;
            this.alphaResultLabel.Text = "0";
            this.alphaResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Red";
            // 
            // redScroll
            // 
            this.redScroll.LargeChange = 0;
            this.redScroll.Location = new System.Drawing.Point(90, 47);
            this.redScroll.Maximum = 259;
            this.redScroll.Name = "redScroll";
            this.redScroll.Size = new System.Drawing.Size(287, 23);
            this.redScroll.SmallChange = 0;
            this.redScroll.TabIndex = 26;
            this.redScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.redScroll_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Obter Cor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Blue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Green";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Alpha";
            // 
            // alphaScroll
            // 
            this.alphaScroll.LargeChange = 0;
            this.alphaScroll.Location = new System.Drawing.Point(90, 17);
            this.alphaScroll.Maximum = 255;
            this.alphaScroll.Name = "alphaScroll";
            this.alphaScroll.Size = new System.Drawing.Size(287, 23);
            this.alphaScroll.SmallChange = 0;
            this.alphaScroll.TabIndex = 12;
            this.alphaScroll.Value = 255;
            this.alphaScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.alphaScroll_Scroll);
            // 
            // greenScroll
            // 
            this.greenScroll.LargeChange = 0;
            this.greenScroll.Location = new System.Drawing.Point(90, 77);
            this.greenScroll.Maximum = 259;
            this.greenScroll.Name = "greenScroll";
            this.greenScroll.Size = new System.Drawing.Size(287, 23);
            this.greenScroll.SmallChange = 0;
            this.greenScroll.TabIndex = 11;
            this.greenScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.greenScroll_Scroll);
            // 
            // blueScroll
            // 
            this.blueScroll.LargeChange = 0;
            this.blueScroll.Location = new System.Drawing.Point(90, 107);
            this.blueScroll.Maximum = 259;
            this.blueScroll.Name = "blueScroll";
            this.blueScroll.Size = new System.Drawing.Size(287, 23);
            this.blueScroll.SmallChange = 0;
            this.blueScroll.TabIndex = 9;
            this.blueScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.blueScroll_Scroll);
            // 
            // getColorTxtBox
            // 
            this.getColorTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getColorTxtBox.Location = new System.Drawing.Point(90, 166);
            this.getColorTxtBox.MaxLength = 10;
            this.getColorTxtBox.Name = "getColorTxtBox";
            this.getColorTxtBox.Size = new System.Drawing.Size(205, 22);
            this.getColorTxtBox.TabIndex = 8;
            this.getColorTxtBox.Text = "000000";
            this.getColorTxtBox.TextChanged += new System.EventHandler(this.getColorTxtBox_TextChanged);
            this.getColorTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.getColorTxtBox_KeyPress);
            // 
            // colorNameTxtBox
            // 
            this.colorNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorNameTxtBox.Location = new System.Drawing.Point(90, 137);
            this.colorNameTxtBox.Name = "colorNameTxtBox";
            this.colorNameTxtBox.Size = new System.Drawing.Size(287, 22);
            this.colorNameTxtBox.TabIndex = 7;
            this.colorNameTxtBox.Text = "COLOR_NAME";
            this.colorNameTxtBox.TextChanged += new System.EventHandler(this.colorNameTxtBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.embedHexBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.argbTxtBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.hexTextBox);
            this.groupBox2.Controls.Add(this.pawnTextBox);
            this.groupBox2.Controls.Add(this.embeddTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(659, 281);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída";
            // 
            // embedHexBox
            // 
            this.embedHexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embedHexBox.ForeColor = System.Drawing.Color.Blue;
            this.embedHexBox.Location = new System.Drawing.Point(95, 246);
            this.embedHexBox.Name = "embedHexBox";
            this.embedHexBox.ReadOnly = true;
            this.embedHexBox.Size = new System.Drawing.Size(558, 22);
            this.embedHexBox.TabIndex = 23;
            this.embedHexBox.Text = "#000000";
            this.embedHexBox.MouseEnter += new System.EventHandler(this.embedHexBox_MouseEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 249);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "#HEX";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "ARGB";
            // 
            // argbTxtBox
            // 
            this.argbTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.argbTxtBox.ForeColor = System.Drawing.Color.Blue;
            this.argbTxtBox.Location = new System.Drawing.Point(95, 219);
            this.argbTxtBox.Name = "argbTxtBox";
            this.argbTxtBox.ReadOnly = true;
            this.argbTxtBox.Size = new System.Drawing.Size(558, 22);
            this.argbTxtBox.TabIndex = 20;
            this.argbTxtBox.Text = "0 255 255 255";
            this.argbTxtBox.MouseEnter += new System.EventHandler(this.argbTxtBox_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Embedd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "No PAWN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Hex Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(6, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 113);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hexTextBox
            // 
            this.hexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexTextBox.ForeColor = System.Drawing.Color.Red;
            this.hexTextBox.Location = new System.Drawing.Point(95, 138);
            this.hexTextBox.Name = "hexTextBox";
            this.hexTextBox.ReadOnly = true;
            this.hexTextBox.Size = new System.Drawing.Size(558, 22);
            this.hexTextBox.TabIndex = 15;
            this.hexTextBox.Text = "0x000000FF";
            this.hexTextBox.MouseEnter += new System.EventHandler(this.hexTextBox_MouseEnter);
            // 
            // pawnTextBox
            // 
            this.pawnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pawnTextBox.ForeColor = System.Drawing.Color.LightSlateGray;
            this.pawnTextBox.Location = new System.Drawing.Point(95, 165);
            this.pawnTextBox.Name = "pawnTextBox";
            this.pawnTextBox.ReadOnly = true;
            this.pawnTextBox.Size = new System.Drawing.Size(558, 22);
            this.pawnTextBox.TabIndex = 14;
            this.pawnTextBox.Text = "#define COLOR_NAME 0x000000FF";
            this.pawnTextBox.MouseEnter += new System.EventHandler(this.pawnTextBox_MouseEnter);
            // 
            // embeddTextBox
            // 
            this.embeddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.embeddTextBox.ForeColor = System.Drawing.Color.Blue;
            this.embeddTextBox.Location = new System.Drawing.Point(95, 192);
            this.embeddTextBox.Name = "embeddTextBox";
            this.embeddTextBox.ReadOnly = true;
            this.embeddTextBox.Size = new System.Drawing.Size(558, 22);
            this.embeddTextBox.TabIndex = 13;
            this.embeddTextBox.Text = "{000000}";
            this.embeddTextBox.MouseEnter += new System.EventHandler(this.embeddTextBox_MouseEnter);
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(6, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 46);
            this.button4.TabIndex = 0;
            this.button4.Text = "Sobre o Aplicativo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.keyComboBox);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.colorsComboBox);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(462, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(209, 203);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ambiente";
            // 
            // keyComboBox
            // 
            this.keyComboBox.FormattingEnabled = true;
            this.keyComboBox.Location = new System.Drawing.Point(47, 14);
            this.keyComboBox.Name = "keyComboBox";
            this.keyComboBox.Size = new System.Drawing.Size(156, 21);
            this.keyComboBox.TabIndex = 37;
            this.keyComboBox.SelectedIndexChanged += new System.EventHandler(this.keyComboBox_SelectedIndexChanged);
            this.keyComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyComboBox_KeyPress);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(129, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 21);
            this.button3.TabIndex = 32;
            this.button3.Text = "Aplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(6, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 46);
            this.button1.TabIndex = 36;
            this.button1.Text = "Ajuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorsComboBox
            // 
            this.colorsComboBox.FormattingEnabled = true;
            this.colorsComboBox.Location = new System.Drawing.Point(9, 68);
            this.colorsComboBox.Name = "colorsComboBox";
            this.colorsComboBox.Size = new System.Drawing.Size(114, 21);
            this.colorsComboBox.TabIndex = 35;
            this.colorsComboBox.SelectedIndexChanged += new System.EventHandler(this.colorsComboBox_SelectedIndexChanged);
            this.colorsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.colorsComboBox_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 16);
            this.label12.TabIndex = 34;
            this.label12.Text = "Cores Pré-definidas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 16);
            this.label11.TabIndex = 32;
            this.label11.Text = "Key:";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(686, 514);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SA Color Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox getColorTxtBox;
        private System.Windows.Forms.TextBox colorNameTxtBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.HScrollBar redScroll;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar alphaScroll;
        private System.Windows.Forms.HScrollBar greenScroll;
        private System.Windows.Forms.HScrollBar blueScroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox hexTextBox;
        private System.Windows.Forms.TextBox pawnTextBox;
        private System.Windows.Forms.TextBox embeddTextBox;
        private System.Windows.Forms.Label blueResultLabel;
        private System.Windows.Forms.Label greenResultLabel;
        private System.Windows.Forms.Label redResultLabel;
        private System.Windows.Forms.Label alphaResultLabel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox argbTxtBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox colorsComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox keyComboBox;
        private System.Windows.Forms.TextBox embedHexBox;
        private System.Windows.Forms.Label label13;
    }
}

