using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
   public void goSettings()
   {
       SceneManager.LoadSceneAsync(1);
   }
}
