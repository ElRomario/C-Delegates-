

using SocialNetwork;

public delegate void LikeEventSystem(User likinguser, User likedUser, DateTime time);
public delegate void NewsEventSystem(string message);                                                                     

internal class LikeMeNetwork
{
    public LikeEventSystem LikeOccured;
    public NewsEventSystem NewsOccured;

    public LikeMeNetwork()
    {

    }

    public void Like(User likingUser, User likedUser, DateTime time)
    {
        LikeOccured?.Invoke(likingUser, likedUser, time);
    }
    public void NewsPublisher(string news)

    { 
        NewsOccured?.Invoke(news);
    }

    
}
