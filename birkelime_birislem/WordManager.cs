using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownGame
{
    class WordManager
    {

        public List<String> SelectedLetters = new List<string>();
        private List<String> FoundWords = new List<string>();
        private const int NUMBER_OF_LETTERS = 8;
        private string alphabet = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVYZ";
        private DB db;
        public string LongestWord { get; private set; }
        public string JokerLetter { get; private set; }


        public WordManager()
        {
            alphabet = alphabet.ToLower();
            db = new DB();
            db.KelimeleriCek();
        }

        public List<String> GenerateRandomLetter()
        {
            Random rnd = new Random();
            SelectedLetters.Clear();
            for (int i = 0; i < NUMBER_OF_LETTERS; i++)
            {
                char harf = alphabet[rnd.Next(alphabet.Length)];
                SelectedLetters.Add(harf.ToString());
            }

            return SelectedLetters;
        }


        private bool CheckLettersInWord(string word)
        {
            int counter = 0;
            int wordLength = word.Length;
            var selectedWord = word.ToCharArray();
            List<string> selectedLetters = new List<string>();

            for (int i = 0; i < NUMBER_OF_LETTERS; i++)
            {
                selectedLetters.Add(SelectedLetters[i]);
            }

            for (int i = 0; i < wordLength; i++)
            {
                if (selectedLetters.Contains(selectedWord[i].ToString()))
                {
                    selectedLetters.Remove(selectedWord[i].ToString());
                    counter++;
                }
            }

            if ( (counter == wordLength || counter==wordLength-1) && counter >= 3)
                return true;
            else
                return false;
        }

        public List<String> FindWords()
        {
            FoundWords.Clear();
            GenerateRandomLetter();
            
            foreach (var item in db.Kelimeler)
            {
                if (CheckLettersInWord(item))
                {
                    FoundWords.Add(item);
                }
            }
            FoundWords = FoundWords.OrderByDescending(x => x.Length).ToList();
            LongestWord = FoundWords[0].ToString();

            string tempLongestWord = LongestWord;

            string selectedLetters="";
            foreach (var item in SelectedLetters)
            {
                selectedLetters += item;
            }


            for (int i = 0; i < tempLongestWord.Length; i++)
            {
                if(selectedLetters.Contains(tempLongestWord[i].ToString()))
                {
                    int index = selectedLetters.IndexOf(tempLongestWord[i].ToString());
                    selectedLetters = selectedLetters.Remove(index, 1);
                }
                else
                {
                    JokerLetter = tempLongestWord[i].ToString();
                    break;
                }
            }
            return FoundWords;
        }

    }
}
