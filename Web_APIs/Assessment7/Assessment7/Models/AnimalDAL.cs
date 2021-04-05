using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

public class AnimalDAL
{
	public string GetAnimalData()
    {
        string url = $"https://gc-zoo.surge.sh/api/animals";

        HttpWebRequest request = WebRequest.CreateHttp(url);
        HttpWebResponse response = null;

        response = (HttpWebResponse)request.GetResponse();
        StreamReader rd = new StreamReader(response.GetResponseStream());
        string json = rd.ReadToEnd();
        return json;
    }
    public List<Result> GetAnimals()
    {
        string animalsList = GetAnimalData();
        AnimalRoot r = JsonConvert.DeserializeObject<AnimalRoot>(animalsList);
        List<Result> results = r.results.ToList();
        return results;
    }

    public string GetSpeciesData(string SpeciesName)
    {
        string url = $"https://gc-zoo.surge.sh/api/species/{SpeciesName}";

        HttpWebRequest request = WebRequest.CreateHttp(url);
        HttpWebResponse response = null;

        response = (HttpWebResponse)request.GetResponse();
        StreamReader rd = new StreamReader(response.GetResponseStream());
        string json = rd.ReadToEnd();
        return json;
    }

    public SpeciesRoot GetSpecies(string SpeciesName)
    {
        string species = GetSpeciesData(SpeciesName);
        SpeciesRoot r = JsonConvert.DeserializeObject<SpeciesRoot>(species);
        return r;
    }
}
