using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using System.Windows.Forms;

namespace Software_de_taquilla.Views.UserViews.components
{
    public partial class MovieCard : UserControl
    {
        public MovieCard(Movie movie)
        {
            InitializeComponent();
            label1.Text = movie.name;
            string imagePath = @"C:\Users\d_car\OneDrive\Escritorio\UMG\4toaño\2do semestre\analisis de sistemas 2\Proyecto1\PROYECTO1\Software_de_taquilla_C\Software_de_taquilla\images\" + movie.image;
            picture.Image = Image.FromFile(imagePath);
// picture.Image = Image.FromFile("./../../../images/" + movie.image);
        }
    }
}
