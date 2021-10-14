using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombChanger : MonoBehaviour
{
    public Sprite[] spriteList;

    public void SpriteChange(int spriteIndex)
    {
        gameObject.GetComponent<Image>().sprite = spriteList[spriteIndex];
    }
        
}
