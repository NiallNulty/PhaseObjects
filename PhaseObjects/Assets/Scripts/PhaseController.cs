using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhaseController : MonoBehaviour
{
    //list of all phasable objects
    [SerializeField] private List<GameObject> phasableObjects = new List<GameObject>();

    //change phasable objects phase type
    public void Phase()
    {
        foreach (GameObject phasableObject in phasableObjects)
        {
            phasableObject.GetComponent<PhasableObject>().ChangeType();
            phasableObject.GetComponent<PhasableObject>().CheckType();
        }
    } 
}
