using System;
using UnityEngine;

public class UI_GPSMap : MonoBehaviour
{
    [SerializeField] GameObject inRange;
    [SerializeField] GameObject notInRange;
    Boolean active = false;
    int tempEvent;

    [SerializeField] EventManager eventManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayInRangeEvent(int id)
    {
        if (!active)
        {
            tempEvent = id;
            inRange.SetActive(true);
            active = true;
        }
    }

    public void DisplayNotInRange()
    {
        if (!active)
        {
            notInRange.SetActive(true);
            active = true;
        }
    }
    
    public void JoinButtonClick()
    {
        eventManager.ActivateEvent(tempEvent);
    }

    public void CloseButtonClick()
    {   
        inRange.SetActive(false);
        notInRange.SetActive(false);
        active = false;
    }
}
