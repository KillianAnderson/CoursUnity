using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject obstacle;
    public float delaiSpawn;
    public Transform position2;

    private void Start()
    {
        InvokeRepeating(methodName: "Spawn", time: 0f, repeatRate: delaiSpawn);
    }

    private void Spawn()
    {
        Debug.Log("Spawn()");
        float random = Random.Range(0f, 1f);
        Vector3 spawnPosition;

        if (random < 0.5f)
        {
            spawnPosition = new Vector3(position2.position.x, -4.5f, 0f);
            Instantiate(obstacle, spawnPosition, Quaternion.identity);
        }
        else
        {
            spawnPosition = new Vector3(position2.position.x, 4.5f, 0f);
            GameObject newObstacle = Instantiate(obstacle, spawnPosition, Quaternion.identity);

            // Obstacle à l'envers
            // Changer sa rotaation pour qu'il point vers le bas
            newObstacle.transform.localEulerAngles = new Vector3(0, 0, 180);
        }
    }

}
