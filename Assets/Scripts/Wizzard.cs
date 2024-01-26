using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wizzard : MonoBehaviour
{
    public GameObject UINoRocks;
    public GameObject UIRocks;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int rockplanks = collision.gameObject.GetComponent<PlayerMovement>().rockplanks;

        if (collision.gameObject.CompareTag("Player") && rockplanks >= 8)
        {
            Debug.Log("Com rochas");
            Debug.Log(rockplanks);
            GameObject uIRockInstance = Instantiate(UIRocks, transform.position, Quaternion.identity);
            Destroy(uIRockInstance, 8f);
            Invoke("CarregarCenaComAtraso", 9f);
        }
        else
        {
            Debug.Log("Sem rochas");
            Debug.Log(rockplanks);
            GameObject uINoRockInstance = Instantiate(UINoRocks, transform.position, Quaternion.identity);
            Destroy(uINoRockInstance, 7f);
        }
    }
    void Start()
    {
        
    }
    void CarregarCenaComAtraso()
    {
        SceneManager.LoadScene(1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
