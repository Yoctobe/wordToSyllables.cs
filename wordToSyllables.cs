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

        /// <summary>
        /// Convrt any word into Sylablles
        /// </summary>
        /// <param name="word"></param>
        /// <returns>List of string wordToSyllables</returns>
        public List<string> convertWordToSyllables(string word)
        {
            List<string> wordToSyllables = new List<string>();

            string pattern = "";

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
                wordToSyllables.Add(word.Substring(startIndex, patt.Length));
                startIndex += patt.Length;

            }

            // check if the last syllable isn't composed of only consonants exemple : ng rt etc

            if (!contains_vowels(wordToSyllables.Last()) && wordToSyllables.Count > 2)
            {
                wordToSyllables[wordToSyllables.Count - 2] += wordToSyllables.Last();
                wordToSyllables.RemoveAt(wordToSyllables.Count - 1);
            }

            return wordToSyllables;

        }
    }
