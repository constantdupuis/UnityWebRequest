// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System;

[Serializable]
public class JSONPlaceHolderAddress
{
    public string street;
    public string suite;
    public string city;
    public string zipcode;
    public JSONPlaceHolderGeo geo;
}

[Serializable]
public class JSONPlaceHolderGeo
{
    public string lat;
    public string lng;
}

[Serializable]
public class JSONPlaceHolderUser
{
    public int id;
    public string name;
    public string username;
    public string email;
    public JSONPlaceHolderAddress address;
}

