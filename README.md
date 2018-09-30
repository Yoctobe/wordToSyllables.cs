# wordToSyllables.cs
This is a c# class that can be used to convert any German/English Word into Syllables
# Simple usage

wordToSyllables wTS = new wordToSyllables();
List<string> syllablesList = new List<string>();
syllablesList = (wTS.convertWordToSyllables("erklärte"));

foreach (string syllable in syllablesList)
 {
  Console.WriteLine(syllable);
 }
