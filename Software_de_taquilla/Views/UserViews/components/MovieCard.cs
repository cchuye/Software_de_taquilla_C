﻿using System;
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
            picture.Image = Image.FromFile("./../../../images/" + movie.image);
        }
    }
}
