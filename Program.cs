//hello 

Console.WriteLine("Hello! Welcome!");
Console.WriteLine("Please enter the dimensions of your room in feet when prompted.");
Console.WriteLine();

//collect data & convert 

Console.Write("Please enter the width of the room: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Please enter the length of the room: ");
double length = double.Parse(Console.ReadLine());

Console.Write("How tall is the room? ");
double height = double.Parse(Console.ReadLine());

 // find area and perimeter, volume and surface area 

double perimeter = (length * 2) + (width * 2);
double area = (length * width);
double volume = (length * width * height);
double surfaceArea = (2 * area) + (2 * (length * height)) + (2 * (height * width));

//display out info 
Console.WriteLine();
Console.WriteLine("The area of your room is " + area + " feet, and the perimeter is " + perimeter + " feet.");
Console.WriteLine("The volume of your room is " + volume + " square feet");
Console.WriteLine("The surface area of your room is " + surfaceArea + " square feet.");


// what size room?


if (area < 250.0)
 {
    Console.WriteLine("Generally speaking, compared to average room sizes, this room is small.");
}
else if (area > 250.0 && area < 650.0)
{
    Console.WriteLine("Generally speaking, compared to average room sizes, this room is medium sized.");
}
else if (area > 650.0)
{
    Console.WriteLine("Generally speaking, compared to average room sizes, this room is large.");

}


