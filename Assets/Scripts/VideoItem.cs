using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoItem : MonoBehaviour
{

    private void Start()
    {
        SetPauseButton(false);
    }

    public void SetThumbnail(bool state)
    {
        transform.GetChild(0).gameObject.SetActive(state);
    }

    public void SetPauseButton(bool state)
    {
        transform.GetChild(3).gameObject.SetActive(state);
        if (state)
        {
            StartCoroutine(TurnOffPause());
        }
    }

    public void SetPlayButton(bool state)
    {
        transform.GetChild(2).gameObject.SetActive(state);
    }
    public void TurnOnPause()
    {
        StopAllCoroutines();
        if (!transform.GetChild(2).gameObject.activeInHierarchy)
        {
            SetPauseButton(true);
        }
       
    }
    IEnumerator TurnOffPause()
    {
        yield return new WaitForSeconds(2);
        transform.GetChild(3).gameObject.SetActive(false);
    }


}
