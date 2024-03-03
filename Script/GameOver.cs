using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Collider bola;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            SceneManager.LoadScene("0"); 
        }
    }
}


