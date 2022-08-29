using UnityEngine;

public class CheckWinLose : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private GameObject _winText;
    [SerializeField] private GameObject _loseText;
    [SerializeField] private GameObject _touchButton;
    [SerializeField] private GameObject _backButton;
    
    private void Start()
    {
        GlobalEventManager.OnGameWin += GameWin;
        GlobalEventManager.OnGameLose += GameLose;
    }

    private void OnDestroy()
    {
        GlobalEventManager.OnGameWin -= GameWin;
        GlobalEventManager.OnGameLose -= GameLose;
    }

    public void GameWin()
    {
        _menu.SetActive(true);
        _winText.SetActive(true);
        _touchButton.SetActive(false);
        _backButton.SetActive(false);
        
    }
    public void GameLose()
    {
        _menu.SetActive(true);
        _loseText.SetActive(true);
        _touchButton.SetActive(false);
        _backButton.SetActive(false);
        
    }
}
