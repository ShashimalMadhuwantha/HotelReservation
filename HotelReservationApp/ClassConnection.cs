﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationApp
{
    internal class ClassConnection
    {
        public string constring = @"Data Source=LAPTOP-KLH5B18V;
                                       Initial Catalog=HotelReservation;
                                        Integrated Security=true";

        public SqlConnection GetConnection()
        {
            try
            {


                SqlConnection conn = new SqlConnection(constring);

                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
