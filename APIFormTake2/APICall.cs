using System;
using System.Collections.Generic;

public class APICall
{
	# region Variables
    string group;
	string name;
	string description;
	public enum Type
	{
		GET,
		PUT,
		POST,
		DELETE
	}
	#endregion

	#region Properties
    public string Category
		{
			get
			{
				return group;
			}
			set
			{
				group = value;
			}
		}
		public string Title
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public string Info
		{
			get
			{
				return description;
			}
			set
			{
				description = value;
			}
		}
    #endregion

    #region Constructors
    public APICall(string groupName, string methodName, string descText, Type callType)
	{
		group = groupName;
		name = methodName;
		description = descText;
	}
    #endregion
}
