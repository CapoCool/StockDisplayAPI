using Newtonsoft.Json;

namespace StockDisplayAPI
{
	public class PolygonIOModel
	{
		[JsonProperty("adjusted")]
		string adjusted = string.Empty;

		[JsonProperty("next_url")]
		string next_url = string.Empty;

		[JsonProperty("queryCount")]
		string queryCount = string.Empty;

		[JsonProperty("request_id")]
		string request_id = string.Empty;

		[JsonProperty("results")]
		List<Results> results = new List<Results>();

		[JsonProperty("resultsCount")]
		string resultsCount = string.Empty;

		[JsonProperty("status")]
		string status = string.Empty;

		[JsonProperty("ticker")]
		string ticker = string.Empty;
	}
}
