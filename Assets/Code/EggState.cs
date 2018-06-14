using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggState : MonoBehaviour {

    Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
	}
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("ClickState", true);
        } else
        {
            anim.SetBool("ClickState", false);
        }
    }
}
