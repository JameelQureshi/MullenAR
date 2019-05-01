
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
    public GameObject loading;
    public void LoadScene(int index)
    {
        loading.SetActive(true);
        SceneManager.LoadScene(index);
    }
    public void OpeURL(string URL)
    {
        Application.OpenURL(URL);
    }
}
