using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhasableObject : MonoBehaviour
{
    //Enum to determine if object is phased or not
    public enum PhaseType
    {
        Unphased,
        Phased
    }

    public PhaseType Type;

    //Materials
    [SerializeField] private Material unphasedMaterial;
    [SerializeField] private Material phasedMaterial;

    void Start()
    {
        //Checks type on start so type can be set before in inspector
        CheckType();
    }

    //Sets object values for type
    public void CheckType()
    {
        //Unphased, solid material and box collider enabled
        if (Type == PhaseType.Unphased)
        {
            this.transform.GetComponent<BoxCollider>().enabled = true;
            this.transform.GetComponent<MeshRenderer>().material = unphasedMaterial;
        }

        //Phased, transparent material and box collider disabled
        else
        {
            this.transform.GetComponent<BoxCollider>().enabled = false;
            this.transform.GetComponent<MeshRenderer>().material = phasedMaterial;
        }
    }

    //for changing phase type
    public void ChangeType()
    {
        if (Type == PhaseType.Unphased)
        {
            Type = PhaseType.Phased;
        }

        else
        {
            Type = PhaseType.Unphased;
        }
    }
}
