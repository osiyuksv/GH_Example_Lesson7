// Перебрать возможные слова из заданных 
// четырёх букв "а" "и" "с" "в", где в слове Т букв

char[] s = {'а', 'и', 'с', 'в'};
int count = s.Length;
int n = 1;

for (int i = 0; i < s.Length; i++)
{
  for (int j = 0; j < s.Length; j++)
  {
    for (int k = 0; k < s.Length; k++)
    {
      for (int l = 0; l < s.Length; l++)
      {
        for (int m = 0; m < s.Length; m++)
        {
          Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
        }
      }
    }
  }
}
