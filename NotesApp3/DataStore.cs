using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp3
{
    public class DataStore
    {
        public static AppUser AppUser = new AppUser { Id = 1, UserName = "Alperen", Password = "13" };
        public static List<Number> Numbers = new List<Number>()

        {
            new Number{Id=1,  Definition="Ahmet - 5696844152 - büfe"},
            new Number{Id=2,  Definition="hakan - 5622455998 - -"},
            new Number{Id=3,  Definition="yağmur - 5688422335 - sınıf"},
            new Number{Id=4,  Definition="ali - 5466985232 - mahalle"},
            new Number{Id=5,  Definition="burak - 8455622332 - iş"},
            new Number{Id=6,  Definition="berat - 5266877423 - yurt"},
            new Number{Id=7,  Definition="YAVUZ Kahraman - 5555555555 - .Net onun işi"},


        };
    }


    public class Number
    {
        public int Id { get; set; }
        //public string Description { get; set; }
        public string Definition { get; set; }

    }
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
