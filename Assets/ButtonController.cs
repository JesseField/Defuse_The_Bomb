using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public GameObject redWire;
    public GameObject blueWire;
    public GameObject greenWire;
    public GameObject blackWire;
    public int currentWire = 0;
    public GameObject bombImage;
    
    // the order of the wires are Black, Green, Blue, Red

    public void OnClicked(int wire)
    {
        Debug.Log("wire #" + wire);

        if (wire == currentWire)
        {
            currentWire++;
            bombImage.GetComponent<BombChanger>().SpriteChange(currentWire);
        }
        else
        {
            //EXPLOSION!
            //Grab the particle system and play()
            //Put an end screen up 
        }
        
        //Switch Not Applicable
        /*switch (wire)
        {
            case 0:
                
                break;
            case 1:
                //something here
                break;
            case 2:
                //something here
                break;
            case 3:
                //something here
                break;
        }*/
    }

    void Update()
    {
        
    }

    void FailState()
    {
        
    }
}
