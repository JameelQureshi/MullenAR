using UnityEngine;
using System.Collections;
using UnityEngine.Video;
namespace Vuforia
{
public class AfterClueDetected : MonoBehaviour,ITrackableEventHandler {
		private TrackableBehaviour mTrackableBehaviour;

        public VideoPlayer videoPlayer;
	
	void Start () {
			
			
		mTrackableBehaviour = GetComponent<TrackableBehaviour>();
		if (mTrackableBehaviour)
		{
			mTrackableBehaviour.RegisterTrackableEventHandler(this);
		}
	}
	
	

	public void OnTrackableStateChanged(
		TrackableBehaviour.Status previousStatus,
		TrackableBehaviour.Status newStatus)
	{
		if (newStatus == TrackableBehaviour.Status.DETECTED ||
			newStatus == TrackableBehaviour.Status.TRACKED ||
			newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
		{

                videoPlayer.Play();


            }
		else
		{

                videoPlayer.Pause();

            }
	}
	}
}
