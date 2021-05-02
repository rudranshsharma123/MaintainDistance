using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButton(0))
        {
            loadNextLevel();
        }*/
    }


    public void loadNextLevel()
    {
        Time.timeScale = 1;
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));

    }

    IEnumerator LoadLevel(int levelInd)
    {
        animator.SetTrigger("Start");
        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene(levelInd);
    }
}


