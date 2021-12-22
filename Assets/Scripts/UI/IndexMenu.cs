using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IndexMenu : MonoBehaviour
{

    public void Return() {
        SceneManager.LoadScene("Menu");
    }
   
    public void Content01() {
        SceneManager.LoadScene("SolarSystem");
        Debug.Log("Scene Loaded~");
    }
    public void Content02() {
        SceneManager.LoadScene("AlphabetGame");
        Debug.Log("Scene Loaded~");
    }

        public void Content03() {
        SceneManager.LoadScene("ColorMe");
        Debug.Log("Scene Loaded~");
    }
    public void Content04() {
        SceneManager.LoadScene("Quiz");
        Debug.Log("Scene Loaded~");
    }
    public void Content05() {
        SceneManager.LoadScene("MemoryGame");
        Debug.Log("Scene Loaded~");
    }
    public void Content06() {
        SceneManager.LoadScene("3D Alphabet Museum");
        Debug.Log("Scene Loaded~");
    }
    public void Content07() {
        SceneManager.LoadScene("3D Coloring Game");
        Debug.Log("Scene Loaded~");
    }
}
