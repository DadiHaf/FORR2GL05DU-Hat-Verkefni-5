using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class Takki : MonoBehaviour
{
    public string SceneNafn;
    public TextMeshProUGUI texti;

    private void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void Byrja()
    {
        SceneManager.LoadScene(SceneNafn);
    }
    public void Endir()
    {
        SceneManager.LoadScene(0);

    }

}