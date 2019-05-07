using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregner
{
    public partial class Form1 : Form
    {
        int clicked_2nd = 0;
        string symbol;
        string minustal;
        bool enter_value;
        bool harminuset;
        bool grad;
        bool rad;
        besked divi = new besked();
        Double tal1;
        Double tal2;
        Double tal3;
        Double tal4;
        Double total;
        Double first_tal;


        public Form1()
        {
            InitializeComponent();
        }

        //Alle talne
        private void btn_tal_og_pon(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || (enter_value))
            {
                textBox.Text = "";
            }
            enter_value = false;

            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text = textBox.Text + num.Text;
                }
            }
            else
            {
                textBox.Text = textBox.Text + num.Text;
            }
        }

        //De alminelige tegn
        private void btn_div_Click(object sender, EventArgs e)
        {
            if (tal1 == 0)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total += tal1;
                symbol = "divider";
                textBox.Text = "";
            }
            else if (tal2 == 0)
            {
                tal2 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "plus":
                        total = total + tal2;
                        break;
                    case "gange":
                        total = total * tal2;
                        break;
                    case "minus":
                        total = total - tal2;
                        break;
                    default:
                        minustal = Convert.ToString(tal1);
                        if (minustal.Contains("-") || textBox.Text.Contains("-"))
                        {
                            divi.ShowDialog();
                        }
                        else
                        {
                            total = total / tal2;
                        }
                        break;
                }
                symbol = "divider";
                textBox.Text = "";
            }
            else if (tal3 == 0)
            {
                tal3 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "plus":
                        total += tal3;
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        else
                        {
                            tal2 = Convert.ToDouble("-" + tal2);
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        break;
                    case "minus":
                        total = total - tal3;
                        break;
                    default:
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 / tal3;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                }
                symbol = "divider";
                textBox.Text = "";
            }
            else if (tal4 == 0)
            {
                tal4 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "plus":
                        total += tal4;
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 * tal4;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal3);
                            total -= tal3;
                            total += tal3 * tal4;
                            harminuset = false;
                        }
                        break;
                    case "minus":
                        total = total - tal4;
                        break;
                    default:
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 / tal4;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                }
                symbol = "divider";
                textBox.Text = "";
            }

        }

        private void btn_ga_Click(object sender, EventArgs e)
        {
            if (tal1 == 0)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total += tal1;
                symbol = "gange";
                textBox.Text = "";
            }
            else if (tal2 == 0)
            {
                tal2 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        minustal = Convert.ToString(tal1);
                        if (minustal.Contains("-") || textBox.Text.Contains("-"))
                        {
                            divi.ShowDialog();
                        }
                        else
                        {
                            total = total / tal2;
                        }
                        break;
                    case "minus":
                        total = total - tal2;
                        break;
                    case "plus":
                        total = total + tal2;
                        break;
                    default:
                        total = total * tal2;
                        break;
                }
                symbol = "gange";
                textBox.Text = "";
            }
            else if (tal3 == 0)
            {
                tal3 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 / tal3;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "minus":
                        total -= tal3;
                        break;
                    case "plus":
                        total = total + tal3;
                        break;
                    default:
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal2);
                            total -= tal2;
                            total += tal2 * tal3;
                            harminuset = false;
                        }
                        break;
                }
                symbol = "gange";
                textBox.Text = "";
            }
            else if (tal4 == 0)
            {
                tal4 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 / tal4;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "minus":
                        total -= tal3;
                        break;
                    case "plus":
                        total = total + tal3;
                        break;
                    default:
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 * tal4;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal3);
                            total -= tal3;
                            total += tal3 * tal4;
                            harminuset = false;
                        }
                        break;
                }
                symbol = "gange";
                textBox.Text = "";
            }
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if (tal1 == 0)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = tal1;
                symbol = "minus";
                textBox.Text = "";
            }
            else if (tal2 == 0)
            {
                tal2 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        minustal = Convert.ToString(tal1);
                        if (minustal.Contains("-") || textBox.Text.Contains("-"))
                        {
                            divi.ShowDialog();
                        }
                        else
                        {
                            total = total / tal2;
                        }
                        break;
                    case "gange":
                        total = total * tal2;
                        break;
                    case "plus":
                        total = total + tal2;
                        break;
                    default:
                        total = total - tal2;
                        break;
                }
                symbol = "minus";
                textBox.Text = "";
                harminuset = true;
            }
            else if (tal3 == 0)
            {
                tal3 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 / tal3;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        else
                        {
                            tal2 = Convert.ToDouble("-" + tal2);
                            total -= tal2;
                            total += tal2 * tal3;
                            harminuset = false;
                        }
                        break;
                    case "plus":
                        total = total + tal3;
                        break;
                    default:
                        total -= tal3;
                        break;
                }
                symbol = "minus";
                textBox.Text = "";
                harminuset = true;
            }
            else if (tal4 == 0)
            {
                tal4 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 / tal4;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 * tal4;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal3);
                            total -= tal3;
                            total += tal3 * tal4;
                            harminuset = false;
                        }
                        break;
                    case "plus":
                        total = total + tal4;
                        break;
                    default:
                        total -= tal4;
                        break;
                }
                symbol = "minus";
                textBox.Text = "";
                harminuset = true;
            }
        }

        private void btn_plu_Click(object sender, EventArgs e)
        {
            if (tal1 == 0)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total += tal1;
                symbol = "plus";
                textBox.Text = "";
            }
            else if (tal2 == 0)
            {
                tal2 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        minustal = Convert.ToString(tal1);
                        if (minustal.Contains("-") || textBox.Text.Contains("-"))
                        {
                            divi.ShowDialog();
                        }
                        else
                        {
                            total = total / tal2;
                        }
                        break;
                    case "gange":
                        total = total * tal2;
                        break;
                    case "minus":
                        total = total - tal2;
                        break;
                    default:
                        total = total + tal2;
                        break;
                }
                symbol = "plus";
                textBox.Text = "";
            }
            else if (tal3 == 0)
            {
                tal3 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 / tal3;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        else
                        {
                            tal2 = Convert.ToDouble("-" + tal2);
                            total -= tal2;
                            total += tal2 * tal3;
                            harminuset = false;
                        }
                        break;
                    case "minus":
                        total = total - tal3;
                        break;
                    default:
                        total += tal3;
                        break;
                }
                symbol = "plus";
                textBox.Text = "";
            }
            else if (tal4 == 0)
            {
                tal4 = Convert.ToDouble(textBox.Text);
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 / tal4;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 * tal4;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal3);
                            total -= tal3;
                            total += tal3 * tal4;
                            harminuset = false;
                        }
                        break;
                    case "minus":
                        total = total - tal4;
                        break;
                    default:
                        total += tal4;
                        break;
                }
                symbol = "plus";
                textBox.Text = "";
            }
        }

        public void btn_lig_Click_1(object sender, EventArgs e)
        {
            if (tal2 == 0)
            {
                tal2 = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
                switch (symbol)
                {
                    case "divider":
                        minustal = Convert.ToString(tal1);
                        if (minustal.Contains("-") || textBox.Text.Contains("-"))
                        {
                            divi.ShowDialog();
                        }
                        else
                        {
                            total = total / tal2;
                        }
                        break;
                    case "gange":
                        total = total * tal2;
                        break;
                    case "minus":
                        total = total - tal2;
                        break;
                    default:
                        total = total + tal2;
                        break;
                }
                symbol = "plus";
            }
            else if (tal3 == 0)
            {
                tal3 = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 / tal3;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal2;
                            total += tal2 * tal3;
                        }
                        else
                        {
                            tal2 = Convert.ToDouble("-" + tal2);
                            total -= tal2;
                            total += tal2 * tal3;
                            harminuset = false;
                        }
                        break;
                    case "minus":
                        total = total - tal3;
                        break;
                    default:
                        total += tal3;
                        break;
                }
                symbol = "plus";
            }
            else if (tal4 == 0)
            {
                tal4 = Convert.ToDouble(textBox.Text);
                textBox.Text = "";
                switch (symbol)
                {
                    case "divider":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 / tal4;
                        }
                        else
                        {
                            divi.ShowDialog();
                        }
                        break;
                    case "gange":
                        if (harminuset == false)
                        {
                            total -= tal3;
                            total += tal3 * tal4;
                        }
                        else
                        {
                            tal3 = Convert.ToDouble("-" + tal3);
                            total -= tal3;
                            total += tal3 * tal4;
                            harminuset = false;
                        }
                        break;
                    case "minus":
                        total = total - tal4;
                        break;
                    default:
                        total += tal4;
                        break;
                }
                symbol = "plus";
            }
            textBox.Text = Convert.ToString(total);
            tal1 = 0;
            tal2 = 0;
            tal3 = 0;
            tal4 = 0;
            harminuset = false;
            symbol = "";
        }

        //De andre tegn
        private void button_C_Click(object sender, EventArgs e)
        {
            //Jeg spørger efter textboxen længde og sletter 1 value
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            tal1 = 0;
            tal2 = 0;
            total = 0;
        }
       
        private void btn_pi_Click(object sender, EventArgs e)
        {
            textBox.Text = "3,14";
        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            tal1 += Convert.ToDouble(textBox.Text);
            total = tal1 * tal1;
            textBox.Text = Convert.ToString(total);
        }

        private void btn_yx_Click(object sender, EventArgs e)
        {
            tal1 = Convert.ToDouble(textBox.Text);
            symbol = "yx";
            textBox.Text = "";
        }

        private void btn_kvad_Click(object sender, EventArgs e)
        {
            Double tal3; 

            tal3 = Convert.ToDouble(textBox.Text);
            total = Math.Sqrt(tal3);
            textBox.Text = Convert.ToString(total);
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            tal1 = Convert.ToDouble(textBox.Text);
            total = tal1 / 100;
            textBox.Text = Convert.ToString(total);
        }
        
        private void btn_2nd_Click(object sender, EventArgs e)
        {
            clicked_2nd = 1;
        }

        private void btn_pos_nev_Click(object sender, EventArgs e)
        {
            List<Double> extra = new List<Double>();

            if (clicked_2nd == 1)
            {
                extra.Add(Convert.ToDouble(textBox.Text));
                first_tal = extra.First();
                textBox.Text = Convert.ToString(first_tal);
                clicked_2nd = 0;
            }
            else
            {
                extra.Add(Convert.ToDouble(textBox.Text));
                first_tal = extra.First();
                textBox.Text = "-" + Convert.ToString(first_tal);
            }
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            tal1 = Convert.ToDouble(textBox.Text);
            total = Math.Log10(tal1);
            textBox.Text = Convert.ToString(total);
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            tal1 = Convert.ToDouble(textBox.Text);
            total = Math.Log(tal1);
            textBox.Text = Convert.ToString(total);
        }

        private void btn_cos_Click(object sender, EventArgs e)
        {
            if (rad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Cos(tal1);
                textBox.Text = Convert.ToString(total);
            }
            else if (grad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Cos(grader(tal1));
                textBox.Text = Convert.ToString(total);
            }

        }

        private void btn_sin_Click(object sender, EventArgs e)
        {
            if (rad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Sin(tal1);
                textBox.Text = Convert.ToString(total);
            }
            else if (grad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Sin(tal1 * Math.PI / 180);
                textBox.Text = Convert.ToString(total);
            }
        }

        private void btn_tan_Click(object sender, EventArgs e)
        {
            if (rad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Tan(tal1);
                textBox.Text = Convert.ToString(total);
            }
            else if (grad == true)
            {
                tal1 = Convert.ToDouble(textBox.Text);
                total = Math.Tan(tal1 * Math.PI / 180);
                textBox.Text = Convert.ToString(total);
            }
        }

        //Hvilken værdi man regner med i vinkler.
        private void rabtn_grad_CheckedChanged(object sender, EventArgs e)
        {
            grad = true;
            rad = false;
        }

        private void rabtn_rad_CheckedChanged(object sender, EventArgs e)
        {
            rad = true;
            grad = false;
        }

        //Hjælp til btn_cos
        Double grader(double angleInDegrees)
        {
            return angleInDegrees * (Math.PI / 180.0);
        }
        
        //This do not working
        private void btn_open_pan_Click(object sender, EventArgs e)
        {
            textBox.Text += "(";

        }

        private void btn_lukket_pan_Click(object sender, EventArgs e)
        {
            textBox.Text += ")";
        }

    }
}
/* ting sat på pause til ubestem tid eller til allersidst
 * de to parnteser
 *  
 * ting sat på pause
 */