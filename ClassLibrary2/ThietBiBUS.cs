﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class ThietBiBUS
    {
        public static List<ThietBi> LoaiTB()
        {
            return ThietBiDAO.GetAllThietBi();
        }
    }
}
