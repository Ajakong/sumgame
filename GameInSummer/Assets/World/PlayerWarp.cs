using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWarp : MonoBehaviour
{
    public string targetObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)                 // 当たり判定を察知
    {
        if (collision.gameObject.name == targetObj)
        {
            SceneManager.LoadScene("Wild2");
        }
    }
}
