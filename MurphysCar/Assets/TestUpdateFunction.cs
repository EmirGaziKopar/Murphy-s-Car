using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdateFunction : MonoBehaviour
{
    private void Start()
    {
        //Application.targetFrameRate = 60;
    }
    int sayac;
    float time;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && time <= 1f)
        {
            time += Time.deltaTime;
            Debug.Log(sayac++);
        }
    }
}
