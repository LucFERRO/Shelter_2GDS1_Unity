using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class test : MonoBehaviour
{
    private float xMovement;
    private Vector3 camRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        xMovement = Input.GetAxisRaw("Mouse X");

        camRotation = new Vector3(Mathf.Clamp(camRotation.x, -90, 90), camRotation.y + xMovement, camRotation.z);

        transform.eulerAngles = camRotation;
    }
}
    