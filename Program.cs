using System;

namespace contacts
{
    class Program
    {
        public Person Model { get; set; }

        static void Main(string[] args)
        {

            List<Person> persons = new List<Person>();

            persons.Add(new Person
            {
                Id = 1,
                Name = "oguz",
                SurName = "bask",
                TelNum = 555
            });
            persons.Add(
            new Person
            {
                Id = 2,
                Name = "oguz2",
                SurName = "bask2",
                TelNum = 5552
            });
            persons.Add(new Person()
            {
                Id = 3,
                Name = "oguz3",
                SurName = "bask3",
                TelNum = 5553
            });
            persons.Add(new Person()
            {
                Id = 4,
                Name = "oguz4",
                SurName = "bask4",
                TelNum = 5554
            });
            persons.Add(new Person()
            {
                Id = 5,
                Name = "oguz5",
                SurName = "bask5",
                TelNum = 5555
            });

            //var personn = persons.FirstOrDefault(c => c.Id == 1);
            int exit = 1;
            do
            {
                Console.WriteLine("Please choose what you want to do :) ******************************************* (1) New Number (2) Deleting Existing Number (3) Updating Existing Number (4) List all contacts (5) Search (0) Exit");
                int choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:

                    exit =0;

                    break;

                    case 1:
                        // taking name from user
                        Console.WriteLine("Name");
                        string name = Console.ReadLine();

                        // taking surname from user
                        Console.WriteLine("SurName");
                        string surName = Console.ReadLine();

                        // taking number from user
                        Console.WriteLine("Telephone Number");
                        int telNum = Int32.Parse(Console.ReadLine());
                        var lastPerson = persons.LastOrDefault();

                        persons.Add(new Person()
                        {
                            Id = lastPerson.Id + 1,
                            Name = name,
                            SurName = surName,
                            TelNum = telNum
                        });

                        break;

                    case 2:
                        Console.WriteLine("Please enter Id you want to delete");
                        //taking id from user
                        int deleteId = Int32.Parse(Console.ReadLine());

                        //taking person from database
                        var deletePerson = persons.FirstOrDefault(c => c.Id == deleteId);

                        //checking existance
                        if (deletePerson == null)
                            Console.WriteLine("there is no record please enter already exists id");

                        //deleting
                        persons.Remove(deletePerson);

                        //making sure person is deleted and giving message
                        var personn = persons.FirstOrDefault(c => c.Id == deleteId);
                        if (personn == null)
                        {
                            Console.WriteLine("succesfully deleted");
                        }

                        break;

                    case 3:
                        Console.WriteLine("Please enter Id you want to update");
                        int updateId = Int32.Parse(Console.ReadLine());

                        //taking the person that has the same id user entered
                        var updatePerson = persons.FirstOrDefault(c => c.Id == updateId);

                        //checking existance
                        if (updatePerson == null)
                            Console.WriteLine("there is no record please enter already exists id");


                        // taking name from user
                        Console.WriteLine("Name");
                        string name1 = Console.ReadLine();

                        // taking surname from user
                        Console.WriteLine("SurName");
                        string surName1 = Console.ReadLine();

                        // taking number from user
                        Console.WriteLine("Telephone Number");
                        int telNum1 = Int32.Parse(Console.ReadLine());

                        //changing datas with updated version
                        updatePerson.Name = name1;
                        updatePerson.SurName = surName1;
                        updatePerson.TelNum = telNum1;
                        Console.WriteLine("succesfully updated");

                        break;

                    case 4:
                        List<Person> item = persons.OrderBy(c => c.Id).ToList();

                        foreach (var i in item)
                        {
                            Console.WriteLine("Id: "+  i.Id);
                            Console.WriteLine("Name: "+ i.Name);
                            Console.WriteLine("Surname: "+ i.SurName);
                            Console.WriteLine("Telephone number: "+ i.TelNum);
                        }

                        break;
                    case 5:
                        Console.WriteLine("Search by name");
                        string searchName = Console.ReadLine();
                        var search = persons.FirstOrDefault(c => c.Name == searchName);

                        Console.WriteLine("Id: "+ search.Id);
                        Console.WriteLine("Name: "+ search.Name);
                        Console.WriteLine("Surname: "+ search.SurName);
                        Console.WriteLine("Telephone number: "+ search.TelNum);
                        break;

                    default:
                        Console.WriteLine("You entered wrong number");
                        break;

                }
            }while(exit != 0);
        }
    }
}