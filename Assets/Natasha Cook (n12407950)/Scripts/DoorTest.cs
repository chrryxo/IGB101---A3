using UnityEngine;

public class DoorTest : MonoBehaviour
{
    public Animation anim;
    public string openAnimationName = "door open animation";
    public string closeAnimationName = "door close animation";
    
    private bool isOpen = false;

    void Start()
    {
        anim = GetComponent<Animation>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isOpen)
            {
                // Play open animation
                anim.Play(openAnimationName);
                isOpen = true;
            }
            else
            {
                // Play close animation
                anim.Play(closeAnimationName);
                isOpen = false;
            }
        }
    }
}