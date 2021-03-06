using System.Collections.Generic;
using Game;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Clients
{
    public class Police : MonoBehaviour
    {
        public void Start()
        {
            if (GameState.CurrentCustomer.Name != "Cop")
                return;
            
            GameObject.Find("Music").GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("PoliceSirens");
            GameObject.Find("Music").GetComponent<AudioSource>().Play();
            
            ClientSprite.Appeared = false;
            GetComponent<ClientSprite>().Appear();
            
            GetComponent<DialogueWindow>().talked = false;
            if (!GameState.FalseCall)
            {
                Dialogues.OrderDict["Cop"] = new List<string>
                {
                    "Благодарим за поимку опасного преступника!",
                    "Вам полагается вознаграждение в 100$"
                };
                GameState.Money += 100;
                GameState.Score += 3;
            }
            else
            {
                Dialogues.OrderDict["Cop"] = new List<string>
                {
                    "Ложный вызов. Вы оштрафованы на 50$"
                };
                GameState.Money -= 50;
                if (GameState.Money <= 0)
                {
                    SceneManager.LoadScene("game over");
                    GameState.LastScene = "game over";
                }
            }
        }
    }
}