using System;
using System.Linq;


namespace TestEFCoreCodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            /*using (TestEFCoreCodefirstDBContext db = new TestEFCoreCodefirstDBContext())
            {
                //User user1 = new User { Name = "Tom", Age = 33 ,RegistrationDate = DateTime.Now};
                //User user2 = new User { Name = "Alice", Age = 26, RegistrationDate = DateTime.Now };

                // добавляем их в бд
                //db.Users.AddRange(user1, user2);
                foreach(var users in db.Users)
                {
                    users.RegistrationDate = DateTime.Now;
                }
                db.SaveChanges();
            }*/

            

            // получение данных
            using (TestEFCoreCodefirstDBContext db = new TestEFCoreCodefirstDBContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
        }
    }
}
