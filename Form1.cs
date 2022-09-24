using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.SceneGraph.Assets;

namespace Fast_GPU_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point StatePoint;
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - StatePoint.X;
                this.Top = this.Top + e.Y - StatePoint.Y;
            }
        }
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            StatePoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = this.Left + e.X - StatePoint.X;
                this.Top = this.Top + e.Y - StatePoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            StatePoint = new Point(e.X, e.Y);
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        float rot = 10.0f;

        int userX = 1;
        int userY = 1;
        int userZ = 1;

        private void openGLControl1_Load(object sender, EventArgs e)
        {

        }
        private void openGLControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = openGLControl1.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -50.0f);
            gl.Rotate(rot, 0.0f, 0.1f, 0.0f);

            for (float iX = 0; iX < userX * 3; iX += 3.0f)
            {
                for (float iY = 0; iY < userY * 3; iY += 3.0f)
                {
                    for (float iZ = 0; iZ < userZ * 3; iZ += 3.0f)
                    {
                        drawBox(iX, iY, iZ, ref gl);
                    }
                }
            }

            gl.Flush();
            rot++;
        }
        private void drawBox(float x, float y, float z, ref OpenGL gl)
        {
            gl.Begin(7);

            // Top
            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + 1.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + 1.0f);
            // Bottom
            gl.Color(1.0f, 0.5f, 0.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + 1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + 1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + -1.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + -1.0f);
            // Front
            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + 1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + 1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + 1.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + 1.0f);
            // Back
            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + -1.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + -1.0f);
            // Left
            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + 1.0f);
            gl.Vertex(x + -1.0f, y + 1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + -1.0f);
            gl.Vertex(x + -1.0f, y + -1.0f, z + 1.0f);
            // Right
            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + -1.0f);
            gl.Vertex(x + 1.0f, y + 1.0f, z + 1.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + 1.0f);
            gl.Vertex(x + 1.0f, y + -1.0f, z + -1.0f);

            gl.End();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBoxInputY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userY = Convert.ToInt32(textBoxInputY.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBoxInoutZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userZ = Convert.ToInt32(textBoxInoutZ.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStartORStop_Click(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                userX = Convert.ToInt32(textBoxInputX.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
