using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Converter
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> lengths = new Dictionary<string, double>()
        {
            {"nm", 1e-9 },
            {"µm", 1e-6 },
            {"mm", 1e-3 },
            {"cm", 1e-2 },
            {"m", 1 },
            {"km", 1e3 },
            {"Mm", 1e6 },
            {"Gm", 1e9 }
        };

        Dictionary<string, double> areas = new Dictionary<string, double>()
        {
            {"nm²", 1e-18 },
            {"µm²", 1e-12 },
            {"mm²", 1e-6 },
            {"cm²", 1e-4 },
            {"m²", 1 },
            {"km²", 1e6 },
            {"Mm²", 1e12 },
            {"Gm²", 1e18 }
        };

        Dictionary<string, double> volumes = new Dictionary<string, double>()
        {
            {"nm³", 1e-27 },
            {"µm³", 1e-18 },
            {"mm³", 1e-9 },
            {"cm³", 1e-6 },
            {"m³", 1 },
            {"km³", 1e9 },
            {"Mm³", 1e18 },
            {"Gm³", 1e27 }
        };
        public Form1()
        {
            InitializeComponent();
            foreach (string k in lengths.Keys)
            {
                comboBox1.Items.Add(k);
                comboBox2.Items.Add(k);
            }
            foreach (string k in areas.Keys)
            {
                comboBox3.Items.Add(k);
                comboBox4.Items.Add(k);
            }
            foreach (string k in volumes.Keys)
            {
                comboBox5.Items.Add(k);
                comboBox6.Items.Add(k);
            }
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 4;
            comboBox3.SelectedIndex = 4;
            comboBox4.SelectedIndex = 4;
            comboBox5.SelectedIndex = 4;
            comboBox6.SelectedIndex = 4;
            update();
        }
        void update()
        {
            try
            {
                double d = double.Parse(textBox1.Text);
                double d2 = d * lengths[comboBox1.Text] / lengths[comboBox2.Text];
                label1.Text = d2.ToString();
                double d3 = double.Parse(textBox2.Text);
                double d4 = d3 * areas[comboBox3.Text] / areas[comboBox4.Text];
                label2.Text = d4.ToString();
                double d5= double.Parse(textBox3.Text);
                double d6 = d5 * volumes[comboBox5.Text] / volumes[comboBox6.Text];
                label3.Text = d6.ToString();
            }
            catch
            {
                label1.Text = "";
                label2.Text = "";
                label3.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}
