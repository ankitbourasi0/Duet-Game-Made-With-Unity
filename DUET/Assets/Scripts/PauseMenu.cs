
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    [SerializeField] private Button ReturnToGame;
    [SerializeField] private  GameObject  pauseMenuUI;
    
     public void Awake(){
    ReturnToGame.onClick.AddListener(PauseMenuClose);
    PauseMenuClose();
     }
    public void PauseMenuOpen(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;

        
    }
    public void PauseMenuClose(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;

    
    }
    public void OnDestroy() {
    ReturnToGame.onClick.RemoveListener(PauseMenuClose);
        
    }
    // Update is called once per frame
    public void Home()
    {
           SceneManager.LoadScene(0);
    }
}
