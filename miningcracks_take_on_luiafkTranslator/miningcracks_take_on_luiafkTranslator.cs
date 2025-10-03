#pragma warning disable CA2255
using LuiAFKRebornCN.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
using System.Runtime.CompilerServices;
namespace LuiAFKRebornCN.miningcracks_take_on_luiafkTranslator
{
	public class miningcracks_take_on_luiafkTranslator
	{
		private class miningcracks_take_on_luiafk{}
		[ExtendsFromMod("miningcracks_take_on_luiafk"), JITWhenModsEnabled("miningcracks_take_on_luiafk")]
		private class TranslatorLoad : ForceLocalizeSystem<miningcracks_take_on_luiafk, TranslatorLoad>{}
		[ModuleInitializer]
		public static void LoadTranslator()
		{
			if(LoadModAssembly.LoadModContext.TryGetValue("miningcracks_take_on_luiafk",out _))
			{
				#region miningcracks_take_on_luiafk.LuiafkPlayer
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.LuiafkPlayer", "StartBattlerCountdown", new ()
				{
					{"极限战争已关闭","Ultimate Battler disabled."},
					{"取消关闭极限战争的倒计时","Ultimate Battler countdown for disabling cancelled."},
					{"极限战争已启用","Ultimate Battler enabled."},
					{"取消启用极限战争的倒计时","Ultimate Battler countdown for enabling cancelled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.LuiafkPlayer", "BattlerCountdown", new ()
				{
					{"极限战争已启用","Ultimate Battler enabled."},
					{"极限战争已关闭","Ultimate Battler disabled."},
					{"极限战争关闭倒计时： ","Ultimate Battler will be disabled in "},
					{"秒"," seconds."},
					{"极限战争启用倒计时： ","Ultimate Battler will be enabled in "},
				});
				#endregion miningcracks_take_on_luiafk.LuiafkPlayer


				#region miningcracks_take_on_luiafk.Images.Tiles.Collection.Chests
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Tiles.Collection.Chests", "MouseOver", new ()
				{
					{"\n收割机仅能在专家及以上难度使用","\nHarvesters are Expert+ only."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Tiles.Collection.Chests


				#region miningcracks_take_on_luiafk.Images.Items.Tools.ComboRod
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.Tools.ComboRod", "CanUseItem", new ()
				{
					{"[LuiAFK] 请禁用智能光标以使用此工具，否则它将无法使用。","[LuiAFK] Please disable Smart Cursor to use this rod, It will be nearly unusable otherwise."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.Tools.ComboRod


				#region miningcracks_take_on_luiafk.Images.Items.Solutions.UnlimitedMultiSolution
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.Solutions.UnlimitedMultiSolution", "UseItem", new ()
				{
					{"位置已保存","Location saved."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.Solutions.UnlimitedMultiSolution


				#region miningcracks_take_on_luiafk.Images.Items.Placeables.Collection.TreeHarvester
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.Placeables.Collection.TreeHarvester", "ModifyTooltips", new ()
				{
					{"[c/b01c1c:Harvesters are Expert+ only!]","[c/b01c1c:Harvesters are Expert+ only!]"},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.Placeables.Collection.TreeHarvester


				#region miningcracks_take_on_luiafk.Images.Items.EventEnable.RainEnable
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.EventEnable.RainEnable", "RainOff", new ()
				{
					{"开始下雨","Rain disabled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.EventEnable.RainEnable", "RainOn", new ()
				{
					{"停止下雨","Rain enabled."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.EventEnable.RainEnable


				#region miningcracks_take_on_luiafk.Images.Items.EventEnable.SandstormEnable
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.EventEnable.SandstormEnable", "SandstormOff", new ()
				{
					{"沙尘暴 已停止","Sandstorm disabled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.EventEnable.SandstormEnable", "SandstormOn", new ()
				{
					{"沙尘暴 已开始","Sandstorm Enabled."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.EventEnable.SandstormEnable


				#region miningcracks_take_on_luiafk.Images.Items.AutoBuilders.GroundFiller
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Images.Items.AutoBuilders.GroundFiller", "UseItem", new ()
				{
					{"仅填充下方","Fill below only."},
					{"填充下方&清空上方","Fill below and clear above."},
					{"填充下方&清空上方——留下地牢、丛林神庙、地下沙漠的背景墙","Fill below and clear above. Leaves Dungeon, Underground Desert, and Temple walls in place."},
				});
				#endregion miningcracks_take_on_luiafk.Images.Items.AutoBuilders.GroundFiller


				#region miningcracks_take_on_luiafk.Utility.Events
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Utility.Events", "SandstormOff", new ()
				{
					{"沙尘暴 已停止","Sandstorm disabled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Utility.Events", "SandstormOn", new ()
				{
					{"沙尘暴 已开始","Sandstorm enabled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Utility.Events", "RainOff", new ()
				{
					{"停止下雨","Rain disabled."},
				});
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Utility.Events", "RainOn", new ()
				{
					{"开始下雨","Rain enabled."},
				});
				#endregion miningcracks_take_on_luiafk.Utility.Events


				#region miningcracks_take_on_luiafk.Utility.TileChecks
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.Utility.TileChecks", "CoordsString", new ()
				{
					{" 以东， "," east, "},
					{" 以西， "," west, "},
					{" 地下"," underground."},
					{" 地表"," surface."},
				});
				#endregion miningcracks_take_on_luiafk.Utility.TileChecks


				#region miningcracks_take_on_luiafk.UI.Button
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.Button", "MouseText", new ()
				{
					{"\n仅困难模式后","\nHardmode only"},
				});
				#endregion miningcracks_take_on_luiafk.UI.Button


				#region miningcracks_take_on_luiafk.UI.ButtonBox
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.ButtonBox", ".cctor", new ()
				{
					{"草种","Grass"},
					{"腐化草种","Corrupt Grass"},
					{"猩红草种","Crimson Grass"},
					{"神圣草种","Hallow Grass"},
					{"蘑菇草种","Mushroom Grass"},
					{"丛林草种","Jungle Grass"},
					{"生命红木魔棒","Wood Wand"},
					{"红木树叶魔棒","Leaf Wand"},
					{"关闭魔棒效果","Wand/Regrowth Off"},
					{"绿苔藓","Green Moss"},
					{"棕苔藓","Brown Moss"},
					{"红苔藓","Red Moss"},
					{"蓝苔藓","Blue Moss"},
					{"紫苔藓","Purple Moss"},
					{"熔岩苔藓","Lava Moss"},
					{"氪苔藓","Krypton Moss"},
					{"氙苔藓","Xenon Moss"},
					{"氩苔藓","Argon Moss"},
					{"红","Red"},
					{"绿","Green"},
					{"蓝","Blue"},
					{"黄","Yellow"},
					{"致动器","Actuator"},
					{"钢丝钳","Cutter"},
					{"雨","Rain"},
					{"沙尘暴/暴风雪","Sandstorm/Blizzard"},
					{"万圣节","Halloween"},
					{"圣诞节","Christmas"},
					{"石板\n与平台不兼容！","Stone Slab\nDoes not work with platforms!"},
					{"灰砖\n与平台不兼容！","Gray Brick\nDoes not work with platforms!"},
					{"木材","Wood"},
					{"珍珠木","Pearlwood"},
					{"针叶木","Boreal Wood"},
					{"棕榈木","Palm Wood"},
					{"乌木","Ebonwood"},
					{"暗影木","Shadewood"},
					{"红木","Rich Mahogany"},
					{"无限巴斯特雕像","Unlimited Bast Statue"},
					{"无限篝火","Unlimited Campfire"},
					{"无限红心灯笼","Unlimited Heart Lantern"},
					{"无限蜂蜜","Unlimited Honey"},
					{"无限星星瓶","Unlimited Star in a Bottle"},
					{"无限和平蜡烛","Unlimited Peace Candle"},
					{"无限水蜡烛","Unlimited Water Candle"},
					{"无限弹药储备","Unlimited Ammo Reservation"},
					{"无限箭术","Unlimited Archery"},
					{"无限战争","Unlimited Battle"},
					{"无限建筑","Unlimited Builder"},
					{"无限镇静","Unlimited Calming"},
					{"无限耐力","Unlimited Endurance"},
					{"无限钓鱼","Unlimited Fishing"},
					{"无限脚蹼","Unlimited Flipper"},
					{"无限鱼鳃\n进入FTW世界自动关闭","Unlimited Gills\nWill get set off automatically when joining For the Worthy Worlds"},
					{"无限花园侏儒","Unlimited Gnome"},
					{"无限拾心","Unlimited Heartreach"},
					{"无限灵液","Unlimited Ichor"},
					{"无限狱火","Unlimited Inferno"},
					{"无限铁皮","Unlimited Ironskin"},
					{"无限瓢虫","Unlimited Ladybug"},
					{"无限生命力","Unlimited Lifeforce"},
					{"无限幸运","Unlimited Luck"},
					{"无限魔能","Unlimited Magic Power"},
					{"无限魔力再生","Unlimited Mana Regeneration"},
					{"无限挖矿","Unlimited Mining"},
					{"无限夜猫子","Unlimited Night Owl"},
					{"无限黑曜石皮肤","Unlimited Obsidian Skin"},
					{"无限暴怒","Unlimited Rage"},
					{"无限再生","Unlimited Regeneration"},
					{"无限光芒","Unlimited Shine"},
					{"无限声纳","Unlimited Sonar"},
					{"无限召唤","Unlimited Summoning"},
					{"无限敏捷","Unlimited Swiftness"},
					{"无限荆棘","Unlimited Thorns"},
					{"无限踉跄","Unlimited Tipsy"},
					{"无限泰坦","Unlimited Titan"},
					{"无限温暖","Unlimited Warmth"},
					{"无限水上漂","Unlimited Water Walking"},
					{"无限酒足饭饱","Unlimited Major Well Fed"},
					{"无限很满意","Unlimited Well Fed"},
					{"无限吃得好","Unlimited Minor Well Fed"},
					{"无限虫洞","Unlimited Wormhole"},
					{"无限怒气","Unlimited Wrath"},
					{"无限弹药箱","Unlimited Ammo Box"},
					{"无限施法桌子","Unlimited Bewitching Table"},
					{"无限水晶球","Unlimited Crystal Ball"},
					{"无限利器站","Unlimited Sharpening Station"},
					{"无限蛋糕快","Unlimited Sliced Cake"},
					{"无限战争桌","Unlimited War Table"},
					{"无限向日葵","Unlimited Sunflower"},
					{"无限生物群系视觉","Unlimited Biome Sight"},
					{"橙","Orange"},
					{"橙绿","Lime"},
					{"青绿","Teal"},
					{"青","Cyan"},
					{"天蓝","Sky Blue"},
					{"紫","Purple"},
					{"蓝紫","Violet"},
					{"粉","Pink"},
					{"深红","Deep Red"},
					{"深橙","Deep Orange"},
					{"深黄","Deep Yellow"},
					{"深橙绿","Deep Lime"},
					{"深绿","Deep Green"},
					{"深青绿","Deep Teal"},
					{"深青","Deep Cyan"},
					{"深天蓝","Deep Sky Blue"},
					{"深蓝","Deep Blue"},
					{"深紫","Deep Purple"},
					{"深蓝紫","Deep Violet"},
					{"深粉","Deep Pink"},
					{"黑","Black"},
					{"白","White"},
					{"灰","Gray"},
					{"棕","Brown"},
					{"暗影","Shadow"},
					{"反色","Negative"},
					{"物块涂色","Paint Tiles"},
					{"墙壁涂色","Paint Walls"},
					{"移除油漆","Remove Paint"},
					{"绿溶液","Green Solution"},
					{"紫溶液","Purple Solution"},
					{"红溶液","Red Solution"},
					{"深蓝溶液","Dark Blue Solution"},
					{"蓝溶液","Blue Solution"},
					{"深绿溶液","Dark Green Solution"},
					{"冰雪溶液\n无法被环境改造枪使用","Snow/Ice Solution\nNot used with Clentaminator"},
					{"地狱溶液\n无法被环境改造枪使用","Hell Solution\nNot used with Clentaminator"},
					{"云溶液\n无法被环境改造枪使用","Cloud Solution\nNot used with Clentaminator"},
					{"整格物块","Full Block"},
					{"半格物块","Half Block"},
					{"左上","Up and Right"},
					{"右上","Up and Left"},
					{"左下","Down and Right"},
					{"右下","Down and Left"},
					{"激活/未激活","Active/Inactive"},
					{"物块放置间隔","Gap Between Blocks"},
					{"极限战争\n覆盖极限和平\n在FTW世界中不生效","Ultimate Battler\nOverrides Ultimate Peaceful\nDoes not work on For the Worthy"},
					{"极限和平\n在FTW世界中不生效","Ultimate Peaceful\nDoes not work on For the Worthy"},
					{"重力控制","Gravity Control"},
					{"羽落","Featherfall"},
					{"炼狱药水可视化","Inferno Visual"},
					{"隐形","Invisibility"},
					{"宝匣","Crate Potion"},
					{"洞穴探险","Spelunker"},
					{"危险感知&猎人","Danger and Hunter"},
					{"猩红","Crimson"},
					{"腐化","Corruption"},
					{"冰原","Ice"},
					{"丛林","Jungle"},
					{"发光蘑菇","Mushroom"},
					{"神圣","Hallow"},
					{"猩红冰原","Crimson Ice"},
					{"腐化冰原","Corruption Ice"},
					{"神圣冰原","Hallow Ice"},
					{"超强吸收绵","Multi-purpose Sponge"},
					{"水桶","Water Bucket"},
					{"岩浆桶","Lava Bucket"},
					{"蜂蜜桶","Honey Bucket"},
					{"微光桶","Shimmer Bucket"},
					{"钓鱼池构建","Fishing Pool Builder"},
				});
				#endregion miningcracks_take_on_luiafk.UI.ButtonBox


				#region miningcracks_take_on_luiafk.UI.OtherItemUIs.ComboRodUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.OtherItemUIs.ComboRodUI", ".ctor", new ()
				{
					{"涂色模式","Paint Mode"},
					{"墙壁模式","Wall Mode"},
					{"物块模式","Tile Mode"},
					{"电线模式","Wire Mode"},
					{"桶模式","Bucket Mode"},
				});
				#endregion miningcracks_take_on_luiafk.UI.OtherItemUIs.ComboRodUI


				#region miningcracks_take_on_luiafk.UI.OtherItemUIs.HouseUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.OtherItemUIs.HouseUI", ".ctor", new ()
				{
					{"灯 开/关","Lights On/Off"},
				});
				#endregion miningcracks_take_on_luiafk.UI.OtherItemUIs.HouseUI


				#region miningcracks_take_on_luiafk.UI.OtherItemUIs.MultiSolutionUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.OtherItemUIs.MultiSolutionUI", "AreaText", new ()
				{
					{"在你转换前\n必须选择2个位置","You must click 2 locations\nbefore you can convert."},
					{"转换矩阵顶点位于：\n","Convert rectangle at:\n"},
				});
				#endregion miningcracks_take_on_luiafk.UI.OtherItemUIs.MultiSolutionUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.ArenaBuilderUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.ArenaBuilderUI", ".ctor", new ()
				{
					{"灯 开/关","Light On/Off"},
					{"放置篝火和泡泡","Place Campfires and Bubbles"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.ArenaBuilderUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.BuildingMaterialsUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.BuildingMaterialsUI", ".ctor", new ()
				{
					{"灯 开/关","Light On/Off"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.BuildingMaterialsUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.FishingBiomeUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.FishingBiomeUI", ".ctor", new ()
				{
					{"灯 开/关","Light On/Off"},
					{"墙壁 打开/关闭","Walls On/Off"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.FishingBiomeUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.HellevatorUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.HellevatorUI", ".ctor", new ()
				{
					{"灯 开/关","Light On/Off"},
					{"地狱电梯的绳索","Rope In Hellevator"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.HellevatorUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.PoolBuilderUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.PoolBuilderUI", ".ctor", new ()
				{
					{"墙壁 打开/关闭","Walls On/Off"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.PoolBuilderUI


				#region miningcracks_take_on_luiafk.UI.AutoBuilderUIs.SubAndSkyUI
				TranslatorLoad.LocalizeByTypeFullName("miningcracks_take_on_luiafk.UI.AutoBuilderUIs.SubAndSkyUI", ".ctor", new ()
				{
					{"灯 开/关","Light On/Off"},
					{"墙壁 打开/关闭","Walls On/Off"},
					{"世界轨道构建\n再次点击切换为平台构建","Minecart Builder\nClick again for Platforms"},
					{"世界平台构建\n再次点击切换为轨道构建","Platform Builder\nClick again for Minecart"},
				});
				#endregion miningcracks_take_on_luiafk.UI.AutoBuilderUIs.SubAndSkyUI


			}
		}
	}
}
