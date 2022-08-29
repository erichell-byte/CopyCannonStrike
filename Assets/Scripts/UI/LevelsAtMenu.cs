using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelsAtMenu : MonoBehaviour
{
    public void LoadFirstLevel()
    {
        SceneManager.LoadScene(0);
    }
    
    public void LoadSecondLevel()
    {
        SceneManager.LoadScene(1);
    }
    
    public void LoadThirdLevel()
    {
        SceneManager.LoadScene(2);
    }
}
