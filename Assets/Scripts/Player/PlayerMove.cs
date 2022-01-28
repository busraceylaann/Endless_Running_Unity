using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3;
    public float leftRightSpeed = 4;

    public GameObject animatonControllerObject;
    public float jumpForce = 10f;
    public GameObject menuAndCoin;
    bool isDeath = false;

    void Update()
    {
        if (!isDeath)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);

                }

            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);

                }

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animatonControllerObject.GetComponent<Animator>().SetTrigger("jump");
                animatonControllerObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
            }
            if (this.transform.position.z - animatonControllerObject.transform.position.z > -208)
            {
                menuAndCoin.GetComponent<menuAndCoin>().die();
                isDeath = true;
            }
        }
    }
}
