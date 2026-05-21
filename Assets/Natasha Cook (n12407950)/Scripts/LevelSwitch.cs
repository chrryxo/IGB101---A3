using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitch : MonoBehaviour
{
    GameManager gameManager;
    public string nextLevel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start(){
       gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame

    private void OnTriggerEnter(Collider otherObject){
        
        if (otherObject.transform.tag == "Player"){
            
            if (gameManager.levelComplete){
                SceneManager.LoadScene(nextLevel);
            }
        }
    }
    
}
