using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDemo : MonoBehaviour {
    public string Button = "Button_A"; // 버튼 매핑된 값
    private int cnt = 0; // 몇번 눌렸나

    float Timer = 0;

    void start(){
        cnt = 0;
        Timer = 0;
    }

	// Update is called once per frame
	void Update () {

        Timer += Time.deltaTime;

        if (Input.GetButtonDown(Button)) {
            ++cnt;
            Debug.Log( Button + " : " + cnt  + " times.. by " 
                + Timer);
            Timer = 0;
 
        }
	}
}
