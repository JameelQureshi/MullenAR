using UnityEngine;
using RenderHeads.Media.AVProVideo;
public class VideoController : MonoBehaviour
{
    public MediaPlayer mediaPlayer;
    public static int currentPlayingIndex=0;
    public GameObject[] videoItem;
    public void Play(int videoIndex)
    {
        if (videoIndex == currentPlayingIndex)
        {   
            mediaPlayer.Play();
            videoItem[videoIndex - 1].GetComponent<VideoItem>().SetPlayButton(false);
            videoItem[videoIndex - 1].GetComponent<VideoItem>().SetPauseButton(true);
        }
        else
        {
            mediaPlayer.OpenVideoFromFile(MediaPlayer.FileLocation.RelativeToStreamingAssetsFolder, "Video"+videoIndex+".mp4", true);
            currentPlayingIndex = videoIndex;
            foreach (GameObject item in videoItem)
            {
                item.GetComponent<VideoItem>().SetThumbnail(true);
                item.GetComponent<VideoItem>().SetPlayButton(true);
                item.GetComponent<VideoItem>().SetPauseButton(false);
            }
            videoItem[videoIndex - 1].GetComponent<VideoItem>().SetThumbnail(false);
            videoItem[videoIndex - 1].GetComponent<VideoItem>().SetPlayButton(false);
            videoItem[videoIndex - 1].GetComponent<VideoItem>().SetPauseButton(true);
        }

    }

    public void Pause()
    {
        mediaPlayer.Pause();
        videoItem[currentPlayingIndex - 1].GetComponent<VideoItem>().SetPlayButton(true);
        videoItem[currentPlayingIndex - 1].GetComponent<VideoItem>().SetPauseButton(false);
    }
}
