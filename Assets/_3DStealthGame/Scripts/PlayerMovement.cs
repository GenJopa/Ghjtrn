
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public InputAction MoveAction;
    
    public float walkSpeed = 1.0f;
    
    public float turnSpeed = 20f;
    
    Rigidbody m_Rigidbody;
    
    Vector3 m_Movement;
    
    Quaternion m_Rotation = Quaternion.identity;
}
void Start()
{
    m_RigidBody = GetCompanen<Rigid

}            
