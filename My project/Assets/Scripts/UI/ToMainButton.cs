using System;
using System.Collections;
using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainButton : MonoBehaviour
{
    public void OnMouseDown()
    {
        var pause = Resources.FindObjectsOfTypeAll<Pause>()[0].gameObject;
        pause.SetActive(true);
        pause.GetComponent<SpriteRenderer>().sprite = pause.GetComponent<ObjectActivation>().idleSprite;
        GameState.Paused = false;
        if (SceneManager.GetActiveScene().name == "phone")
        {
            GameState.Money += GameObject.Find("OK").GetComponent<PhoneOkButton>().servicesPrice;
            GameState.LastScene = "main";
            SceneManager.LoadScene("main");
        }
        else
        {
            GameState.LastScene = "main";
            SceneManager.LoadScene("main");
        }
    }
}
