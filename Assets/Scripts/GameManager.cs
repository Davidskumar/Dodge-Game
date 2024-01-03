using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameend = false;
    public float restartDelay = 1f;
    public GameObject completeui;

    public void CompleteLeve()
    {
        completeui.SetActive(true);

    }
    
    public void EndGame()
    {
        if(gameend == false)
        {
            gameend = true;
            Debug.Log("Game Over");
            Invoke("Restart",restartDelay);
        }
         

    }
    void Restart()
    {
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
