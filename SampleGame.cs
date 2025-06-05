using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

public class SampleGame : Game
{
    private GraphicsDeviceManager _graphics;

    public SampleGame()
    {
        _graphics = new GraphicsDeviceManager(this);

        InitializeSteam();
    }

    public void InitializeSteam()
    {
        try
        {
            Steamworks.SteamClient.Init(480, true);

            var playername = Steamworks.SteamClient.Name;
        }
        catch (Exception e)
        {
            Debug.WriteLine("{0}", e);
        }
    }
}