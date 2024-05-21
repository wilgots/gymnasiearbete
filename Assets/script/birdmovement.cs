using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class birdmovement : MonoBehaviour
{

    // Hastighet och rotationshastighet för objektet, satta i Unity-editorn.
    private float fagelhopphastighet = 2.5f;
    float tiltangle = 30f;
    float smooth = 20f;
    

    // Rigidbody-komponenten för att hantera fysikbeteendet.
    [SerializeField] private Rigidbody2D fagel;
    public GameManager gamemanager;
    public AudioSource Audio;
    public AudioClip flaxa, slåi, poäng;

    // Start anropas före första bildrutan.
    void Start()
    {
        
    }

    // Update anropas en gång per bildruta.
    void Update()
    {
        // Kontrollera om jumpknappen trycktes ned i den här bildrutan.
        if (Input.GetButtonDown("Jump"))
        {
            // Sätt fågelns hastighet uppåt när jumpknappen trycks ned.
            fagel.velocity = new Vector2(0, fagelhopphastighet);
            Audio.clip = flaxa;
            Audio.Play();
        }



        float tiltaroundz = fagel.velocity.y * tiltangle;

        Quaternion target = Quaternion.Euler(0, 0, tiltaroundz);

        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
    }

   

    // när collision sker
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Anropa Gameover i gamemanager genom gamemanager variablen.
        gamemanager.Gameover();
        Audio.clip = slåi;
        Audio.Play();
    }

    // om fågeln kör in i vår trigger i rörets gap
    private void OnTriggerEnter2D(Collider2D collision)
    {  //Kalla på addscore
        Score.addscore();
        Audio.clip = poäng;
        Audio.Play();
    }
}
