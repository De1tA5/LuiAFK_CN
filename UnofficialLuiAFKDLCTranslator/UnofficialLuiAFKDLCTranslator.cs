#pragma warning disable CA2255
using LuiAFKRebornCN.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace LuiAFKRebornCN.UnofficialLuiAFKDLCTranslator
{
	public class UnofficialLuiAFKDLCTranslator
	{
		private class UnofficialLuiAFKDLC{}
		[ExtendsFromMod("UnofficialLuiAFKDLC"), JITWhenModsEnabled("UnofficialLuiAFKDLC")]
		private class TranslatorLoad : ForceLocalizeSystem<UnofficialLuiAFKDLC, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("UnofficialLuiAFKDLC",out _))
			{
				#region UnofficialLuiAFKDLC.Content.Items.Placeable.AncientScrollCrafterTile
				TranslatorLoad.LocalizeByTypeFullName("UnofficialLuiAFKDLC.Content.Items.Placeable.AncientScrollCrafterTile", "SetStaticDefaults", new ()
				{
					{"至尊灾厄的奥术撰卷桌","Arcane Scriptorium"},
				});
				#endregion UnofficialLuiAFKDLC.Content.Items.Placeable.AncientScrollCrafterTile


			}
		}
	}
}
