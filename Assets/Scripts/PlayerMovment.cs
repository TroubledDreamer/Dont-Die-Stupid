using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float scaleChangeRate = 0.1f;

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        AdjustScale();
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.position += new Vector3(moveX, moveY, 0f);
    }

    void AdjustScale()
    {
        if (Input.GetAxis("Vertical") > 0)
        {
            // Player moves up
            transform.localScale -= Vector3.one * scaleChangeRate * Time.deltaTime;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            // Player moves down
            transform.localScale += Vector3.one * scaleChangeRate * Time.deltaTime;
        }

        // Optional: Prevent the player from scaling too much
        transform.localScale = new Vector3(
            Mathf.Clamp(transform.localScale.x, 0.5f, 2f),
            Mathf.Clamp(transform.localScale.y, 0.5f, 2f),
            transform.localScale.z
        );
    }
}


