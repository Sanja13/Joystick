using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    private CinemachineVirtualCamera virtualCamera;

    private void Start()
    {
        virtualCamera = GetComponentInChildren<CinemachineVirtualCamera>();
    }

    private void LateUpdate()
    {
        // Only update the Y position of the camera to follow the player
        Vector3 newPosition = transform.position;
        newPosition.y = target.position.y;
        transform.position = newPosition;

        // Reset the camera rotation
        transform.rotation = Quaternion.identity;

        // Set the player as the camera's follow target
        virtualCamera.Follow = target;
    }
}
