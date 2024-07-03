//1.GerericAttributes
GenericAttributes.Method();

//2.GenericMath
//1) UnsignedRightShiftOpt
GenericMath.UnsignedRightShiftOpt();
//2) checked operators
var p1 = new Point(2,3);
var p2 = new Point(1,4);
var p3 = p1+p2;
Console.WriteLine($"point:{p3.X},{p3.Y}");
  
//3.NumericIntPtr
NumericIntPtr.Method();

//4.Newlines in string interpolations
NewlinesInterpolations.Method(75);

//5.ListPatterns
ListPatterns.Method();

//6.ImprovedMethodGroup
ImprovedMethodGroup.Sum();

//7.Raw string literals
RawString.Method();
RawString.location(112.12,29.12);

//8.AutoDefaultStructs
var p = new Product("book");
Console.WriteLine($"C={p.CategoryId}:N={p.Name}");

//9.PatternMatchSpan
PatternMatchSpan.Method();