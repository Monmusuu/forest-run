using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnPlay : MonoBehaviour
{
    public void BtnStart()
    {
        SceneManager.LoadScene("EndlessRunner");
    }
}
