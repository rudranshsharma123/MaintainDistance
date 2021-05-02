using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DragDrop : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D col;
    bool moveAllow;
    public GameObject touchEffect;
    
    void Start()
    {
       
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    // Creating the touch contorols----->
    void Update()
    {
        if (Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            if ( touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCol = Physics2D.OverlapPoint(touchPos);
                if (col == touchedCol)
                {
                    Instantiate(touchEffect, transform.position, Quaternion.identity);
                    moveAllow = true;

                }

            }
        
            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllow)
                {
                    transform.position = new Vector2(touchPos.x, touchPos.y);
                }

            }
        
            if (touch.phase == TouchPhase.Ended)
            {
                moveAllow = false;
            }
        }
    
    
        

    }
    

}
