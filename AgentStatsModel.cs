//By Ronny Berglihn Reinertsen <ronny@reinertsen.net> 05.11.2019
using System.Runtime.Serialization;
using ServiceStack.Text;

namespace FSKristiansandWebLib.Prime
{

	public static class AgentStatsModelExt
	{
		public static string ConverToJson(this AgentStatsModel model)
		{
			return JsonSerializer.SerializeToString(model);
		}
	}

	[DataContract]
	public class AgentStatsModel
	{
		[DataMember(Name = "Time Span")]
		public string TimeSpan { get; set; }
		[DataMember(Name = "Agent Name")]
		public string AgentName { get; set; }
		[DataMember(Name = "Agent Faction")]
		public string AgentFaction { get; set; }
		[DataMember(Name = "Date (yyyy-mm-dd)")]
		public string Date { get; set; }
		[DataMember(Name = "Time (hh:mm:ss)")]
		public string Time { get; set; }
		[DataMember(Name = "Level")]
		public int Level { get; set; }
		[DataMember(Name = "Lifetime AP")]
		public long LifetimeAP { get; set; }
		[DataMember(Name = "Current AP")]
		public long CurrentAP { get; set; }
		[DataMember(Name = "Unique Portals Visited")]
		public int UniquePortalsVisited { get; set; }
		[DataMember(Name = "Portals Discovered")]
		public int PortalsDiscovered { get; set; }
		[DataMember(Name = "XM Collected")]
		public long XMCollected { get; set; }
		[DataMember(Name = "OPR Agreements")]
		public int OPRAgreements { get; set; }
		[DataMember(Name = "Distance Walked")]
		public int DistanceWalked { get; set; }
		[DataMember(Name = "Resonators Deployed")]
		public int ResonatorsDeployed { get; set; }
		[DataMember(Name = "Links Created")]
		public int LinksCreated { get; set; }
		[DataMember(Name = "Control Fields Created")]
		public int ControlFieldsCreated { get; set; }
		[DataMember(Name = "Mind Units Captured")]
		public long MindUnitsCaptured { get; set; }
		[DataMember(Name = "Longest Link Ever Created")]
		public long LongestLinkEverCreated { get; set; }
		[DataMember(Name = "Largest Control Field")]
		public long LargestControlField { get; set; }
		[DataMember(Name = "XM Recharged")]
		public long XMRecharged { get; set; }
		[DataMember(Name = "Portals Captured")]
		public long PortalsCaptured { get; set; }
		[DataMember(Name = "Portals Captured")]
		public long UniquePortals { get; set; }
		[DataMember(Name = "Unique Portals Captured")]
		public long UniquePortalsCaptured { get; set; }
		[DataMember(Name = "Mods Deployed")]
		public long ModsDeployed { get; set; }
		[DataMember(Name = "Resonators Destroyed")]
		public long ResonatorsDestroyed { get; set; }
		[DataMember(Name = "Portals Neutralized")]
		public long PortalsNeutralized { get; set; }
		[DataMember(Name = "Enemy Links Destroyed")]
		public long EnemyLinksDestroyed { get; set; }
		[DataMember(Name = "Enemy Fields Destroyed")]
		public long EnemyFieldsDestroyed { get; set; }
		[DataMember(Name = "Max Time Portal Held")]
		public long MaxTimePortalHeld { get; set; }
		[DataMember(Name = "Max Time Link Maintained")]
		public long MaxTimeLinkMaintained { get; set; }
		[DataMember(Name = "Max Link Length x Days")]
		public long MaxLinkLengthxDays { get; set; }
		[DataMember(Name = "Max Time Field Held")]
		public long MaxTimeFieldHeld { get; set; }
		[DataMember(Name = "Largest Field MUs x Days")]
		public long LargestFieldMUsxDays { get; set; }
		[DataMember(Name = "Unique Missions Completed")]
		public long UniqueMissionsCompleted { get; set; }
		[DataMember(Name = "Hacks")]
		public long Hacks { get; set; }

		[DataMember(Name = "Glyph Hack Points")]
		public long GlyphHackPoints { get; set; }
		[DataMember(Name = "Longest Hacking Streak")]
		public long LongestHackingStreak { get; set; }

		[DataMember(Name = "Agents Successfully Recruited")]
		public long AgentsSuccessfullyRecruited { get; set; }
		[DataMember(Name = "First Saturday Events")]
		public long FirstSaturdayEvents { get; set; }

	}
}
