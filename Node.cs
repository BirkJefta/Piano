using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWN {
    public class Node {

        public int frequency;
        public int duration;
        public int delay;

        public Node()
        {

        }
        /// <summary>
        /// Kan lave en node basere på bpm og beat. Beat er baseret på billedet i facebook.
        /// </summary>
        /// <param name="frequency"></param>
        /// <param name="bpm"></param>
        /// <param name="node_beat"></param>
        /// <returns></returns>
        public Node Node_From_BPM_And_NodeBeat(int frequency, int bpm, double node_beat) 
        {
            Node node1 = new Node();

            double NodeVarighed_i_ms = (60000 / bpm) * node_beat;
            node1.duration = ((int)NodeVarighed_i_ms);
            node1.delay = ((int)NodeVarighed_i_ms / 10);
            node1.frequency = frequency;
            return node1;
        }

    }
}
