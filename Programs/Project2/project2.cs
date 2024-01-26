using System;
using System.Collections.Generic;
using System.Linq;

class project2
{
    static List<Assignment> assignments = new List<Assignment>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nHomework Organizer");
            Console.WriteLine("1. Add Assignment");
            Console.WriteLine("2. Remove Assignment");
            Console.WriteLine("3. Show Assignments");
            Console.WriteLine("4. Mark Assignment as Completed");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddAssignment();
                    break;
                case "2":
                    RemoveAssignment();
                    break;
                case "3":
                    ShowAssignments();
                    break;
                case "4":
                    MarkAssignmentAsCompleted();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddAssignment()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();

        Console.Write("Enter due date (yyyy-mm-dd): ");
        string dueDate = Console.ReadLine();

        Console.Write("Enter subject: ");
        string subject = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        assignments.Add(new Assignment(title, dueDate, subject, description));
        Console.WriteLine("Assignment added successfully.");
    }

    static void RemoveAssignment()
    {
        ShowAssignments();

        Console.Write("Enter the title of the assignment to remove: ");
        string title = Console.ReadLine();
        var assignment = assignments.FirstOrDefault(a => a.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (assignment != null)
        {
            assignments.Remove(assignment);
            Console.WriteLine("Assignment removed successfully.");
        }
        else
        {
            Console.WriteLine("Assignment not found.");
        }
    }

    static void ShowAssignments()
    {
        foreach (var assignment in assignments.OrderBy(a => a.Duedate))
        {
            Console.WriteLine(assignment);
        }
    }

    static void MarkAssignmentAsCompleted()
    {
        ShowAssignments();

        Console.Write("Enter the title of the assignment to mark as completed: ");
        string title = Console.ReadLine();
        var assignment = assignments.FirstOrDefault(a => a.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        if (assignment != null)
        {
            assignment.IsCompleted = true;
            Console.WriteLine("Assignment marked as completed.");
        }
        else
        {
            Console.WriteLine("Assignment not found.");
        }
    }
}