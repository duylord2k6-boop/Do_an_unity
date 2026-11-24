using UnityEngine;

public class xulyvacham : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CheckPoint"))
        {
            game.Instance.quaCheckPoint();
        }

        if (other.CompareTag("Winponit"))
        {
            game.Instance.quaWinPoint();
        }

        if (other.CompareTag("Obstacle"))
        {
            game.Instance.chamVatCan();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            game.Instance.chamDat();
        }
    }
}
