using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Networking;

public class NewtonSoftTest : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(GetRequest("https://jsonplaceholder.typicode.com/users"));
    }

    // Update is called once per frame
    private void Update()
    {
    }

    private IEnumerator GetRequest(string uri)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
        {
            // Request and wait for the desired page.
            yield return webRequest.SendWebRequest();

            string[] pages = uri.Split('/');
            int page = pages.Length - 1;

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                    break;

                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                    break;

                case UnityWebRequest.Result.Success:
                    Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);

                    List<User> myDeserializedClass = JsonConvert.DeserializeObject<List<User>>(webRequest.downloadHandler.text);
               
                    if (myDeserializedClass != null)
                    {
                        Debug.Log($"{myDeserializedClass.Count} Users returned.");
                        myDeserializedClass.ForEach(x => Debug.Log($" Name: {x.name}"));
                        //Debug.Log($"User 0 = {res[0].name}");
                    }
                    else
                    {
                        Debug.Log("Error while parsing returned JSON :-(");
                    }

                    break;
            }
        }
    }
}