using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prueba_movimiento
{
    public partial class Form1 : Form
    {
        private Point mouseOffset;//Objeto Point nuevo. Esto actuará como variable cuando calcule cómo mover el formulario. 
        private bool isMouseDown = false;//El campo isMouseDown se utiliza para controlar si el usuario mantiene presionado el botón del mouse.
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }//Boton Salir

        //-------------------------TRES EVENTOS PARA MOVER EL FORM: MouseDown, MouseMove y MouseUp----------------------------------\\

        /*private void Form1_MouseDown(object sender, MouseEventArgs e)//Pulsamos boton del mouse
        {
            int xOffset;//Asignar coordenadas a la variable mouseOffset en función de la posición actual del puntero del mouse.
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;//la posición de desplazamiento se calcula utilizando información del  
                yOffset = -e.Y - SystemInformation.CaptionHeight -//sistema sobre el tamaño del borde (FrameBorderSize.Width)
                    SystemInformation.FrameBorderSize.Height;// y el alto de la barra de título (CaptionHeight).
                mouseOffset = new Point(xOffset, yOffset);//Asignamos la posicion del desplazamiento a la variable Point.
                isMouseDown = true;//Está pulsado el boton del mouse.
            }
        }*/

        /*private void Form1_MouseMove(object sender, MouseEventArgs e)//Movemos el mouse
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;//Cuando se hace clic con el botón primario del mouse y se arrastra el mouse, 
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;//la propiedad Location del formulario se establece en la nueva posición.
            }
        }*/

       /*private void Form1_MouseUp(object sender, MouseEventArgs e)//Levantamos el boton del mouse
        {
            if (e.Button == MouseButtons.Left)//El movimiento solo se produce pisando el boton izquierdo del mouse.
            {
                isMouseDown = false;
            }

        }*/

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;//Asignar coordenadas a la variable mouseOffset en función de la posición actual del puntero del mouse.
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;//la posición de desplazamiento se calcula utilizando información del  
                yOffset = -e.Y - 100 - SystemInformation.CaptionHeight -//sistema sobre el tamaño del borde (FrameBorderSize.Width)
                    SystemInformation.FrameBorderSize.Height;// y el alto de la barra de título (CaptionHeight).
                mouseOffset = new Point(xOffset, yOffset);//Asignamos la posicion del desplazamiento a la variable Point.
                isMouseDown = true;//Está pulsado el boton del mouse.
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;//Cuando se hace clic con el botón primario del mouse y se arrastra el mouse, 
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;//la propiedad Location del formulario se establece en la nueva posición.
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//El movimiento solo se produce pisando el boton izquierdo del mouse.
            {
                isMouseDown = false;
            }
        }

        

        //-------------------------\\------------------------------//-----------------------------\\--------------------------------\\
        //Aqui esta el codigo:
        //http://msdn.microsoft.com/es-es/library/6k15y9et(VS.80).aspx#Y1257
        //-------------------------\\------------------------------//-----------------------------\\--------------------------------\\

    }
}
