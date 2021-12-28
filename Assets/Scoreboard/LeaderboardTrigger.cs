using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
public class LeaderboardTrigger : MonoBehaviour
{

    public GameObject scoreboardCanvas;
    public GameObject inputCanvas;
    public Text leaderBoardText;
    public int subjectId;
    // Start is called before the first frame update
    void Awake()
    {
        scoreboardCanvas.gameObject.SetActive(false);
        
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            inputCanvas.gameObject.SetActive(false);
            scoreboardCanvas.gameObject.SetActive(true);
            LoadScoreBoard();
        }
    }

    public void CloseCanvas()
    {
        scoreboardCanvas.gameObject.SetActive(false);
        inputCanvas.gameObject.SetActive(true);
    }

    async void LoadScoreBoard(){
        string baseURL = PlayerPrefs.GetString("url");
        int _userId =  PlayerPrefs.GetInt("user_id");

        string message = null;

        string url = $"{baseURL}/process_section.php?score_board={subjectId}&userId={_userId}";

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

        leaderBoardText.text = message;
    }

   
}
