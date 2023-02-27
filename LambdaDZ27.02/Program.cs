// 1. Создать метод конвертации номеров, который принимает список строк и анонимную функцию.
//Реализовать анонимные функции, или лямбды, которые бы занимались преобразованием номера.
//Примеры, какие должны быть возможные форматы:
//"(123) 456-7890"
//"+123 456 7890"
//"+123-456-7890"

var numbers = new List<string>() { "5254556988", "4624111322", "3962763665", "8733614557",
    "5953997852", "1254974696", "1489238837", "5657549459", "9827346157", "8785814247", "2325415961",
    "1553513438", "3968681621", "7627985697", "7748283552", "2533643534", "2116577714", "7179737224",
    "2977339522", "9232818615", "5829746958", "8488371476", "8686672919", "4364231973", "8626662478",
    "6855159817", "6872249743", "5651287119", "9333534576", "3565974769", "7678177689", "3625935114",
    "2368528772", "9761329447", "8759453667", "1545875776" };

// 1
var newNumbers1 = ConvertOfNumbers(numbers, x => $"({x.Substring(0, 3)}) {x.Substring(3, 3)}-{x.Substring(6, 4)}");
foreach (var num in newNumbers1)
    Console.WriteLine(num);
// 2
var newNumbers2 = ConvertOfNumbers(numbers, x => $"+{x.Substring(0, 3)} {x.Substring(3, 3)} {x.Substring(6, 4)}");
foreach (var num in newNumbers2)
    Console.WriteLine(num);
// 3
var newNumbers3 = ConvertOfNumbers(numbers, x => $"+{x.Substring(0, 3)}-{x.Substring(3, 3)}-{x.Substring(6, 4)}");
foreach (var num in newNumbers3)
    Console.WriteLine(num);


List<string> ConvertOfNumbers(List<string> numbers, Convertation convertation)
{
    var result = new List<string>();
    foreach (string number in numbers)
        result.Add(convertation(number));
    return result;
}

delegate string Convertation(string value);





// 2. Функция принимает список такого рода:
//{ 1, 3, 12, "h", 90, "great", 56, 4, "qwe"}
//Также функция принимает лямбду/анонимную функцию, которая оставила бы в списке лишь числа:
//{ 1, 3, 12, 90,  56, 4}

//var list = new List<string>() { "1", "3", "12", "h", "90", "great", "56", "4", "qwe" };

//var result = SortOfList(list, x => int.TryParse(x, out int res));
//foreach (var item in result)
//	Console.WriteLine(item);

//List<int> SortOfList(List<string> list, Sorter sorter)
//{
//    var newList = new List<int>();
//	foreach (var item in list)
//        if(sorter(item))
//			newList.Add(int.Parse(item));
//	return newList;
//}

//delegate bool Sorter(string str);





// 3. Создать функцию, которая бы принимала список почтовых ящиков, домен, и лямбда функцию.
//Функция по итогу будет возвращать список ящиков с соответствующим доменом.

//var mails = new List<string>() { "izemlak@hotmail.com", "fisher.kelly@hotmail.com", "powlowski.sierra@gmail.com", 
//    "btillman@yahoo.com", "schroeder.vernie@hotmail.com", "carolanne.maggio@yahoo.com", "velda.wisozk@gmail.com", 
//    "rice.deion@gmail.com", "rsporer@hotmail.com", "carolyne86@gmail.com", "kylie47@yahoo.com", "filiberto97@reinger.com", 
//    "lilly59@yahoo.com", "harris.melyna@champlin.com", "audra28@gmail.com", "nadia26@yahoo.com", "camryn.tillman@rogahn.org", 
//    "celvice32@reinger.com", "jake99@hotmail.com", "toney35@nitzsche.com", "zluettgen@daugherty.com", "wehner.jasen@emard.com", 
//    "hoeger.archibald@hotmail.com", "runte.amanda@gmail.com", "chet.rutherford@emard.com", "runte.amanda@gmail.com", 
//    "elyse38@yahoo.com", "jesus91@lindgren.com", "jonathon.cronin@kautzer.org", "edouglas@gmail.com" };

//Console.WriteLine("Введите домен:");
//string domen = Console.ReadLine();

//var newMails = SortOfMails(mails, domen, (x, domen) => x.EndsWith(domen));
//foreach (var mail in newMails)
//    Console.WriteLine(mail);

//List<string> SortOfMails(List<string> mails, string domen, Sorter sorter)
//{
//    var result = new List<string>();    
//    foreach (var mail in mails) 
//        if(sorter(mail, domen))
//            result.Add(mail);   
//    return result;
//}

//delegate bool Sorter(string mail, string domen);





// 4. Создать функцию, которая бы принимала список чисел, и лямбда функцию, которая бы преобразовывала
// все отрицательные числа в положительные.

//using System;

//var nums = new List<int>() { 1, -2, 3, -4, 5, -6, 7, 8, -9 };

//var posNumbers = Convertation(nums, x => x < 0 ? 0 - x : x);
//foreach (var number in posNumbers)
//    Console.WriteLine(number);

//// 5. Которая бы возводила в квадрат.
//var sqrtNums = Convertation(nums, x => x * x);
//foreach (var number in sqrtNums)
//    Console.WriteLine(number);

//// 6. Умножала на 5.
//var MultNums = Convertation(nums, x => x * 5);
//foreach (var number in MultNums)
//    Console.WriteLine(number);

//// 7. Реализовать функцию фильтр, для списка чисел, которая принимает лямбда функцию которая
//// оставила бы в списке только четные числа.
//var EvenNums = Filtration(nums, x => x%2 == 0);
//foreach (var number in EvenNums)
//    Console.WriteLine(number);

//// 8. Оставляла нечетные)
//var OddNums = Filtration(nums, x => x % 2 != 0);
//foreach (var number in OddNums)
//    Console.WriteLine(number);

//// 9. Оставляла числа только больше 5 и меньше 10.
//var newNums = Filtration(nums, x => x > 5 && x < 10);
//foreach (var number in newNums)
//    Console.WriteLine(number);

//// 10. Оставляла только положительные числа.
//var positiveNums = Filtration(nums, x => x > 0);
//foreach (var number in positiveNums)
//    Console.WriteLine(number);

//// 11. Только те, у которых можно извлечь корень на цело.
//var resNums = Filtration(nums, x => int.TryParse(Math.Sqrt(x).ToString(), out int res));
//foreach (var number in resNums)
//    Console.WriteLine(number);


//// Methods
//List<int> Convertation(List<int> nums, Func func)
//{
//    var result = new List<int>();
//    foreach (int num in nums)
//        result.Add(func(num));
//    return result;
//}

//List<int> Filtration(List<int> nums, Func2 func2)
//{
//    var result = new List<int>();
//    foreach(int num in nums)    
//        if(func2(num))  
//            result.Add(num);
//    return result;  
//}

//delegate int Func(int num);
//delegate bool Func2(int num);





