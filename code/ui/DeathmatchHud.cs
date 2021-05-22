﻿
using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;
using System;
using System.Threading.Tasks;

namespace Element.UI
{

	[Library]
	public partial class DeathmatchHud : HudEntity<RootPanel>
	{
		public DeathmatchHud()
		{
			if ( !IsClient )
				return;

			RootPanel.StyleSheet.Load( "/ui/DeathmatchHud.scss" );

			RootPanel.AddChild<VitalsInfo>();
			RootPanel.AddChild<WeaponInfo>();
			RootPanel.AddChild<HeroInfo>();

			RootPanel.AddChild<NameTags>();
			RootPanel.AddChild<DamageIndicator>();
			RootPanel.AddChild<HitIndicator>();

			RootPanel.AddChild<InventoryBar>();
			RootPanel.AddChild<PickupFeed>();

			RootPanel.AddChild<ChatBox>();
			RootPanel.AddChild<KillFeed>();
			RootPanel.AddChild<Scoreboard>();
			RootPanel.AddChild<VoiceList>();
		}

		[ClientRpc]
		public void OnPlayerDied( string victim, string attacker = null )
		{
			Host.AssertClient();
		}

		[ClientRpc]
		public void ShowDeathScreen( string attackerName )
		{
			Host.AssertClient();
		}
	}
}
