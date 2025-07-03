using UnityEngine;

public class TargetFallDetector : MonoBehaviour
{
    private bool hasFallen = false;
    private static int score = 0;

    void Update()
    {
        if (hasFallen)
            return;

        if (Vector3.Angle(transform.up, Vector3.up) > 45f)
        {
            hasFallen = true;
            score++;
            print($"{gameObject.name} tombé");
            print($"Score : {score}");
        }
    }
}
