//ask for room info
Console.WriteLine("Welcome to the room detail generator!");
Console.WriteLine();
Console.WriteLine("What is the room's length?");
double length = double.Parse(Console.ReadLine());
Console.WriteLine("What is the room's width?");
double width = double.Parse(Console.ReadLine());
Console.WriteLine("What is the room's height?");
double height = double.Parse(Console.ReadLine());
//Calculations
double area = length * width;
double perimeter = 2 * (length + width);
double volume = length * width * height;
double surfaceArea = 2 * (width * length + height * length + height * width);
//display info
Console.WriteLine();
Console.WriteLine("The room's area is " + area);
Console.WriteLine("The room's perimeter is " + perimeter);
if(area <= 250)
{
    Console.WriteLine("The room is small sized");
}
else if (250 < area && area < 650)
{
    Console.WriteLine("The room is medium sized");
}
else
{
    Console.WriteLine("The room is large sized");
}
Console.WriteLine("The room's volume is " + volume);
Console.WriteLine("The room's surface area is " + surfaceArea);
Console.WriteLine();
Console.WriteLine("Thanks for using the room detail generator!");