
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        //private static Singleton instance = null; -- for lazyloading only
        //private static readonly Singleton instance = new Singleton();// works without 'readonly' too - why?
        //or:
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(() =>new Singleton());// Lazy keyword is threadsafe!
        //private static readonly object obj = new object(); -- for lazyloading only
        public static Singleton GetInstance
        {
            get
            {
                // Die lock-Anweisung ruft die Sperre für gegenseitigen Ausschluss für ein bestimmtes Objekt ab,
                // führt einen Anweisungsblock aus und hebt die Sperre anschließend auf. Während eine Sperre aufrechterhalten wird,
                // kann der Thread, der die Sperre aufrechterhält, die Sperre abrufen und aufheben.
                // Für jeden anderen Thread wird das Abrufen der Sperre blockiert, und die Sperre wartet auf die Aufhebung.
                //
                //if (instance == null) -- for lazyloading only
                //{
                //    lock (obj)
                //    {
                //        if (instance == null) // warum Double-checked locking? - übergeordn. instanz reicht doch?
                //            instance = new Singleton();
                //    }
                //} -- for lazyloading only
                //
                // return instance; -- for eager Loading
                return instance.Value;// -- for eager <Lazy> loading
            }
        }
        //public static Singleton GetInstance()
        //{
        //    if (instance == null)
        //        instance = new Singleton();
        //    return instance;
        //}
        private Singleton()
        {//Constructor private, thus we need an alternative to instanciate
            counter++;
            Console.WriteLine("CounterValue: " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
