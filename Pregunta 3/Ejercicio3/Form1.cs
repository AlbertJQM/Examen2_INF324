using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        int cR, cG, cB;
        int cRx, cGx, cBx;

        int x = 0;
        int y = 0;
        int n = 0;

        Color[] colores;
        int[] cantidad;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Bitmap bmp = new Bitmap(openFileDialog1.FileName);
            picImagen.Image = bmp;
        }

        private void btnReconocer_Click(object sender, EventArgs e)
        {
            ReconocerSeccion(0, 200, 0, 180, picPaletaT);
            ReconocerSeccion(70, 260, 190, 320, picPaletaL);
            ReconocerSeccion(300, 540, 0, 150, picPaletaV);

        }

        private void ReconocerSeccion(int x0, int xf, int y0, int yf, PictureBox P)
        {
            Bitmap bmp = new Bitmap(picImagen.Image);
            Bitmap bmpPaleta = new Bitmap(250, 50);
            Color c = new Color();
            x = bmp.Width;
            y = bmp.Height;
            colores = new Color[x * y];
            cantidad = new int[x * y];
            for (int i = x0; i < xf; i = i + 5)
                for (int j = y0; j < yf; j = j + 5)
                {
                    c = bmp.GetPixel(i, j);
                    int r = Existe(c, n);
                    if (r == -1)
                    {
                        colores[n] = c;
                        cantidad[n] = 1;
                        n++;
                    }
                    else
                    {
                        cantidad[r]++;
                    }
                }

            Ordenar(n);

            int cc = 0;
            for (int k = 0; k < bmpPaleta.Width; k += 50)
            {
                for (int i = k; i < bmpPaleta.Width; i++)
                {
                    for (int j = 0; j < bmpPaleta.Height; j++)
                    {
                        bmpPaleta.SetPixel(i, j, colores[cc]);
                    }
                }
                cc++;
            }

            P.Image = bmpPaleta;
        }

        private int Existe(Color c, int indice)
        {
            int sw = -1;
            for (int j = 0; j < indice + 1; j++)
            {
                if (colores[j].Equals(c))
                {
                    sw = j;
                    break;
                }
            }
            return sw;

        }

        private void picImagen_MouseClick_1(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(picImagen.Image);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cRx = 0;
            cGx = 0;
            cBx = 0;
            int p = 0;
            picColor.BackColor = c;
            for (int i = e.X; (i < e.X + 10) && (i < bmp.Width); i++)
                for (int j = e.Y; (j < e.Y + 10) && (j < bmp.Height); j++)
                {
                    p++;
                    c = bmp.GetPixel(i, j);
                    cRx = c.R + cRx;
                    cGx = c.G + cGx;
                    cBx = c.B + cBx;
                }
            cRx = cRx / p;
            cGx = cGx / p;
            cBx = cBx / p;
            txtR.Text = c.R.ToString() + " " + cRx.ToString();
            txtG.Text = c.G.ToString() + " " + cGx.ToString();
            txtB.Text = c.B.ToString() + " " + cBx.ToString();
            picColorProm.BackColor = Color.FromArgb(cRx, cGx, cBx);
            textBox1.Text = e.X.ToString();
            textBox2.Text = e.Y.ToString();
        }

        private void Ordenar(int indice)
        {
            for (int k = 0; k < indice; k++)
            {
                for (int i = 0; i < indice - k - 1; i++)
                {
                    if (cantidad[i] < cantidad[i + 1])
                    {
                        int tmp = cantidad[i + 1];
                        cantidad[i + 1] = cantidad[i];
                        cantidad[i] = tmp;
                        
                        Color tmp2 = colores[i + 1];
                        colores[i + 1] = colores[i];
                        colores[i] = tmp2;
                    }
                }
            }
        }

        private void picPaletaT_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(picPaletaT.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 20 <= cRx) && (cRx <= cR + 20)) && ((cG - 20 <= cGx) && (cGx <= cG + 20)) && ((cB - 20 <= cBx) && (cBx <= cB + 20)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }

        private void picPaletaL_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(picPaletaL.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 20 <= cRx) && (cRx <= cR + 20)) && ((cG - 20 <= cGx) && (cGx <= cG + 20)) && ((cB - 20 <= cBx) && (cBx <= cB + 20)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }

        private void picPaletaV_MouseClick(object sender, MouseEventArgs e)
        {
            Bitmap img = new Bitmap(picImagen.Image);
            Bitmap bmp = new Bitmap(picPaletaV.Image);
            Bitmap bmp2 = new Bitmap(img.Width, img.Height);
            Color c = new Color();
            c = bmp.GetPixel(e.X, e.Y);
            cR = c.R;
            cG = c.G;
            cB = c.B;
            int p = 0;
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color cx = img.GetPixel(i, j);
                    cRx = cx.R;
                    cGx = cx.G;
                    cBx = cx.B;
                    if (((cR - 20 <= cRx) && (cRx <= cR + 20)) && ((cG - 20 <= cGx) && (cGx <= cG + 20)) && ((cB - 20 <= cBx) && (cBx <= cB + 20)))
                    {
                        bmp2.SetPixel(i, j, cx);
                    }
                }
            picModificado.Image = bmp2;
        }
    }
}
