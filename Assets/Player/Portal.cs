using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField]
    private Transform targetLocation;

    public IEnumerator Teleport(GameObject teleportingObject)
    {
        yield return new WaitForSeconds(.1f);
        teleportingObject.transform.position = targetLocation.position;
    }
}
