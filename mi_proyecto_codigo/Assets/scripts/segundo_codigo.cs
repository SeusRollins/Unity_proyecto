using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segundo_codigo : MonoBehaviour
{
    public GameObject cubo2;
    public BoxCollider colision;
    public float x;
    public float timer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //Usar el getcomponent en el start
        colision = GetComponent<BoxCollider>();
        colision = cubo2.GetComponent<BoxCollider>();


        colision.isTrigger = true;
        //como igualar a un vector
        colision.size = new Vector3(0.5f, 0.5f, 0.5f);

        //
        this.transform.position = new Vector3(10, 10, 10);


    }

    // Update is called once per frame
    void Update()
    {
        //Inputs
        if (Input.GetKeyDown(KeyCode.Space))
        {

            Debug.Log("GetKeyDown");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(x++, 0, 0);
            Debug.Log("GetKey");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("GetKeyUp");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        //Contadores
        //timer += Time.deltaTime; // timer = timer + Time.deltaTime
        Debug.Log(timer);

        if (timer <= 5.0f)
        {
            timer += Time.deltaTime;
        }

    }

}
