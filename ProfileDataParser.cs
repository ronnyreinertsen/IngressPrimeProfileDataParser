//By Ronny Berglihn Reinertsen <ronny@reinertsen.net> 05.11.2019
using System;
using System.Linq;
using System.Runtime.Serialization;


namespace FSKristiansandWebLib.Prime
{
	public static class ProfileDataParser
	{
		public static AgentStatsModel ParseData(string data)
		{
			var retVal = new AgentStatsModel();

			string[] dataLines = data.Split(new char[] { (char)0x0a });

			string[] columns = dataLines[0].Split('\t');
			string[] rows = dataLines[1].Split('\t');
				
			for (int i = 0; i < columns.Length; ++i)
			{
				if (!string.IsNullOrEmpty(columns[i]))
					SetField(ref retVal, columns[i], rows[i]);
			}

			void SetField(ref AgentStatsModel model, string propName, object value)
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

			}

			return retVal;
		}


	}
}
