using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.7f;
    public GameObject bird;

    Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawnpipes", 2.0f, 3.0f);

        currentScene = SceneManager.GetActiveScene();
        Debug.Log(currentScene.name);
    }

    // Update is called once per frame
    void Update()
    {
        if (bird == null)
        {
            Debug.Log("Works");
            StartCoroutine(RestartScene());
            
        }
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(currentScene.name);
    }

    void Spawnpipes()
    {
        Instantiate(pipePrefab, new Vector2(2, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }
}
