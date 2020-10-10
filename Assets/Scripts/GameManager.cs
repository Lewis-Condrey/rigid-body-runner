using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    bool gameover = false;
    public float restartDelay = 1f;
    public AudioSource audioSource;
    public float volume = 0.5f;
    public GameObject BnW;
    public GameObject completelevelUI;

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //SceneManager.LoadScene("theMenu");
        }
    }
    public void EndGame ()
    {
       
        if (gameover == false)
        {
            BnW.GetComponent<PostProcessVolume>().enabled = true;
            audioSource.PlayOneShot(audioSource.clip, volume);
            gameover = true;
            Invoke("Restart", restartDelay);
            
        }


    }

    public void CompleteLevel ()
    {
        completelevelUI.SetActive(true);
    }



    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
