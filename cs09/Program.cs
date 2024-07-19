
 var product = new Product
{
    Name = "VideoGame",
    CategoryId = 1
};
var newProduct = product with { CategoryId = 2 };
Console.WriteLine(product.CategoryId + ":" + product.Name);