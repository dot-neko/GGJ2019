using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCredits : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("salida", 3.0f);
    }

    void salida()
    {
        Application.Quit();
    }
}
