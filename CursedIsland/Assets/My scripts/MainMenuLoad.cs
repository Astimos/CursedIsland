using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour
{
    [SerializeField] int LevelNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(0);
    }
}
