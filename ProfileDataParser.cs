//By Ronny Berglihn Reinertsen <ronny@reinertsen.net> 05.11.2019
using System;
using System.Linq;
using System.Runtime.Serialization;


namespace FSKristiansandWebLib.Prime
{
	public static class ProfileDataParser
	{
		/// <summary>
		/// Convert from uploaded profile to object
		/// </summary>
		/// <param name="data">Uploaded profile data</param>
		/// <returns>AgentStatsModel object</returns>
		public static AgentStatsModel ParseData(string data)
		{
			var retVal = new AgentStatsModel();

			if (data.IndexOf((char)0x0a) == -1)
				return retVal;
						

			string[] dataLines = data.Split(new char[] { (char)0x0a });
			string[] columns = dataLines[0].Split('\t');

			if (dataLines.Length > 1)
			{
				string[] rows = dataLines[1].Split('\t');
				for (int i = 0; i < columns.Length; ++i)
				{
					if (!string.IsNullOrEmpty(columns[i]))
						SetField(ref retVal, columns[i], rows[i]);
				}
			}

			return retVal;
		}

		/// <summary>
		/// Set data on variables using reflection to get attribute name
		/// </summary>
		/// <param name="model">AgentStatsModel</param>
		/// <param name="propName">Property name</param>
		/// <param name="value">Property value</param>
		public static void SetField(ref AgentStatsModel model, string propName, object value)
		{
			if (string.IsNullOrWhiteSpace(propName)) return;

			var propertiesWithAttribute = typeof(AgentStatsModel).GetProperties()
				 .Select(pi => new { Property = pi, Attribute = pi.GetCustomAttributes(typeof(DataMemberAttribute), true).FirstOrDefault() as DataMemberAttribute })
				 .Where(x => x.Attribute != null)
				 .ToList();


			var findProperty = propertiesWithAttribute.Where(p => p.Attribute.Name == propName).FirstOrDefault().Property;

			if (findProperty != null)
			{
				findProperty.SetValue(model, Convert.ChangeType(value, findProperty.PropertyType));
				return;
			}
			else
			{
				//Log item not found... We need to add support for it in our AgentStatsModel class
				LogHelper.Warn($"ProfileDataParser>SetField>Missing data column property for '{propName}'");
			}

		}


	}
}
