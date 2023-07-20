using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Views;

namespace Software_de_taquilla.Controllers
{
    public class LoginController
    {
        public Login view;
        public LoginController(Login view)
        {
            this.view = view;
            this.view.btn_login.Click += new EventHandler(this.buildView);
        }

        private void buildView(Object sender, EventArgs e)
        {
            UserDao myuser = new UserDao();
            string user = this.view.txt_user.Text;
            string pass = this.view.txt_pass.Text;
            string msg = myuser.userExist(user, pass) ? "Conexion realizaada" : "Error en al conexion";
            this.view.printMessage(msg);
        }
    }
}

