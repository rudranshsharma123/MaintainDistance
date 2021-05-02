using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject restart;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    float speed = 1.5f;
    float timeToMaxdiff;

    private GameManager gm;
    public GameObject gmO;

    float minSpeed = 0.5f;
    float maxSpeed = 10f;
    public float getSpeed()
    {
        return speed;
    }

    public void changeSpeed(float s)
    {
        speed = s;
    }
    Vector2 targetPos;
    
    Vector2 getRandomPos()
    {
        float randX = Random.Range(minX, maxX);
        float randY = Random.Range(minY, maxY);
        return new Vector2(randX, randY);


    }
    void Start()
    {
        Time.timeScale = 1;
        targetPos = getRandomPos();
        speed = 1.5f;
        gm = gmO.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPos)
        {
           /* speed = Mathf.Lerp(minSpeed, maxSpeed, getDiff());*/
            transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
        }
        else
        {

            targetPos = getRandomPos();
        }
    
    }
    float getDiff()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / timeToMaxdiff);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Virus")
        {
            /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);*/
            gm.gameOver();
            
            speed = 0f;

        }
    }
}
