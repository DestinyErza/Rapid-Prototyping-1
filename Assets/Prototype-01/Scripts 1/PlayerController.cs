using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private SpawnManager SM;
    private GameObject focalPoint;
    public GameObject powerupIndicator;
    public GameObject Wall;

    public float speed = 5.0f;
    public float powerupStrength = 15.0f;

    public bool hasPowerup;
    public bool hasInstaKill;





    void Start()
    {
        SM = GetComponent<SpawnManager>();
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }
    /// <summary>
    /// moves player using vertical input based on the focal point
    /// </summary>

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        //places poweup below player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        if (hasInstaKill == true)
        {
            hasPowerup = false;
        }
    }


    /// <summary>
    /// applies powerup and destroys the game object + turns on indicator
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }

        //turns on wall+ rns ienumerator to turn it off
        if (other.CompareTag("WallUP"))
        {
            Wall.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(WallCountdownRoutine());
        }

        if (other.CompareTag("InstaKill"))
        {
            hasInstaKill = true;
            Destroy(other.gameObject);
            StartCoroutine(IKCountdownRoutine());
        }

        //trap triggers falling objects


        /*if (other.CompareTag("Trap"))
        {
            Debug.Log("uh oh");
            Destroy(other.gameObject);
            SM.SpawnFall();
        }*/
    }


    

    /// <summary>
    /// after powerup is picked up, wait (seconds) until it is turned off + turns off inddicator
    /// </summary>
    /// <returns></returns>
    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
    //wallcountdown
    IEnumerator WallCountdownRoutine()
    {
        yield return new WaitForSeconds(10);
        Wall.gameObject.SetActive(false);
    }
    //InstaKillcountdown
    IEnumerator IKCountdownRoutine()
    {
        yield return new WaitForSeconds(10);
        hasInstaKill = false;
    }

    /// <summary>
    /// when player collides with enemy + has powerup / powerup is applied
    /// </summary>
    /// <param name="collision"></param>

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Collided with" + collision.gameObject.name + "with powerup set to" + hasPowerup);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }

        else if (collision.gameObject.CompareTag("Enemy") && (hasInstaKill == true))
        {
            Debug.Log("YOOOOOOO");
            Destroy(collision.gameObject);
        }
    }


}
