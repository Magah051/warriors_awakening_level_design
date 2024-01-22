using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizzard : MonoBehaviour
{
    public GameObject UINoRocks;
    public float displayTime = 4f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int rockplanks = collision.gameObject.GetComponent<PlayerMovement>().rockplanks;

        if (collision.gameObject.CompareTag("Wizzard") && rockplanks >= 8)
        {
            Debug.Log("Parabéns, você conseguiu!");
        }
        else
        {
            GameObject uIBearInstance = Instantiate(UINoRocks, transform.position, Quaternion.identity);
            Destroy(uIBearInstance, displayTime);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
