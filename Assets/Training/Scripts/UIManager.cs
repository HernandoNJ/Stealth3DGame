using UnityEngine;
using UnityEngine.SceneManagement;

namespace Training.Scripts
{
public class UIManager : MonoBehaviour
{
    private static UIManager _instance;
    public static UIManager instance
    { get{ if(_instance ==  null) Debug.Log("UiManager null"); return _instance; }}

    [SerializeField] private string startScene;
    
    private void Awake() => _instance = this;

    private void Start() => startScene = "Main1";

    public void RestartGame() => SceneManager.LoadScene(startScene);

    public void QuitGame() => Application.Quit();

}
}
