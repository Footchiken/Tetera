using SharpGL;
using SharpGL.SceneGraph.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tetera
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenGLControl_OpenGLDraw(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;

            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            gl.LoadIdentity();

            gl.Translate(0.0f, 0.0f, -6.0f);

            //dibujar una piramide. Primero rotar el modelo de ls matriz
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);
                      //rotatePyramid

            //comenzar a dibujar los triangulos

            //gl.Begin(OpenGL.GL_TRIANGLES);

            //gl.Color(1.0f, 0.0f, 0.0f);
            //gl.Vertex(0.0f, 1.0f, 0.0f);
            //gl.Color(0.0f, 1.0f, 0.0f);
            //gl.Vertex(-1.0f, -1.0f, 1.0f);
            //gl.Color(0.0f, 0.0f, 1.0f);
            //gl.Vertex(1.0f, -1.0f, 1.0f);

            //gl.End();

            //IntPtr quadric = gl.NewQuadric();
            //gl.QuadricNormals(quadric, OpenGL.GLU_SMOOTH);
            //gl.Sphere(quadric, 1.0, 200, 200);

            //tetera
            Teapot tp = new Teapot();
            tp.Draw(gl, 14, 1, OpenGL.GL_FILL);

            rotation += 3.0f;

            //Reiniciar el modelo

            //rotar la geometria en un bit
            rotatePyramid += 3.0f;
            rquad -= 3.0f;
        }
        float rotatePyramid = 0;
        float rquad = 0;
        private float rotation;

        private void OpenGLControl_OpenGLInitialized(object sender, SharpGL.SceneGraph.OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;

            gl.Enable(OpenGL.GL_DEPTH_TEST);

            float[] global_ambient = new float[] { 0.1f, 0.5f, 1.0f, -12f };
            float[] light0pos = new float[] { -10.0f, 15f, 10.0f, 1.0f };
            float[] light0ambient = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
            float[] light0diffuse = new float[] { 0.3f, 0.3f, 0.3f, 1.0f };
            float[] light0specular = new float[] { 0.8f, 0.8f, 0.8f, 1.0f };

            float[] lmodel_ambient = new float[] { 0.2f, 0.2f, 0.2f, 1.0f };
            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, lmodel_ambient);

            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, global_ambient);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, light0pos);
            //gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, light0ambient);
            //gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, light0diffuse);
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, light0specular);
            gl.Enable(OpenGL.GL_LIGHTING);
            gl.Enable(OpenGL.GL_LIGHT0);
            gl.ShadeModel(OpenGL.GL_SMOOTH);
        }


        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void Posicion_de_luz_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Luz_ambiental_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Luz_difusa_Checked(object sender, RoutedEventArgs e)
        {
            OpenGL gl = args.OpenGL;

            gl.Enable(OpenGL.GL_DEPTH_TEST);
            float[] light0specular = new float[] { 0.3f, 0.3f, 0.3f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT3, OpenGL.GL_SPECULAR, light0specular);
            gl.Enable(OpenGL.GL_LIGHT3);
        }

        private void Luz_especular_Checked(object sender, RoutedEventArgs e)
        {

        }
    }

    internal class args
    {
        internal static OpenGL OpenGL;
    }
}
