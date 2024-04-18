using Newtonsoft.Json;

namespace StockDisplayAPI
{
	public class Results
	{
		[JsonProperty("c")]
		string closing = string.Empty;

		[JsonProperty("h")]
		string high = string.Empty;

		[JsonProperty("l")]
		string low = string.Empty;

		[JsonProperty("n")]
		string numberOfTransactions = string.Empty;

		[JsonProperty("o")]
		string open = string.Empty;

		[JsonProperty("t")]
		string unixMsecTimeStamp = string.Empty;

		[JsonProperty("v")]
		string volume = string.Empty;

		[JsonProperty("vw")]
		string volumeWeighted = string.Empty;
	}
}
