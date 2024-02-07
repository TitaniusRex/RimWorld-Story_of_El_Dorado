// SoED
using System.Collections.Generic;
using RimWorld;
using Verse;

namespace SoED {

	[DefOf]
	public static class ThingDefOf
{
	public static ThingDef Apparel_SoEDGoldSkin;
}
	[DefOf]
	public class ThoughtWorker_GoldingSkinMerikaFackYeah : ThoughtWorker
{
	protected override ThoughtState CurrentStateInternal(Pawn p)
	{
			List<Apparel> wornApparel = p.apparel.WornApparel;
			for (int i = 0; i < wornApparel.Count; i++)
			{
				if (wornApparel[i].def == ThingDefOf.Apparel_SoEDGoldSkin)
				{
					return true;
				}
			}
		return ThoughtState.Inactive;
	}
}
}
