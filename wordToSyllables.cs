    class wordToSyllables
    {
        private char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü' };


        /// <summary>
        /// Chack whether string contains vowels
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool containsVowels</returns>
        private bool contains_vowels(string str)
        {
            bool containsVowels = false;
            foreach (char ch in str)
            {
                if (vowels.Contains(ch)) { containsVowels = true; break; } else { containsVowels = false; }
            }
            return containsVowels;
        }
        private string word = "Nothing";
        
        public wordToSyllables () { Syllables(); }
        
        //Setting property : Word
         public string Word 
        {
            get { return word;} set { if(!string.IsNullOrEmpty(value)) { word = value; } else { word = ""; } }
        }
       
      
        // Convert the word into Syllables
        public List<string> Syllables ()
        {
            string pattern = "";
            List<string> Syllables = new List<string>();

            // convert the word into a binary string

            foreach (char ch in word)
            {
                if (vowels.Contains(ch)) { pattern += "v"; } else { pattern += "c"; }
            }

            //two cases 
            List<int> syllPositions = new List<int>();
            int startIndex = 0;// the end index is the position of '-'


            if (vowels.Contains(word[0])) { pattern = pattern.Replace("cv", "c-v"); } else { pattern = pattern.Replace("vc", "v-c"); }

            // replace the letter before the last if it is '-'

            if (pattern.Length > 2 && pattern[pattern.Length - 2] == '-') { pattern = pattern.Remove(pattern.Length - 2, 1); }

            string[] patterns = pattern.Split('-');

            foreach (string patt in patterns)
            {
                Syllables.Add(word.Substring(startIndex, patt.Length));
                startIndex += patt.Length;

            }

            // check if the last syllable isn't composed of only consonants exemple : ng rt etc

            if (!contains_vowels(Syllables.Last()) && Syllables.Count > 2)
            {
                Syllables[Syllables.Count - 2] += Syllables.Last();
                Syllables.RemoveAt(Syllables.Count - 1);
            }

            return Syllables;

        }
      
       


    }
