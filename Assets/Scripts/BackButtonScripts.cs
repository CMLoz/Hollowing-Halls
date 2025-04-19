using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonScripts : MonoBehaviour
{
    public void goBack()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
