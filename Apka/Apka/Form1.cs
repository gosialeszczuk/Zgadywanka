using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Apka
{
    public partial class Form1 : Form
    {
      

        int yes;
        int no;
   
        bool was, mezczyzna, okulary, ciemne, kapelusz;
        Bohater bohater1 = new Bohater();
        Bohater bohater2 = new Bohater();
        Bohater bohater3 = new Bohater();
        Bohater bohater4 = new Bohater();
        Bohater bohater5 = new Bohater();
        Bohater bohater6 = new Bohater();
        Bohater bohater7 = new Bohater();
        Bohater bohater8 = new Bohater();
        Bohater bohater9 = new Bohater();
        Bohater bohater10 = new Bohater();
        Bohater bohater11 = new Bohater();
        Bohater bohater12 = new Bohater();
        List<Bohater> boh = new List<Bohater>();
        List<Image> zdjecia = new List<Image>();





        public Form1()
        {
            InitializeComponent();

            tak.Click += YesClickHandler;
            //tworzenie Alexa
            bohater1.PodajImie = "alex";
            bohater1.Okularnik = false;
            bohater1.Kapelusznik = false;
            bohater1.CzyMaWas = true;
            bohater1.KolorWloskow = "ciemne";
            bohater1.CzyjestFacetem = true;
            bohater1.DodajObrazek =
                Image.FromFile(@".\alex.jpg");
            //tworzenie Alfreda
            bohater2.PodajImie = "alfred";
            bohater2.Okularnik = false;
            bohater2.Kapelusznik = false;
            bohater2.CzyMaWas = true;
            bohater2.KolorWloskow = "rudy";
            bohater2.CzyjestFacetem = true;
            bohater2.DodajObrazek = Image.FromFile(@".\alfred.jpg");
            //tworzenie Anity
            bohater3.PodajImie = "anita";
            bohater3.Okularnik = false;
            bohater3.Kapelusznik = false;
            bohater3.KolorWloskow = "blond";
            bohater3.CzyjestFacetem = false;
            bohater3.CzyMaWas = false;
            bohater3.DodajObrazek =
               Image.FromFile(@".\anita.jpg");
            //tworzenie Anne 
            bohater4.PodajImie = "anne";
            bohater4.Okularnik = false;
            bohater4.Kapelusznik = false;
            bohater4.KolorWloskow = "ciemne";
            bohater4.CzyjestFacetem = false;
            bohater4.CzyMaWas = false;
            bohater4.DodajObrazek = Image.FromFile(@".\anne.jpg");
            //tworzenie Bernarda
            bohater5.PodajImie = "bernard";
            bohater5.Okularnik = false;
            bohater5.Kapelusznik = true;
            bohater5.KolorWloskow = "ciemne";
            bohater5.CzyjestFacetem = true;
            bohater5.CzyMaWas = false;
            bohater5.DodajObrazek = Image.FromFile(@".\bernard.jpg");
            //tworzenie Claire
            bohater6.PodajImie = "claire";
            bohater6.Okularnik = true;
            bohater6.Kapelusznik = true;
            bohater6.KolorWloskow = "rudy";
            bohater6.CzyjestFacetem = false;
            bohater6.CzyMaWas = false;
            bohater6.DodajObrazek = Image.FromFile(@".\claire.jpg");
            //tworzenie Joe
            bohater7.PodajImie = "joe";
            bohater7.Okularnik = true;
            bohater7.KolorWloskow = "blond";
            bohater7.CzyjestFacetem = true;
            bohater7.Kapelusznik = false;
            bohater7.CzyMaWas = false;
            bohater7.DodajObrazek= Image.FromFile(@".\joe.jpg");

            //tworzenie Marii
            bohater8.PodajImie = "maria";
            bohater8.Okularnik = false;
            bohater8.Kapelusznik = true;
            bohater8.KolorWloskow = "ciemne";
            bohater8.CzyjestFacetem = false;
            bohater8.CzyMaWas = false;
            bohater8.DodajObrazek= Image.FromFile(@".\maria.jpg");

            //tworzenie Erica
            bohater9.PodajImie = "eric";
            bohater9.Okularnik = false;
            bohater9.Kapelusznik = true;
            bohater9.KolorWloskow = "blond";
            bohater9.CzyjestFacetem = true;
            bohater9.CzyMaWas = false;
            bohater9.DodajObrazek= Image.FromFile(@".\eric.jpg");
            //tworzenie Toma
            bohater10.DodajObrazek = Image.FromFile(@".\tom.jpg");
            bohater10.PodajImie = "tom";
            bohater10.Okularnik = true;
            bohater10.KolorWloskow = "ciemne";
            bohater10.CzyjestFacetem = true;
            bohater10.CzyMaWas = false;
            bohater10.Kapelusznik = false;
  

            //dodawanie bohaterów do listy
            boh.Add(bohater1);
            boh.Add(bohater2);
            boh.Add(bohater3);
            boh.Add(bohater4);
            boh.Add(bohater5);
            boh.Add(bohater6);
            boh.Add(bohater7);
            boh.Add(bohater8);
            boh.Add(bohater9);
            boh.Add(bohater10);
          
    


            //tworzymy listę zdjęć bohaterów

            zdjecia.Add(bohater1.DodajObrazek);
            zdjecia.Add(bohater2.DodajObrazek);
            zdjecia.Add(bohater3.DodajObrazek);
            zdjecia.Add(bohater4.DodajObrazek);
            zdjecia.Add(bohater5.DodajObrazek);
            zdjecia.Add(bohater6.DodajObrazek);
            zdjecia.Add(bohater7.DodajObrazek);
            zdjecia.Add(bohater8.DodajObrazek);
            zdjecia.Add(bohater9.DodajObrazek);
            zdjecia.Add(bohater10.DodajObrazek);
            
           


        }

        private void YesClickHandler(object sender, EventArgs e)
        {
            Button ClickedButton = (Button)sender;
        }

        private void obrazek_Click(object sender, EventArgs e)
        {


        }
        //guzik uruchamiający grę i pierwsze pytanko
        private void graj_Click(object sender, EventArgs e)
        {
           

     
            Random losuj = new Random();
            
            obrazek.Image= zdjecia[losuj.Next(0, zdjecia.Count - 1)];
           



            Pytanie.Text = "Czy postać jest mężczyzną?";
            tak.Visible = true;
            NIE.Visible = true;

            graj.Visible = true;
            odpowiedz.Visible = false;
         
            mezczyzna = false;
            was = false;
            kapelusz = false;
            okulary = false;



        }


        //textBox z pytaniem
        private void Pytanie_TextChanged(object sender, EventArgs e)
        {



        }
        //odpowiedz TAK
        private void button1_Click(object sender, EventArgs e)
        {
            yes += 1;

          

            NIE.Visible = false;
            tak.Visible = false;
            if (Pytanie.Text == "Czy postać jest mężczyzną?")
            {
                pytanie1.Visible = true;
                mezczyzna = true;
            }

            if (Pytanie.Text == "Czy postać ma ciemne włosy?")
            {
                pytanie2.Visible = true;
                ciemne = true;


            }

            if (Pytanie.Text == "Czy postać nosi okulary?")
            {
                pytanie3.Visible = true;
                okulary = true;


            }

            if (Pytanie.Text == "Czy postać nosi nakrycie głowy?")
            {
                pytanie4.Visible = true;
                kapelusz = true;

            }
            if (Pytanie.Text == "Czy postać ma wąsy?")
            {
              
                was = true;
                Pytanie.Text = string.Empty;

            }
            if (Pytanie.Text == string.Empty)
            {
                odpowiedz.Visible = true;

            }



        }
        //odpowiedz NIE
        private void NIE_Click(object sender, EventArgs e)
        {


            no += 1;
         
            tak.Visible = false;
            NIE.Visible = false;


            if (Pytanie.Text == "Czy postać jest mężczyzną?")
            {
                pytanie1.Visible = true;
                mezczyzna = false;
            }

            if (Pytanie.Text == "Czy postać ma ciemne włosy?")
            {
                pytanie2.Visible = true;
                ciemne = false;

            }

            if (Pytanie.Text == "Czy postać nosi okulary?")
            {
                pytanie3.Visible = true;
                okulary = false;

            }

            if (Pytanie.Text == "Czy postać nosi nakrycie głowy?")
            {
                pytanie4.Visible = true;
                kapelusz = false;
            }

            if (Pytanie.Text == "Czy postać ma wąsy?")
            {
               
                was = false;
                Pytanie.Text = string.Empty;

            }
            if (Pytanie.Text == string.Empty)
            {
                odpowiedz.Visible = true;

            }




        }
        
        private void Nastepny_Click(object sender, EventArgs e)
        {
         

        }
      
        private void Nastepny1_Click(object sender, EventArgs e)
        {

        

        }
        //button w którym będziemy informować jaka to postać :) 
        private void odpowiedz_Click(object sender, EventArgs e)
        { /*
            Ta odpowiedź jest trochę zakręcona, ale mniej więcej
            chodzi w niej oto, że 
            Tworzę listy znalezionych i dzielę je na mniejsze listy 
            i na podstawie mniejszych list odnajduję bohatera.
            W przypadku przekłamania bohater nie zostanie odnaleziony poprawnie.
             
            */

            if (mezczyzna == true)
            {
                List<Bohater> znaleziony = boh.FindAll(
          delegate (Bohater bk)
          {
              return bk.CzyjestFacetem == true;
          }
          );
                if (znaleziony.Count != 0)
                {
                   

                    if (ciemne == true)
                    {
                        List<Bohater> ciemnowlosy = znaleziony.FindAll(
                            delegate (Bohater bok)
                            {
                                return bok.KolorWloskow == "ciemne";
                            }

                        );

                        if (ciemnowlosy.Count != 0)
                        {
                            
                            if (was == true)
                            {

                                List<Bohater> wasik = ciemnowlosy.FindAll(
                                    delegate (Bohater b2)
                                    {
                                        return b2.CzyMaWas == true;
                                    }
                                    );
                                if (wasik.Count != 0)
                                {

                                    


                                    if (kapelusz == true && okulary == true)
                                    {
                                        List<Bohater> okularnicyiKapelusznicy = wasik.FindAll(
                            delegate (Bohater bok2)
                            {
                                return bok2.Kapelusznik == true && bok2.Okularnik == true;
                            }
                                            );


                                        if (okularnicyiKapelusznicy.Count != 0)
                                        {
                                            foreach (Bohater b in okularnicyiKapelusznicy)
                                            {


                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                            }


                                        }

                                    }
                                    else if (kapelusz == true)
                                    {
                                        List<Bohater> wesolyKapelusznik = wasik.FindAll(
                                delegate (Bohater wK1)
                                {
                                    return wK1.Kapelusznik == true;
                                }



                                          );

                                        if (wesolyKapelusznik.Count != 0)
                                        {


                                            foreach (Bohater b in wesolyKapelusznik)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }


                                    }


                                    else if (kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezKapelusza = wasik.FindAll(
                                        delegate (Bohater lbK)
                                        {
                                            return lbK.Kapelusznik == false;
                                        }
                                        );

                                        if (ludzieBezKapelusza.Count != 0)
                                        {


                                            foreach (Bohater b in ludzieBezKapelusza)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }

                                    }


                                    else if (okulary == true)
                                    {
                                        List<Bohater> ludziewOkularach = wasik.FindAll(
                                        delegate (Bohater blwO)
                                        { return blwO.Okularnik == true; }
                                        );
                                        if (ludziewOkularach.Count != 0)
                                        {
                                            foreach (Bohater b in ludziewOkularach)
                                            {
                                                MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                            }

                                        }

                                    }


                                    else if (okulary == false)
                                    {
                                        List<Bohater> ludzieBezOkularow = wasik.FindAll(
                                            delegate (Bohater bLbO)
                                            {
                                                return bLbO.Okularnik == false;
                                            }
                                                );


                                        if (ludzieBezOkularow.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkularow)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }

                                        }
                                    }

                                    else if (okulary == false && kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezOkiKap = wasik.FindAll(
                                          delegate (Bohater ludzBezOkKap)
                                          {
                                              return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                          }

                                              );
                                        if (ludzieBezOkiKap.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkiKap)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }
                                        }

                                    }
                                }

                            }

                            else if (was == false)
                            {
                                List<Bohater> Bezwasa = ciemnowlosy.FindAll(
                                    delegate (Bohater b2)
                                    {
                                        return b2.CzyMaWas == false;
                                    }
                                    );
                                if (Bezwasa.Count != 0)
                                {


                                    if (kapelusz == true && okulary == true)
                                    {
                                        List<Bohater> okularnicyiKapelusznicy = Bezwasa.FindAll(
                            delegate (Bohater bok2)
                            {
                                return bok2.Kapelusznik == true && bok2.Okularnik == true;
                            }
                                            );


                                        if (okularnicyiKapelusznicy.Count != 0)
                                        {
                                            foreach (Bohater b in okularnicyiKapelusznicy)
                                            {


                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                            }


                                        }

                                    }
                                    else if (kapelusz == true)
                                    {
                                        List<Bohater> wesolyKapelusznik = Bezwasa.FindAll(
                                delegate (Bohater wK1)
                                {
                                    return wK1.Kapelusznik == true;
                                }



                                          );

                                        if (wesolyKapelusznik.Count != 0)
                                        {


                                            foreach (Bohater b in wesolyKapelusznik)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }


                                    }


                                    else if (kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezKapelusza = Bezwasa.FindAll(
                                        delegate (Bohater lbK)
                                        {
                                            return lbK.Kapelusznik == false;
                                        }
                                        );

                                        if (ludzieBezKapelusza.Count != 0)
                                        {


                                            foreach (Bohater b in ludzieBezKapelusza)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }

                                    }


                                    else if (okulary == true)
                                    {
                                        List<Bohater> ludziewOkularach = Bezwasa.FindAll(
                                        delegate (Bohater blwO)
                                        { return blwO.Okularnik == true; }
                                        );
                                        if (ludziewOkularach.Count != 0)
                                        {
                                            foreach (Bohater b in ludziewOkularach)
                                            {
                                                MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                            }

                                        }

                                    }


                                    else if (okulary == false)
                                    {
                                        List<Bohater> ludzieBezOkularow = Bezwasa.FindAll(
                                            delegate (Bohater bLbO)
                                            {
                                                return bLbO.Okularnik == false;
                                            }
                                                );


                                        if (ludzieBezOkularow.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkularow)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }

                                        }
                                    }

                                    else if (okulary == false && kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezOkiKap = Bezwasa.FindAll(
                                          delegate (Bohater ludzBezOkKap)
                                          {
                                              return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                          }

                                              );
                                        if (ludzieBezOkiKap.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkiKap)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }
                                        }

                                    }
                                }

                            }

                        }

                    }
                    else if (ciemne == false)
                    {
                        List<Bohater> innykolor = znaleziony.FindAll(
                    delegate (Bohater b1)
                    {
                        return b1.KolorWloskow != "ciemne";
                    }




                            );
                        if (innykolor.Count != 0)
                        {
                            if (was == true)
                            {

                                List<Bohater> wasik = innykolor.FindAll(
                                    delegate (Bohater b2)
                                    {
                                        return b2.CzyMaWas == true;
                                    }
                                    );
                                if (wasik.Count != 0)
                                {

                                   


                                    if (kapelusz == true && okulary == true)
                                    {
                                        List<Bohater> okularnicyiKapelusznicy = wasik.FindAll(
                            delegate (Bohater bok2)
                            {
                                return bok2.Kapelusznik == true && bok2.Okularnik == true;
                            }
                                            );


                                        if (okularnicyiKapelusznicy.Count != 0)
                                        {
                                            foreach (Bohater b in okularnicyiKapelusznicy)
                                            {


                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                            }


                                        }

                                    }
                                    else if (kapelusz == true)
                                    {
                                        List<Bohater> wesolyKapelusznik = wasik.FindAll(
                                delegate (Bohater wK1)
                                {
                                    return wK1.Kapelusznik == true;
                                }



                                          );

                                        if (wesolyKapelusznik.Count != 0)
                                        {


                                            foreach (Bohater b in wesolyKapelusznik)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }


                                    }


                                    else if (kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezKapelusza = wasik.FindAll(
                                        delegate (Bohater lbK)
                                        {
                                            return lbK.Kapelusznik == false;
                                        }
                                        );

                                        if (ludzieBezKapelusza.Count != 0)
                                        {


                                            foreach (Bohater b in ludzieBezKapelusza)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }

                                    }


                                    else if (okulary == true)
                                    {
                                        List<Bohater> ludziewOkularach = wasik.FindAll(
                                        delegate (Bohater blwO)
                                        { return blwO.Okularnik == true; }
                                        );
                                        if (ludziewOkularach.Count != 0)
                                        {
                                            foreach (Bohater b in ludziewOkularach)
                                            {
                                                MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                            }

                                        }

                                    }


                                    else if (okulary == false)
                                    {
                                        List<Bohater> ludzieBezOkularow = wasik.FindAll(
                                            delegate (Bohater bLbO)
                                            {
                                                return bLbO.Okularnik == false;
                                            }
                                                );


                                        if (ludzieBezOkularow.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkularow)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }

                                        }
                                    }

                                    else if (okulary == false && kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezOkiKap = wasik.FindAll(
                                          delegate (Bohater ludzBezOkKap)
                                          {
                                              return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                          }

                                              );
                                        if (ludzieBezOkiKap.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkiKap)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }
                                        }

                                    }
                                }

                            }

                            else if (was == false)
                            {
                                List<Bohater> Bezwasa = innykolor.FindAll(
                                    delegate (Bohater b2)
                                    {
                                        return b2.CzyMaWas == false;
                                    }
                                    );
                                if (Bezwasa.Count != 0)
                                {


                                    if (kapelusz == true && okulary == true)
                                    {
                                        List<Bohater> okularnicyiKapelusznicy = Bezwasa.FindAll(
                            delegate (Bohater bok2)
                            {
                                return bok2.Kapelusznik == true && bok2.Okularnik == true;
                            }
                                            );


                                        if (okularnicyiKapelusznicy.Count != 0)
                                        {
                                            foreach (Bohater b in okularnicyiKapelusznicy)
                                            {


                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                            }


                                        }

                                    }
                                    else if (kapelusz == true)
                                    {
                                        List<Bohater> wesolyKapelusznik = Bezwasa.FindAll(
                                delegate (Bohater wK1)
                                {
                                    return wK1.Kapelusznik == true;
                                }



                                          );

                                        if (wesolyKapelusznik.Count != 0)
                                        {


                                            foreach (Bohater b in wesolyKapelusznik)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }


                                    }


                                    else if (kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezKapelusza = Bezwasa.FindAll(
                                        delegate (Bohater lbK)
                                        {
                                            return lbK.Kapelusznik == false;
                                        }
                                        );

                                        if (ludzieBezKapelusza.Count != 0)
                                        {


                                            foreach (Bohater b in ludzieBezKapelusza)
                                            {
                                                MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                            }


                                        }

                                    }


                                    else if (okulary == true)
                                    {
                                        List<Bohater> ludziewOkularach = Bezwasa.FindAll(
                                        delegate (Bohater blwO)
                                        { return blwO.Okularnik == true; }
                                        );
                                        if (ludziewOkularach.Count != 0)
                                        {
                                            foreach (Bohater b in ludziewOkularach)
                                            {
                                                MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                            }

                                        }

                                    }


                                    else if (okulary == false)
                                    {
                                        List<Bohater> ludzieBezOkularow = Bezwasa.FindAll(
                                            delegate (Bohater bLbO)
                                            {
                                                return bLbO.Okularnik == false;
                                            }
                                                );


                                        if (ludzieBezOkularow.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkularow)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }

                                        }
                                    }

                                    else if (okulary == false && kapelusz == false)
                                    {
                                        List<Bohater> ludzieBezOkiKap = Bezwasa.FindAll(
                                          delegate (Bohater ludzBezOkKap)
                                          {
                                              return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                          }

                                              );
                                        if (ludzieBezOkiKap.Count != 0)
                                        {
                                            foreach (Bohater b in ludzieBezOkiKap)
                                            {
                                                MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                            }
                                        }

                                    }
                                }

                            }

                        }

                    }
                }
            }






            else
        if (mezczyzna == false)
            {
                {
                    List<Bohater> znaleziona = boh.FindAll(
              delegate (Bohater bk)
              {
                  return bk.CzyjestFacetem == false;
              }
              );
                    if (znaleziona.Count != 0)
                    {


                        if (ciemne == true)
                        {
                            List<Bohater> ciemnowlosy = znaleziona.FindAll(
                                delegate (Bohater bok)
                                {
                                    return bok.KolorWloskow == "ciemne";
                                }

                            );

                            if (ciemnowlosy.Count != 0)
                            {

                                if (kapelusz == true && okulary == true)
                                {
                                    List<Bohater> okularnicyiKapelusznicy = ciemnowlosy.FindAll(
                        delegate (Bohater bok2)
                        {
                            return bok2.Kapelusznik == true && bok2.Okularnik == true;
                        }
                                        );


                                    if (okularnicyiKapelusznicy.Count != 0)
                                    {
                                        foreach (Bohater b in okularnicyiKapelusznicy)
                                        {


                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                        }


                                    }

                                }
                                else if (kapelusz == true)
                                {
                                    List<Bohater> wesolyKapelusznik = ciemnowlosy.FindAll(
                            delegate (Bohater wK1)
                            {
                                return wK1.Kapelusznik == true;
                            }



                                      );

                                    if (wesolyKapelusznik.Count != 0)
                                    {


                                        foreach (Bohater b in wesolyKapelusznik)
                                        {
                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                        }


                                    }


                                }


                                else if (kapelusz == false)
                                {
                                    List<Bohater> ludzieBezKapelusza = ciemnowlosy.FindAll(
                                    delegate (Bohater lbK)
                                    {
                                        return lbK.Kapelusznik == false;
                                    }
                                    );

                                    if (ludzieBezKapelusza.Count != 0)
                                    {


                                        foreach (Bohater b in ludzieBezKapelusza)
                                        {
                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                        }


                                    }

                                }


                                else if (okulary == true)
                                {
                                    List<Bohater> ludziewOkularach = ciemnowlosy.FindAll(
                                    delegate (Bohater blwO)
                                    { return blwO.Okularnik == true; }
                                    );
                                    if (ludziewOkularach.Count != 0)
                                    {
                                        foreach (Bohater b in ludziewOkularach)
                                        {
                                            MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                        }

                                    }

                                }


                                else if (okulary == false)
                                {
                                    List<Bohater> ludzieBezOkularow = ciemnowlosy.FindAll(
                                        delegate (Bohater bLbO)
                                        {
                                            return bLbO.Okularnik == false;
                                        }
                                            );


                                    if (ludzieBezOkularow.Count != 0)
                                    {
                                        foreach (Bohater b in ludzieBezOkularow)
                                        {
                                            MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                        }

                                    }
                                }

                                else if (okulary == false && kapelusz == false)
                                {
                                    List<Bohater> ludzieBezOkiKap = ciemnowlosy.FindAll(
                                      delegate (Bohater ludzBezOkKap)
                                      {
                                          return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                      }

                                          );
                                    if (ludzieBezOkiKap.Count != 0)
                                    {
                                        foreach (Bohater b in ludzieBezOkiKap)
                                        {
                                            MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                        }
                                    }

                                }
                            }

                        }




                        else if (ciemne == false)
                        {
                            List<Bohater> innykolor = znaleziona.FindAll(
                               delegate (Bohater bok)
                               {
                                   return bok.KolorWloskow != "ciemne";
                               }

                           );

                            if (innykolor.Count != 0)
                            {


                                if (kapelusz == true && okulary == true)
                                {
                                    List<Bohater> okularnicyiKapelusznicy = innykolor.FindAll(
                        delegate (Bohater bok2)
                        {
                            return bok2.Kapelusznik == true && bok2.Okularnik == true;
                        }
                                        );


                                    if (okularnicyiKapelusznicy.Count != 0)
                                    {
                                        foreach (Bohater b in okularnicyiKapelusznicy)
                                        {


                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);
                                        }


                                    }

                                }
                                else if (kapelusz == true)
                                {
                                    List<Bohater> wesolyKapelusznik = innykolor.FindAll(
                            delegate (Bohater wK1)
                            {
                                return wK1.Kapelusznik == true;
                            }



                                      );

                                    if (wesolyKapelusznik.Count != 0)
                                    {


                                        foreach (Bohater b in wesolyKapelusznik)
                                        {
                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                        }


                                    }


                                }


                                else if (kapelusz == false)
                                {
                                    List<Bohater> ludzieBezKapelusza = innykolor.FindAll(
                                    delegate (Bohater lbK)
                                    {
                                        return lbK.Kapelusznik == false;
                                    }
                                    );

                                    if (ludzieBezKapelusza.Count != 0)
                                    {


                                        foreach (Bohater b in ludzieBezKapelusza)
                                        {
                                            MessageBox.Show("zgaduję, że to: " + " " + b.PodajImie);



                                        }


                                    }

                                }


                                else if (okulary == true)
                                {
                                    List<Bohater> ludziewOkularach = innykolor.FindAll(
                                    delegate (Bohater blwO)
                                    { return blwO.Okularnik == true; }
                                    );
                                    if (ludziewOkularach.Count != 0)
                                    {
                                        foreach (Bohater b in ludziewOkularach)
                                        {
                                            MessageBox.Show("zgaduję, że jest to : " + b.PodajImie);
                                        }

                                    }

                                }


                                else if (okulary == false)
                                {
                                    List<Bohater> ludzieBezOkularow = innykolor.FindAll(
                                        delegate (Bohater bLbO)
                                        {
                                            return bLbO.Okularnik == false;
                                        }
                                            );


                                    if (ludzieBezOkularow.Count != 0)
                                    {
                                        foreach (Bohater b in ludzieBezOkularow)
                                        {
                                            MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                        }

                                    }
                                }

                                else if (okulary == false && kapelusz == false)
                                {
                                    List<Bohater> ludzieBezOkiKap = innykolor.FindAll(
                                      delegate (Bohater ludzBezOkKap)
                                      {
                                          return ludzBezOkKap.Okularnik == false && ludzBezOkKap.Kapelusznik == false;
                                      }

                                          );
                                    if (ludzieBezOkiKap.Count != 0)
                                    {
                                        foreach (Bohater b in ludzieBezOkiKap)
                                        {
                                            MessageBox.Show("zgaduję, że jest to: " + b.PodajImie);
                                        }
                                    }

                                }
                            }
                        }


                        }
                    }
                }
            }
        
        


        //guzik pokazujący kolejne pytanie nr 2
        private void pytanie1_Click(object sender, EventArgs e)
        {

            //numer += 1;
            Pytanie.Text = "Czy postać ma ciemne włosy?";
            pytanie1.Visible = false;
            tak.Visible = true;
            NIE.Visible = true;


        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZASADY_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gra ZGADNIJ KTO polega na odgadnięciu przez komputer wylosowanego bohatera . Użytkownik odpowiada na pytania TAK/NIE. Komputer na podstawie jego odpowiedzi odgaduję bohatera widocznego na obrazku. W przypadku gdy komputer został 'oszukany' wynik jest niepoprawny.W puli bohaterów znajduje się 10 postaci.","Zasady gry",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void pytanie2_Click(object sender, EventArgs e)
        {
            Pytanie.Text = "Czy postać nosi okulary?";
            pytanie2.Visible = false;
            tak.Visible = true;
            NIE.Visible = true;
        }

        private void pomocniczyBut_Click(object sender, EventArgs e)
        {
            
        }

        private void pytanie3_Click(object sender, EventArgs e)
        {
            Pytanie.Text = "Czy postać nosi nakrycie głowy?";
            pytanie3.Visible = false;
            tak.Visible = true;
            NIE.Visible = true;
        }

        private void pytanie4_Click(object sender, EventArgs e)
        {
            Pytanie.Text = "Czy postać ma wąsy?";
            pytanie4.Visible = false;
            

            tak.Visible = true;
            NIE.Visible = true;
        }
    }
}

