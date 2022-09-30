using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float slowdownFactor = 0.05f;
    public float slowdownLenght = 2f;
    public IEnumerator SlowMotion()
    {

        float time = 0f;

        /*float counterTime = 0f;
        while (counterTime < 0.22f)
        {
            counterTime += Time.deltaTime;
            yield return null;
        }
        */

        while (time < 0.2f)
        {

            Time.timeScale = slowdownFactor;
            Time.fixedDeltaTime = Time.timeScale * .02f;
            time += Time.deltaTime;
            yield return null;
        }

        Time.fixedDeltaTime = 0.02f;
        Time.timeScale = 1f;
        //Oyunu tekrar baslat 
        SceneManager.LoadScene(0, LoadSceneMode.Single);



    }

    public void slowMotionEffectCall()
    {   
        StartCoroutine(SlowMotion());
    }

}
