using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using System.Drawing.Imaging;
using System.Drawing.Printing;

namespace Resistor_Calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initialize_all();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            
         }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'myDataSet.someTable' table. You can move, or remove it, as needed.

        }

        private void label1_Click(object sender, EventArgs e) { }

        private void groupBox4_Enter(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "" || textBox6.Text == "" || textBox10.Text == "" || textBox14.Text == "" || textBox18.Text == "" || textBox22.Text == "" || textBox26.Text == "" || textBox30.Text == "")
            {
                MessageBox.Show("Value fields cannot be blank. Put zero 0 if none.");

            }
            else { 
                calculate_all(); 
            }
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e) {
        
        }

        private void calculate_all() 
        {

            /***Accumulator***/
                       
            double LR1set;
            double LR2set;
            double LR3set;
            double RR1set;
            double RR2set;
            double RR3set;
            double valueAccuL = double.Parse(textBox2.Text);
          
             /***L Accul Channel**/
            if (valueAccuL <= 1000)
            {
                LR1set = 0;
                textBox3.Text = LR1set.ToString();
                LR2set = 1.02 * valueAccuL;
                textBox4.Text = LR2set.ToString();
                LR3set = ((valueAccuL * LR2set) / (LR2set - valueAccuL));
                textBox5.Text = LR3set.ToString();
            } 
                        
            /***R Accul Channel**/
            double valueAccuR = double.Parse(textBox6.Text);
            if (valueAccuR <= 1000)
            {
                RR1set = 0;
                textBox7.Text = RR1set.ToString();
                RR2set = 1.02 * valueAccuR;
                textBox8.Text = RR2set.ToString();
                RR3set = ((valueAccuR * RR2set) / (RR2set - valueAccuR));
                textBox9.Text = RR3set.ToString();
            } /***Left Brake System Channel***/ /*****L-R115******/
            double L_R115_R1;
            double
            L_R115_R2;
            double L_R115_R3_set;

            double value_Brk_L_R115 = double.Parse(textBox10.Text);
            if (value_Brk_L_R115 <= 1000)
            {
                L_R115_R1 = 0;
                textBox11.Text = L_R115_R1.ToString();
                L_R115_R2 = 1.02 * value_Brk_L_R115;
                textBox12.Text = L_R115_R2.ToString();
                L_R115_R3_set = ((value_Brk_L_R115 * L_R115_R2) / (L_R115_R2 - value_Brk_L_R115));
                textBox13.Text = L_R115_R3_set.ToString();
            } /*****L-R116******/
            double L_R116_R1;
            double L_R116_R2;
            double L_R116_R3_set;

            double value_Brk_L_R116 = double.Parse(textBox14.Text);
            if (value_Brk_L_R116 <= 1000)
            {
                L_R116_R1 = 0;
                textBox15.Text = L_R116_R1.ToString();
                L_R116_R2 = 1.02 * value_Brk_L_R116;
                textBox16.Text = L_R116_R2.ToString();
                L_R116_R3_set = ((value_Brk_L_R116 * L_R116_R2) / (L_R116_R2 - value_Brk_L_R116));
                textBox17.Text = L_R116_R3_set.ToString();
            } /*****L-R117******/
            double L_R117_R1;
            double L_R117_R2;
            
            double L_R117_R3_set;

            double value_Brk_L_R117 = double.Parse(textBox18.Text);
            if (value_Brk_L_R117 <= 1000)
            {
                L_R117_R1 = 0;
                textBox19.Text = L_R117_R1.ToString();
                L_R117_R2 = 1.02 * value_Brk_L_R117;
                textBox20.Text = L_R117_R2.ToString();
                L_R117_R3_set = ((value_Brk_L_R117 * L_R117_R2) / (L_R117_R2 - value_Brk_L_R117));
                textBox21.Text = L_R117_R3_set.ToString();
            } /***rIGHTBrake System Channel***/ /*****L-R115******/
            double R_R115_R1;
            double R_R115_R2;
            double R_R115_R3_set;
            double value_Brk_R_R115 = double.Parse(textBox22.Text);
            if (value_Brk_R_R115 <= 1000)
            {
                R_R115_R1 = 0;
                textBox23.Text = R_R115_R1.ToString();
                R_R115_R2 = 1.02 * value_Brk_R_R115;
                textBox24.Text = R_R115_R2.ToString();
                R_R115_R3_set = ((value_Brk_R_R115 * R_R115_R2) / (R_R115_R2 - value_Brk_R_R115));
                textBox25.Text = R_R115_R3_set.ToString();
            } /*****L-R116******/
            double R_R116_R1;
            double R_R116_R2;
            double R_R116_R3_set;

            double value_Brk_R_R116 = double.Parse(textBox26.Text);
            if (value_Brk_R_R116 <= 1000)
            {
                R_R116_R1 = 0;
                textBox27.Text = R_R116_R1.ToString();
                R_R116_R2 = 1.02 * value_Brk_R_R116;
                textBox28.Text = R_R116_R2.ToString();
                R_R116_R3_set = ((value_Brk_R_R116 * R_R116_R2) / (R_R116_R2 - value_Brk_R_R116));
                textBox29.Text = R_R116_R3_set.ToString();
            } /*****L-R117******/
            double R_R117_R1;
            double R_R117_R2;
            
            double R_R117_R3_set;

            double value_Brk_R_R117 = double.Parse(textBox30.Text);
            if (value_Brk_R_R117 <= 1000)
            {
                R_R117_R1 = 0;
                textBox31.Text = R_R117_R1.ToString();
                R_R117_R2 = 1.02 * value_Brk_R_R117;
                textBox32.Text = R_R117_R2.ToString();
                R_R117_R3_set = ((value_Brk_R_R117 * R_R117_R2) / (R_R117_R2 - value_Brk_R_R117));
                textBox33.Text = R_R117_R3_set.ToString();
            }

            /*****If values are greater than 1000 Ohms****/

            /***L Accul Channel**/
            if (valueAccuL >= 1001)
            {
                LR1set = 0.75 * valueAccuL;
                textBox3.Text = LR1set.ToString();
                LR2set = 1.33 * valueAccuL;
                textBox4.Text = LR2set.ToString();
                LR3set = LR2set*((LR1set-valueAccuL) /(valueAccuL - LR2set- LR1set));
                textBox5.Text = (Math.Round(LR3set, 1)).ToString();

                   }


            /***R Accul Channel**/
           
            if (valueAccuR >= 1001)
            {
                RR1set = 0.75 * valueAccuR;
                textBox7.Text = RR1set.ToString();
                RR2set = 1.33 * valueAccuR;
                textBox8.Text = RR2set.ToString();
                RR3set = RR2set * ((RR1set - valueAccuR) / (valueAccuR - RR2set - RR1set));
                textBox9.Text = (Math.Round(RR3set, 1)).ToString();
            } /***Left Brake System Channel***/ /*****L-R115******/
           
            if (value_Brk_L_R115 >= 1001)
            {
                L_R115_R1 = 0.75 * value_Brk_L_R115;
                textBox11.Text = L_R115_R1.ToString();
                L_R115_R2 = 1.33 * value_Brk_L_R115;
                textBox12.Text = L_R115_R2.ToString();
                L_R115_R3_set = L_R115_R2 * ((L_R115_R1 - value_Brk_L_R115) / (value_Brk_L_R115 - L_R115_R2 - L_R115_R1));
                textBox13.Text = (Math.Round(L_R115_R3_set, 1)).ToString();
            } /*****L-R116******/
          
            if (value_Brk_L_R116 >= 1001)
            {
                L_R116_R1 = 0.75 * value_Brk_L_R116;
                textBox15.Text = L_R116_R1.ToString();
                L_R116_R2 = 1.33 * value_Brk_L_R116;
                textBox16.Text = L_R116_R2.ToString();
                L_R116_R3_set = L_R116_R2 * ((L_R116_R1 - value_Brk_L_R116) / (value_Brk_L_R116 - L_R116_R2 - L_R116_R1));
                textBox17.Text = (Math.Round(L_R116_R3_set, 1)).ToString();
            } /*****L-R117******/
            
            if (value_Brk_L_R117 >= 1001)
            {
                L_R117_R1 = 0.75 * value_Brk_L_R117;
                textBox19.Text = L_R117_R1.ToString();
                L_R117_R2 = 1.33 * value_Brk_L_R117;
                textBox20.Text = L_R117_R2.ToString();
                L_R117_R3_set = L_R117_R2 * ((L_R117_R1 - value_Brk_L_R117) / (value_Brk_L_R117 - L_R117_R2 - L_R117_R1));
                textBox21.Text = (Math.Round(L_R117_R3_set, 1)).ToString();
            } /***rIGHTBrake System Channel***/ /*****L-R115******/
           
            if (value_Brk_R_R115 >= 1001)
            {
                R_R115_R1 = 0.75 * value_Brk_R_R115;
                textBox23.Text = R_R115_R1.ToString();
                R_R115_R2 = 1.33 * value_Brk_R_R115;
                textBox24.Text = R_R115_R2.ToString();
                R_R115_R3_set = R_R115_R2 * ((R_R115_R1 - value_Brk_R_R115) / (value_Brk_R_R115 - R_R115_R2 - R_R115_R1));
                textBox25.Text = (Math.Round(R_R115_R3_set, 1)).ToString();
            } 
            if (value_Brk_R_R116 >= 1001)
            {
                R_R116_R1 = 0.75 * value_Brk_R_R116;
                textBox27.Text = R_R116_R1.ToString();
                R_R116_R2 = 1.33 * value_Brk_R_R116;
                textBox28.Text = R_R116_R2.ToString();
                R_R116_R3_set = R_R116_R2 * ((R_R116_R1 - value_Brk_R_R116) / (value_Brk_R_R116 - R_R116_R2 - R_R116_R1));
                textBox29.Text = (Math.Round(R_R116_R3_set, 1)).ToString();
            } 
            if (value_Brk_R_R117 >= 1001)
            {
                R_R117_R1 = 0.75 * value_Brk_R_R117;
                textBox31.Text = R_R117_R1.ToString();
                R_R117_R2 = 1.33 * value_Brk_R_R117;
                textBox32.Text = R_R117_R2.ToString();
                R_R117_R3_set = R_R117_R2 * ((R_R117_R1 - value_Brk_R_R117) / (value_Brk_R_R117 - R_R117_R2 - R_R117_R1));
                textBox33.Text = (Math.Round(R_R117_R3_set, 1)).ToString();
            }

                    }
        private void initialize_all()
        {
            textBox2.Text =  "0";
            textBox6.Text =  "0";
            textBox10.Text = "0";
            textBox14.Text = "0";
            textBox18.Text = "0";
            textBox22.Text = "0";
            textBox26.Text = "0";
            textBox30.Text = "0";
            textBox34.Text = "0";
            textBox37.Text = "0";
            textBox38.Text = "0";
            textBox39.Text = "0";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Select a vendor");
            }
            else {
                switch (comboBox1.SelectedItem.ToString().Trim())
                {

                    case "DigiKey":
                        System.Diagnostics.Process.Start("chrome.exe", "https://www.digikey.com/en/products/filter/chip-resistor-surface-mount/52?gclid=EAIaIQobChMIge-779_38wIV-CitBh2nIAezEAAYASAAEgJ0z_D_BwE&s=N4IgjCBcoExaBjKAzAhgGwM4FMA0IB7KAbXABYAGANjJAF18AHAFyhAGVmAnASwDsA5iAC%2B%2BAMzwQSSGix5CJcGDER8ATgDsVEPgAcZXTpC6w2-BpVGqasyCpUNVgKyqQYjRrj4yasGRiu7hoQDCAsbJy8giL4YI7QUigYOPhEkKQwFGBO9EyskBzc-EKi4DC%2BktKyKQrpbmpiMIah4QWRxTHgarpqlUlyqYoUuWH5hVElpXB1ME4ABAAKCwCy9MJAA&utm_adgroup=General&utm_campaign=EN_Product_Resistors&utm_content=General&utm_medium=cpc&utm_source=google&utm_term=smd%20resistor");
                        break;
                    case "Newark":
                        System.Diagnostics.Process.Start("chrome.exe", "https://www.newark.com/w/c/passive-components/resistors-fixed-value/chip-smd-resistors?resistor-case-style=smd&ost=smd%2Bresistor");
                        break;
                    case "Mouser":
                        System.Diagnostics.Process.Start("chrome.exe", "https://www.mouser.com/c/passive-components/resistors/smd-resistors-chip-resistors/");
                        break;
                    default:
                        break;

                }

            }
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            
            {

            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

        }

        private void groupBox15_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (textBox34.Text == "" )
            {
                MessageBox.Show("Please fill out an initial value for resistance.");

            }

            else
            {
                calculate_new_values();

            }

        }

        Bitmap memoryImage;
        private PrintDocument printDocument1 = new PrintDocument();

        private Button printButton = new Button();
        
        private void calculate_new_values()
        {

            double initial_value = double.Parse(textBox34.Text);
            double new_value;
            double deviation ;
            double r1 = double.Parse(textBox37.Text);
            double r2 = double.Parse(textBox38.Text);
            double r3 = double.Parse(textBox39.Text);

            new_value = Math.Round(r1 + ((r2 * r3) / (r2 + r3)),1);
            textBox35.Text = new_value.ToString();

            deviation = Math.Round(((new_value-initial_value)/initial_value), 1);
            textBox36.Text = deviation.ToString();

            //  throw new NotImplementedException();
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Triple Pressure Indicator MOD.G Resistor Calculator\n\n\t\tBeta Release v1.00 ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();

        }

        private void CaptureScreen()
                       
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);

        }

        private void printDocument1_PrintPage(System.Object sender,
         System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private static void SaveScreenshot(Form frm)
        {
            string ImagePath = string.Format(@"C:\temp\Screen_{0}.png", DateTime.Now.Ticks);
            Bitmap Image = new Bitmap(frm.Width, frm.Height);
            frm.DrawToBitmap(Image, new Rectangle(0, 0, frm.Width, frm.Height));
            Image.Save(ImagePath, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}