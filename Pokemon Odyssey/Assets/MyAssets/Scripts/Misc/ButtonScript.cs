using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // selects which scene to go to
	public void ChangeScene(string m_sceneName)
    {
        SceneManager.LoadScene(m_sceneName);

    }

    // will have to add in an "async" later for loading screens... 



    // quits the game
    public void QuitGame()
    {
        Application.Quit();
    }

}
