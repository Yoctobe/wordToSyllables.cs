wordToSyllables wTS = new wordToSyllables(); 
List syllablesList = new List(); 
syllablesList = (wTS.convertWordToSyllables("erklärte"));
foreach (string syllable in syllablesList) { Console.WriteLine(syllable); }
