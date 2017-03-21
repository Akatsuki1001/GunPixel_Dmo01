using UnityEngine;
using System.Collections;

public class EnemyXLController : MonoBehaviour {
    Transform enemyXL;
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
}
