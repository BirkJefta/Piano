using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PWN {
    public class ToneToFrequency {
        //Dicionary med oktaverne. Key er oktavnummer, value er frekvens.
        public Dictionary<int,int> ReferenceFrequency { get; set; } = new Dictionary<int,int>();

        // indeks væk fra reference
        public Dictionary<string, int> KeyIndex = new Dictionary<string, int>();

        public int C { get; } = 0;
        public int Cs { get; } = 1;
        public int D { get; } = 2;
        public int Ds { get; } = 3;
        public int E { get; } = 4;
        public int F { get; } = 5;
        public int Fs { get; } = 6;
        public int G { get; } = 7;
        public int Gs { get; } = 8;
        public int A { get; } = 9;
        public int As { get; } = 10;
        public int B { get; } = 11;

        //instansierer
        public ToneToFrequency()
        {
            //tilføjer alle oktaverne
            ReferenceFrequency.Add(1, 33);
            ReferenceFrequency.Add(2, 65);
            ReferenceFrequency.Add(3, 131);
            ReferenceFrequency.Add(4, 262);
            ReferenceFrequency.Add(5, 523);
            ReferenceFrequency.Add(6, 1047);
            ReferenceFrequency.Add(7, 2093);

            //tilføjer  alle keys til dictionary

            KeyIndex.Add("C", C);
            KeyIndex.Add("Cs", Cs); // For C#
            KeyIndex.Add("D", D);
            KeyIndex.Add("Ds", Ds); // For D#
            KeyIndex.Add("E", E);
            KeyIndex.Add("F", F);
            KeyIndex.Add("Fs", Fs); // For F#
            KeyIndex.Add("G", G);
            KeyIndex.Add("Gs", Gs); // For G#
            KeyIndex.Add("A", A);
            KeyIndex.Add("As", As); // For A#
            KeyIndex.Add("B", B);


        }
        /// <summary>
        /// PianoKey skal være med stort. Sharp altså #, skrives som et lille s (eks C# skrives som Cs)
        /// Må højest være 7 oktaver
        /// </summary>
        /// <param name="oktav"></param>
        /// <param name="Key"></param>
        /// <returns></returns>
        public int GetFrequency(string PianoKey, int oktav) 
        {
            //definerer reference key, baseret på den oktav bruger har inputtet. Her finder den, frekvens på reference oktaven.

            int f_0 = ReferenceFrequency.FirstOrDefault(rf => rf.Key == oktav).Value;
            //finder ud af hvor man klaverknapper, den ønskede knap er væk fra referenceknappen.
            int n = KeyIndex.FirstOrDefault(KI => KI.Key == PianoKey).Value;

            //udregner den rigtige frekvens baseret på input af bruger så eks F3. Her er resultatet et decimaltal da math.pow 
            //kun virker med decimal tal. Der står f_0*2**(n/12). 

            double frequencydouble = f_0 * Math.Pow(2, n/12.0);
            //laver den om til heltal altså int
            int frequecy = (int)Math.Round(frequencydouble);

            return frequecy;
        }
    }
}
