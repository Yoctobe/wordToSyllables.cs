            wordToSyllables wTS = new wordToSyllables() ;

            List<string> syllablesList = new List<string>();

            wTS.Word = "Gesellschaft";

            syllablesList = wTS.Syllables();

            // Display All Syllables
            foreach (string syllable in syllablesList)
            {
                Console.WriteLine(syllable);             
            }

/* Output: 
Ge
se
llschaft
Syllables Count : 3
*/  

            // Count Syllables 
            Console.WriteLine("Syllables Count : " + syllablesList.Count);
