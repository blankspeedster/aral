using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;

    
   public void Pause() {
       pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        print("Paused");

   }

   public void Resume() {
       
       pauseMenu.SetActive(false);
       Time.timeScale = 1f;
       print("Resumed");
       
   }

   public void Restart() {
       Time.timeScale = 1.0f;
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void Home() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu");
   }

   public void Alphabet() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("AlphabetGame");
   }

    public void Memory() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MemoryGame");
   }
    public void ColorMe() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("ColorMe");
   }
    public void CountingGame() {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Quiz");
   }

   public void Exit() {
       Application.Quit();
       Debug.Log("Game closed!");
   }
}
