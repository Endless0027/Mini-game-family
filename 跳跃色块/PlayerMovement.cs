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
                Debug.Log("������������");
            }
          
        }
        if (canJump == true)
        {
            
            if ( Input.GetKeyDown(KeyCode.W) ) 
            {
                rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed);
                rigidbody.AddForce(Vector3.up * jumpSpeed);
                Debug.Log("W��������");
            }
        }

    }

    public void DisableJump()//����W����
    {
        canJump = false;
        canMove = true;//��֤����������������

    }
    public void all()//������
    {
        canJump = true;
        canMove = true;
    }

    public void EnableJump()//����W���ܼ�
    {
        canJump = true;
        canMove = false;//�������๦�ܼ�

    }
}

