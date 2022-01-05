using System;
using System.Collections.Generic;

namespace APIFormTake2
{
	public class APITemplate
	{
        protected string name;
        protected string method;
        protected string url;
        protected string resource;
        protected List<string> paramName;
        protected List<string> paramDescription;

        public string Name { get => name;}
        public string Method { get => method;}
        public string Url { get => url;}
        public string Resource { get => resource;}
        public List<string> ParamName { get => paramName;}
        public List<string> ParamDescription { get => paramDescription;}



        /// <summary>
        /// Add parameter names and their descriptions.
        /// </summary>
        virtual protected void AddParameterInfo()
        {

        }
	}

}
