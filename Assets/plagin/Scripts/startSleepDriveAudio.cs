using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startSleepDriveAudio : MonoBehaviour {

    public mAudioManager thisAm;
    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCar") {
            thisAm.StartSleepyDriving();
        }
    }
}
