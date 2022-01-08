
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject SettingsUI;

    [SerializeField] private Button closeButton;
    [SerializeField] private Button closeButtonCredit;

    [SerializeField] private GameObject CreditUI;
 
    public void GameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);    
    }
    public void GameMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Awake(){
    closeButton.onClick.AddListener(SettingsClose);
    SettingsClose();
    closeButtonCredit.onClick.AddListener(CreditsClose);
    CreditsClose();
    }

    public void SettingsOpen(){
        SettingsUI.SetActive(true);
     
    }
    public void SettingsClose()
    {
               SettingsUI.SetActive(false);

    }
     public void OnDestroy(){

     closeButton.onClick.RemoveListener(SettingsClose);
     closeButtonCredit.onClick.RemoveListener(CreditsClose);

    }
    public void CreditsOpen(){
        CreditUI.SetActive(true);
     
    }
    public void CreditsClose()
    {
               CreditUI.SetActive(false);

    }
}

