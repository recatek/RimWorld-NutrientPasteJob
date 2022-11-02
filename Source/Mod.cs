using HarmonyLib;
using UnityEngine;
using Verse;

namespace Recatek.NutrientPasteJob.Core
{
    public class Mod : Verse.Mod
    {
        private readonly ModContentPack content;

        public Mod(ModContentPack content) : base(content)
        {
            this.content = content;
            new Harmony(ModConstants.Id).PatchAll();
            GetSettings<ModSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            ModSettings.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return content.Name;
        }
    }
}
