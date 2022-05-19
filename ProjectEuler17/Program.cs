// Project Euler Problem 17
// If the numbers 1 to 5 are written out in words: one, two, three,
// four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?

// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one
// hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.

using ProjectEuler17;

int answer = 0;
for (int x = 1; x <= 1000; x++)
{
    int[] demo;
    demo = ArrayClass.NumberToDigits(x);
    for (int i = 0; i < demo.Length; i++)
    {
        Console.Write(demo[i]);
    }
    Console.Write("   ");
    string demoWords;
    int letterCount = 0;
    demoWords = WordsClass.DigitsToWords(demo);
    letterCount = demoWords.Count();
    answer = answer + letterCount;
    Console.WriteLine(demoWords + " has " + letterCount + " letters   Total letters: " + answer);

}
