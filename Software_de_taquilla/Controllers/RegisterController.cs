using Software_de_taquilla.Models.Dao;
using Software_de_taquilla.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Controllers
{
    public class RegisterController
    {
        public Register view;
        public RegisterController(Register view)
        {
            this.view = view;
            this.view.Load += new EventHandler(this.buildComponents);
        }

        public void buildComponents(Object sender, EventArgs e)
        {
            this.view.btn_reg.Click += new EventHandler(this.register);
        }

        public void register(Object sender, EventArgs e)
        {
            string name = this.view.txt_user.Text;
            string pass = this.view.txt_pass.Text;
            UserDao usr = new UserDao();
            usr.insertUser(name, pass, 3);
            this.view.printMessage("¡Usuario creado!");
        }

    }
}
