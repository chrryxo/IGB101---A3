using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Animator anim;

    public float rotSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ForwardMovement();

        Turning();
        Actions();

    }

    private void ForwardMovement()
    {
        if (Input.GetKey("w"))
        {
            anim.SetBool("Walking", true);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetBool("Running", true);
            }
            else
            {
                anim.SetBool("Running", false);
            }
        }
        else if (Input.GetKeyUp("w"))
        {
            anim.SetBool("Walking", false);
            anim.SetBool("Running", false);
        }
    }

    private void Turning()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(0, -rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Left", true);
        }
        else if (Input.GetKey("d"))
        {
            transform.Rotate(0, rotSpeed * 15 * Time.deltaTime, 0, Space.World);
            anim.SetBool("Turn Right", true);
        }
        else
        {
            anim.SetBool("Turn Left", false);
            anim.SetBool("Turn Right", false);
        }
    }
    private void Actions()
    {
        Debug.Log("Layer 2 state: " + anim.GetCurrentAnimatorStateInfo(2).IsName("Idle") + " | Weight: " + anim.GetLayerWeight(2));

        if (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F))
        {
            anim.SetLayerWeight(2, 1f);
            anim.SetBool("Waving", true);
        }
        else if (Input.GetKeyUp(KeyCode.E) || Input.GetKeyUp(KeyCode.F))
        {
            anim.SetBool("Waving", false);
        }

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(2);
        if (stateInfo.IsName("Idle"))
        {
            anim.SetLayerWeight(2, 0f);
        }
    }
}
