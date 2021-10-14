using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{
    public GameObject enemy;
    public float width;
    public bool pause;

    // Start is called before the first frame update
    void Start()
    {
        width = Camera.main.orthographicSize * Camera.main.aspect;
        InvokeRepeating("createEnemy", 0, 1);
    }

    private void createEnemy()
    {
        float posX = Random.Range(-width, width);
        Vector2 position = new Vector2(posX, Camera.main.orthographicSize + 1);
        Instantiate(enemy, position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause = !pause;

            Time.timeScale = pause ? 0 : 1;
            if (pause)
                SceneManager.LoadSceneAsync((int)Scenes.Home, LoadSceneMode.Additive);
            else
                SceneManager.UnloadSceneAsync((int)Scenes.Home);

        }
    }
}
