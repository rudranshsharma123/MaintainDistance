using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgColor : MonoBehaviour
{


    
    public Color color1;
    public Color color2;
    float maxX;
    float delta = 0.5f;
    public float duration;
    static Vector2 pos;
    // Start is called before the first frame update
    public float speed = 1;
    public Vector3 endPosition;
    Vector3 startPosition;
    void Awake()
    {
        startPosition = (Vector2)transform.position;
        endPosition = (Vector2)startPosition + new Vector2(1, 0);
    
    }
   



    void Start()
    {
        pos = (Vector2)transform.position;
       
        /*cam.clearFlags = CameraClearFlags.SolidColor;*/
    }
    
    
 
    void Update()
    {
        double i = 0.5;

        transform.position = Vector2.Lerp(startPosition, endPosition, 0.5f ) ;

        


    }
}
