using UnityEngine;
using System.Collections;

public class EnemyXLController : MonoBehaviour
{
    /* GameObject _character;
     public GameObject _enemy;

    public  Transform enemyXL;
     // Use this for initialization
     NavMeshAgent nav;
     void Awake() {
         enemyXL = GameObject.FindGameObjectWithTag("Player").transform;
         nav = GetComponent<NavMeshAgent>();
             }
     // Update is called once per frame
     void Update () {
         nav.SetDestination(enemyXL.position);

     }
     */

    public Transform Target;
    private GameObject Enemy;
    private GameObject Player;
    private float Range;
    public float Speed;


    // Use this for initialization
    void Start()
    {
        Enemy = GameObject.FindGameObjectWithTag("EnemyXL");
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    { /*
        //Vector2.Distance = enemy.transform.position - player.transform.position
       Range = Vector2.Distance(Enemy.transform.position, Player.transform.position);
         if (Range <= 15f)
         {
             transform.Translate(Vector2.MoveTowards(Enemy.transform.position, Player.transform.position, Range) * Speed * Time.deltaTime);
         }
         */

        Vector2 velocity = new Vector2((transform.position.x - Player.transform.position.x) * Speed, (transform.position.y - Player.transform.position.y) * Speed);
        GetComponent<Rigidbody2D>().velocity = -velocity;

    }
}
