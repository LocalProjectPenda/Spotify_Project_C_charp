using SpotyFake.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotyFake.Controller
{
    internal class RadioController
    {
       
        

            public void GetSoong(Radio radio, PlayList playlist)
            {

           

            Console.WriteLine("\t-POP ");
            Console.WriteLine("\t-ROCK ");
            Console.WriteLine("\t-REAGGAE ");
            Console.WriteLine("\t-HIP HOP ");
            Console.WriteLine("\t-LATINO ");

            string gender = Console.ReadLine().ToLower();

           

            var list = radio._songs.Where(i => i._genre == gender);

            Console.WriteLine("\n\n LIST SONG \n\n");


                if (list != null)
                {
                
                    foreach (var s in list)
                    {
                        var album = radio._albums.Where(i=>i.songs.Contains(s)).FirstOrDefault<Album>();
                        var artist = radio._artists.Where(i=>i.albums.Contains(album)).FirstOrDefault<Artist>();

                        Console.WriteLine(s.Id + "   " + s._title+"  "+album._title+"  "+artist._artName);

                    }


                    Console.WriteLine("\n\n SELECT SONG ");
                    

                    string note = Console.ReadLine();
                    int son;
                    if (int.TryParse(note, out son))
                    {



                        var audio = radio._songs.Where(i => i.Id == son).First<Song>();
                        if (audio != null)
                        {

                            Media media = new Media();
                            media.Play(audio);


                            playlist._songs.Add(audio);

                        }


                    }
                    else
                    {
                        Console.WriteLine("La valeur entrée n'est pas un entier valide.");
                    }


                Console.WriteLine("\n\n 1_ EXit ");

                int exit = Convert.ToInt32(Console.ReadLine());
                if (exit != 0)
                {
                    return;
                }





            }



        }
    }
}
