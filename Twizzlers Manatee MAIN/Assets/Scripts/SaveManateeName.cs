using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SaveManateeName : MonoBehaviour
{
    //public GameObject name1;
    //public GameObject name2;
    public GameObject canvas1;
    public string manateeName;

    /*
    private void Awake()
    {
        DontDestroyOnLoad(this);
        //SceneManager.LoadScene(1);
    }
    */

    //SceneManager.LoadScene("Simulation", LoadSceneMode.Single);
    //GameObject.Find("Dioxygen").SetActive(false);

    void Start()
    {
        //GameObject.Find("canvas1").SetActive(false);
        //GameObject.Find("canvas2").SetActive(false);
        //DontDestroyOnLoad(GameObject.Find("canvas1"));
        //DontDestroyOnLoad(canvas1);
    }


    public void NameFirstManatee()
    {
        GameObject.Find("canvas1").SetActive(true);
        GameObject.Find("canvas2").SetActive(false);
        Debug.Log("Name picked: canvas1");
    }

    public void name(string manateeName)
    {
        this.manateeName = ("HarunAbi");
    }
}
