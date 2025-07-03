using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class DisableSpawn : MonoBehaviour
{
    public void disable()
    {
        ObjectSpawner.Instance.enableSpawn = false;   
    }
}
