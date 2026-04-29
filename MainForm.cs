using System;
using System.Globalization;
using System.Windows.Forms;

namespace ObjectMover
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void StartConvertation(object sender, EventArgs e)
        {
            string[] finalresult = new string[CodeText.Lines.Length];

            if (CodeText.Lines.Length != 0)
            {
                for (int i = 0; i < CodeText.Lines.Length; i++)
                {
                    GameCoordinate parsed = Parser.ParseToGameCoordinate((CodeText.Lines[i]));

                    Vector3 offsetCoordinate = new Vector3()
                    {
                        x = float.Parse(CenterXBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture),
                        y = float.Parse(CenterYBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture),
                        z = float.Parse(CenterZBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture)
                    };

                    parsed.position = parsed.position + offsetCoordinate;

                    string result = default;

                    switch(Parser.GetObjectType(CodeText.Lines[i]))
                    {
                        case ObjectType.CreateObject:
                            result = parsed.ToCreateObject();
                            break;
                        case ObjectType.CreateDynamicObject:
                            result = parsed.ToStreamer();
                            break;
                        default:
                            result = "Unknown object type";
                            break;
                    }

                    finalresult[i] = $"{result}";
                }

                ResultForm resultFormObj = new(finalresult);
                resultFormObj.ShowDialog();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
