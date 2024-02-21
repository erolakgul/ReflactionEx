using System.Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();

// uygullama exe ismi çekilir
Console.WriteLine();

var starts = string.Join("", Enumerable.Repeat("*", 10));
var space = string.Join("", Enumerable.Repeat(" ", 10));

Console.WriteLine($"{starts} Application {starts}");
Console.WriteLine(assembly);
Console.WriteLine("\n");

// sistmede oluşturduğumuz class ve interface tipleri alınır (sealed olarak işaretlenmemişler alınır)
var types = assembly.GetTypes()
                    .Where(t => (t.IsClass || t.IsInterface || t.IsEnum )) //  && t.MemberType == MemberTypes.Method
                    .ToArray();

Console.WriteLine($"{starts} Types {starts}");

int count = 1;

foreach (var type in types)
{
    Console.WriteLine("\n");
    Console.WriteLine($"{count}-{type.Name} - IsClass :{type.IsClass} - IsInterface :{type.IsInterface}");

    #region alınan class ların method larını (sadece benim oluşturduğum DeclaredOnly) oku
    var methods = type.GetMethods(
                       BindingFlags.Public | BindingFlags.Instance |
                       BindingFlags.Static | BindingFlags.DeclaredOnly
                       )
                 .Where(m => !m.IsSpecialName).ToArray();

    if (methods.Length > 0)
    {
        Console.WriteLine("\n");
        Console.WriteLine($"{space}{starts} Methods {starts}");

        foreach (var mtd in methods)
        {
            Console.WriteLine($"{space}{mtd.Name.ToString()} - {mtd.ReturnType}");
        }

        Console.WriteLine("\n");
    }


    #endregion


    #region class a ait property ve property type ları al

    var properties = type.GetProperties();

    if (properties.Length > 0)
    {
        Console.WriteLine("\n");
        Console.WriteLine($"{space}{starts} Properties {starts}");


        foreach (var prop in properties)
        {
            Console.WriteLine($"{space}{prop.Name} - {prop.PropertyType}");
        }
        Console.WriteLine("\n");
    }

    #endregion

    count++;
}

Console.ReadLine();