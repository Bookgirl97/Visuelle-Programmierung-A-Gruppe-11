using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHiddenText : MonoBehaviour
{

    public Text textz;

    // Use this for initialization
    void Start()
    {
        textz = GameObject.Find("Textx").GetComponent<Text>();
        textz.color = Color.clear;
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void FirstColor()
    {

        textz.color = Color.clear;

    }
    public void GetColor()
    {

        textz.color = Color.black;

    }
}
