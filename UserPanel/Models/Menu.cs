using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserPanel.Models
{
    public class Menu
    {
        public int ID { get; set; }
        public string MenuAdi { get; set; }
        public int UstMenuID { get; set; }
        public string Route { get; set; }
        public bool Aktiflik { get; set; }
    }
}