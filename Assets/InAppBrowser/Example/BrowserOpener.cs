using UnityEngine;
using System.Collections;

public class BrowserOpener : MonoBehaviour {
    private void Start()
    {
        OnButtonClicked();
    }

    public string pageToOpen = "https://pano.autohome.com.cn/car/pano/34383";

	// check readme file to find out how to change title, colors etc.
	public void OnButtonClicked() {
		InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions();
		options.displayURLAsPageTitle = false;
		options.pageTitle = "Qianto50 K50 360View";

		InAppBrowser.OpenURL(pageToOpen, options);
	}

	public void OnClearCacheClicked() {
		InAppBrowser.ClearCache();
	}
}
