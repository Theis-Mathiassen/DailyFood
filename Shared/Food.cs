using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFood.Shared
{
    public interface Food
    {
        public string Getname ();
        public float Getprot100g ();
        public float Getcarb100g ();
        public float Getfiber100g ();
        public float Getfat100g ();
        public float Getalco100g ();
        public float Getenergy100gkJ ();
    }




}
