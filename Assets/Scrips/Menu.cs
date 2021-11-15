using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //"FindObjectOfType<AudioManager>().Play("bla bla");" och allt med animation skrivet av Theo
    public Animator animator;

    // skrivet av Markus

    // Options menu
    public GameObject optionsMenu;

    //bool options = false;

    // Pause menu
    public GameObject pauseMenu;
    bool pause = false;


    //-----------//Ska l�gga dit death scene saker senare efter man kan d�
    public GameObject deathMenu;
    bool death = false;

    // Start av scenen
    public void Start()
    {
        Time.timeScale = 1;
        //Hittar "AudioManager" scripten och anv�nder "Play" metoden f�r att spela ljudet/l�ten med namnet "Start Menu Music".
        FindObjectOfType<AudioManager>().Play("Start Menu Music");

        pause = false;
        pauseMenu.SetActive(false);
        

        optionsMenu.SetActive(false);
        

        deathMenu.SetActive(false);
        death = false;

    }


    public void Dead()
    {
        // Invoke g�r att functionen har en delay och siffran �r hur l�ng delayen �r
        Invoke("ReallyDead", 2);

        //Mute:ar gameplay-l�ten och spelar death-ljudeffekten n�r spelaren d�r.
        FindObjectOfType<AudioManager>().Mute("Gameplay Music");
        FindObjectOfType<AudioManager>().Play("Player Death");
    }

    public void ReallyDead()
    {
        deathMenu.SetActive(true);
        death = true;
        Time.timeScale = 0;
        //H�r spelas deathscreen-musiken.
        FindObjectOfType<AudioManager>().Play("Death Music");
    }

    // Pause Menu knapp

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pause == false)
            {
                pause = true;
                pauseMenu.SetActive(true);
                Time.timeScale = 0;
                //H�r mute:as gameplay-musiken och pausemeny-musiken spelas ist�llet. Detta sker n�r man trycker "escape" knappen, allts� pausar spelet.
                FindObjectOfType<AudioManager>().Mute("Gameplay Music");
                FindObjectOfType<AudioManager>().UnMute("Pause Music");
            }
            else
            {
                pause = false;
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                //H�r mute:as pausmusiken och gameplay-musiken unmute:as. 
                FindObjectOfType<AudioManager>().UnMute("Gameplay Music");
                FindObjectOfType<AudioManager>().Mute("Pause Music");
            }

        }

        if (death == true)
        {
            Time.timeScale = 0;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Dead();
        }
    }

    public void resume()
    {
        pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        //H�r mute:as pausmusiken och gameplay-musiken unmute:as.
        FindObjectOfType<AudioManager>().UnMute("Gameplay Music");
        FindObjectOfType<AudioManager>().Mute("Pause Music");
    }



    // Byte av scener med knapp

    public void start()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }

    public void goBack()
    {
        SceneManager.LoadScene("MenuScene");
    }


    // Options Menu knappar. Inte klart och id�en blev borttagen

    //---------------------------//
    public void settings()
    {
        optionsMenu.SetActive(true);
        //options = true;
    }
    public void editied()
    {
        optionsMenu.SetActive(false);
        //options = false;
    }


    //------------------------------//


    // Quit knapp

    public void Quit()
    {
        Application.Quit();
    }

}
