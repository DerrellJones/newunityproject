using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    GameObject Character; //refrence to the player so we can track its position 
    Renderer rend; //Refrence to the Renderer so we can modify its texture

    float characterStartPos;
    public float speed = 0.5f; 
    
    void Start() 
    {
        Character = GameObject.Find("Character");
        rend = GetComponent<Renderer>();
        characterStartPos = Character.transform.position.x;

    }
    private void Update()
    {
        float offset = (Character.transform.position.x - characterStartPos) * speed;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offset, 0f));

    }


}


    
        
    

