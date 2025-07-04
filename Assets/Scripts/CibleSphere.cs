using UnityEngine;

public class CibleSphere : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Balle"))
        {
            gameObject.SetActive(false);
            ScoreManager.Instance.AddScore(10);
        }
    }

    public void ResetSphere()
    {
        gameObject.SetActive(true);
    }
}
