using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameui : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Update()
    {
        thoigiangame();
    }

    public void thoigiangame()
    {
        timeText.SetText(Mathf.FloorToInt(game.Instance.thoigiandichchuyen).ToString());
    }

    public void Choilai()
    {
        SceneManager.LoadScene("Game");
    }
    public void ThoatGame()
    {
        SceneManager.LoadScene("Menu");
    }
}