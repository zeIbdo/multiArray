using System.Collections.Concurrent;
using System.Diagnostics.SymbolStore;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace multiArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 2 dimensial array print
            //int[,] numbers = { { 1, 2, 3 }, { 3, 4, 5 }, { 4, 5, 6 } };
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.WriteLine(numbers[i, j]);
            //    }
            //}
            #endregion
            #region 3 dimensial array print
            //int[,,] numbers2 = { { { 1, 2, 3 }, { 4, 5, 6 }, }, { { 5, 6, 7, }, { 6, 7, 8 } } };
            //for (int i = 0; i < numbers2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers2.GetLength(1); j++)
            //    {
            //        for(int k = 0; k < numbers2.GetLength(2); k++)
            //        {
            //            Console.WriteLine(numbers2[i,j,k]);
            //        }
            //    }
            //}
            #endregion
            #region endl print
            //string name = "Salam menim adim Asimandir";
            //string name2 = "";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == ' ')
            //    {
            //        Console.WriteLine(name2);
            //        name2 = "";
            //    }
            //    else
            //    {
            //        name2 += name[i];

            //    }
            //    if (i == name.Length - 1)
            //    {
            //        Console.WriteLine(name2);
            //    }
            //}


            #endregion
            #region ters print
            //string name = "Ibrahim";
            //string name2 = "";
            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    name2 += name[i];

            //}
            //Console.WriteLine(name2);
            #endregion
            #region how many elements in array
            //Console.Write("Enter your sentence: ");
            //string sentence = Console.ReadLine().ToLower();
            //Console.Write("Enter your element: ");
            //char element =char.Parse(Console.ReadLine().ToLower());
            //bool ent = false;
            //int count = 0;
            //for (int i = 0; i < sentence.Length;i++)
            //{
            //    if(element == sentence[i])
            //    {
            //        count ++;
            //    }
            //}
            //Console.WriteLine($"There are {count} {element} in {sentence}");
            #endregion
            #region isdigit
            //string name = "asdf1";
            //for(int i=0; i < name.Length; i++)
            //{
            //    char character = name[i] ;                
            //    if (char.IsDigit(character) == true)
            //    {
            //        Console.WriteLine("there are digit in name ");
            //        break;
            //    }                
            //}


            #endregion
            #region ilk herf boyuk
            //string name = "AsimaN";
            //bool ent = false;
            ////if(char.IsUpper(name[0]))
            ////        ent = true;
            //for (int i = 0; i <name.Length; i++)
            //{
            //    if (char.IsLower(name[i]) && char.IsUpper(name[0]))
            //    {
            //        ent = true;
            //    }
            //    else ent = false;

            //}
            //if (ent) {
            //    Console.WriteLine("soz dzugundur");
            //}
            //else { Console.WriteLine("soz sehv yazilib"); }
            #endregion
            #region hasletter
            //string word = Console.ReadLine();
            //bool hasLetter = false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    int number = (int)word[i];
            //    if ((number >= 65 && number <= 90) || (number >= 97 && number <= 122))
            //    {
            //        hasLetter = true;
            //        break;
            //    }
            //}
            //if (hasLetter == true)
            //{
            //    Console.WriteLine("your input has letter in it");
            //}
            //else
            //    Console.WriteLine("your word has no letter in it");
            #endregion
            #region tersine string print
            //string name = "Ibrahim";
            //int lastIndex = name.Length - 1;
            //for(int i = lastIndex ; i >=0; i--)
            //{
            //    Console.Write(name[i]);
            //}
            #endregion
            #region cumledeki sozler print
            //Console.WriteLine("Enter your sentence: ");
            //string sentence = Console.ReadLine();
            //string word = "";
            //int lastIdx = sentence.Length - 1;
            //for (int i = 0; i < sentence.Length; i++)
            //{
            //    if (sentence[i] == ' ')
            //    {
            //        Console.WriteLine(word);
            //        word = "";

            //    }
            //    else
            //    {
            //        word += sentence[i];
            //    }
            //    if (i == lastIdx)
            //        Console.WriteLine(word);

            //}
            #endregion
            #region reverse number
            //Console.Write("enter your number: ");
            //string input = Console.ReadLine();
            //bool res;
            //int num;
            //string reverseNumString = "";
            //res = int.TryParse(input, out num);
            //if (!res)
            //    Console.WriteLine("invalid input");
            //string numString = num.ToString();
            //for (int i = numString.Length - 1; i >= 0; i--)
            //{
            //    reverseNumString += numString[i];
            //}
            //num = Convert.ToInt32(reverseNumString);
            //Console.WriteLine(num);
            //==============================================

            //int number = 123401;
            //int number2 = 0;
            //while (number > 0)
            //{
            //    number2 += number % 10;
            //    number2 = number2 * 10;
            //    number = number / 10;
            //}
            //number = number2 / 10;
            //Console.WriteLine(number2);
            #endregion
            #region Palindrom detector
            //Console.Write("enter your number: ");
            //string input = Console.ReadLine();
            //bool res;
            //int num;
            //bool isPalidrom = true;
            //res = int.TryParse(input , out num);
            //if (!res)
            //    Console.WriteLine("invalid input");
            //string numString = num.ToString();
            //for(int i = 0; i < numString.Length; i++)
            //{
            //    if (numString[i] != numString[numString.Length - i - 1])
            //    {
            //        isPalidrom = false;

            //    }
            //}
            //if(isPalidrom == true)
            //    Console.WriteLine("your number is palidrom");
            //else
            //    Console.WriteLine("not palidrom");
            #endregion
            #region count of letters
            //Console.Write("enter your string: ");
            //string word = Console.ReadLine();
            //Console.Write("enter your character: ");
            //char letter = char.Parse(Console.ReadLine());
            //int count = 0;
            //for(int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == letter)
            //        count++;                    
            //}
            //Console.WriteLine($"there are {count} {letter} in {word}");
            #endregion
            #region removing spaces
            //string name = "I b ra him";
            //string name2 = "";
            //for(int i = 0; i < name.Length; i++)
            //{
            //    if (name[i] == ' ')
            //        continue;
            //    name2 += name[i];
            //}
            //name = name2;
            //Console.WriteLine(name);
            #endregion
            #region verilmis araliqda string
            //string name = "Ibrahim";
            //int idx = int.Parse(Console.ReadLine());
            ////int n = int.Parse(Console.ReadLine());
            //string name2 = "";
            //string newName = Console.ReadLine();
            //for(int i = 0; i < name.Length; i++)
            //{
            //    name2 += name[i];
            //    if (i == idx - 1)
            //        name2 += newName;
            //}
            //name = name2;
            //Console.WriteLine(name);
            #endregion
            #region firstUpper
            //string name = Console.ReadLine();
            //bool correctWord = false;
            //if (char.IsUpper(name[0]) == true)
            //    correctWord = true;
            //while (correctWord == true)
            //{
            //    for (int i = 1; i < name.Length; i++)
            //    {
            //        if (char.IsLower(name[i]) == false)
            //        {
            //            correctWord = false;
            //            break;
            //        }
            //    }
            //    break;
            //}
            //if(correctWord == true)
            //    Console.WriteLine("Ad duzgun yazilib");
            //else if (correctWord == false)
            //    Console.WriteLine("ad duzgun yazilmayib");
            #endregion
            #region reqem silen
            //string word = Console.ReadLine();
            //string word2 = "";
            //for(int i = 0; i < word.Length; i++)
            //{
            //    int number = (int)word[i];
            //    if (number >= 48 && number <= 57)
            //        continue;
            //    word2 += word[i];
            //}
            //word = word2;
            //Console.WriteLine(word);
            #endregion
            #region +994
            //string number = Console.ReadLine();
            //bool haveCC = false;
            //bool length = true;
            //bool isNumber = false;
            //for (int i = 0; i < number.Length; i++)
            //{
            //    int digit = (int)number[i];
            //    if (digit >= 48 & digit <= 57)
            //        isNumber = true;
            //}
            //while (isNumber == true)
            //{
            //    if (number.Length != 13)
            //    {
            //        length = false;
            //        Console.WriteLine("your number length is not correct");
            //        break;
            //    }
            //    while (length == true)
            //    {
            //        if (number[0] == '+')
            //            haveCC = true;
            //        else
            //            haveCC = false;
            //        if (number[1] == '9')
            //            haveCC = true;
            //        else
            //            haveCC = false;
            //        if (number[2] == '9')
            //            haveCC = true;
            //        else
            //            haveCC = false;
            //        if (number[3] == '4')
            //            haveCC = true;
            //        else
            //            haveCC = false;

            //        if (haveCC == true)
            //            Console.WriteLine("country code is right");
            //        else
            //            Console.WriteLine("country code is not right");
            //        break;
            //    }
            //    break;
            //}
            #endregion
            #region alt coxluq string
            //string name = "ekber";
            //string bigName = "ekbereli";
            //bool isSubName = true;
            //int count = 0;
            //while (count <= name.Length)
            //{
            //    for (int i = 0; i < name.Length; i++)
            //    {
            //        for (int j = 0; j < bigName.Length; j++)
            //        {
            //            if (name[i] == bigName[j])
            //            {
            //                isSubName = true;
            //                count++;
            //                break;

            //            }
            //            else if (name[i] != bigName[j])
            //            {
            //                isSubName = false;
            //                count = 0;

            //            }
            //        }
            //    }
            //    break;
            //}
            //if (count == name.Length)
            //    isSubName = true;
            //if (isSubName == true)
            //    Console.WriteLine("daxilinde var");
            //if (isSubName == false)
            //    Console.WriteLine("daxilinde yoxdur");
            #endregion
            //========================================
            #region minmaxhasil
            //int number = 2345;

            //int digit = 0;
            //int add = number;
            //while (add > 0)
            //{

            //    add = add / 10;
            //    digit++;

            //}
            //int[] qaliq = new int[digit];
            //int i = 0;
            //while (i < qaliq.Length)
            //{
            //    qaliq[i] = number % 10;
            //    number = number / 10;

            //    i++;
            //}
            //int maxDigit = qaliq[0];
            //int minDigit = qaliq[0];
            //for (int k = 0; k < qaliq.Length; k++)
            //{
            //    if (qaliq[k] > maxDigit)
            //        maxDigit = qaliq[k];

            //}
            //for (int j = 1; j < qaliq.Length; j++)
            //{
            //    if (qaliq[j] < minDigit)
            //        minDigit = qaliq[j ];

            //}
            //Console.WriteLine(maxDigit * minDigit); 



            //2ci usul
            //int number = 2345;
            //int maxDigit = number%10;
            //int minDigit = number%10;
            //number = number / 10;
            //while(number > 0)
            //{
            //    int result = number % 10;
            //    if(result>maxDigit)
            //        maxDigit = result;
            //    if(result<minDigit)
            //        minDigit = result;

            //    number = number / 10;
            //}
            //Console.WriteLine(minDigit*maxDigit);
            #endregion
            #region palindrome
            //int number = 1221;
            //int reverse = 0;
            //int i = 1;
            //int add = number;
            //while (add > 0) 
            //{

            //    reverse+= (i*(add % 10));
            //    add = add / 10;
            //    i =i* 10;
            //}
            //Console.WriteLine(reverse);
            //if(number == reverse)
            //    Console.WriteLine("is palindrome"); 
            #endregion
            string input = "   Everything i nEed, is a CuP of      CoFFee ";
            string desiredInput = "";
            int i = 0;
            while (i < input.Length && input[i] ==' ')
            {
                i++;
            }
            while (i < input.Length)
            {
                if (input[i] != ' ')
                {
                    if (desiredInput.Length == 0 || !char.IsLetter(desiredInput[desiredInput.Length - 1]))
                        desiredInput += char.ToUpper(input[i]);
                    else
                        desiredInput += char.ToLower(input[i]);
                }
                else
                {
                    if (i != input.Length - 1)
                    {
                        if ((input[i] == ' ' & input[i + 1] != ' '))
                            desiredInput += input[i];
                    }
                }
                i++;
            }
            Console.WriteLine(desiredInput);            
        }
        static bool casualNumber(int number)
        {
            bool isCasual = true;
            int divider = 2;
            if (number == 1 | number == 0)
            {
                return false;
            }
            while (number > 1 & number > divider)
            {
                for (divider = 2; divider < number; divider++)
                {
                    if (number % divider == 0)
                    {
                        isCasual = false;
                    }
                }
                break;
            }
            return isCasual;
        }
        static bool perfectNumber(int number)
        {
            if(number<=0) { return false; }
            int total = 0;
            for (int divider = 1; divider < number; divider++)
            {
                if (number % divider == 0)
                {
                    total += divider;
                }
            }
            return total == number;
        }
        static void monthFinder(int number)
        {
            int month = 0;
            int year = 0;
            if (number < 12)
            {
                month = number;
                Console.WriteLine($"{month} month");
            }
            else if(number==0)
                Console.WriteLine("wrong input");
            else
            {
                if (number % 12 != 0)
                {
                    year = number / 12;
                    month = number % 12;
                    Console.WriteLine($"{year} year {month} month");
                }
                else {
                    year = number / 12;
                    month = number % 12;
                    Console.WriteLine($"{year} year ");
                }
            }
        }
        static decimal celciusToFahreneit( decimal celcius )
        {
            decimal fahreneit = (celcius * 9 / 5) + 32;
            return fahreneit;
        }
        static void pattern(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        static void reversePattern(int number)
        {
            for(int i = number-2;i >= 0; i--)
            {
                Console.Write("*");
                for(int j = 0;j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
