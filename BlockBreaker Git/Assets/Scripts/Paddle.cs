using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // configuration parameters
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    [SerializeField] private Camera mainCamera;

    // Update is called once per frame
    void Update()
    {

        float mousePosInUnits = mainCamera.ScreenToWorldPoint(Input.mousePosition).x;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, minX, maxX);
        transform.position = paddlePos;



    }
}
