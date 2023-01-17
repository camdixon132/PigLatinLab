bool again = true;
while (again = true)
{

    Console.WriteLine("Please enter a word.");
    string word = Console.ReadLine();
    word = word.ToLower();


    int vowelPosition = -1;
    foreach (char letter in word)
    {
        vowelPosition = vowelPosition + 1;
        if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
        {
            break;
        }
    }

    string PigLatinWord = "";
    string BeforeLetters = "";
    string AfterLetters = "";
    switch (vowelPosition)
    {
        case 0:
            PigLatinWord = word + "way";
            break;
        case 1:
            BeforeLetters = word.Substring(0, 1);
            AfterLetters = word.Substring(1);
            PigLatinWord = AfterLetters + BeforeLetters + "ay";
            break;
        case 2:
            BeforeLetters = word.Substring(0, 2);
            AfterLetters = word.Substring(2);
            PigLatinWord = BeforeLetters + AfterLetters + "ay";
            break;

    }
    Console.WriteLine(PigLatinWord);

    Console.WriteLine("Would you like to go again? y/n");
    string answer = Console.ReadLine();

    if(answer == "y")
    {
        again = true;
    }
    else
    {
        break;
    }

}
