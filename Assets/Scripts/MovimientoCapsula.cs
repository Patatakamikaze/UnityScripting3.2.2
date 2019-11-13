using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCapsula : MonoBehaviour
{
    public float speed = 4f;
    public GameObject camerasParent;
    public float hRotationSpeed = 60f;
    public float vRotationSpeed = 40f;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        GameObject.Find("Capsule").GetComponent < MeshRenderer >().enabled= false;
    }
    void Update()
    {
        
        movement();
    }
    public void movement()
    {
        float hMovement = Input.GetAxisRaw("Horizontal");
        float vMovement = Input.GetAxisRaw("Vertical");

        Vector3 movementDirection = hMovement * Vector3.right + vMovement * Vector3.forward;
        transform.Translate(movementDirection * (speed * Time.deltaTime));

        float vCamRotation = Input.GetAxis("Mouse Y") * vRotationSpeed * Time.deltaTime;
        float hPlayerRotation = Input.GetAxis("Mouse X") * hRotationSpeed * Time.deltaTime;

        transform.Rotate(0f, hPlayerRotation, 0f);
        camerasParent.transform.Rotate(-vCamRotation, 0f, 0f);
    }
}
