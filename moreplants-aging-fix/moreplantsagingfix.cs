using HarmonyLib;
using KMod;

namespace moreplants_aging_fix
{
    public sealed class Mod : UserMod2
    {
        public override void OnLoad(Harmony harmony)
        {
            base.OnLoad(harmony);

            // Apply all Harmony patches in this mod
            harmony.PatchAll();
        }
    }
}