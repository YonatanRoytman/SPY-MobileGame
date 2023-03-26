using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameEngine : MonoBehaviour
{
    public GameObject OpttionCanvas, GameCanvas, PlayerButton , p,p1,p2,p3,p4,p5,p6,p7,p8,p9 , PlayerPanel, SpyPanel , QuitPanel , Button1, Button2;
    public Text WorkPlaceText;

    string input;
    public string[] WorkPlaces;
    public int Players, spy;
    public bool twospies;


    void Start()
    {
        twospies = false;
        spy = 1;
        Players = 3;
        RandomPlace();
        Button1.GetComponent<Image>().color = Color.green;

    }

    void Update()
    {
        
    }


   public void Spy1()
    {
        twospies = false;
        Debug.Log("two spies " + twospies);
        spy = 1;
        if(twospies == false)
        {
            Button1.GetComponent<Image>().color = Color.green;
            Button2.GetComponent<Image>().color = Color.white;
        }
    }

    public void Spy2()
    {
        twospies = true;
        Debug.Log("two spies " + twospies);
        spy = 2;
        if (twospies == true)
        {
            Button1.GetComponent<Image>().color = Color.white;
            Button2.GetComponent<Image>().color = Color.green;
        }
    }

    public void HowManyPlayers(string s)
    {
        input = s;
        Players = int.Parse(input);
        Debug.Log(Players);
    }

    public void CreatePlayerButtons()
    {
        //Instantiate(PlayerButton);
        //GameObject newPlayerButton = Instantiate(PlayerButton, new Vector3(PlayerButton.transform.position.x, i * 2.0f, 0), Quaternion.identity) as GameObject;
       // newPlayerButton.transform.SetParent(GameCanvas.transform, true);

        /* for (int i = 0; i < Players; i++)
         {
            int a = i + 5;
             GameObject newPlayerButton = Instantiate(PlayerButton, new Vector3(5 , a - 80), Quaternion.identity) as GameObject;
         newPlayerButton.transform.SetParent(GameCanvas.transform, false);
         }*/
    }


    public void RandomPlayer()
    {
        if (twospies == false && Players > 0)
        {
         
               int randomNum = Random.Range(1, 11);
                if(randomNum < 4 && spy > 0 && Players > 0)
                {
                    spy--;
                    Players--;
                    Debug.Log("sus");
                    SpyPanel.SetActive(true);
                    
                }
                else if(spy > 0 && Players == 1)
                {
                spy--;
                Players--;
                Debug.Log("sus");
                SpyPanel.SetActive(true);

            }
            else
                {
                Players--;
                Debug.Log("Player");
                PlayerPanel.SetActive(true);
            }
        }
        if(twospies == true && Players > 0)
        {
            int randomNum = Random.Range(1, 11);
            if (randomNum < 4 && spy > 0)
            {
                spy--;
                Players--;
                Debug.Log("sus");
                SpyPanel.SetActive(true);

            }
            else if (spy == 1 && Players == 1)
            {
                spy--;
                Debug.Log("sus");
                Players--;
                SpyPanel.SetActive(true);

            }
            else if(spy == 2 && Players == 2)
            {
                spy--;
                Debug.Log("sus");
                Players--;
                SpyPanel.SetActive(true);

            }
            else
            {
                Players--;
                Debug.Log("Player");
                PlayerPanel.SetActive(true);
            }
        }
       // gameObject.SetActive(false);
    }

    public void StartGame()
    {
        if (Players > 2 && Players < 11)
        {
            OpttionCanvas.SetActive(false);
            GameCanvas.SetActive(true);
            SpwanPlayers();
            CreatePlayerButtons();
        }


    }
    public void SpwanPlayers()
    {
        if(Players == 3)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);

        }
        else if (Players == 4)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);

        }
        else if (Players == 5)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);

        }
        else if (Players == 6)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);

        }
        else if (Players == 7)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);
            p6.SetActive(true);

        }
        else if (Players == 8)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);
            p6.SetActive(true);
            p7.SetActive(true);


        }
        else if (Players == 9)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);
            p6.SetActive(true);
            p7.SetActive(true);
            p8.SetActive(true);

        }
        else if (Players == 10)
        {
            p.SetActive(true);
            p1.SetActive(true);
            p2.SetActive(true);
            p3.SetActive(true);
            p4.SetActive(true);
            p5.SetActive(true);
            p6.SetActive(true);
            p7.SetActive(true);
            p8.SetActive(true);
            p9.SetActive(true);

        }
    }

    public void RandomPlace()
    {
       string randomWorkPlace = WorkPlaces[Random.Range(0, WorkPlaces.Length)];
        WorkPlaceText.text = randomWorkPlace;
        
    }

    public void CloseSP()
    {
        SpyPanel.SetActive(false);
    }
    public void ClosePP()
    {
        PlayerPanel.SetActive(false);
    }

    public void EndGame()
    {
        //  GameCanvas.SetActive(false);
        //OpttionCanvas.SetActive(true);
        SceneManager.LoadScene(0);
        
    }


    public void OpenQuitMenu()
    {
        QuitPanel.SetActive(true);
        OpttionCanvas.SetActive(false);
    }
    public void closeQuitMenu()
    {
        QuitPanel.SetActive(false);
        OpttionCanvas.SetActive(true);
    }
    public void Quitgame()
    {
        Application.Quit();
    }

}
