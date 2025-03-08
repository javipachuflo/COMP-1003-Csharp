// See https://aka.ms/new-console-template for more information

////task 1: Write the string “Hello World” to the console

//Console.WriteLine("Hello, World!");

////task 2: Write the value of an integer variable to the console

//Console.WriteLine(1);

////task 3: Write some text followed by an integer to the console (using one Write statement alone)


//Console.WriteLine("Number " + 7);

////task 4: Read an integer from the console

//Console.WriteLine("number: ");
//string input = Console.ReadLine();

//Console.WriteLine("You entered: " + input);

////task 4 experimentation
//string the_input = Console.ReadLine();

//Console.WriteLine(the_input);

//task 5: Sum the numbers from 1 to 10 using a for-loop

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

//task 6: Sum the numbers from 1 to 10 using a while-loop

//int number = 0;
//int othernum = 0;

//while (number < 10) {
//    number++;
//    othernum += number;
//    Console.WriteLine(othernum);
//}

////task 7: Fill an integer array of size 10 with random numbers in the range from 0 to 19 (ask google for “C# Random()”)

//int arrSize = 10;
//int[] numbersArray = new int[arrSize];
//Random rnd = new Random();


//for (int i = 0; i < arrSize; i++)
//{
//    numbersArray[i] = rnd.Next(1, 20);
//    Console.WriteLine(numbersArray[i]);
//}

// vvv Alternative method vvv
//Array.ForEach(numbersArray, Console.WriteLine);

////task 8: Find the minimum of the array in task 7

//int smallest = numbersArray[0];

//for (int i = 0; i < numbersArray.Length; i++) {
//    if (numbersArray[i] < smallest) {
//        smallest = numbersArray[i];
//    }
//}

//Console.WriteLine("The smallest number is: " + smallest);

//task 9: Linear search: Write code that searches for a value, say “5”, in the array from task 7 by going through the array from beginning to the end and comparing the search value with the values in the array. If the value is found print “The value has been found” otherwise print “The value has not been found”. Use a for-loop and an if-then-else statement.

//int specnum = 2;
//bool isInArray = numbersArray.Contains(specnum);

//if (isInArray)
//{
//    Console.WriteLine("The number " + specnum + " is in the array!");
//} else
//{
//    Console.WriteLine("The number " + specnum + " is NOT in the array!");
//}

//task 10: Swap the values of two integers

//int temp = numbersArray[0];
//numbersArray[0] = numbersArray[1];
//numbersArray[1] = temp;

//for (int i = 0; i < arrSize; i++) {
//    Console.WriteLine(numbersArray[i]);
//}

//task 11: Copy the content of one array into another using a for-loop (don't use Array.Copy() or other C# intrinsics like Array.Length)

//int[] numbersArray_2 = new int[arrSize];

//for (int i = 0; i < arrSize; i++) {
//    numbersArray_2[i] = numbersArray[i];
//}

//for (int i = 0; i < arrSize; i++)
//{
//    Console.WriteLine("numbersArray " + i + ": " + numbersArray[i] + " | numbersArray_2 " + i + ": " + numbersArray_2[i]);
//}

//Console.WriteLine();// same as "\n"

////task 12: Write a function/method that swaps two integers and returns the result to the calling function

//(int, int) swapIntegers(int a, int b) {
//    int temp = a;
//    a = b;
//    b = temp;

//    return (a, b);
//}

//(numbersArray[0], numbersArray_2[1]) = swapIntegers(numbersArray[0], numbersArray_2[1]);

////print arrays with number swapped
//for (int i = 0; i < arrSize; i++)
//{
//    Console.WriteLine("numbersArray " + i + ": " + numbersArray[i] + " | numbersArray_2 " + i + ": " + numbersArray_2[i]);
//}
//Console.WriteLine(); // same as "\n"

//task 12, but without arrays

//int x = 1;
//int y = 2;

//void swapNums(int a, int b, string nameA, string nameB) { // (value a, value b, name of var a, name of var b)

//    Console.WriteLine("UNCHANGED: Value of " + nameA + " is " + a + " | Value of " + nameB + " is " + b);

//    int temp = a;
//    a = b;
//    b = temp;

//    Console.WriteLine("CHANGED: Value of " + nameA + " is " + a + " | Value of " + nameB + " is " + b);

//}

//swapNums(x, y, nameof(x), nameof(y)); // nameof() gets the name of the variable rather than the variable's data.

//Console.WriteLine(); // same as "\n"

//task 13: Write a function/method that returns the maximum value of a integer array(this requires a loop; don't use C#-intrinsic methods)

//int maxValue = numbersArray[0];

//int findMaxValueOfArray() {

//    for (int i=0; i<arrSize; i++) {
//        if (maxValue  < numbersArray[i]) {
//            maxValue = numbersArray[i];
//        }
//    }

//    return maxValue;
//}

//Console.WriteLine("The maxValue of the array is: " + findMaxValueOfArray());

//task 14: Write a function that takes two arrays “source” and “dest” and copies “source” to “dest” (don't use Array.Copy())

//int[] numbersArray_3 = new int[arrSize];

//Console.WriteLine("BEFORE THE COPY: ");
//for (int i = 0; i < arrSize; i++)
//{
//    Console.WriteLine("numbersArray " + i + ": " + numbersArray[i] + " | numbersArray_3 " + i + ": " + numbersArray_3[i]);
//}

//void copyArray(int[] source, int[] dest) {
//    for (int i = 0; i < arrSize; i++) {
//        dest[i] = source[i] ;
//    }
//}

//copyArray(numbersArray, numbersArray_3);

//Console.WriteLine("\n  AFTER THE COPY: ");
//for (int i = 0; i < arrSize; i++)
//{
//    Console.WriteLine("numbersArray " + i + ": " + numbersArray[i] + " | numbersArray_3 " + i + ": " + numbersArray_3[i]);
//}

//bool a = true;
//bool b = false;
//bool c = false;
//bool d;

//if ((a && b) || c)
//{
//    d = true;
//} else {
//    d = false;
//}
//Console.WriteLine(nameof(d) + " is " + d);

//task 16
bool[] values = { false, true };

Console.WriteLine("a\tb\tc\t(a && b) || c");
Console.WriteLine("--------------------------------");

// Iterate over all combinations of a, b, and c
foreach (bool a in values)
{
    foreach (bool b in values)
    {
        foreach (bool c in values)
        {
            bool result = (a && b) || c;
            Console.WriteLine($"{a}\t{b}\t{c}\t{result}");
        }
    }
}

