using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMeNetwork
{
    internal class User
    {
        public EventHandler LikeOccured;
      
        public string Name { get; set; }
        public void Like(User subscription)
        {
            LikeOccured?.Invoke(subscription.Name);
        }
        public void HandleLike(string name)
        {
            Console.WriteLine($"{this.Name} Like {name} photo");
        }
        public User(string name) => Name = name;
        
    }
}



