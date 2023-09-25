using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int a, b, c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
        {

            a = Random.Range(0, 255);
            b = Random.Range(0, 255);
            c = Random.Range(0, 255);

            this.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 1);

        }

        if (Input.GetKeyDown(KeyCode.W))
        {

            gameObject.transform.Translate(0, 0, 0.2f);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            gameObject.transform.Translate(0, 0, -0.2f);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            gameObject.transform.Translate(-0.2f, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            gameObject.transform.Translate(0.2f, 0, 0);

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            gameObject.transform.Translate(0, 0.5f, 0);

        }

    }
}
