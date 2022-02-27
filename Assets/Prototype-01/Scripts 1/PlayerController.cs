using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private SpawnManager SM;


    public GameObject powerupIndicator;
    public GameObject EntryWall;
    public GameObject resetPoint;

    public int Score;
    public TMP_Text scoreText;

    public float speed = 2.0f;
    public float powerupStrength = 15.0f;

    public bool hasPowerup;
    public bool hasInstaKill;




    void Start()
    {
        SM = GetComponent<SpawnManager>();
        playerRb = GetComponent<Rigidbody>();
        resetPoint = GameObject.Find("Reset_Point");

        
    }
   

    void Update()
    {
        //wasd, arrow imput movement
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(Horizontal, 0.0f, Vertical);
        playerRb.AddForce(move * speed);

        scoreText.text = "score: " + Score;
       
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


        //fix into wall repair
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }

        if (other.CompareTag("InstaKill"))
        {
            hasInstaKill = true;
           // Score += 1;
            Destroy(other.gameObject);
            StartCoroutine(IKCountdownRoutine());
        }

        if (other.CompareTag("EntryTrigger"))
        {
            EntryWall.gameObject.SetActive(true);
        }

         if (other.gameObject.CompareTag("Respawn"))
        {
            Debug.Log("test");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        

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
            // Debug.Log("YOOOOOOO");
            Score += 1;
            Destroy(collision.gameObject);
        }

        
    }




}
