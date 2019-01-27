using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Jugar",3.0f);
    }

    public void Jugar()
    {
        SceneManager.LoadScene("MainGame");
    }
}
