using System.Runtime.Intrinsics;
using System.Transactions;
using System.Threading.Tasks.Dataflow;
using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    [SerializeField]
    Transform Player;
    
    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float disToPlayer = Vector2.Distance(Transform.position, Player.position)
        print("distToPlayer:" + disToPlayer)

        if(disToPlayer < agroRange)
        {
            //code chase player
            ChasePlayer();

        }
        else
        {
            //stop chasing player
            StopChasingPlayer();
        }

        //needs to be adapted to 4 directional movement
         void ChasePlayer() {
            if(TransactionInformation.position.x < player.position.x) 
            {
                //enemy is to the left side of the player, so move right
                rb2d.velocity - new Vector2(moveSpeed, 0);
            }
            else
            {
                //enemy is to the right side of the player, so move left
                rb2d.velocity = new Vector2(-moveSpeed, 0);
            }

        }

         void StopChasingPlayer() 
        {
            rb2d.velocity = Vector2.zero;
        }

    }
}
