using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MyGameEvent : MonoBehaviour
{

    public GameObject menu;
    public MouseFollow mf;
    public AudioSource music;
    private void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menu)
        {
            if (menu.activeInHierarchy)
            {
                menu.SetActive(false);
                Time.timeScale = 1;
                mf.control = true;
                music.pitch = 1;
            }
            else
            {
                menu.SetActive(true);
                Time.timeScale = 0;
                mf.control = false;
                music.pitch = 0;
            }
        }
    }
}
