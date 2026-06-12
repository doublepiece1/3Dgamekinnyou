using UnityEngine;

using UnityEngine.InputSystem;
using System;
public class Player : MonoBehaviour
{
    [SerializeField]  float speedMax;
    PlayerInput playerInput;
    void Update()
    {
        var moveVec = playerInput.actions["MOVE"].ReadValue<Vector2>();
        var moveVec3D = new Vector3(moveVec.x * speedMax, 0, moveVec.y * speedMax);
        transform.position  = transform.position + moveVec3D * Time.deltaTime;
    }
}
