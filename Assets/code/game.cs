using UnityEngine;

public class game : MonoBehaviour
{
    public float thoigiandichchuyen = 30f;
    public bool ketthuc = false;
    public bool WinGame = false;

    private static game instance;

    public GameObject gameOver;
    public GameObject winGame;
    public GameObject timeOver;

    [SerializeField]
    private float thoigiancheckpoint = 10f;
    [SerializeField]
    private float thoigianbitru = 5f;

    public static game Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindFirstObjectByType<game>();
                if (instance == null)
                {
                    GameObject obj = new GameObject("game");
                    instance = obj.AddComponent<game>();
                }
            }
            return instance;
        }
    }

    private void Update()
    {
        if (ketthuc) return;

        thoigiandichchuyen -= Time.deltaTime;

        if (thoigiandichchuyen <= 0)
        {
            thoigiandichchuyen = 0;
            timeOver.SetActive(false);
            gameOver.SetActive(true);
            ResetGame();
        }
    }

    public void ResetGame()
    {
        ketthuc = true;
    }

    public void quaCheckPoint()
    {
        if (!ketthuc)
        {
            thoigiandichchuyen += thoigiancheckpoint;
        }
    }

    public void quaWinPoint()
    {
        if (!ketthuc)
        {
            WinGame = true;
            ketthuc = true;
            timeOver.SetActive(false);
            winGame.SetActive(true);
        }
    }

    public void chamVatCan()
    {
        if (!ketthuc)
        {
            thoigiandichchuyen -= thoigianbitru;
            if (thoigiandichchuyen < 0) thoigiandichchuyen = 0;
        }
    }

    public void chamDat()
    {
        if (!ketthuc)
        {
            thoigiandichchuyen = 0;
            ketthuc = true;
            timeOver.SetActive(false);
            gameOver.SetActive(true);
        }
    }
}