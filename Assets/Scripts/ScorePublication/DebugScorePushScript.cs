using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using UnityEngine.UI;
public class DebugScorePushScript : MonoBehaviour
{
    // 1 - colors, 2 - numbers, 3 - alphabets, 4 - shapes
    public InputField colors, numbers, alphabets, shapes;
    public Text messageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //To push scores for colors
    async public void publishScoreColors(){
        string baseURL = PlayerPrefs.GetString("url");
        int _userId =  PlayerPrefs.GetInt("user_id");

        string message = null;

        string url = $"{baseURL}/process_section.php?push_color=1&userId={_userId}&score={colors.text}";

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
            message = body;   
        }

       messageText.text = message;
    }

    //To push scores for numbers
    async public void publishScoreNumbers(){
        string baseURL = PlayerPrefs.GetString("url");
        int _userId =  PlayerPrefs.GetInt("user_id");

        string message = null;

        string url = $"{baseURL}/process_section.php?push_numbers=2&userId={_userId}&score={numbers.text}";

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
            message = body;   
        }

       messageText.text = message;
    }

    //To push scores for shapes
    async public void publishScoreAlphabets(){
        string baseURL = PlayerPrefs.GetString("url");
        int _userId =  PlayerPrefs.GetInt("user_id");

        string message = null;

        string url = $"{baseURL}/process_section.php?push_alphabets=3&userId={_userId}&score={alphabets.text}";

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
            message = body;   
        }

       messageText.text = message;
    }

    //To push scores for shapes
    async public void publishScoreShapes(){
        string baseURL = PlayerPrefs.GetString("url");
        int _userId =  PlayerPrefs.GetInt("user_id");

        string message = null;

        string url = $"{baseURL}/process_section.php?push_shapes=4&userId={_userId}&score={shapes.text}";

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
            message = body;   
        }

       messageText.text = message;
    }
}
