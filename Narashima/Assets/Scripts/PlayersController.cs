using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersController : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 3.0f;

    private Vector2 movement;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        movement = new Vector2 (Input.GetAxis("Horizontal"), 0).normalized;
        animator.SetFloat("Speed", Mathf.Abs(movement.magnitude * movementSpeed));

        bool flipped = movement.x < 0;
        this.transform.rotation = Quaternion.Euler(new Vector3(0f, flipped ? 180f : 0f, 0f));
    }

    private void FixedUpdate()
    {
        if (movement != Vector2.zero)
        {
            var xMovement = movement.x * movementSpeed * Time.deltaTime;
            this.transform.Translate(new Vector3(xMovement, 0), Space.World);
        }
    }
}
