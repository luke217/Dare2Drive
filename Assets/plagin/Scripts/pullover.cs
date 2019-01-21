using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pullover : MonoBehaviour {

    private bool isPullover = false;
    public countDownTimer CountDown;
    public GameObject eyeLip;
    private bool check = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "playerCar") {
            isPullover = true;
        }
    }
    IEnumerator rest() {
        CountDown.Timer += 10f;
        yield return new WaitForSeconds(20f);
        eyeLip.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown("space")) {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
        if (isPullover&&!check) {
            eyeLip.SetActive(false);
            StartCoroutine(rest());
            check = true;
        }
	}
}
