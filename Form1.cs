using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string alphaColor, greenColor, redColor, blueColor, hexResult;
        int keyID, colorID;
        bool isSelectingColor;

        public Form1()
        {
            InitializeComponent();

            keyComboBox.Items.Add("Alt");
            keyComboBox.Items.Add("Ctrl");
            keyComboBox.SelectedIndex = 0;
            keyID = 0;

            colorsComboBox.Items.Add("Preto");
            colorsComboBox.Items.Add("Branco");
            colorsComboBox.Items.Add("Vermelho");
            colorsComboBox.Items.Add("Amarelo");
            colorsComboBox.Items.Add("Ciano");
            colorsComboBox.Items.Add("Verde");
            colorsComboBox.Items.Add("Azul");
            colorsComboBox.SelectedIndex = 0;
        }

        [DllImport("user32.dll")]
        private static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("user32.dll")]
        private static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

        [DllImport("gdi32.dll")]
        private static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

        private void alphaScroll_Scroll(object sender, ScrollEventArgs e)
        {
            alphaColor = alphaScroll.Value.ToString("X8");

            int red = Convert.ToInt32(redColor, 16);
            int green = Convert.ToInt32(greenColor, 16);
            int blue = Convert.ToInt32(blueColor, 16);
            int alpha = Convert.ToInt32(alphaColor, 16);

            argbTxtBox.Text = alpha + " " + red + " " + green + " " + blue + " ";

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            hexTextBox.Text = hexResult;
            getColorTxtBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;
            alphaResultLabel.Text = alphaScroll.Value.ToString();        
        }

        private void redScroll_Scroll(object sender, ScrollEventArgs e)
        {
            redColor = redScroll.Value.ToString("X8");

            int redARGB = Convert.ToInt32(redColor, 16);
            int greenARGB = Convert.ToInt32(greenColor, 16);
            int blueARGB = Convert.ToInt32(blueColor, 16);
            int alphaARGB = Convert.ToInt32(alphaColor, 16);

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            int red = redScroll.Value;
            int green = greenScroll.Value;
            int blue = blueScroll.Value;

            getColorTxtBox.Text = hexResult;
            embeddTextBox.Text = "{" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2") + "}";
            embedHexBox.Text = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;
            redResultLabel.Text = redScroll.Value.ToString();
        }

        private void greenScroll_Scroll(object sender, ScrollEventArgs e)
        {
            greenColor = greenScroll.Value.ToString("X8");

            int redARGB = Convert.ToInt32(redColor, 16);
            int greenARGB = Convert.ToInt32(greenColor, 16);
            int blueARGB = Convert.ToInt32(blueColor, 16);
            int alphaARGB = Convert.ToInt32(alphaColor, 16);

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            int red = redScroll.Value;
            int green = greenScroll.Value;
            int blue = blueScroll.Value;

            getColorTxtBox.Text = hexResult;
            embeddTextBox.Text = "{" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2") + "}";
            embedHexBox.Text = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;
            greenResultLabel.Text = greenScroll.Value.ToString();
        }

        private void blueScroll_Scroll(object sender, ScrollEventArgs e)
        {
            blueColor = blueScroll.Value.ToString("X8");

            int redARGB = Convert.ToInt32(redColor, 16);
            int greenARGB = Convert.ToInt32(greenColor, 16);
            int blueARGB = Convert.ToInt32(blueColor, 16);
            int alphaARGB = Convert.ToInt32(alphaColor, 16);

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            int red = redScroll.Value;
            int green = greenScroll.Value;
            int blue = blueScroll.Value;

            getColorTxtBox.Text = hexResult;
            embeddTextBox.Text = "{" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2") + "}";
            embedHexBox.Text = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;
            blueResultLabel.Text = blueScroll.Value.ToString();
        }

        private void colorNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
                string color;
                color = string.Format("{0:X8}", colorDialog1.Color.ToArgb());

                string c = color.ToString();
                alphaColor = c.Substring(0, 2);
                redColor = c.Substring(2, 2);
                greenColor = c.Substring(4, 2);
                blueColor = c.Substring(6, 2);
                hexResult = redColor + greenColor + blueColor + alphaColor;
                pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " 0x" + hexResult;
                string a = hexResult.ToString();
                string b = a.Remove(6, 2);
                embeddTextBox.Text = "{" + b + "}";
                embedHexBox.Text = "#" + b;
                getColorTxtBox.Text = "0x" + hexResult;
                hexTextBox.Text = "0x" + hexResult;

                int red = Convert.ToInt32(redColor, 16);
                int green = Convert.ToInt32(greenColor, 16);
                int blue = Convert.ToInt32(blueColor, 16);
                int alpha = Convert.ToInt32(alphaColor, 16);

                alphaScroll.Value = alpha;
                redScroll.Value = red;
                greenScroll.Value = green;
                blueScroll.Value = blue;

                alphaResultLabel.Text = alphaScroll.Value.ToString();
                redResultLabel.Text = redScroll.Value.ToString();
                greenResultLabel.Text = greenScroll.Value.ToString();
                blueResultLabel.Text = blueScroll.Value.ToString();

                argbTxtBox.Text = alpha + " " + red + " " + green + " " + blue + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alphaResultLabel.Text = alphaScroll.Value.ToString();
            redResultLabel.Text = redScroll.Value.ToString();
            greenResultLabel.Text = greenScroll.Value.ToString();
            blueResultLabel.Text = blueScroll.Value.ToString();

            alphaColor = alphaScroll.Value.ToString("X8");
            redColor = redScroll.Value.ToString("X8");
            greenColor = greenScroll.Value.ToString("X8");
            blueColor = blueScroll.Value.ToString("X8");

            alphaScroll.Maximum = 255;
            redScroll.Maximum = 255;
            greenScroll.Maximum = 255;
            blueScroll.Maximum = 255;

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            int red = redScroll.Value;
            int green = greenScroll.Value;
            int blue = blueScroll.Value;

            int redARGB = Convert.ToInt32(redColor, 16);
            int greenARGB = Convert.ToInt32(greenColor, 16);
            int blueARGB = Convert.ToInt32(blueColor, 16);
            int alphaARGB = Convert.ToInt32(alphaColor, 16);

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";
            getColorTxtBox.Text = hexResult;
            embeddTextBox.Text = "{" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2") + "}";
            embedHexBox.Text = "#" + red.ToString("X2") + green.ToString("X2") + blue.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;

            if(Control.ModifierKeys == Keys.Control)
                MessageBox.Show("with CTRL");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = getColorTxtBox.Text;
            string red, green, blue, alpha;
            string find = "0x";

            int search = text.IndexOf(find, StringComparison.OrdinalIgnoreCase);

            if (search >= 0 & text.Length >= 8 & text.Length < 10)
            {
                string b = text.Insert(8, "FF");
                alpha = "FF";
                getColorTxtBox.Text = b;
            }
            else
                alpha = text.Substring(8, 2);

            red = text.Substring(2, 2);
            green = text.Substring(4, 2);
            blue = text.Substring(6, 2);

            int redARGB = Convert.ToInt32(red, 16);
            int greenARGB = Convert.ToInt32(green, 16);
            int blueARGB = Convert.ToInt32(blue, 16);
            int alphaARGB = Convert.ToInt32(alpha, 16);

            alphaScroll.Value = alphaARGB;
            redScroll.Value = redARGB;
            greenScroll.Value = greenARGB;
            blueScroll.Value = blueARGB;

            blueColor = blueScroll.Value.ToString("X8");

            alphaColor = alphaScroll.Value.ToString("X8");
            redColor = redScroll.Value.ToString("X8");
            greenColor = greenScroll.Value.ToString("X8");
            blueColor = blueScroll.Value.ToString("X8");

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";
            embeddTextBox.Text = "{" + redARGB.ToString("X2") + greenARGB.ToString("X2") + blueARGB.ToString("X2") + "}";
            embedHexBox.Text = "#" + redARGB.ToString("X2") + greenARGB.ToString("X2") + blueARGB.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            alphaResultLabel.Text = alphaScroll.Value.ToString();
            redResultLabel.Text = redScroll.Value.ToString();
            greenResultLabel.Text = greenScroll.Value.ToString();
            blueResultLabel.Text = blueScroll.Value.ToString();
        }

        private void getColorTxtBox_TextChanged(object sender, EventArgs e)
        {
            string text = getColorTxtBox.Text;
            string find = "0x";

            if (text.Length < 8)
                button2.Enabled = false;

            else
                button2.Enabled = true;

            int search = text.IndexOf(find, StringComparison.OrdinalIgnoreCase);

            if (search == -1)
            {
                string b = text.Insert(0, "0x");
                getColorTxtBox.Text = b;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (keyID == 0)
            {
                if (Control.ModifierKeys == Keys.Alt)
                {
                    Color color = GetPixelColor();
                    pictureBox1.BackColor = color;

                    string fColor = string.Format("{0:X8}", color.ToArgb());

                    string c = fColor.ToString();
                    alphaColor = c.Substring(0, 2);
                    redColor = c.Substring(2, 2);
                    greenColor = c.Substring(4, 2);
                    blueColor = c.Substring(6, 2);
                    hexResult = redColor + greenColor + blueColor + alphaColor;
                    pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " 0x" + hexResult;
                    string a = hexResult.ToString();
                    string b = a.Remove(6, 2);
                    embeddTextBox.Text = "{" + b + "}";
                    embedHexBox.Text = "#" + b;
                    getColorTxtBox.Text = "0x" + hexResult;
                    hexTextBox.Text = "0x" + hexResult;

                    int red = Convert.ToInt32(redColor, 16);
                    int green = Convert.ToInt32(greenColor, 16);
                    int blue = Convert.ToInt32(blueColor, 16);
                    int alpha = Convert.ToInt32(alphaColor, 16);

                    alphaScroll.Value = alpha;
                    redScroll.Value = red;
                    greenScroll.Value = green;
                    blueScroll.Value = blue;

                    alphaResultLabel.Text = alphaScroll.Value.ToString();
                    redResultLabel.Text = redScroll.Value.ToString();
                    greenResultLabel.Text = greenScroll.Value.ToString();
                    blueResultLabel.Text = blueScroll.Value.ToString();

                    argbTxtBox.Text = alpha + " " + red + " " + green + " " + blue + " ";

                    isSelectingColor = true;
                }
            }
            if (keyID == 1)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    Color color = GetPixelColor();
                    pictureBox1.BackColor = color;

                    string fColor = string.Format("{0:X8}", color.ToArgb());

                    string c = fColor.ToString();
                    alphaColor = c.Substring(0, 2);
                    redColor = c.Substring(2, 2);
                    greenColor = c.Substring(4, 2);
                    blueColor = c.Substring(6, 2);
                    hexResult = redColor + greenColor + blueColor + alphaColor;
                    pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " 0x" + hexResult;
                    string a = hexResult.ToString();
                    string b = a.Remove(6, 2);
                    embeddTextBox.Text = "{" + b + "}";
                    embedHexBox.Text = "#" + b;
                    getColorTxtBox.Text = "0x" + hexResult;
                    hexTextBox.Text = "0x" + hexResult;

                    int red = Convert.ToInt32(redColor, 16);
                    int green = Convert.ToInt32(greenColor, 16);
                    int blue = Convert.ToInt32(blueColor, 16);
                    int alpha = Convert.ToInt32(alphaColor, 16);

                    alphaScroll.Value = alpha;
                    redScroll.Value = red;
                    greenScroll.Value = green;
                    blueScroll.Value = blue;

                    alphaResultLabel.Text = alphaScroll.Value.ToString();
                    redResultLabel.Text = redScroll.Value.ToString();
                    greenResultLabel.Text = greenScroll.Value.ToString();
                    blueResultLabel.Text = blueScroll.Value.ToString();

                    argbTxtBox.Text = alpha + " " + red + " " + green + " " + blue + " ";

                    isSelectingColor = true;
                }
            }
        }
        private static Point GetCurrentPosition()
        {
            Point p = new Point();
            GetCursorPos(ref p);
            return p;
        }
        public static Color GetPixelColor()
        {
            Point currentPoint = GetCurrentPosition();
            IntPtr hdc = GetDC(IntPtr.Zero);
            uint pixel = GetPixel(hdc, currentPoint.X, currentPoint.Y);
            ReleaseDC(IntPtr.Zero, hdc);
            Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);
            return color;
        }

        
        private void colorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorID = colorsComboBox.SelectedIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string alpha = "", red = "", green = "", blue = "";

            if (colorID == 0)//preto
            {
                alpha = "FF";
                red = "00";
                green = "00";
                blue = "00";
            }
            else if (colorID == 1)//branco
            {
                alpha = "FF";
                red = "FF";
                green = "FF";
                blue = "FF";
            }
            else if (colorID == 2)//vermelho
            {
                alpha = "FF";
                red = "FF";
                green = "00";
                blue = "00";
            }
            else if (colorID == 3)//Amarelo
            {
                alpha = "FF";
                red = "FF";
                green = "FF";
                blue = "00";
            }
            else if (colorID == 4)//Ciano
            {
                alpha = "FF";
                red = "00";
                green = "FF";
                blue = "FF";
            }
            else if (colorID == 5)//Verde
            {
                alpha = "FF";
                red = "00";
                green = "FF";
                blue = "00";
            }
            else if (colorID == 6)//Azul
            {
                alpha = "FF";
                red = "00";
                green = "00";
                blue = "FF";
            }

            int redARGB = Convert.ToInt32(red, 16);
            int greenARGB = Convert.ToInt32(green, 16);
            int blueARGB = Convert.ToInt32(blue, 16);
            int alphaARGB = Convert.ToInt32(alpha, 16);

            alphaScroll.Value = alphaARGB;
            redScroll.Value = redARGB;
            greenScroll.Value = greenARGB;
            blueScroll.Value = blueARGB;

            blueColor = blueScroll.Value.ToString("X8");

            alphaColor = alphaScroll.Value.ToString("X8");
            redColor = redScroll.Value.ToString("X8");
            greenColor = greenScroll.Value.ToString("X8");
            blueColor = blueScroll.Value.ToString("X8");

            int colorHex = alphaScroll.Value | (blueScroll.Value << 8) | (greenScroll.Value << 16) | (redScroll.Value << 24);
            hexResult = "0x" + string.Format("{0:X}", colorHex.ToString("X8"));

            argbTxtBox.Text = alphaARGB + " " + redARGB + " " + greenARGB + " " + blueARGB + " ";
            embeddTextBox.Text = "{" + redARGB.ToString("X2") + greenARGB.ToString("X2") + blueARGB.ToString("X2") + "}";
            embedHexBox.Text = "#" + redARGB.ToString("X2") + greenARGB.ToString("X2") + blueARGB.ToString("X2");
            hexTextBox.Text = hexResult;
            pawnTextBox.Text = "#define " + colorNameTxtBox.Text + " " + hexResult;

            Color previewColor = Color.FromArgb(alphaScroll.Value, redScroll.Value, greenScroll.Value, blueScroll.Value);
            pictureBox1.BackColor = previewColor;

            alphaResultLabel.Text = alphaScroll.Value.ToString();
            redResultLabel.Text = redScroll.Value.ToString();
            greenResultLabel.Text = greenScroll.Value.ToString();
            blueResultLabel.Text = blueScroll.Value.ToString();
        }

        private void hexTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectingColor)
            {
                hexTextBox.Focus();
                hexTextBox.SelectAll();
            }
        }

        private void pawnTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectingColor)
            {
                pawnTextBox.Focus();
                pawnTextBox.SelectAll();
            }
        }

        private void embeddTextBox_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectingColor)
            {
                embeddTextBox.Focus();
                embeddTextBox.SelectAll();
            }
        }

        private void argbTxtBox_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectingColor)
            {
                argbTxtBox.Focus();
                argbTxtBox.SelectAll();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (isSelectingColor)
            {
                argbTxtBox.Focus();
                isSelectingColor = false;
            }
        }

        private void colorsComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void keyComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void getColorTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (getColorTxtBox.Text == "0x000000FF")
            {
                getColorTxtBox.Text = "";
                getColorTxtBox.SelectionStart = 3;
                getColorTxtBox.SelectionLength = 0;
            }
        }

        private void keyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyID = keyComboBox.SelectedIndex;
            alphaScroll.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            about f = new about();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://test-los.comuf.com/cpicker/index.html");
        }

        private void embedHexBox_MouseEnter(object sender, EventArgs e)
        {
            if (!isSelectingColor)
            {
                embedHexBox.Focus();
                embedHexBox.SelectAll();
            }
        }
    }
}