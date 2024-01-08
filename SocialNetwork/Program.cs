using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LikeMeNetwork likeNetwork = new LikeMeNetwork();
            List<User> users = new List<User>();

            UserListInitializer(users);
            SubscribeListElements(users, likeNetwork);
            LikeRandomizer(users, likeNetwork);

            PublishNews(likeNetwork, new string("Wow it happend!"));
            foreach (User user in users)
            {
                user.PrintAllNotifications();
            }
        }

        static void SubscribeListElements(List<User> users, LikeMeNetwork network)
        {
            foreach(User user in users)
            {
                network.LikeOccured += user.HandeLikeEvent;
                network.NewsOccured += user.HandleNewsEvent;
            }
        }
        static void UserListInitializer(List<User> users)
        {
            User userVera = new User("Vera");
            User userAnton = new User("Anton");
            User userMichael = new User("Michael");
            User userSergey = new User("Sergey");
            User userAlex = new User("Alex");

            users.Add(userVera); users.Add(userAnton);
            users.Add(userMichael); users.Add(userSergey);
            users.Add(userAlex); 
        }

        static void LikeRandomizer(List<User> users, LikeMeNetwork net)
        {
            Random rand = new Random();
            int count = 0;
            int index1 = 0;
            int index2 = 0;
            DateTime time = new();
            while (users.Count != count)
            {
                do
                {
                    index1 = rand.Next(0, 5);
                    index2 = rand.Next(0, 5);
                    time = new DateTime(rand.Next(2019, 2024),
                                        rand.Next(1, 12),
                                        rand.Next(1, 31),
                                        rand.Next(1, 12),
                                        rand.Next(1, 60),
                                        rand.Next(1, 60));
                }
                while (index1 == index2);
                
                net.Like(users[index1], users[index2], time);
                count++;
            }
        }
        static void PublishNews( LikeMeNetwork net, string newsMessage)
        {
            net.NewsPublisher(newsMessage);
        }
        }
    }


