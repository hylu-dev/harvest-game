using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed;

    private Vector2 position;

    public Animator animator;

    public Camera mainCamera;

    public float minCameraDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        position.x = Input.GetAxis("Horizontal");
        position.y = Input.GetAxis("Vertical");

        animator.SetFloat("Horizontal", position.x);
        animator.SetFloat("Vertical", position.y);
        animator.SetFloat("Speed", position.sqrMagnitude);

        float finalMoveSpeed = moveSpeed;
        if (Input.GetKey(KeyCode.LeftShift)) {
            finalMoveSpeed = moveSpeed*2f;
        }

        rb.velocity = new Vector3(position.x * finalMoveSpeed, rb.velocity.y, position.y * finalMoveSpeed);
        constrainSpriteDistanceToCamera();

        if (Input.GetKey(KeyCode.Escape)) {
            SceneManager.LoadScene("Start Menu");
        }
    }

    private void constrainSpriteDistanceToCamera() {
        float cameraDistance = Mathf.Abs(rb.position.z - mainCamera.transform.position.z);
        if (cameraDistance < minCameraDistance) {
            rb.position = new Vector3(rb.position.x, rb.position.y, mainCamera.transform.position.z + minCameraDistance);
        }
    }

}
