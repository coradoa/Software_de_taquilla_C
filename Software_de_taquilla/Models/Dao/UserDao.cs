﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dao
{
    public class UserDao : DBContext
    {

        public bool isConnected()
        {
            this.connection.Open();
            return this.connection != null;
        }
    }
}
