using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public GameObject loading;
    public GameObject signUp;
    public GameObject message;

    public InputField nameInput;
    public InputField phoneInput;
    public InputField emailInput;
    public Dropdown personTypeSelect;
    public string s_personType="Fan";
    public string BASE_URL = "https://docs.google.com/forms/d/e/1FAIpQLSd33v6V4mlpj_SBwvZ9dZrECyS7z9E92G4NHjIHgHTwFtgc3A/formResponse";
    // Start is called before the first frame update
    void Start()
    {
        loading.SetActive(false);   
    }


    public void LoadScene(int index)
    {
        loading.SetActive(true);
        StartCoroutine(LoadYourAsyncScene(index));
    }

    IEnumerator LoadYourAsyncScene(int index)
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(index);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void OpenURL(string URL)
    {
        Application.OpenURL(URL);
    }


    public void SignUp()
    {
        string name = nameInput.text;
        string phone = phoneInput.text;
        string email = emailInput.text;

        if (name!="" && phone != "" && email != "")
        {

            StartCoroutine(PostData(name, phone, email,s_personType));
        }
       
    }

    IEnumerator PostData(string name,string phone,string email,string personType)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.413578446", name);
        form.AddField("entry.1476296251", phone);
        form.AddField("entry.1725177634", email);
        form.AddField("entry.516814386", personType);
        byte[] rawData = form.data;
        
        WWW www = new WWW(BASE_URL,rawData);
        yield return www;
        signUp.SetActive(false);
    }

    public void OnDropDownValueChanged()
    {
        switch (personTypeSelect.value)
        {
            case 0:
                s_personType = "Fan";
                break;
            case 1:
                s_personType = "Investor";
                break;
            case 2:
                s_personType = "Media";
                break;
            case 3:
                s_personType = "Other";
                break;

        }

    }

}
