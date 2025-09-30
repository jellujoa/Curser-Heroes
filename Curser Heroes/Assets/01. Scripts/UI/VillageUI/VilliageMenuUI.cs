using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
public class VilliageMenuUI : MonoBehaviour
{
    public GameObject settingPanel;

    private void OnEnable()
    {
        CloseSettingPanel();
    }

    public void OpenSettingPanel()
    {
        settingPanel.SetActive(true);
    }

    public void CloseSettingPanel()
    {
        settingPanel.SetActive(false);
    }

    public void ClickBackButton()
    {
        gameObject.SetActive(false);
    }

    public void ClickTitleButton()
    {
        Addressables.LoadSceneAsync("Assets/02. Scenes/TitleSceneTest.unity");
        //SceneManager.LoadScene("TitleSceneTest");
    }
    
    
}
