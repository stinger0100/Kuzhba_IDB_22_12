using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plush : MonoBehaviour
{
    public int a1, a2, a3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            a1 = Random.Range(0, 225);
            a2 = Random.Range(0, 225);
            a3 = Random.Range(0, 225);

            this.GetComponent<Renderer>().material.color = new Color32((byte)a1, (byte)a2, (byte)a3, 1);
        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            gameObject.transform.Translate(0, 0.4f, 0);
        }


    }
}
