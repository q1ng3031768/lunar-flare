using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class enemybehaviour : MonoBehaviour
{

    public GameObject manager; 
    public float lookRadius = 15f;
    public float health = 3;

    Transform target;
    NavMeshAgent agent;

    void Start()
    {
        target = manager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Get the distance to the player
        float distance = Vector3.Distance(target.position, transform.position);

        // If inside the radius
        if (distance <= lookRadius)
        {
            // Move towards the player
            agent.SetDestination(target.position);
            //if (distance <= agent.stoppingDistance){}
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }

    // Point towards the player
    void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }

    public void damage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            perish();
        }
    }

    void perish()
    {
        Destroy(GameObject);
    }
}