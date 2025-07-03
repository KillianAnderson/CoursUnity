using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class DisableSpawn : MonoBehaviour
{
    void Start()
    {
        ObjectSpawner.Instance.enableSpawn = false;   
    }
}
