using Point = (int x, int y);

//1.PrimaryConstructors
var person = new Person("do","ku");
person.Print();
var distance = new Distance(3,4);
distance.Print();

//2.Default Lambda parameters
var IncrementBy = (int source,int increment = 1) => source+increment;
Console.WriteLine(IncrementBy(5));

//3.Alias any type
Point p = new Point(2,3);
Console.WriteLine($"point:{p.x},{p.y}");

//4.Inline arrays
InlineArray.Print();

