using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpSpeed;
    [SerializeField] new Rigidbody rigidbody;
     bool canJump = true;
    bool canMove = true;

    private void FixedUpdate()
    {
        if (canMove == true)
        {
            rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
            if ( Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            {
                
                rigidbody.AddForce(Vector3.up * jumpSpeed);
                Debug.Log("按下了其他键");
            }
          
        }
        if (canJump == true)
        {
            
            if ( Input.GetKeyDown(KeyCode.W) ) 
            {
                rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
                rigidbody.AddForce(Vector3.up * jumpSpeed);
                Debug.Log("W键被按下");
            }
        }

    }

    public void DisableJump()//禁用W功能
    {
        canJump = false;
        canMove = true;//保证其他按键功能启用

    }
    public void all()//都启用
    {
        canJump = true;
        canMove = true;
    }

    public void EnableJump()//启用W功能键
    {
        canJump = true;
        canMove = false;//禁用其余功能键

    }
}

