//1.GerericAttributes
//GenericAttributes.Method();

//2.GenericMath
//1) UnsignedRightShiftOpt
//GenericMath.UnsignedRightShiftOpt();
//2) checked operators
//var p1 = new Point(2,3);
//var p2 = new Point(1,4);
//var p3 = p1+p2;
//Console.WriteLine($"point:{p3.X},{p3.Y}");
  
//3.NumericIntPtr
//NumericIntPtr.Method();

//4.Newlines in string interpolations
//NewlinesInterpolations.Method(75);

//5.ListPatterns
//ListPatterns.Method();

//6.ImprovedMethodGroup
//ImprovedMethodGroup.Sum();

//7.Raw string literals
//RawString.Method();
//RawString.location(112.12,29.12);

//8.AutoDefaultStructs
//var p = new Product("book");
//Console.WriteLine($"C={p.CategoryId}:N={p.Name}");

//9.PatternMatchSpan
//PatternMatchSpan.Method();

//10.Extended nameof scope
try
{
    var person = new Person();
    person.Name = null;
}
catch (System.Exception ex)
{    
    Console.WriteLine(ex.Message);
}

//11.UTF-8 string literals
ReadOnlySpan<byte> u8Span = "ABC"u8; //65, 66, 67
UTF8StringLiterals.Method(u8Span.ToArray());

//12.Required members
//var motor = new Motor("Toyota");
var car = new Car("Toyota");

//13.ref struct
//Span<int> span = RefStruct.Foo( 1);

