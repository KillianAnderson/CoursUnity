using UnityEngine;

public class BackgroundManage : MonoBehaviour
{
    public float vitesse = 8f;
    public float resetX = -20f;
    public float startX = 40f;

    void Update()
    {
        transform.position += Vector3.left * vitesse * Time.deltaTime;

        if (transform.position.x < resetX)
        {
            Vector3 pos = transform.position;
            pos.x = startX;
            transform.position = pos;
        }
    }
}
