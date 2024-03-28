#region Task 1

using Delegate.Models;

List<Person> people = new();

FilterPeople(person => person.Salary > 1000);

void FilterPeople(Predicate<Person> predicate)
{
    List<Person> filteredPeople = people.FindAll(predicate);
    foreach (Person person in filteredPeople)
    {
        Console.WriteLine(person.Name + person.Surname + person.Address);
    }
}

#endregion

#region Task 2

List<Book> books = new();

FilterBooks(book => book.Author == "Nizami");

void FilterBooks(Predicate<Book> predicate)
{
    List<Book> filteredBooks = books.FindAll(predicate);
    Console.WriteLine(filteredBooks.Count);
}

#endregion

#region Task 3

List<Employee> employees = new();

AverageSalary(employees);

int AverageSalary(List<Employee> employees)
{
    List<Employee> filteredEmployees = employees.FindAll(employee => employee.Age > 20 && employee.Age < 40);
    int sum = 0;
    foreach (Employee employee in filteredEmployees)
    {
        sum += employee.Salary;
    }
    int average = sum / employees.Count;
    return average;
}

#endregion