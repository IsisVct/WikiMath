using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoCGTEC2023
{
    public partial class frmCirculoTrigonometrico : Form
    {
        public frmCirculoTrigonometrico()
        {
            InitializeComponent();
        }
        private class SecCosec
        {
            public Pen Pen { get; set; }
            public PointF PointF1 { get; set; }
            public PointF PointF2 { get; set; }
            public double Value { get; set; }

            public SecCosec(Pen Pen, PointF PointF1, PointF PointF2, double Value)
            {
                this.Pen = Pen;
                this.PointF1 = PointF1;
                this.PointF2 = PointF2;
                this.Value = Value;
            }
        }

        private NumericUpDown LastNumeric { get; set; }
        private decimal OldValue { get; set; }

        private void drawCircle(NumericUpDown sender)
        {
            Bitmap circle = new Bitmap(pboxCircle.Size.Width, pboxCircle.Size.Height);
            Graphics draw = Graphics.FromImage(circle);

            double angle = 0, arcLength = 0, sin = 0, cos = 0, tan = 0, cot = 0, sec = 0, csc = 0;

            switch (sender.Name)
            {
                case "numAngle":
                    angle = Convert.ToDouble(sender.Value);
                    arcLength = angle * Math.PI / 180;
                    sin = Math.Sin(arcLength);
                    cos = Math.Cos(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numArcLength":
                    arcLength = (sender.Value == sender.Maximum) ? 2 * Math.PI : Convert.ToDouble(sender.Value);
                    angle = arcLength * 180 / Math.PI;
                    sin = Math.Sin(arcLength);
                    cos = Math.Cos(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numSine":
                    sin = Convert.ToDouble(sender.Value);
                    arcLength = (Math.Asin(sin) + 2 * Math.PI) % (2 * Math.PI);
                    angle = arcLength * 180 / Math.PI;
                    cos = Math.Cos(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numCosine":
                    cos = Convert.ToDouble(sender.Value);
                    arcLength = Math.Acos(cos);
                    angle = arcLength * 180 / Math.PI;
                    sin = Math.Sin(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numTangent":
                    tan = Convert.ToDouble(sender.Value);
                    arcLength = (Math.Atan(tan) + 2 * Math.PI) % (2 * Math.PI);
                    angle = arcLength * 180 / Math.PI;
                    sin = Math.Sin(arcLength);
                    cos = Math.Cos(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numCotangent":
                    cot = Convert.ToDouble(sender.Value);
                    tan = 1 / cot;
                    arcLength = (Math.Atan(tan) + 2 * Math.PI) % (2 * Math.PI);
                    angle = arcLength * 180 / Math.PI;
                    sin = Math.Sin(arcLength);
                    cos = Math.Cos(arcLength);
                    sec = 1 / cos;
                    csc = 1 / sin;
                    break;
                case "numSecant":
                    if (Math.Abs(sender.Value) < 1)
                    {
                        MessageBox.Show("Não insira um valor menor que 1 na Secante!", "xERROx", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sec = Convert.ToDouble(OldValue);
                    }
                    else
                    {
                        sec = Convert.ToDouble(sender.Value);
                    }
                    cos = 1 / sec;
                    arcLength = Math.Acos(cos);
                    angle = arcLength * 180 / Math.PI;
                    sin = Math.Sin(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    csc = 1 / sin;
                    break;
                case "numCosecant":
                    if (Math.Abs(sender.Value) < 1)
                    {
                        MessageBox.Show("Não insira um valor menor que 1 na Cossecante!", "xERROx", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        csc = Convert.ToDouble(OldValue);
                    }
                    else
                    {
                        csc = Convert.ToDouble(sender.Value);
                    }
                    sin = 1 / csc;
                    arcLength = (Math.Asin(sin) + 2 * Math.PI) % (2 * Math.PI);
                    angle = arcLength * 180 / Math.PI;
                    cos = Math.Cos(arcLength);
                    tan = Math.Tan(arcLength);
                    cot = 1 / tan;
                    sec = 1 / cos;
                    break;
            }

            numAngle.Value = Convert.ToDecimal(angle);
            numArcLength.Value = Convert.ToDecimal(arcLength);
            numSine.Value = Convert.ToDecimal(sin);
            numCosine.Value = Convert.ToDecimal(cos);


            float middle = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 2F;
            float radius = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 3F;
            float sinF = middle - Convert.ToSingle(sin) * radius;
            float cosF = middle + Convert.ToSingle(cos) * radius;
            float tanF = middle - Convert.ToSingle(tan) * radius * Math.Sign(cos);
            float cotF = middle + Convert.ToSingle(cot) * radius * Math.Sign(sin);
            float originArc = middle + radius;
            float originTan = middle + radius * Math.Sign(cos);
            float originCot = middle - ((arcLength == 0) ? radius : (radius * Math.Sign(sin)));
            PointF originP = new PointF(middle, middle);
            PointF sinP = new PointF(middle, sinF);
            PointF cosP = new PointF(cosF, middle);
            PointF sincosP = new PointF(cosF, sinF);
            PointF originTanP = new PointF(originTan, middle);
            PointF originCotP = new PointF(middle, originCot);
            PointF tanP = new PointF(originTan, tanF);
            PointF cotP = new PointF(cotF, originCot);

            float normalWidth = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 100F;
            Color sinC = Color.Red;
            Color cosC = Color.Blue;
            Color tanC = Color.Yellow;
            Color cotC = Color.Orange;
            Color secC = Color.Green;
            Color cscC = Color.Purple;

            //Circle
            draw.DrawEllipse(new Pen(Color.FromArgb(128, Color.Black), normalWidth), new RectangleF(middle - radius, middle - radius, radius * 2F, radius * 2F));

            //Sin
            draw.DrawLine(new Pen(Color.FromArgb(255, sinC), normalWidth), originP, sinP);

            //Cos
            draw.DrawLine(new Pen(Color.FromArgb(255, cosC), normalWidth), originP, cosP);

            List<SecCosec> secCosec = new List<SecCosec>();

            try
            {
                //Tan
                numTangent.Value = Convert.ToDecimal(tan);
                draw.DrawLine(new Pen(Color.FromArgb(255, tanC), normalWidth), originTanP, tanP);

                //Sec
                numSecant.Value = Convert.ToDecimal(sec);
                secCosec.Add(new SecCosec(new Pen(Color.FromArgb(255, secC), normalWidth), originP, tanP, 1 / Math.Cos(arcLength)));
            }
            catch (OverflowException)
            {
                //Tan
                numTangent.Value = 0;

                //Sec
                numSecant.Value = 0;
            }

            try
            {
                //Cot
                numCotangent.Value = Convert.ToDecimal(cot);
                draw.DrawLine(new Pen(Color.FromArgb(255, cotC), normalWidth), originCotP, cotP);

                //Csc
                numCosecant.Value = Convert.ToDecimal(csc);
                secCosec.Add(new SecCosec(new Pen(Color.FromArgb(255, cscC), normalWidth), originP, cotP, 1 / Math.Sin(arcLength)));
            }
            catch(OverflowException)
            {
                //Cot
                numCotangent.Value = 0;

                //Csc
                numCosecant.Value = 0;
            }

            secCosec = secCosec.OrderByDescending(e => Math.Abs(e.Value)).ToList();

            foreach (SecCosec e in secCosec)
            {
                draw.DrawLine(e.Pen, e.PointF1, e.PointF2);
            }

            //Angle
            draw.DrawLine(new Pen(Color.Black, normalWidth), originP, sincosP);

            draw.Dispose();
            pboxCircle.Image = circle;
        }

        private void drawCircleByClick(int x, int y)
        {
            Bitmap circle = new Bitmap(pboxCircle.Size.Width, pboxCircle.Size.Height);
            Graphics draw = Graphics.FromImage(circle);

            float middle = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 2F;
            float radius = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 3F;

            double arcLength = (Math.Atan2(y + middle, x + middle) + 2 * Math.PI) % (2 * Math.PI);
            double angle = arcLength * 180 / Math.PI;
            double sin = Math.Sin(arcLength);
            double cos = Math.Cos(arcLength);
            double tan = Math.Tan(arcLength);
            double cot = 1 / tan;
            double sec = 1 / cos;
            double csc = 1 / sin;

            numAngle.Value = Convert.ToDecimal(angle);
            numArcLength.Value = Convert.ToDecimal(arcLength);
            numSine.Value = Convert.ToDecimal(sin);
            numCosine.Value = Convert.ToDecimal(cos);

            float sinF = middle - Convert.ToSingle(sin) * radius;
            float cosF = middle + Convert.ToSingle(cos) * radius;
            float tanF = middle - Convert.ToSingle(tan) * radius * Math.Sign(cos);
            float cotF = middle + Convert.ToSingle(cot) * radius * Math.Sign(sin);
            float originArc = middle + radius;
            float originTan = middle + radius * Math.Sign(cos);
            float originCot = middle - ((arcLength == 0) ? radius : (radius * Math.Sign(sin)));
            PointF originP = new PointF(middle, middle);
            PointF sinP = new PointF(middle, sinF);
            PointF cosP = new PointF(cosF, middle);
            PointF sincosP = new PointF(cosF, sinF);
            PointF originTanP = new PointF(originTan, middle);
            PointF originCotP = new PointF(middle, originCot);
            PointF tanP = new PointF(originTan, tanF);
            PointF cotP = new PointF(cotF, originCot);

            float normalWidth = Math.Min(pboxCircle.Size.Width, pboxCircle.Size.Height) / 100F;
            Color sinC = Color.Red;
            Color cosC = Color.Blue;
            Color tanC = Color.Yellow;
            Color cotC = Color.Orange;
            Color secC = Color.Green;
            Color cscC = Color.Purple;

            //Circle
            draw.DrawEllipse(new Pen(Color.FromArgb(128, Color.Black), normalWidth), new RectangleF(middle - radius, middle - radius, radius * 2F, radius * 2F));

            //Sin
            draw.DrawLine(new Pen(Color.FromArgb(255, sinC), normalWidth), originP, sinP);

            //Cos
            draw.DrawLine(new Pen(Color.FromArgb(255, cosC), normalWidth), originP, cosP);

            List<SecCosec> secCosec = new List<SecCosec>();

            try
            {
                //Tan
                numTangent.Value = Convert.ToDecimal(tan);
                draw.DrawLine(new Pen(Color.FromArgb(255, tanC), normalWidth), originTanP, tanP);

                //Sec
                numSecant.Value = Convert.ToDecimal(sec);
                secCosec.Add(new SecCosec(new Pen(Color.FromArgb(255, secC), normalWidth), originP, tanP, 1 / Math.Cos(arcLength)));
            } catch (OverflowException)
            {
                //Tan
                numTangent.Value = 0;

                //Sec
                numSecant.Value = 0;
            }

            try
            {
                //Cot
                numCotangent.Value = Convert.ToDecimal(cot);
                draw.DrawLine(new Pen(Color.FromArgb(255, cotC), normalWidth), originCotP, cotP);

                //Csc
                numCosecant.Value = Convert.ToDecimal(csc);
                secCosec.Add(new SecCosec(new Pen(Color.FromArgb(255, cscC), normalWidth), originP, cotP, 1 / Math.Sin(arcLength)));
            } catch (OverflowException)
            {
                //Cot
                numCotangent.Value = 0;

                //Csc
                numCosecant.Value = 0;
            }

            secCosec = secCosec.OrderByDescending(e => Math.Abs(e.Value)).ToList();

            foreach (SecCosec e in secCosec)
            {
                draw.DrawLine(e.Pen, e.PointF1, e.PointF2);
            }

            //Angle
            draw.DrawLine(new Pen(Color.Black, normalWidth), originP, sincosP);

            draw.Dispose();
            pboxCircle.Image = circle;
        }

        private void frmTrigonometricCircle_Load(object sender, EventArgs e)
        {
            numArcLength.Maximum = Convert.ToDecimal(Math.PI * 2);
            numArcLength.Increment = numArcLength.Maximum / 72;
            numTangent.Maximum = decimal.MaxValue;
            numTangent.Minimum = decimal.MinValue;
            numCotangent.Maximum = decimal.MaxValue;
            numCotangent.Minimum = decimal.MinValue;
            numSecant.Maximum = decimal.MaxValue;
            numSecant.Minimum = decimal.MinValue;
            numSecant.Increment = Convert.ToDecimal(2 / Math.Sqrt(3)) - 1;
            numCosecant.Maximum = decimal.MaxValue;
            numCosecant.Minimum = decimal.MinValue;
            numCosecant.Increment = Convert.ToDecimal(2 / Math.Sqrt(3)) - 1;
            drawCircle(numAngle);
        }

        private void numerics_ValueChanged(object sender, EventArgs e)
        {
            if (sender.Equals(LastNumeric))
            {
                drawCircle((NumericUpDown)sender);
                OldValue = ((NumericUpDown)sender).Value;
            }
        }

        private void numerics_Enter(object sender, EventArgs e)
        {
            LastNumeric = (NumericUpDown)sender;
            OldValue = ((NumericUpDown)sender).Value;
        }

        private void pboxCircle_MouseClick(object sender, MouseEventArgs e)
        {
            drawCircleByClick(e.X, e.Y);
        }
    }
}
