using UnityEngine;
using System.Collections.Generic;

public class Table : MonoBehaviour
{
    private List<CibleIndividuelle> cibles = new List<CibleIndividuelle>();
    private int ciblesTombees = 0;
    private bool hasSpawnedNextTable = false;


    void Start()
    {
        cibles.Clear();
        cibles.AddRange(GetComponentsInChildren<CibleIndividuelle>());
    }

    public void CibleTouchee()
    {
        ciblesTombees++;

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
