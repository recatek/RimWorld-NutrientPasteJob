using UnityEngine;
using Verse;

namespace Recatek.NutrientPasteJob
{
    public class ModSettings : Verse.ModSettings
    {
        private static string _intSettingBuffer = null;

        private static bool _boolSetting = true;
        private static int _intSetting = 20;

        internal static bool BoolSetting { get => _boolSetting; set => _boolSetting = value; }
        internal static int IntSetting { get => _intSetting; set => _intSetting = value; }

        public override void ExposeData()
        {
            base.ExposeData();

            Scribe_Values.Look(ref _boolSetting, "boolSetting", true);
            Scribe_Values.Look(ref _intSetting, "intSetting", 20);
        }

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);

            listingStandard.CheckboxLabeled("NutrientPasteJob.BoolSetting".Translate(), ref _boolSetting);

            listingStandard.Label("NutrientPasteJob.IntSetting".Translate());
            listingStandard.IntEntry(ref _intSetting, ref _intSettingBuffer);

            listingStandard.End();
        }
    }
}
