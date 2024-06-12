using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerScript : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0);

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
