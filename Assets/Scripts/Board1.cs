using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board1 : MonoBehaviour
{
    public GameObject board1;

    //public AudioClip coinSound;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Instantiate(board1, this.gameObject.transform);
            GameObject boardInstance1 = Instantiate(board1, transform.position, Quaternion.identity);
            Destroy(boardInstance1, 7f);
            Destroy(gameObject, 7f);
            //GameObject soundObject = new GameObject("CollisionSound");
            //AudioSource audioSource = soundObject.AddComponent<AudioSource>();
            //audioSource.clip = coinSound;
            //audioSource.Play();
            //Destroy(soundObject, coinSound.length);

        }

    }
}