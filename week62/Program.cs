string MyString = "Erasmuse";

Console.WriteLine(MyString.Length);

Console.WriteLine(MyString[0]);
Console.WriteLine(MyString[MyString.Length - 1]);

// a-counter

//int counter = 0;

//for (int i = 0; i < MyString.Length; i++)
//{
//    if (MyString[i] == 'a')
//    {
//        counter++;
//    }
//}

//Console.WriteLine($"Your word have {counter} a letters.");

//replace 
// a-4

string UpdatedWord = MyString.Replace('a', '4').Replace('e', '3'); ;

Console.WriteLine(UpdatedWord);
