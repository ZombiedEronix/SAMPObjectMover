using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SampObjectMove
{
    public partial class Form1 : Form
    {
        private string[] object_mode =
        {
            "CreateObject",
            "CreateDynamicObject"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] finalresult = new string[CodeText.Lines.Length];



            if(ObjectTypeBox.SelectedIndex  == -1)
            {
                MessageBox.Show("Выберите тип объекта", "Ты кое что забыл =3");
                return;
            }
            string pattern = @"CreateDynamicObject\(([^)]+)\);";


            if (CodeText.Lines.Length != 0)
            {
                for (int i = 0; i < CodeText.Lines.Length; i++)
                {
                    Match match = Regex.Match(CodeText.Lines[i], pattern);

                    if (match.Success)
                    {
                        string[] parameters = match.Groups[1].Value.Split(',');
                        double x, y, z;

                        double.TryParse(parameters[1], NumberStyles.Float, CultureInfo.InvariantCulture, out x);
                        double.TryParse(parameters[2], NumberStyles.Float, CultureInfo.InvariantCulture, out y);
                        double.TryParse(parameters[3], NumberStyles.Float, CultureInfo.InvariantCulture, out z);

                        x += double.Parse(CenterXBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture);
                        y += double.Parse(CenterYBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture);
                        z += double.Parse(CenterZBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture);


                        parameters[1] = x.ToString(CultureInfo.InvariantCulture);
                        parameters[2] = y.ToString(CultureInfo.InvariantCulture);
                        parameters[3] = z.ToString(CultureInfo.InvariantCulture);

                        for (int p = 0; p < parameters.Length; p++)
                        {
                            finalresult[i] = $"{object_mode[ObjectTypeBox.SelectedIndex]}({string.Join(", ", parameters)});";
                        }



                    }

                }

                ResultForm resultFormObj = new(finalresult);
                resultFormObj.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
