﻿using System;
using System.Collections.Generic;

namespace PoolPuzzle
{

    class Of2016 : Clowns
    {
        public override string Face
        {
            get { return "Of2016"; }
        }
        public static void Main(string[] args)
        {
            string result = "";
            //INose[] i = new INose[3];
            List<INose> i = new List<INose> ();
            //i[0] = new Acts();
            i.Add(new Acts());

            //i[1] = new Clowns();
            i.Add(new Clowns());

            //i[2] = new Of2016();
            i.Add(new Of2016());


            for (int x = 0; x < 3; x++)
            {
                result +=
                  $"{    i[x].Ear()    } {   i[x].Face   }\n";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
