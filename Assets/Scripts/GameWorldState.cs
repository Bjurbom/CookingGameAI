using UnityEngine;

public class GameWorldState : MonoBehaviour
{
    public void DoneWithAnimaiton()
    {
        WorldState.animationDone = true;
    }
}


public static class WorldState
{
    public static bool animationDone = false;
}
