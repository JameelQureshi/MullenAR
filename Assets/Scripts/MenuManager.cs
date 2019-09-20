using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public GameObject loading;
    public GameObject signUp;
    public GameObject message;
    public GameObject submitLoading;
    public InputField nameInput;
    public InputField emailInput;
    public InputField messageInput;

    string BASE_URL = "https://arhub.net/Php/UploadMullen.php";
    // Start is called before the first frame update
    void Start()
    {
        loading.SetActive(false);
        submitLoading.SetActive(false);
        message.SetActive(false);
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


    public void Submit()
    {
        string name = nameInput.text;
        string email = emailInput.text;
        string message = messageInput.text;

        if (name!="" && email != "" && message != "")
        {
            submitLoading.SetActive(true);
             nameInput.text="";
             emailInput.text="";
             messageInput.text="";
            StartCoroutine(PostData(name,email,message));
        }
       
    }


    IEnumerator PostData(string p_name, string p_email, string p_message)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", p_name);
        form.AddField("email", p_email);
        form.AddField("message", p_message);

        using (UnityWebRequest www = UnityWebRequest.Post(BASE_URL, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                submitLoading.SetActive(false);
                message.SetActive(true);
                message.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Error Uploading!";
                Invoke("TurnOffMessage", 3);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text == "Done")
                {
                    signUp.SetActive(false);
                    message.SetActive(true);
                    message.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Message Sent!";
                    Invoke("TurnOffMessage", 3);
                }
                else
                {
                    message.SetActive(true);
                    message.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Error Uploading!";
                    Invoke("TurnOffMessage", 3);
                }
                submitLoading.SetActive(false);
            }
        }
    }

    void TurnOffMessage()
    {
        message.SetActive(false);
    }


}
