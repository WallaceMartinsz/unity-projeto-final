using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScrolling : MonoBehaviour
{

    public MeshRenderer myRenderer;
    public float speed;
    

   


    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }
}
