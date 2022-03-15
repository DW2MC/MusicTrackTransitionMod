using DistantWorlds2;
using JetBrains.Annotations;

namespace MusicTrackTransitionMod;

[PublicAPI]
public class Mod
{
    public Mod(DWGame game)
    {
        game.MusicSystem.TrackTransitionTime = 180;
        game.MusicSystem.TrackTransitionTimeOverride = 15;
    }
}
