
                                       // Ass-04

// from Ass-2

// Q11

int? year = null;
Console.WriteLine("Year: " + year.HasValue);
year = 2023;
Console.WriteLine("Year: " + year);

// Q12

string? reviewer = null;

Console.WriteLine("Reviewer: " + (reviewer == null));

// Q13

Book? book = null;
Console.WriteLine($"book title : {book?.Title}");



// Q14

string? name = null;
string name01 = name ?? "Untitled";
Console.WriteLine(name01);

string? name02 = null;
name02 ??= "Untitled";
Console.WriteLine(name02);

// Q15

string? Name = "Ahmed";
string? Name01 = Name!;

Console.WriteLine(Name01);


// fronm Ass-3

// Q16

string[] Book01 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int i = 0; i < Book01.Length; i++)
{
    if (Book01[i] == "Refactoring")
        break;

    Console.WriteLine(Book01[i]);
}

// Q17

string[] Book02 = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

for (int i = 0; i < Book02.Length; i++)
{
    if (Book02[i] == "The Pragmatic Programmer")
        continue;

    Console.WriteLine(Book02[i]);
}



// from Ass-4

// Q1

double[] prices = { 25.5, 40.0, 33.75 };
Console.WriteLine(prices[1]);

// Q2

int[,] shelfCopies = { { 3 , 5 },
                       { 1 , 4 }  };

Console.WriteLine(shelfCopies[1, 0]);

// Q3

void PrintWelcomeMessage()
{
    Console.WriteLine("Welcome to the Library!");
}

PrintWelcomeMessage();

// Q4

void PrintBookTitle(string title)
{
    Console.WriteLine($"BookTitle : {title}");
}

PrintBookTitle("Clean Code");

// Q5

void AddBonusPages(int pages)
{
    pages += 50;
    Console.WriteLine($"Bonus Pages Added: {pages}");
}

AddBonusPages(400);

// Q6

double ApplyDiscount(double[] prices)

{
    prices[0] -= 5;
    Console.WriteLine($"Discounted Price: {prices[0]}");
    return prices[0]
    ;
    
}


ApplyDiscount(prices);


// Q7
void addBonusPages(int pages)
{
    Console.WriteLine($"Bonus Pages Added: {pages}");
}

int pages = 400;
pages += 50;
addBonusPages(pages);



// Q8

// Q9

// Q10

// Q11


























class Book
{
    public string Title;
}