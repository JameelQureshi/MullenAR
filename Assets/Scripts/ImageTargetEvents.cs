using UnityEngine;
using System.Collections;
using UnityEngine.Events;

namespace Vuforia
{
public class ImageTargetEvents : MonoBehaviour,ITrackableEventHandler {
		private TrackableBehaviour mTrackableBehaviour;
        public UnityEvent onTargetFound;
        public UnityEvent onTargetLost;
	// Use this for initialization
	void Start () {

		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{

                onTargetFound.Invoke();
                Debug.Log("Target Found");

        }
		else
		{

                onTargetLost.Invoke();
                Debug.Log("Target Lost");
            }
        }



    }
}
