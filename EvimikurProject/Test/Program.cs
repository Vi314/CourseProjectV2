
using DataAccess;
using Entity.Entity;
using Logic.Repository;
using System.Linq;
using Logic.Concrete_Service;

public class Program
{
    private static void Main(string[] args)
    {
        //var employee = new Employee {Id=7, FirstName = "mike", LastName = "tyson", Department="Sales" };
        //BaseRepository<Employee> repo = new (context);

        ////Console.WriteLine(repo.Create(employee));

        ////Console.WriteLine(repo.Delete(5));
        ////Console.WriteLine(repo.Delete(6));

        ////var employeeList = context.Employees.Select(x => new
        ////{ x.Id, x.State, x.FirstName, x.LastName, x.Department }).ToList();

        //var employeeList = repo.GetAll();

        ////repo.Update(employee);

        //foreach (var item in employeeList)
        //{
        //    Console.WriteLine($"{item.Id}, {item.FirstName}, {item.LastName}, {item.Department}");
        //}

    }
}