using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizzard : MonoBehaviour
{
    public GameObject UINoRocks;

    void OnCollisionEnter2D(Collision2D collision)
    {
        int rockplanks = collision.gameObject.GetComponent<PlayerMovement>().rockplanks;

        if (collision.gameObject.CompareTag("Wizzard") && rockplanks >= 8)
        {
            Debug.Log("Parabéns, você conseguiu!");
        }
        else
        {
            GameObject uINoRockInstance = Instantiate(UINoRocks, transform.position, Quaternion.identity);
            Destroy(uINoRockInstance, 7f);
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
