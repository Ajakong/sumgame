using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionOfMusuko : MonoBehaviour
{
    EnemyState enel;


    int hp=0;

    public string targetObjectName;
    // Start is called before the first frame update
    void Start()
    {
//        this.enel = GameObject.Find("Enemy").GetComponent<EnemyState>();//FindObjectOfType<EnemyState>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // 当たり判定を察知
    {
        if (collision.gameObject.name == targetObjectName)
        {
            enel = collision.GetComponent<EnemyState>();
            hp = enel.hpMove;
            //            hp = enel.hpMove;
            enel.hpMove -= 20;
//            enel.hpMove = hp - 20;
//            if(enel.hpMove==0)
            if (hp <= 0)
            {
//                enel = null;
                hp = 0;
            }
        }
    }
}
