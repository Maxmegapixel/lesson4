// в тексте заменить Г ==> г, о ==> O, " " ==> "_"
string text123 = "Ехал Грека через реку,"
              + "Видит Грека в реке рак."
              + "Сунул Грека рука в реку,"
              + "Рак за руку Греку цап.";
static string MetText(string text, char OldSim, char NewSim)
{
    string result = "";
    for (int i = 0; i <= text.Length; i++)
    {
        if (text[i] == OldSim) result += $"{NewSim}";
        else result += $"{text[i]}";

    }
    return result;
}
string TextTest = MetText(text123, OldSim: 'Г', NewSim: 'ж');
Console.WriteLine(TextTest);