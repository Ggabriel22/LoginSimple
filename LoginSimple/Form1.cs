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

namespace LoginSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string usuario = "nekszer";
        string contraseña = "nekszer";

        private void button1_Click(object sender, EventArgs e)
        {
          string user =  BoxUser.Text;
          string password = BoxPassword.Text;
            if (user.Equals(usuario))
            { 
                if (password.Equals(contraseña))
                {
                    MessageBox.Show("Login exitoso");
                }
                else
                {
                    MessageBox.Show("La contraseña es incorrecta");
                    //Falla por contraseña
                }
            } 
            else
            {
                MessageBox.Show("No se reconoce usuario");
                //Fall por usuario
            }

        

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            
                
            

        }

    }
}
