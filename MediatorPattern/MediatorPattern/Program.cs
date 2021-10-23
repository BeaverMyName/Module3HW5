using System;
using MediatorPattern.Visitor;

namespace MediatorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Mediator
            var manager = new Manager();
            var client = new Client(manager);
            var programmer = new Programmer(manager);
            var tester = new Tester(manager);
            manager.Client = client;
            manager.Programmer = programmer;
            manager.Tester = tester;

            client.Send("Make this project as soon as possible!");
            programmer.Send("I have done the project. Make the tests!");
            tester.Send("Tests are done. Take your project!");

            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();

            // Visitor
            var bank = new Bank();
            var company = new Company();
            var person = new Person();
            var htmlVisitor = new HtmlVisitor();
            var xmlVisitor = new XmlVisitor();

            bank.Add(company);
            bank.Add(person);

            bank.Accept(htmlVisitor);
            bank.Accept(xmlVisitor);
        }
    }
}
