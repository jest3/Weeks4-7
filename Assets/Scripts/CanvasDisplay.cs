using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CanvasDisplay : MonoBehaviour
{
    public EnableDisable canvas;
    public GameObject pirate;
    public float distance = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 NPCpos = transform.position;
        Vector3 piratePos = pirate.transform.position;
        float distanceWithPirate = Vector3.Distance(NPCpos, piratePos);
        
        if (distanceWithPirate > distance)
        {
            canvas.enabled = false;
        }

        if (distanceWithPirate < distance)
        {
            canvas.enabled = true;
        }
    }
}
