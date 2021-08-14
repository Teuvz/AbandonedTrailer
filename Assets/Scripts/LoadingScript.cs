using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingScript : MonoBehaviour
{

    public GameObject Logo;
    public GameObject Blurb;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadingScreens());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadingScreens()
    {

        yield return new WaitForSeconds(1);

        Logo.SetActive(true);

        yield return new WaitForSeconds(3);

        Logo.SetActive(false);

        yield return new WaitForSeconds(3);

        Blurb.SetActive(true);

        yield return new WaitForSeconds(10);

        Blurb.SetActive(false);

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("MenuScene");

    }

}
