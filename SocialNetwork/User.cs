using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class User
    {
        public static int ID = 0;
        List<string> messages = new List<string>();
        public string Name { get; set; }

        public User()
        {
            ID++;
        }

        public User(string name)
        {
            Name = name;
            ID++;
        }

        public void HandeLikeEvent(User likingUser, User likedUser, DateTime time)
        {
            messages.Add($"User {this.Name} recieved that: \n        user {likingUser.Name} liked {likedUser.Name} at {time}");
        }
        public void HandleNewsEvent(string newsMessage)
        {
            messages.Add($"User{this.Name} recieved news: \n {newsMessage}");
        }
        public void HandleNewsDealer(string message)
        {
            messages.Add($"User {this.Name} recieved news: \n {message}");
        }

        public void PrintAllNotifications()
        {
            Console.WriteLine($"==========\nNotifications that {this.Name} receieved\n==========");
            foreach (string message in messages) 
            {
                Console.WriteLine(message);
            }
        }

    }
}
