using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Basic : MonoBehaviour
{
    public GameObject Basic1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        gameObject.SetActive(false);
        Basic1.SetActive(true);
        Invoke("LoadScene", 1);

    }
    void LoadScene()
    {
        SceneManager.LoadScene("Scene02-3_BasicHamburger");
    }

}
