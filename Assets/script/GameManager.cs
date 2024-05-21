using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
    

    // en variabel till gameoverscreen som vi kopplar till ui genom unity inspektorn.
    public GameObject gameOverScreen;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Metod som ska anropas när spelet är över
    public void Gameover()
    {
        // Aktivera Game Over skärmen
        gameOverScreen.SetActive(true);

        // Pausa spelet
        Time.timeScale = 0;
    }

    
    public void Restart()
    {
        // Ladda buildindex dvs så det ser ut i början
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        Time.timeScale = 1;
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Mainmenuscene");
        Time.timeScale = 1;

    }

    public void Startgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
