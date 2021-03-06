using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]private float _loadingScreenDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneDelay(_loadingScreenDelay));
    }

    IEnumerator LoadSceneDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Debug.log("Waiting for Seconds...");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
