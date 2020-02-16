using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    //不要になったアイテムを順次破棄しましょう
    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
