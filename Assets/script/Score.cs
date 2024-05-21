using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    

   
    public Text ScoreText;

    public Text HighScore;

    // Variabel för att hålla reda på aktuell poäng.
    static float Poäng;
    public float highscore;

   

   
    
        
    

    //static så man kan kalla på den
    public static void addscore()
    {
        // Öka poängen med 1.
        Poäng++;

        
    }

 
    void Start()
    {
        
        
        // ge highscore det sparade värdet för highscore från tidigare spelrundor
        highscore = PlayerPrefs.GetFloat("HighScore");
        // återställ poängen.
        Poäng = 0; 
    
    }

    

    
    void Update()
    {
        // uppdatera scoretext och highscoretext varje frame
        ScoreText.text = Poäng.ToString();
        HighScore.text = PlayerPrefs.GetFloat("HighScore").ToString();

        //kolla om highscore slagits
        if (Poäng > highscore)
        {
            // sätt vårt sparade värde till poängens värde därmed blir highscore uppdaterat
            PlayerPrefs.SetFloat("HighScore", Poäng);

        }
        
    }
}