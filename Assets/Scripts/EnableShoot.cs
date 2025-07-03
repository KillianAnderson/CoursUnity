using UnityEngine;

public class EnableShooting : MonoBehaviour
{
    void Start()
    {
        BallShooter shooter = Camera.main.GetComponent<BallShooter>();
        if (shooter != null)
            shooter.canShoot = true;
    }
}
