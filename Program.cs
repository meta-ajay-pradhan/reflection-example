using System.Reflection;
public class Test
{
    //Fields
    private int field;
    protected int field2;
    public int field3;

    //Properties
    protected int Id { get; private set; }
    public string? Name { get; set; }

    //Members
    public void show()
    {
        Console.WriteLine($"Hello, I am {this.Name}");
    }

    protected void hello() {
        Console.WriteLine("Protected Method!");
    }

    private void hi() {
        Console.WriteLine("Private Method!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Type t = typeof(Test);
        Test a = new Test();

        Console.WriteLine("\nAll public fields: ");
        FieldInfo[] fields = t.GetFields();
        foreach (var field in fields)
        {
            Console.WriteLine(field);
        }
        Console.WriteLine("\nAll Non public fields: ");
        fields = t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var field in fields)
        {
            Console.WriteLine(field);
        }

        Console.WriteLine("\nAll public Properties: ");
        PropertyInfo[] properties = t.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine(property);
        }
        Console.WriteLine("\nAll non public Properties: ");
        properties = t.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
        foreach (var property in properties)
        {
            Console.WriteLine(property);
        }

        Console.WriteLine("\nAll public method: ");
        MethodInfo[] methods = t.GetMethods();
        foreach( var method in methods) {
            Console.WriteLine(method);
        } 
        Console.WriteLine("\nAll non public Methods: ");
        methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
        foreach(var method in methods) {
            Console.WriteLine(method);
        }


    }
}