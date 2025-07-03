using UnityEngine;
using UnityEngine.InputSystem;

public class BallShooter : MonoBehaviour
{
    public bool canShoot = false;

    public GameObject projectilePrefab;
    public float shootForce = 500f;

    public void Shoot(InputAction.CallbackContext context)
    {
        if (!canShoot) return;
        if (!context.started) return;

        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * shootForce);
    }
}
