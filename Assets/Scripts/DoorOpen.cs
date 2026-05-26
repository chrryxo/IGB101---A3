using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    public Transform player;

    private bool isOpen = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < 3f && Input.GetKeyDown(KeyCode.F))
        {
            if (!isOpen)
            {
                animator.Play("DoorOpen", 0, 0f);
                isOpen = true;
            }
            else
            {
                animator.Play("DoorClose", 0, 0f);
                isOpen = false;
            }
        }
    }
}