//By Ronny Berglihn Reinertsen <ronny@reinertsen.net> 05.11.2019
using System.Runtime.Serialization;
using ServiceStack.Text;
using FSKristiansandWebLib.Attributes;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System;

namespace FSKristiansandWebLib.Prime
{

	public static class AgentStatsModelExt
	{

		/// <summary>
		/// Another way to de-serialize from json string
		/// </summary>
		/// <param name="jsonData"></param>
		/// <returns></returns>
		private static AgentStatsModel DataContractConvertFromJson(this string jsonData)
		{

			using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonData)))
			{
				var serializer = new DataContractJsonSerializer(typeof(AgentStatsModel));
				return (AgentStatsModel)serializer.ReadObject(ms);
			}

		}

		/// <summary>
		/// Another way to serialize to Json string
		/// </summary>
		/// <param name="model"></param>
		/// <returns></returns>
		public static string DataContractConvertToJson(this AgentStatsModel model)
		{

			DataContractJsonSerializer _dataContractJsonSerializer = new DataContractJsonSerializer(typeof(AgentStatsModel));
			using (MemoryStream stream1 = new MemoryStream())
			{
				_dataContractJsonSerializer.WriteObject(stream1, model);
				stream1.Position = 0;
				using (var sr = new StreamReader(stream1))
				{
					return sr.ReadToEnd();
				}

			}
		}

		public static string ConvertToJson(this AgentStatsModel model)
		{
			return JsonSerializer.SerializeToString(model);			
		}

		public static AgentStatsModel ConverFromJson(this string jsonData)
		{
			return JsonSerializer.DeserializeFromString<AgentStatsModel>(jsonData);
		}

	}

	[DataContract]
	public class AgentStatsModel
	{
		[FSProfile(Name = "TimeSpan")]
		[DataMember(Name = "Time Span")]
		public string TimeSpan { get; set; }

		[FSProfile(Name = "AgentName")]
		[DataMember(Name = "Agent Name")]
		public string AgentName { get; set; }

		[FSProfile(Name = "AgentFaction")]
		[DataMember(Name = "Agent Faction")]
		public string AgentFaction { get; set; }

		[FSProfile(Name = "Date")]
		[DataMember(Name = "Date (yyyy-mm-dd)")]
		public string Date { get; set; }

		[FSProfile(Name = "Time")]
		[DataMember(Name = "Time (hh:mm:ss)")]
		public string Time { get; set; }

		[FSProfile(Name = "Level")]
		[DataMember(Name = "Level")]
		public int Level { get; set; }

		[FSProfile(Name = "LifetimeAP")]
		[DataMember(Name = "Lifetime AP")]
		public long LifetimeAP { get; set; }

		[FSProfile(Name = "CurrentAP")]
		[DataMember(Name = "Current AP")]
		public long CurrentAP { get; set; }

		[FSProfile(Name = "UniquePortalsVisited")]
		[DataMember(Name = "Unique Portals Visited")]
		public int UniquePortalsVisited { get; set; }

		[FSProfile(Name = "PortalsDiscovered")]
		[DataMember(Name = "Portals Discovered")]
		public int PortalsDiscovered { get; set; }

		[FSProfile(Name = "XMCollected")]
		[DataMember(Name = "XM Collected")]
		public long XMCollected { get; set; }

		[FSProfile(Name = "OPRAgreements")]
		[DataMember(Name = "OPR Agreements")]
		public int OPRAgreements { get; set; }

		[FSProfile(Name = "DistanceWalked")]
		[DataMember(Name = "Distance Walked")]
		public int DistanceWalked { get; set; }

		[FSProfile(Name = "ResonatorsDeployed")]
		[DataMember(Name = "Resonators Deployed")]
		public int ResonatorsDeployed { get; set; }

		[FSProfile(Name = "LinksCreated")]
		[DataMember(Name = "Links Created")]
		public int LinksCreated { get; set; }

		[FSProfile(Name = "ControlFieldsCreated")]
		[DataMember(Name = "Control Fields Created")]
		public int ControlFieldsCreated { get; set; }

		[FSProfile(Name = "MindUnitsCaptured")]
		[DataMember(Name = "Mind Units Captured")]
		public long MindUnitsCaptured { get; set; }

		[FSProfile(Name = "LongestLinkEverCreated")]
		[DataMember(Name = "Longest Link Ever Created")]
		public long LongestLinkEverCreated { get; set; }

		[FSProfile(Name = "LargestControlField")]
		[DataMember(Name = "Largest Control Field")]
		public long LargestControlField { get; set; }

		[FSProfile(Name = "XMRecharged")]
		[DataMember(Name = "XM Recharged")]
		public long XMRecharged { get; set; }

		[FSProfile(Name = "PortalsCaptured")]
		[DataMember(Name = "Portals Captured")]
		public long PortalsCaptured { get; set; }


		[FSProfile(Name = "UniquePortalsCaptured")]
		[DataMember(Name = "Unique Portals Captured")]
		public long UniquePortalsCaptured { get; set; }

		[FSProfile(Name = "ModsDeployed")]
		[DataMember(Name = "Mods Deployed")]
		public long ModsDeployed { get; set; }

		[FSProfile(Name = "ResonatorsDestroyed")]
		[DataMember(Name = "Resonators Destroyed")]
		public long ResonatorsDestroyed { get; set; }

		[FSProfile(Name = "PortalsNeutralized")]
		[DataMember(Name = "Portals Neutralized")]
		public long PortalsNeutralized { get; set; }

		[FSProfile(Name = "EnemyLinksDestroyed")]
		[DataMember(Name = "Enemy Links Destroyed")]
		public long EnemyLinksDestroyed { get; set; }

		[FSProfile(Name = "EnemyFieldsDestroyed")]
		[DataMember(Name = "Enemy Fields Destroyed")]
		public long EnemyFieldsDestroyed { get; set; }

		[FSProfile(Name = "MaxTimePortalHeld")]
		[DataMember(Name = "Max Time Portal Held")]
		public long MaxTimePortalHeld { get; set; }

		[FSProfile(Name = "MaxTimeLinkMaintained")]
		[DataMember(Name = "Max Time Link Maintained")]
		public long MaxTimeLinkMaintained { get; set; }

		[FSProfile(Name = "MaxLinkLengthxDays")]
		[DataMember(Name = "Max Link Length x Days")]
		public long MaxLinkLengthxDays { get; set; }

		[FSProfile(Name = "MaxLinkLengthxDays")]
		[DataMember(Name = "Max Time Field Held")]
		public long MaxTimeFieldHeld { get; set; }

		[FSProfile(Name = "LargestFieldMUsxDays")]
		[DataMember(Name = "Largest Field MUs x Days")]
		public long LargestFieldMUsxDays { get; set; }

		[FSProfile(Name = "UniqueMissionsCompleted")]
		[DataMember(Name = "Unique Missions Completed")]
		public long UniqueMissionsCompleted { get; set; }

		[FSProfile(Name = "Hacks")]
		[DataMember(Name = "Hacks")]
		public long Hacks { get; set; }

		[FSProfile(Name = "GlyphHackPoints")]
		[DataMember(Name = "Glyph Hack Points")]
		public long GlyphHackPoints { get; set; }

		[FSProfile(Name = "LongestHackingStreak")]
		[DataMember(Name = "Longest Hacking Streak")]
		public long LongestHackingStreak { get; set; }

		[FSProfile(Name = "AgentsSuccessfullyRecruited")]
		[DataMember(Name = "Agents Successfully Recruited")]
		public long AgentsSuccessfullyRecruited { get; set; }

		[FSProfile(Name = "FirstSaturdayEvents")]
		[DataMember(Name = "First Saturday Events")]
		public long FirstSaturdayEvents { get; set; }

		[FSProfile(Name = "ProfileTimestamp")]
		[DataMember(Name = "ProfileTimestamp")]
		public DateTime ProfileTimestamp
		{
			get
			{
				if (string.IsNullOrEmpty(this.Date) || string.IsNullOrEmpty(this.Date))
					return default;

				string[] d = this.Date.Split('-');
				string[] t = this.Time.Split(':');
				return new DateTime(int.Parse(d[0]), int.Parse(d[1]), int.Parse(d[2]), int.Parse(t[0]), int.Parse(t[1]), int.Parse(t[2]));

			}
		}


	}
}
