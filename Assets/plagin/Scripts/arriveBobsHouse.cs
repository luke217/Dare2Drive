using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arriveBobsHouse : MonoBehaviour {

    public GameObject thisEyeClose;
    public eyeClose thisEyeClose2;
    public GameObject closeEye;
    public GameObject turnTable;
    private bool arrived = false;
    public bool finishReading = false;
    public mAudioManager thisAM;
    public void Update()
    {
        if (arrived) {
            turnTable.SetActive(true);
            closeEye.SetActive(true);
            thisEyeClose.SetActive(true);
            if (finishReading) {
                closeEye.SetActive(false);
                thisEyeClose2.startTired = true;
            }
        }
    }
    //IEnumerator ReadStory() {
    //    yield return new WaitForSeconds()
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCar") {
            arrived = true;
            thisAM.ReachBobsHouse();
        }
    }
}
