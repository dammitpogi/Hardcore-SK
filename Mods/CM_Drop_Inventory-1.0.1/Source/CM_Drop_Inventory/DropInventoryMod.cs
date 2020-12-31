using HarmonyLib;
using RimWorld;
using Verse;

namespace CM_Drop_Inventory
{
    public class DropInventoryMod : Mod
    {
        private static DropInventoryMod _instance;
        public static DropInventoryMod Instance => _instance;

        public DropInventoryMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony("CM_Drop_Inventory");
            harmony.PatchAll();

            _instance = this;
        }
    }
}
