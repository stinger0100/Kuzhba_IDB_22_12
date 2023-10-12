using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stolknoveniya : MonoBehaviour
{
    public int x;
    public Text textToEdit;

    void Start() { 

        x = 100;
        textToEdit = GameObject.Find("Text").GetComponent<Text>();

    }

    void OnCollisionEnter (Collision Other)
    {

        Debug.Log("Hello");
        x--;
        textToEdit.text = "Collisions: " + x.ToString();

    }
}
