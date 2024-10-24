/*
 * Created by SharpDevelop.
 * User: CC2-PC07
 * Date: 24/10/2024
 * Time: 08:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace piedrota
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnIngresoClick(object sender, EventArgs e)
		{
			string nombre = txtName.Text;
			string correo = "email@example.com";
			string contrasena = "contraseña1234";
			
			if(txtContrasena.Text==contrasena&&txtCorreo.Text==correo)
			{
				MessageBox.Show("Bienvenido " + nombre + "!");
			}
			else {
				MessageBox.Show("Un dato no es valido");
			}
		}
		
	}
}
