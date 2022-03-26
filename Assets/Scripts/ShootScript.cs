using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ShootScript : MonoBehaviour
{

    public GameObject arCamera;

    public AudioSource source;
    public AudioClip clip;

    public int kills = 0;
    public void shoot(){
        RaycastHit hit;

        if(Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit)){
            kills += 1;
            source.PlayOneShot(clip);
            Destroy(hit.transform.gameObject);
        }

        if(kills == 9){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
