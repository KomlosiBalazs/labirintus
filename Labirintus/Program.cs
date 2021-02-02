using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Labirintus
{

    class Program
    {
        static void Main(string[] args)
        {
            Maphandler map1 = new Maphandler("Első pálya");
            bool gameisrunning = true;

            while (gameisrunning)
            {
                char command = Console.ReadKey().KeyChar;
                switch (command) {
                    case 'w': map1.up(); break;
                    case 's': map1.down(); break;
                    case 'a': map1.left(); break;
                    case 'd': map1.right(); break;
                    case 'f': Console.WriteLine(map1.whereamI()[0]+'|'+map1.whereamI()[1]); ; break;
                    default:
                        Console.WriteLine("nincs ilyen utasítás");
                        break;
                }

                Console.WriteLine(map1.getName());
                map1.showMap();

            }
            Console.ReadKey();
        }

        class Maphandler
        {
            private char[,] map;
            private String mapname;
            public Maphandler(String name)
            {
                this.mapname = name;
                this.map = new char[,]
                    {
                    { '#', '@','#','#','#','#'},
                    { '#', '.','#','.','.','#'},
                    { '#', '.','.','#','.','x'},
                    { '#', '#','.','#','.','#'},
                    { '.', '.','.','.','.','#'},
                    { '#', '.','.','#','.','#'},
                    { '#', '.','#','#','#','#'},

                    };
            }

                public String getName()
                {
                    return mapname;

                }

                public char[,] getMap() {
                    return map;
                }

                public void showMap() {
                    int meret = this.map.GetLength(0);
                    for (int row = 0; row < meret; row++) {
                        for (int col = 0; col < meret; col++) {
                            Console.Write(this.map[row, col]+" ");

                        }
                    Console.WriteLine();
                }


            }
            public int[] whereamI() {
                int[] pos = { 0, 0 };
                int meret = this.map.GetLength(0);
                for (int row = 0; row < meret; row++)
                {
                    for (int col = 0; col < meret; col++)
                    {
                        if (this.map[row, col] == '@')
                        {
                            pos[0] = row;
                            pos[1] = col;
                        
                        }

                    }
                }


                return pos;
            }
            public void up() { }
            public void down() { }
            public void left() { }
            public void right() { }

            }
        }
    }

