using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onclictest : MonoBehaviour
{

    public GameObject cube;
    Button greenbutton;
    Button yellowbutton;

    // Start is called before the first frame update
    void Start()
    {
        greenbutton = GameObject.Find("GreenButton").GetComponent<Button>();
        greenbutton.onClick.AddListener(() => changegreen());

        yellowbutton = GameObject.Find("YellowButton").GetComponent<Button>();
        yellowbutton.onClick.AddListener(() => changeyellow());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changered()
    {
        cube.GetComponent<Renderer>().material.color = Color.red;
    }

    public void changegreen()
    {
        cube.GetComponent<Renderer>().material.color = Color.green;
    }

    public void changeyellow()
    {
        cube.GetComponent<Renderer>().material.color = Color.yellow;
    }
}
