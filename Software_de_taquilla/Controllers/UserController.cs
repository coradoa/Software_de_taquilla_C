using Software_de_taquilla.Views.AdminViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using Software_de_taquilla.Models.Dao;

namespace Software_de_taquilla.Controllers
{
    public class UserController
    {
        public UserManagment view;
        public UserController(UserManagment view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponent);
        }

        public void buildComponent(Object sender, EventArgs e)
        {
            this.view.btn_save.Click += new EventHandler(this.saveUser);
        }

        public bool isFullFields()
        {
            return this.view.txt_contrasenia.Text != "" || this.view.txt_name.Text != "" || this.view.txt_rol.Text != "";
        }

        public void saveUser(Object sender, EventArgs e)
        {
            string username = this.view.txt_name.Text;
            string pass = this.view.txt_contrasenia.Text;
            int rol = Convert.ToInt32(this.view.txt_rol.Text);
            UserDao mydao = new UserDao();
            mydao.insertUser(username, pass, rol);
            if (this.isFullFields())
            {
                this.view.printMessage("Usuario Agregado :D");
            }
            else
            {
                this.view.printMessage("Llene todos los campos");
            }
        }
    }
}
