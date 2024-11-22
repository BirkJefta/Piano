using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWN {
    public class Klaver {
        //foreach spil sang
        //en metode play song
        
         public Klaver() { } 

        public void playsong(List<Node> nodes, string songname) 
        {
            Console.WriteLine($"spiller '{songname}'");
            Console.WriteLine();
            int index = 0;
            foreach (Node node in nodes)
            {
                
                index++;
                Console.WriteLine($"Node {index} skal spille med en frekvens på {node.frequency} Hz, i {node.duration} ms og holde en pause på {node.delay} ms");
                Console.WriteLine();
            }
        }

        

    }
}
