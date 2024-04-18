using Newtonsoft.Json;
using StockDisplayAPI;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/StockInformation/{ticker}", (string ticker) => 
{
	const string KEY = "/range/1/day/2023-01-09/2023-01-20?adjusted=true&sort=asc&limit=120&apiKey=4ZRDH5eAgpcXn74vFSYbkfSPhvRhupM0";
	const string API_URL_FIRST = "https://api.polygon.io/v2/aggs/ticker/";
	HttpWebRequest request;
	HttpWebResponse response;
	Stream stream;
	StreamReader reader;
	string responseString;

	request = (HttpWebRequest)WebRequest.Create(API_URL_FIRST + ticker + KEY);
	response = (HttpWebResponse)request.GetResponse();
	stream = response.GetResponseStream();
	reader = new StreamReader(stream);
	responseString = reader.ReadToEnd();
	stream.Close();

	//PolygonIOModel polygonIOModel = JsonConvert.DeserializeObject<PolygonIOModel>(responseString);
	return responseString;
});

app.Run();
