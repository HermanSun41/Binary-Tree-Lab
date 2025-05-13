// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public static void Main(string[] args)
{
    BinarySearchTree bst = new BinarySearchTree();

    while (true)
    {
        Console.WriteLine("\n=== Binary Search Tree Menu ===");
        Console.WriteLine("1. Add elements");
        Console.WriteLine("2. Find an element");
        Console.WriteLine("3. Display sorted elements");
        Console.WriteLine("4. Find smallest value");
        Console.WriteLine("5. Find largest value");
        Console.WriteLine("6. Exit");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        try
        {
            switch (choice)
            {
                case "1":
                    Console.Write("Enter integers separated by space: ");
                    string[] inputs = Console.ReadLine().Split();
                    foreach (string input in inputs)
                    {
                        if (int.TryParse(input, out int val))
                        {
                            try
                            {
                                bst.Add(val);
                                Console.WriteLine($"Added: {val}");
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid input: {input}");
                        }
                    }
                    break;

                case "2":
                    Console.Write("Enter value to find: ");
                    if (int.TryParse(Console.ReadLine(), out int target))
                    {
                        bool found = bst.Find(target);
                        Console.WriteLine(found ? $"Value {target} found." : $"Value {target} not found.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;

                case "3":
                    List<int> sorted = bst.Sort();
                    Console.WriteLine("Sorted elements: " + string.Join(", ", sorted));
                    break;

                case "4":
                    Console.WriteLine("Smallest value: " + bst.FindMin());
                    break;

                case "5":
                    Console.WriteLine("Largest value: " + bst.FindMax());
                    break;

                case "6":
                    Console.WriteLine("Exiting...");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
        catch (Exception ex)
        {
            // Top-level catch to prevent app crash
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
