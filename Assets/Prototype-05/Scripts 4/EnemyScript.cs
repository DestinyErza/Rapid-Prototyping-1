using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    //  public EnemyType myType;
    // public PatrolType patrolType;
    int patrolPoint = 0;  //needed for linear patrol
    bool reverse = false;  //eneeded for repeat patrol


    public PatrolType patrolType;

  

     Transform moveToPos;
   
    public float mySpeed;
    public float myHealth;
    public int _damage = 1;


    Animator anim;
    NavMeshAgent agent;
    int currentWaypoint;
    float detectDistance = 10f;
    float detectTime = 5f;
    float attackDistance = 3f;
    public bool attacking;
    public AudioSource enemyfootsteps;

    PlayerController5 _P;
    EnemyManager _EM;




    void Start()
    {

        _P = PlayerController5.instance;
        _EM = EnemyManager.instance;

        anim = GetComponent<Animator>();

        moveToPos = _EM.spawnPoints[Random.Range(0, _EM.spawnPoints.Length)];
        agent = GetComponent<NavMeshAgent>();
        SetNav();


    }




    //changes between types of movement
    void Update()
    {

        float distToPlayer = Vector3.Distance(transform.position, _P.transform.position);

        if (distToPlayer <= attackDistance)
        {
            patrolType = PatrolType.Attack;
        }
        else if (distToPlayer <= detectDistance)
        {
            if (patrolType != PatrolType.Chase)
                patrolType = PatrolType.Detect;
        }

        //controls the patrols of enemy between detect attack and chase
        switch (patrolType)
        {
            case PatrolType.Attack:
                agent.SetDestination(transform.position);
                transform.LookAt(new Vector3(_P.transform.position.x, 0, _P.transform.position.z));
                Attack();
                break;
            case PatrolType.Chase:
                agent.SetDestination(_P.transform.position);
                ChangeSpeed(mySpeed * 2);
                if (distToPlayer > detectDistance)
                    patrolType = PatrolType.Detect;

                break;
            case PatrolType.Detect:
                agent.SetDestination(transform.position);
                ChangeSpeed(0);
                detectTime -= Time.deltaTime;
                if (detectTime <= 0)
                {
                    if (distToPlayer <= detectDistance)
                    {
                        if(_P.hiding == false)
                        {
                            patrolType = PatrolType.Chase;
                            detectTime = 2f;
                        }
                        else if(_P.hiding == true)
                        {
                            patrolType = PatrolType.Patrol;
                        }
                      
                    }

                    else
                    {
                        patrolType = PatrolType.Patrol;
                        SetNav();
                    }
                }
                break;

            case PatrolType.Patrol:
                float distToWaypoint = Vector3.Distance(transform.position, _EM.spawnPoints[currentWaypoint].position);
                if (distToWaypoint < 1)
                    SetNav();
                detectTime = 2f;


                break;



        }
    }
    void Attack()
    {
        if (!attacking)
        {
            attacking = true;
          //  anim.SetTrigger("Attack");
            StartCoroutine(ResetAttack());
        }
    }

    void SetNav()
    {
        currentWaypoint = Random.Range(0, _EM.spawnPoints.Length);
        agent.SetDestination(_EM.spawnPoints[currentWaypoint].position);
        ChangeSpeed(mySpeed);
    }
    void ChangeSpeed(float _speed)
    {
        agent.speed = _speed;
    }

    public void Hit(int _damage)
    {
        //causes damage on hit
        Debug.Log("test");
        myHealth -= _damage;
        anim.SetTrigger("Hit");
        if (myHealth <= 0)
            Die();
        //else
        //    GameEvents.ReportEnemyHit(gameObject);
    }

    //kills enemy at 0 health
    void Die()
    {
        anim.SetTrigger("Die");
     //   GameEvents.ReportEnemyDied(gameObject);
    }


    //sets timer to allow attacks every 2 seconds max
    IEnumerator ResetAttack()
    {
        yield return new WaitForSeconds(2);
        attacking = false;
    }
    int RandomAnimation()
    {
        return Random.Range(1, 3);
    }

}
