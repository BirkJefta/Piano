using System.Xml.Linq;

namespace PWN {
    internal class Program {
        static void Main(string[] args)
        { 
           
            Klaver klaver = new Klaver();
            Sangbog sangbog = new Sangbog();

            //klaver.playsong(sangbog.SeDenLilleKat(), "Se den lille katte killing");
            klaver.playsong(sangbog.AintNoSunshine(), "aint no sunshine");    
            
        }
    }
}
