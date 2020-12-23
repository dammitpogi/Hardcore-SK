using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RimWorld;
using Verse;

namespace Gewen_AdditionalTraits
{
	public class ThoughtWorker_Perv : ThoughtWorker
	{
		protected override ThoughtState CurrentSocialStateInternal (Pawn pawn, Pawn other)
		{
			if (!other.RaceProps.Humanlike || !RelationsUtility.PawnsKnowEachOther(pawn, other))
				return (ThoughtState)false;
			if (pawn.story.traits.HasTrait(TraitDef.Named("GAT_Pervert")))
				return (ThoughtState)false;
			if (!other.story.traits.HasTrait(TraitDef.Named("GAT_Pervert")))
				return (ThoughtState)false;
			return (ThoughtState)true;
		}
	}
}
