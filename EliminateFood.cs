﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminateFood : MonoBehaviour
{
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //Debug.Log(screenBounds);
    }

    // Update is called once per frame
    void Update()
    {
/*        print("object: "+transform.position.y);
        print("Screen: "+screenBounds.y);*/
        if (transform.position.y < screenBounds.y * -3)
        {
            print(":'/");
            Destroy(this.gameObject);
        }
    }
}
