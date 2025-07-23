using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartMenu : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public void StartGame()
    {
        PlayerData.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene("main");
    }
}
