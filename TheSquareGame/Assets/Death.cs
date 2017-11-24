using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject Player;
    public AudioSource SoundSource;
    public AudioClip Sound;



    IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SoundSource.PlayOneShot(Sound);
            other.transform.position = new Vector3(1000f, 17.25717f, -6.44f);
            yield return new WaitForSeconds(1);
            other.transform.position = new Vector3(3.496f, 17.25717f, -6.44f);
            other.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);

        }


    }


}
