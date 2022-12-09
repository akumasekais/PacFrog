using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("Restarted!");
     }
}