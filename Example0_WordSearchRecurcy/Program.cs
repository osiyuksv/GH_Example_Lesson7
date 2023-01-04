// Перебрать возможные слова из заданных 
// четырёх букв "а" "и" "с" "в", где в слове Т букв

// char[] s = {'а', 'и', 'с', 'в'};
int n = 1;

void FindWords (string alphabet, char[] word, int length = 0)
{
  if(length == word.Length)
  {
     Console.WriteLine($"{n++} {new String(word)}"); return;
  }
    for (int i = 0; i < alphabet.Length; i++)
    {
      word[length] = alphabet[i];
      FindWords (alphabet, word, length + 1);
    }
  }

FindWords ("аисв", new char[5]);