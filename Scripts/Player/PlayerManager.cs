using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    
    // On collision with computer, the quiz starts
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Computer")
        {
            SceneManager.LoadScene(1);
        }
    }
}
