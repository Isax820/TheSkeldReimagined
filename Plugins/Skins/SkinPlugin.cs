using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using Reactor;
using Reactor.Utilities;

namespace TheSkeldReimagined.Skins;

[BepInPlugin(Id, "TheSkeldReimagined Skins", Version)]
[BepInProcess("Among Us.exe")]
[BepInDependency(ReactorPlugin.Id)]
public class TheSkeldReimagined : BasePlugin
{
    public const string Id = "theskeldreimagined.skins";
    public const string Version = "2026.11.8";

    public Harmony Harmony { get; } = new(Id);

    public static ConfigEntry<bool> UnlockCosmetics;
    public static ConfigEntry<bool> DontShowCosmeticsInGame;

    public override void Load()
    {
        UnlockCosmetics = Config.Bind("Cosmetics", "UnlockAll", true, "Unlock all cosmetics");
        DontShowCosmeticsInGame = Config.Bind("Cosmetics", "DontShowCosmeticsInGame", false, "Don't show any cosmetics in-game (only client-side)");

        ReactorCredits.Register("TheSkeldReimagined Skins", Version, false, ReactorCredits.AlwaysShow);
        
        Harmony.PatchAll();
     
    } 
}