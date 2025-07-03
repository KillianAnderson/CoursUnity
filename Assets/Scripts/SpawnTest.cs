using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public GameObject tablePrefab;

    void Start()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 2);
        Quaternion spawnRotation = Quaternion.identity;

        Instantiate(tablePrefab, spawnPosition, spawnRotation);
        Debug.Log("Table instanciée");
    }
}
