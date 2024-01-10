

using SocialNetwork;

public delegate void LikeEventSystem(User likinguser, User likedUser, DateTime time);

internal class LikeMeNetwork
{
    public LikeEventSystem LikeOccured;

    public LikeMeNetwork()
    {

    }

    public void Like(User likingUser, User likedUser, DateTime time)
    {
        LikeOccured?.Invoke(likingUser, likedUser, time);
    }
   

    
}
