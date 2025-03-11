//examine a hand of poker

int cardsNum = 5;
int possibleCards = 13;

void printCards(int[] c) {

    Console.WriteLine("Your cards: ");

    for (int i = 0; i < cardsNum; i++) {
       Console.Write(c[i] + " ");
    }

    Console.WriteLine("\n"); // just for extra 2 lines
}

void printCount(int[] co) {

    Console.WriteLine("Your count: ");

    for (int i = 0; i < possibleCards; i++)
    {
        Console.Write(i + 1 + ": ");
        Console.Write(co[i]);
        Console.WriteLine();
    }

    Console.WriteLine(); // just for extra 2 lines

}

while (true)
{
    int[] cards = new int[cardsNum];
    int[] count = new int[possibleCards];

    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        //Console.WriteLine($"Enter card number {i + 1}:");
        //int input = Convert.ToInt32(Console.ReadLine());
        //if (input < 14 && input > 0)
        //{
        //    Console.WriteLine($"{input} is valid");

        //    cards[i] = input;
        //} else
        //{
        //    Console.WriteLine($"{input} is NOT valid; \nRestarting...");
        //    break;
        //}

        //--------------------------------------------------------------------

        int randNum = random.Next(1, 14);
        cards[i] = randNum;
    }

    printCards(cards);

    for (int i = 0; i < cardsNum; i++) {
        count[cards[i] - 1]++;
    }

    printCount(count);

    bool count4 =  false;
    bool count3 = false;
    int count2 = 0;

    for (int i = 0; i < possibleCards; i++) {
        if (count[i] == 4) {
            count4 = true;
        }
        if (count[i] == 3)
        {
            count3 = true;
        } 
        if (count[i] == 2)
        {
            count2++;
        } 
    }

    if (count4) {
        Console.WriteLine("4 of a kind");
    } else if (count3) {
        if (count2 > 0)
        {
            Console.WriteLine("Full House");
        } else { 
            Console.WriteLine("3 of a kind");
        }
    }else if (count2 == 1) {
        Console.WriteLine("pair");

    } else if (count2 == 2) {
        Console.WriteLine("2 pairs");

    } else { 
        Console.WriteLine("Your hand has no value");

    }

    Console.ReadKey(true);
}