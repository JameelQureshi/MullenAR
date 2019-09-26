using UnityEngine;
using System.Collections;

public class LocalFileOpener : MonoBehaviour {

	/*
	 * Your local files should be placed in StreamingAssets directory
	 * 
	 * This path is relative to it, meaning full path will be 
	 * /StreamingAssets/LocalSite/index.html
	 * */
	

	public void OpenInvestmentPage(string pathToFile) {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "Investment"
        };
        options.hidesTopBar = false;
        InAppBrowser.OpenLocalFile(pathToFile, options);
	}

    public void OpenLoungePage(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "Mullen Lounge"
        };
        options.hidesTopBar = false;
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }
    public void OpenAboutUs(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "About"
        };
        options.hidesTopBar = false;
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }


}
