using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 inputVector;
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        body.AddForce(inputVector * 5.5f, ForceMode.Force);
        body.drag = Input.GetKey(KeyCode.Space) ? 3f : 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Portal>())
        {
            StartCoroutine(other.GetComponent<Portal>().Teleport(this.gameObject));
        }
    }
}
