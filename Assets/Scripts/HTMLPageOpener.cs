using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTMLPageOpener : MonoBehaviour
{
    public void OpenAboutUs(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "About"
        };
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }
    public void OpenLounge(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "Lounge"
        };
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }

    public void OpenInvestment(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "Investment"
        };
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }
    public void OpenQianto50K50Info(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "Qianto50K50Info"
        };
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }
    public void OpenNews(string pathToFile)
    {
        InAppBrowser.DisplayOptions options = new InAppBrowser.DisplayOptions
        {
            displayURLAsPageTitle = false,
            pageTitle = "News"
        };
        InAppBrowser.OpenLocalFile(pathToFile, options);
    }

}
