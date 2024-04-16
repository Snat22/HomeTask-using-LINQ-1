using _001Select;

var category = new List<Category>();
var category1 =new Category()
{
    Id = 1,
    Name = "Fruits",
};
var category2 =new Category()
{
    Id = 2,
    Name = "Vegetables",
};

category.Add(category1);
category.Add(category2);

var productions = new List<Product>
{
    new Product {Id = 1,Name = "Apple",  Quantity = 10,Price = 1200,Category = category1},
    new Product {Id = 2,Name = "Banana",  Quantity = 20 ,Price = 2100,Category =category1 },
    new Product {Id = 3,Name = "Broccoli",  Quantity = 30,Price = 2300,Category =category2 }
};


//1.
//Выбрать все записи из таблицы "Products"
//Select all records from the "Products" table

//2.
//Выбрать только имена продуктов из таблицы "Products"
//Select only product names from the "Products" table

//3.
//Выбрать только уникальные категории продуктов из таблицы "Products"
//Select only unique product categories from the "Products" table


// With Operators LINQ

// var product = (from p in productions select p);
// System.Console.WriteLine();
// foreach (var item in product)
// {
//     // System.Console.WriteLine($"ID:{item.Id} Name: {item.Name} Quantity: {item.Quantity} Price: {item.Price} Category Id:{item.Category.Id} Name: {item.Category.Name}");
// }

// var product = (from p in productions select p);
// System.Console.WriteLine();
// foreach (var item in product)
// {
//     System.Console.WriteLine($"Product Name: {item.Name}");
// }


// var prod = productions
//            .Select(p => p.Category)
//             .Distinct();
//     foreach (var item in uniqueCategories)
//     {
//         System.Console.WriteLine($"{item.Name}");
//     }
