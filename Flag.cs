using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компонент
{
    public partial class Flag : UserControl
    {
        Color[] mas = { Color.Blue, Color.White, Color.Red };
        Color color1;
        Color color2;
        Color color3;

        public Flag()
        {
            InitializeComponent();

            color1 = mas[0];
            color2 = mas[1];
            color3 = mas[2];
        }
        

        int count = 0;

        public Color Color1
        {
            set { color1 = value; mas[0] = color1;  Refresh();  }
            get { return color1; }
        }

        public Color Color2
        {
            set { color2 = value; mas[1] = color2; Refresh(); }
            get { return color2; }
        }

        public Color Color3
        {
            set { color3 = value; mas[2] = color3; Refresh(); }
            get { return color3; }
        }


        private void Flag_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(mas[ (count + 0) % 3 ]), 0, 0, this.Width/3, this.Height);
            gr.FillRectangle(new SolidBrush(mas[ (count + 1) % 3 ]), this.Width / 3, 0, this.Width / 3*2, this.Height);
            gr.FillRectangle(new SolidBrush(mas[ (count + 2) % 3 ]), this.Width / 3 * 2, 0, this.Width , this.Height);
            gr.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            Refresh();
        }

        private void Flag_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
