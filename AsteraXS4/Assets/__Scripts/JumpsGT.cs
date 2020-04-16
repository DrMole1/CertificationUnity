using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JumpsGT : MonoBehaviour
{

    const int COORDSAFE = 100;
    const int PADDING = 2;

    // Declaration of variables
    // =========================================

    [Header("Number of Jumps")]
    public int jumps = 3;

    [SerializeField]
    [Range(2, 5)]
    float timeToReappear = 3f;

    GameObject testSafeZoneObject;
    TestSafeZone testSafeZone;
    GameObject playerShip;
    Text txtJumps;

    // =========================================



    void Awake()
    {
        testSafeZoneObject = GameObject.Find("TestSafeZone");
        testSafeZone = testSafeZoneObject.GetComponent<TestSafeZone>();
        playerShip = GameObject.Find("PlayerShip");
        txtJumps = GetComponent<Text>();
    }


    void Start()
    {
        ShowJumps();
    }


    void Update()
    {
        // Update is necessary to enabled/disabled script in the inspector
    }


    /// <summary>
    /// Teleport the playerShip to a safe place out of the screen.
    /// </summary>
    /// <param name="actor">The GameObject would be disappear : the playerShip</param>
    public void Disappear(GameObject actor)
    {

        actor.transform.position = new Vector3(COORDSAFE, COORDSAFE, 0);

        Invoke("CheckReappear", timeToReappear);
    }


    /// <summary>
    /// We find a safe place zone.
    /// </summary>
    public void CheckReappear()
    {
        
        bool SafeZoneFound = false;
        float coordX = 0f;
        float coordY = 0f;
        Vector2 sizeBackground = GameObject.Find("Space_Background").GetComponent<SpriteRenderer>().size;

        do
        {
            // To not spawn ship under UI we use padding
            coordX = Random.Range(-sizeBackground.x + PADDING, sizeBackground.x - PADDING);
            coordY = Random.Range(-sizeBackground.y + PADDING, sizeBackground.y - PADDING);

            testSafeZoneObject.transform.position = new Vector3(coordX, coordY, 0);

            if (!testSafeZone.IsTouchingAsteroid)
            {
                Jump(coordX, coordY);
                SafeZoneFound = true;
            }

            ResetTestSafeZone();

        } while (!SafeZoneFound);
    }


    /// <summary>
    /// We reset the position of the object TestSafeZone and we reset the variables of it script.
    /// </summary>
    void ResetTestSafeZone()
    {
        testSafeZoneObject.transform.position = new Vector3(COORDSAFE, COORDSAFE, 0);
        testSafeZone.IsTouchingAsteroid = false;
    }


    /// <summary>
    /// Teleport the playerShip to a safe place within the screen, in game.
    /// </summary>
    void Jump(float coordX, float coordY)
    {

        if (jumps > 0)
        {
            jumps--;
            ShowJumps();
            playerShip.transform.position = new Vector3(coordX, coordY, 0);
        }
        else
            StartCoroutine(Defeat());
    }


    /// <summary>
    /// Generate the new actual number of jumps on the screen.
    /// </summary>
    void ShowJumps()
    {
        txtJumps.text = string.Concat(jumps.ToString(), " Jumps");
    }


    /// <summary>
    /// Destroy the ship and restart the level
    /// </summary>
    IEnumerator Defeat()
    {
        Destroy(playerShip);

        yield return new WaitForSeconds(timeToReappear);

        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
