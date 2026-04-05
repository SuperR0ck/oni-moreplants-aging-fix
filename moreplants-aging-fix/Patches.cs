using HarmonyLib;

namespace moreplants_aging_fix
{
    // Prevent decorative plants from aging (StandardBasicMorePlants)
    [HarmonyPatch(typeof(StandardBasicMorePlants.States), "IsOld")]
    public static class Patch_StandardBasicMorePlants_IsOld
    {
        public static bool Prefix(StandardBasicMorePlants.StatesInstance smi, ref bool __result)
        {
            // Get plant prefab ID
            var prefabId = smi.master.gameObject.PrefabID().Name;

            // If it's a decorative plant from MorePlants mod
            if (!string.IsNullOrEmpty(prefabId) && prefabId.StartsWith("moreplants_deco_"))
            {
                __result = false; // never old
                return false;     // skip original method
            }

            return true; // run original logic
        }
    }

    // Same fix for StandardMorePlants
    [HarmonyPatch(typeof(StandardMorePlants.States), "IsOld")]
    public static class Patch_StandardMorePlants_IsOld
    {
        public static bool Prefix(StandardMorePlants.StatesInstance smi, ref bool __result)
        {
            // Get plant prefab ID
            var prefabId = smi.master.gameObject.PrefabID().Name;

            // Apply only to decorative plants
            if (!string.IsNullOrEmpty(prefabId) && prefabId.StartsWith("moreplants_deco_"))
            {
                __result = false; // never old
                return false;     // skip original method
            }

            return true; // default behavior
        }
    }
}