using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if(horizontalInput != 0)
        {
            transform.position = new Vector3(transform.position.x + horizontalInput * speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if(verticalInput != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + verticalInput * speed * Time.deltaTime);
        }
    }
}
