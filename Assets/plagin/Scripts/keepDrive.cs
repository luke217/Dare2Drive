using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keepDrive : MonoBehaviour {

    public eyeClose thisEyeLip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCar") {
            thisEyeLip.decideToDrive = true;
        }
    }
}
