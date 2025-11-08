using UnityEngine;
using UnityEngine.SceneManagement;
public class EventManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void ActivateEvent(int eventId){
        Debug.Log(eventId);
        switch (eventId)
        {
            case 0:// WOOD
                break;
            case 1:// IRON
                SceneManager.LoadScene("Start");
                break;

            default:
                break;
        }
        // SceneManager.LoadScene("Start");
    }
}
