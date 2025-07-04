using UnityEngine;
using System.Collections.Generic;

public class Table : MonoBehaviour
{
    public static Table Instance;
    private List<CibleIndividuelle> cibles = new List<CibleIndividuelle>();
    private int ciblesTombees = 0;
    private bool hasSpawnedNextTable = false;
    public GameObject cibleSphere;

    void Start()
    {
        cibles.Clear();
        cibles.AddRange(GetComponentsInChildren<CibleIndividuelle>());
        Instance = this;
    }

    public void CibleTouchee(CibleIndividuelle cible)
    {
        ciblesTombees++;

        if (cible.name.Contains("Sphere"))
        {
            Animator animator = cible.GetComponent<Animator>();
            Renderer renderer = cible.GetComponent<Renderer>();

            animator.enabled = false;
            cible.enabled = false;
        }

        if (!hasSpawnedNextTable && ciblesTombees >= cibles.Count)
        {
            hasSpawnedNextTable = true;
            Invoke(nameof(ResetTable), 1.5f);
        }
    }

    public void ResetTable()
    {
        ciblesTombees = 0;
        hasSpawnedNextTable = false;
        foreach (var cible in cibles)
        {
            Rigidbody rb = cible.GetComponent<Rigidbody>();
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            cible.ResetCible();
        }
    }


}
