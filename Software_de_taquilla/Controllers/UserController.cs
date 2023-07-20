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
            this.fillDataGrid();
            this.fillRoleList();
        }

        public bool isFullFields()
        {
            return this.view.txt_contrasenia.Text != "" || this.view.txt_name.Text != "";
        }


        public void saveUser(Object sender, EventArgs e)
        {
            string username = this.view.txt_name.Text;
            string pass = this.view.txt_contrasenia.Text;
            int rol = Convert.ToInt32(this.view.role_list.SelectedIndex + 1);
            UserDao mydao = new UserDao();
            mydao.insertUser(username, pass, rol);
            if (this.isFullFields())
            {
                this.view.printMessage("Usuario Agregado :D");
                this.fillDataGrid();
                this.view.clearTextBox();
            }
            else
            {
                this.view.printMessage("Llene todos los campos");
                this.view.clearTextBox();
            }
        }


        public void fillDataGrid()
        {
            UserDao userdao = new UserDao();
            List<User> users = userdao.getUsers();
            this.view.data_grid.ColumnCount = 4;
            this.view.data_grid.Columns[0].Name = "ID";
            this.view.data_grid.Columns[1].Name = "Usuario";
            this.view.data_grid.Columns[2].Name = "Contraseña";
            this.view.data_grid.Columns[3].Name = "Rol";
            this.view.data_grid.Rows.Clear();
            foreach (User user in users)
            {
                this.view.data_grid.Rows.Add(user.id, user.name, user.pass, user.rol);
            }
        }

        public void fillRoleList()
        {
            RoleDao roledao = new RoleDao();
            List<Role> roles = roledao.getRoles();
            foreach (Role role in roles)
            {
                this.view.role_list.Items.Add(role.description);
            }
        }
    }
}
