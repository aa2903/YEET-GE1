using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsSkip : MonoBehaviour
{

    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene(0);
        }
    }

}
