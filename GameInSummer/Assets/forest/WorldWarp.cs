using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class WorldWarp : MonoBehaviour
{
    GameObject player;

    Vector3 pos = new Vector3();

    public string targetObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerStay2D(Collider2D collision)                 // �����蔻����@�m
    {
        if (collision.gameObject.name == targetObj)
        {
            player = GameObject.Find("player");
            //Debug.Log("�����Ă��");
            pos = player.transform.position;

            pos = new Vector3(-9.5f, 1.5f, 0);
            Debug.Log("�u�Ԉړ�");
            player.transform.position = pos;
            SceneManager.LoadScene("worldScene");
        }
    }
}