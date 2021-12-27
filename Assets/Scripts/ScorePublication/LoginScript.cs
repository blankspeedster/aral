using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginScript : MonoBehaviour
{
    public InputField email, password;
    public Button loginButton;
    public Text errorText;
    public GameObject errorTextObject;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("url","http://localhost/aral-web-app/");
        errorTextObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(email.text == "" && password.text == ""){
            loginButton.enabled = false;
        }
        else{
            loginButton.enabled = true;
        }
    }

    public async void Login(){
        string baseURL = PlayerPrefs.GetString("url");
        string _email = email.text;
        string _password = password.text;

        string message = null;

        string url = $"{baseURL}process_registration.php?login_game=1&email={_email}&password={_password}";

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

        if(message == "not_validated"){
            errorText.text = "ending Validation!";
        }
        else if(message == "incorrect_credentials"){
            errorText.text = "Incorrent Credentials!";
            errorTextObject.SetActive(true);
        }
        else if(message == "email_not_found"){
            errorText.text = "Email not found!";
            errorTextObject.SetActive(true);
        }
        else{
            int id = Int32.Parse(message);
            PlayerPrefs.SetInt("user_id",id);
            Debug.Log("Validated!");
            errorTextObject.SetActive(true);
            SceneManager.LoadScene("Menu");
        }
    }
}
