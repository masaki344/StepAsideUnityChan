using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //不要になったアイテムを順次破棄しましょう
    private GameObject cam;
    void Start ()
    {
        this.cam = GameObject.Find("Main Camera");
	}
	
	void Update ()
    {
        if (this.transform.position.z < this.cam.transform.position.z)
        {
            Destroy(this.gameObject);
        }
	}
}
