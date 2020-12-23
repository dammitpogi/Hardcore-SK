using HarmonyLib;
using RimWorld;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Verse;
using Verse.AI;

namespace Gewen_AdditionalTraits
{
	[StaticConstructorOnStartup]
	static class AdditionalTraits
	{
		//public static List<DefPackage> packages = Verse.LoadedModManager.GetMod<GewensAddTraits_Mod>().Content.GetDefPackagesInFolder("TraitDefs\\").ToList();

		static AdditionalTraits()
		{
			GAT_TraitSettings.Init();

			foreach (KeyValuePair<string, GAT_FileInfo> file in GAT_TraitSettings.fileInfoDict)
			{
				foreach (KeyValuePair<string, GAT_FileInfo.GAT_DefInfo> item in file.Value.defInfo)
				{
					TraitDef td = DefDatabase<TraitDef>.GetNamedSilentFail(item.Key);

					if (td == null) //Def does not exist (it was deleted)
					{
						GAT_TraitSettings.defsChanged = true;
						GAT_TraitSettings.fileInfoDict[file.Key].defInfo[item.Key].exists = false;
					}
					else //Def exists
					{
						GAT_TraitSettings.fileInfoDict[file.Key].defInfo[item.Key].exists = true;

						if (file.Value.exists == false || td.fileName.Equals(file.Key) == false) //def exists, but the file does not (def moved to new file / file has been renamed)
						{
							GAT_TraitSettings.defsChanged = true;
							GAT_TraitSettings.fileInfoDict[file.Key].defInfo[item.Key].fileChanged = td.fileName;
						}

						if (item.Value.enabled == false) //def exists and needs to be removed
						{
							RemoveTrait(item.Key);
						}
					}
				}
			}

			if (GAT_TraitSettings.defsChanged == true)
			{
				GAT_TraitSettings.HandleChanges();
			}
		}

		public static bool RemoveTrait(string traitDefName)
		{
			Traverse.Create(typeof(DefDatabase<TraitDef>)).Method("Remove", new Type[]
			{
				typeof (TraitDef)
			}).GetValue(TraitDef.Named(traitDefName));

			return true;
		}
	}
}
