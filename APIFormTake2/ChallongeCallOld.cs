using System;
using System.Collections.Generic;

public class ChallongeCallOld
{
	# region Variables
    string _group;
	string _name;
	string _description;

    public enum Type
	{
		GET,
		PUT,
		POST,
		DELETE
	}
	#endregion

	#region Properties
	
    public string Group { get => _group; set => _group = value; }
    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
	
	#endregion

	#region Constructors
	public ChallongeCallOld(string groupName, string methodName, string descText, Type callType)
	{
		Group = groupName;
		Name = methodName;
		Description = descText;
	}
    #endregion
}
