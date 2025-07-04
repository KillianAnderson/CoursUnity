using UnityEngine;

public class CibleIndividuelle : MonoBehaviour
{
    private bool dejaTouchee = false;
    private Vector3 positionInitiale;
    private Quaternion rotationInitiale;
    public bool estSphere = false;

    void Start()
    {
        positionInitiale = transform.localPosition;
        rotationInitiale = transform.localRotation;
    }

    void Update()
    {
        if (dejaTouchee)
            return;

        if (!dejaTouchee && Vector3.Angle(transform.up, Vector3.up) > 45f)
        {
            dejaTouchee = true;
            ScoreManager.Instance.AddScore();
            Table table = GetComponentInParent<Table>();
            table.CibleTouchee(this);
        }
    }

    public void ResetCible()
    {
        dejaTouchee = false;

        transform.localPosition = positionInitiale;
        transform.localRotation = rotationInitiale;
    }
}
