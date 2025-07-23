using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text nameText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = "Best Score: " + MainManager.highScoreName + ": " + MainManager.HighestScore;
    }
}
