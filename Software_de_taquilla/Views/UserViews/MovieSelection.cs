using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Views.UserViews
{
    public partial class MovieSelection : Form
    {
        public Movie movie;
        public MovieSelection(Movie mov)
        {
            this.movie = mov;
            InitializeComponent();
            this.buildComponent();
        }

        public void buildComponent()
        {
            label1.Text = this.movie.name;
            label2.Text = this.movie.public_;
            label3.Text = this.movie.duration;
            label4.Text = this.movie.id_room.ToString();
            picture.Image = Image.FromFile("./../../../images/" + movie.image);
        }
    }
}
