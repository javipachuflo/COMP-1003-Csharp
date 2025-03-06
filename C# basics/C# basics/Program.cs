// See https://aka.ms/new-console-template for more information

////task 1
//Console.WriteLine("Hello, World!");

////task 2
//Console.WriteLine(1);

////task 3
//Console.WriteLine("Number " + 7);

////task 4
//Console.WriteLine("number: ");
//string input = Console.ReadLine();

//Console.WriteLine("You entered: " + input);

////task 4 experimentation
//string the_input = Console.ReadLine();

//Console.WriteLine(the_input);

//task 5
//int number = 0;
//int othernum = 0;
//int addednum;
//for (int i = 0; i < 10; i++)
//{

//    //get current number
//    number++;
//    //add current number to stored number
//    othernum += number;
//    // add 

//    Console.WriteLine(othernum);
//}

//task 6
//int number = 0;
//int othernum = 0;

//while (number < 10) {
//    number++;
//    othernum += number;
//    Console.WriteLine(othernum);
//}

////task 7
int[] numbersArray = new int[10];
Random rnd = new Random();


for (int i = 0; i < numbersArray.Length; i++)
{
    numbersArray[i] = rnd.Next(1, 20);
}

Array.ForEach(numbersArray, Console.WriteLine);

////task 8
//int smallest = numbersArray[0];

//for (int i = 0; i < numbersArray.Length; i++) {
//    if (numbersArray[i] < smallest) {
//        smallest = numbersArray[i];
//    }
//}

//Console.WriteLine("The smallest number is: " + smallest);

//task 9

int specnum = 2;
bool isInArray = numbersArray.Contains(specnum);

if (isInArray)
{
    Console.WriteLine("The number " + specnum + " is in the array!");
} else
{
    Console.WriteLine("The number " + specnum + " is NOT in the array!");
}

//task 10

int temp = numbersArray[0];
numbersArray[0] = numbersArray[1];
numbersArray[1] = temp;

Array.ForEach(numbersArray, Console.WriteLine);