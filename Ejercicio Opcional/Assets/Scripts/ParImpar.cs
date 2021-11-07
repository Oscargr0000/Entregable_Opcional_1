using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParImpar : MonoBehaviour
{
    //Declaración del numero
    private int num;

    //Función para detectar si es par o impar
    public void EsParImpar(int num)
    {
        if ((num) % 2 == 0)
        {
            Debug.Log($"El numero {num} es par");
        }
        else
        {
            Debug.Log($"El numero {num} es impar");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            num = int.Parse(GetComponent<InputField>().text);
            EsParImpar(num);
        }
    }
}
