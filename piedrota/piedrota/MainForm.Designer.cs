/*
 * Created by SharpDevelop.
 * User: CC2-PC07
 * Date: 24/10/2024
 * Time: 08:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace piedrota
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.btnIngreso = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(97, 12);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtCorreo
			// 
			this.txtCorreo.Location = new System.Drawing.Point(97, 48);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(100, 20);
			this.txtCorreo.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Correo:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 84);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Contraseña:";
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(97, 83);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.Size = new System.Drawing.Size(100, 20);
			this.txtContrasena.TabIndex = 5;
			// 
			// btnIngreso
			// 
			this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIngreso.Location = new System.Drawing.Point(14, 110);
			this.btnIngreso.Name = "btnIngreso";
			this.btnIngreso.Size = new System.Drawing.Size(183, 29);
			this.btnIngreso.TabIndex = 6;
			this.btnIngreso.Text = "Ingresar";
			this.btnIngreso.UseVisualStyleBackColor = true;
			this.btnIngreso.Click += new System.EventHandler(this.BtnIngresoClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(215, 149);
			this.Controls.Add(this.btnIngreso);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCorreo);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "piedrota";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnIngreso;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
	}
}
