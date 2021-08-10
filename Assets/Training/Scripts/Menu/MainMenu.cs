using UnityEngine;
using UnityEngine.SceneManagement;

namespace Training.Scripts.Menu
{
public class MainMenu : MonoBehaviour
{
    [SerializeField] private string gameScene = "LoadingScreen";

    public void StartGame() => SceneManager.LoadScene(gameScene);

    public void QuitGame() => Application.Quit();
}
}
