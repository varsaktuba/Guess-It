using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LockSystem : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        LockScenes();
    }
    public Button[] buttons;
    public void OpenScenes(string scene_name)
    {
      SceneManager.LoadScene(scene_name);
    }
    public void LockScenes()
    {
        int scenes = PlayerPrefs.GetInt("scene");
        for (int i = 0; i < buttons.Length; i++)
        {
            if (scenes + 1 >= int.Parse(buttons[i].name))
            {
                buttons[i].interactable = true;
            }
            else
            {
                buttons[i].interactable = false;
            }
        }
    }
}
