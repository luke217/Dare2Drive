using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survive : MonoBehaviour {

    public GameObject surviver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCar") {
            surviver.GetComponent<AudioSource>().Play();
        }
    }
}
