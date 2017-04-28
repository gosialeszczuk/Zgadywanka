using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Apka
{
    class Bohater
    {
        string imie;
        bool okulary;
        string kolorWlosow;
        bool Czyfacet;
        bool kapelusz;
        bool was;
        Image obrazek;
        
        public Bohater()
        {

        }
       
        public Bohater(string i,bool o,string k,bool cz,bool kap,bool wa, Image obr)
        {
            imie = i;
            okulary = o;
            kolorWlosow = k;
            Czyfacet = cz;
            kapelusz = kap;
            was = wa;
            obrazek = obr;
        }
        public string PodajImie
        {
           get
            {
                return imie;
            }

            set
            {
                imie = value;
            }
        }

        public bool Okularnik
        {
            set
            {
                okulary = value;
            }
            get
            {
                return okulary;
            }
        }
        public string KolorWloskow
        {
            set
            {
                kolorWlosow = value;
            }
            get
            {
                return kolorWlosow;
            }
        }
        public bool CzyjestFacetem
        {
            set
            {
                Czyfacet = value;
            }
            get
            {
                return Czyfacet;
            }
        }
        public bool Kapelusznik
        {
            set
            {
                kapelusz = value;
            }
            get
            {
                return kapelusz;
            }
        }
        public bool CzyMaWas
        {
            set
            {
                was = value;
            }
            get
            {
                return was;
            }
        }
        public Image DodajObrazek
        {
            set
            {
                obrazek = value;
            }
            get
            {
                return obrazek;

            }
        }

    }
    
}
