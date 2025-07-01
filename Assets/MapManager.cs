using UnityEngine;

public class MapManager : MonoBehaviour
{
    private float vitesse = 8f;

    void Update()
    {
        transform.position += Vector3.left * vitesse * Time.deltaTime;

        if (transform.position.x < -15f)
        {
            Destroy(gameObject);
        }
    }
}
