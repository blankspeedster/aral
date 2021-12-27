using System.Collections;
using System.Collections.Generic;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using UnityEngine;

public class SampleScore : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {   
        int user_id = 1;
        int subject = 1;
        int score = 1000;
        string url = $"http://aral.jjjwelry.com/process_section.php?publish_score=1&user_id={user_id}&subject={subject}&score={score}";
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(url),
            Headers =
            {
                { "Accept", "application/json" },
            },
            Content = new StringContent("")
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
            }
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Debug.Log(body);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
