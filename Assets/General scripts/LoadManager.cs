using UnityEngine;
using UnityEngine.SceneManagement;

namespace General_scripts
{
    public class LoadManager : MonoBehaviour
    {
        //name of scene to be loaded
        public string SceneName;
   
        public void changeScene()
        {
            //change scene to scene with SceneName
            SceneManager.LoadScene(SceneName);
        }
    }
}
