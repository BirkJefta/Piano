using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PWN {
    public class Sangbog {


        List<Node> song;
        ToneToFrequency toneToFrequency;
        Node nodeE;
        Node nodeG;
        Node nodeC;
        Node nodeD;
        Node nodeF;
        Node nodeA;
        Node nodeB;
        public Sangbog() 
        {
            song =new List<Node>();
            toneToFrequency = new ToneToFrequency(); 
            nodeE = new Node();
            nodeG = new Node();
            nodeC = new Node();
            nodeD = new Node();
            nodeF = new Node();
            nodeA = new Node();
            nodeB = new Node();
        }
        private void AddE()
        {
            song.Add(nodeE.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("E", 3), 78, 1));
        }
        private void AddG()
        {
            song.Add(nodeG.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("G", 3), 78, 1));
        }
        private void AddC()
        {
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 3), 78, 1));
        }

        private void AddD()
        {
            song.Add(nodeD.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("D", 3), 78, 1));
        }
        private void AddF()
        {
            song.Add(nodeF.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("F", 3), 78, 1));
        }
        private void AddA()
        {
            song.Add(nodeA.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("A", 3), 78, 1));
        }
        private void AddB()
        {
            song.Add(nodeB.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("B", 3), 78, 1));
        }


        public List<Node> SeDenLilleKat()
        {
            

            //spiller 4 E
            for (int i = 1; i <= 4; i++)
            {
                AddE();
            }
            //spiller GEEE
            AddG();

            for (int i = 1; i < 3; i++)
            {

                AddE() ;
            }

            //GE
            AddG();
            AddE();

            //CE
            AddC();
            AddE();

            //
            AddD();
            

            return song;
        }

        public List<Node> BroBbroBrille()
        {
            AddG();
            AddG();

            AddA();
            AddA() ;

            AddG();
            AddA();

            AddG();
            AddF();

            AddE() ;
            AddC();
            return song;

        }

        public List<Node> AintNoSunshine()
        {
            AddE();
            AddG();
            AddA();
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 4), 156, 1));
            AddB();

            AddA();
            AddA();

            // delay

            AddE();
            AddG();
            AddA();
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 4), 78, 1));
            AddB();
            AddG() ;

            //a med fuld
            song.Add(nodeA.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("A", 3), 78, 2));

            //delay

            AddA();
            AddA();
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 4), 156, 1));
            song.Add(nodeE.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("E", 4), 156, 1));
            song.Add(nodeD.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("D", 4), 156, 1));
            song.Add(nodeE.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("E", 4), 78, 1));
            song.Add(nodeE.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("E", 4), 78, 1));

            AddA() ;
            song.Add(nodeD.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("D", 4), 78, 1));
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 4), 78, 1));
            AddA();
            AddG();
            AddA();

            AddG();
            AddA();
            song.Add(nodeC.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("C", 4), 78, 1));
            song.Add(nodeD.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("D", 4), 78, 1));
            AddA();
            AddG();
            AddA();
            song.Add(nodeA.Node_From_BPM_And_NodeBeat(toneToFrequency.GetFrequency("A", 3), 78, 2));
            //delay

            return song;
        }

    }
}
