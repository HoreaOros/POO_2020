using System;
using System.Net.Http.Headers;

namespace _01_25_feb
{
    class World
    {
        /// <summary>
        /// numarul de identificare al -World-
        /// nefiind static el este de tip instanta si va exista cate unul pentru fiecare obiect creat
        /// spunem ca este o variabila la nivel de obiect
        /// </summary>
        private int id;
        
        /// <summary>
        /// tine evidenta numarului de obiecte de tip World create. 
        /// fiind static, va exista o singura valoare pentru toate obiectele create
        /// spunem ca este o variabila la nivel de clasa. 
        /// </summary>
        private static int counter = 0;

        public static int Counter 
        { 
            get
            {
                return counter;
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello from {id}");
        }


        /// <summary>
        /// Metoda constructor. 
        /// Are acelasi nume ca si clasa
        /// Nu are tip de return, nici macar void
        /// Initializeaza obiectul.
        /// Se apeleaza automat la crearea/instantierea unui obiect. 
        /// </summary>
        /// <param name="id"></param>
        public World(int id)
        {
            this.id = id;
            counter++;
        }
    }
}