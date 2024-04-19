using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class primer_codigo : MonoBehaviour
{
    //variables
    public int a;
    public float b;
    public char c;
    public bool d;
    public string palabra;
    //Comentario

    /*UwU
     * 
     * 
     * 
     * 
     */

    //Arreglos
    public int[] arreglo;
    public bool[] arregloBool;

    //La variable sale en el inspector a pesar de ser privada
    [SerializeField]
    private int privada;

    public GameObject objeto;
    public BoxCollider colision;

    // Start is called before the first frame update
    void Start()
    {
        print("Hola Mundo!");
        Debug.Log("Como estas ?");

        a = 10;
        // lleva la letra f al final el valor de los flotantes
        b = 1.1f;
        c = 'a';

        a = 5 + 10;

        //Condicionales
        // < , == , > , <= , >= , !=
        if (a < 5)
        {
            Debug.Log("Entro al if!");
        }
        else if (a == 10)
        {
            Debug.Log("Entro al else if!");
        }
        else
        {
            Debug.Log("Entro al else!");
        }

        // and, or, xor, not
        if (a < 5 && d == true)
        {
            Debug.Log("Entro al AND!");
        }

        if (a < 5 || d == true)
        {
            Debug.Log("Entro al OR!");
        }

        if (!d)
        {
            Debug.Log("Entro al else NOT!");
        }

        if (a < 5 ^ d == true)
        {
            Debug.Log("Entro al else XOR!");
        }

        switch (a)
        {
            case 1:
                Debug.Log("1");
                break;
            case 2:
                Debug.Log("2");
                break;
            case 3:
                Debug.Log("3");
                break;
            default:
                break;
        }

        //Ciclos
        for (int i = 6; i < 10; i++)
        {
            Debug.Log(i);
        }

        //CUIDADO
        //PELIGRO
        //NO USARLO SIN SABER LO QUE HACEN
        while (a < 100)
        {
            Debug.Log("Entro al while!");
            a++;
        }

        foreach (int x in arreglo)
        {
            Debug.Log("Foreach numero " + x);
        }


        Debug.Log(arreglo[0]);
        arreglo[0] = 50;

        //Para el objeto
        objeto.SetActive(false);
        //Para los componentes del objeto
        colision.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hola Mundo!");
        //a = 20;
    }
}
