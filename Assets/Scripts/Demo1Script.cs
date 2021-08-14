using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Demo1Script : MonoBehaviour
{

    public GameObject capturedText;
    public GameObject comingText;
    public GameObject comingBackground;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(EndingFunction());

        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MenuScene");
        }

    }

    IEnumerator EndingFunction()
    {
        if (transform.position.x <= -7)
        {
            capturedText.SetActive(false);
            comingText.SetActive(true);
            comingBackground.SetActive(true);

            yield return new WaitForSeconds(3);

            SceneManager.LoadScene("MenuScene");

        }
        else
            transform.Translate(Vector3.forward * Time.deltaTime);
    }

}
