using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ProjectApp
{
	public static class ErrorHandler
	{
		public static string ExtractErrorMessage(string jsonResponse)
		{
			try
			{
				var errorObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);
				return errorObject.ContainsKey("message") ? errorObject["message"] : jsonResponse;
			}
			catch
			{
				return jsonResponse; // return raw response if JSON parsing fails
			}
		}
	}
}
