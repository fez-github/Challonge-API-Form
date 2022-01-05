using System;
using System.Collections.Generic;

namespace APIFormTake2
{
	public class APIIndexTournament : APITemplate
	{
		public APIIndexTournament()
        {
			AddParameterInfo();
        }

		/// <summary>
		/// Add parameter names and their descriptions.
		/// </summary>
		override protected void AddParameterInfo()
		{
			name = "IndexTournament";
			method = "GET";
			url = "https://api.challonge.com/v1";
			resource = "tournaments";

			paramName.Add("state");
			paramName.Add("type");
			paramName.Add("created_after");
			paramName.Add("created_before");
			paramName.Add("subdomain");

			paramDescription.Add("all, pending, in_progress, ended");
			paramDescription.Add("single elimination, double elimination, round robin, swiss");
			paramDescription.Add("YYYY-MM-DD");
			paramDescription.Add("YYYY-MM-DD");
			paramDescription.Add("A Challonge subdomain you've published tournaments to.  NOTE: Until v2 of our API, " +
				"the subdomain parameter is required to retrieve a list of your organization-hosted tournaments");
		}
	}
}
