using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float horizontalSpeed = 5f;
    [SerializeField] private float verticalSpeed = 7f;

    private Camera camera;
    private Transform refTransform;

    private void Awake()
    {
        camera = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        Vector3 forward = new Vector3 (camera.transform.forward.x, 0, camera.transform.forward.z);
        Vector3 right = new Vector3 (camera.transform.right.x, 0, camera.transform.right.z);

        Vector3 movementX = right * Input.GetAxis("Horizontal") * horizontalSpeed;
        Vector3 movementZ = forward * Input.GetAxis("Vertical") * verticalSpeed;
        Vector3 movement = movementX + movementZ;

        Debug.Log(movement);

        this.transform.position += movement * Time.deltaTime;
    }
}
