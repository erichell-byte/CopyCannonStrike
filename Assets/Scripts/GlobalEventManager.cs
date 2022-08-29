using System;
public class GlobalEventManager
{
    public static Action OnBulletFired;
    public static Action OnGameWin;
    public static Action OnGameLose;

    public static void SendBulletFired()
    {
        if (OnBulletFired != null )
            OnBulletFired.Invoke();
    }

    public static void SendGameWin()
    {
        if (OnGameWin != null)
            OnGameWin.Invoke();
    }

    public static void SendGameLose()
    {
        if (OnGameLose != null)
            OnGameLose.Invoke();
    }

}
