using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CameraControls : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalSensitivity = 1f;
    public float verticalSensitivity = 1f;
    private Transform camTransform;
    private Camera cam;
    private float movement;
    private float xMovement;
    private float yMovement;
    private Vector3 camHolderRotation;
    private Vector3 camRotation;
    private Vector3 startingRotation;
    void Start()
    {
        //camTransform = GetComponentInChildren<Transform>();
        cam = GetComponentInChildren<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        startingRotation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = -Input.GetAxisRaw("Horizontal");
        xMovement = Input.GetAxisRaw("Mouse X") * horizontalSensitivity;
        yMovement = -Input.GetAxisRaw("Mouse Y") * verticalSensitivity;

        camHolderRotation = new Vector3(Mathf.Clamp(camHolderRotation.x, -90, 90), Mathf.Clamp(camHolderRotation.y + movement, -92, 27) , camHolderRotation.z);
        camRotation = new Vector3(Mathf.Clamp(camRotation.x + yMovement, -90, 90), camRotation.y + xMovement, camRotation.z);

        cam.transform.eulerAngles = camRotation;
        transform.eulerAngles = camHolderRotation;
    }
}
