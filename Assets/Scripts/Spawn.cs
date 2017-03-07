using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {
    public GameObject objectToSpawn;
    public GameObject instantiatedObj;
    private Vector3 spawnPosition;
    private GameObject spawnedEnemy;
    private int[] spawnPoint = new int[3];
    public int spawnReq = 0;
    public bool spawnPlease = false;
    private int rotation = 0;
    public int spawnCycle = 3;
    public int time;
    private int i = 0, randomSpawn = 0;
    private string location;

	// Use this for initialization
	void Start () {
        //enemySpawn();
        for(int j = 0; j < 3; j++)
        {
            spawnPoint[j] = -1;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (spawnPlease) //find if spawnReq is already inside queue
        {
            int check = 0;
            while (true)
            {
                if (spawnPoint[i] == spawnReq)
                {
                    Debug.Log("Same found in queue, quitting");
                    break;
                }
                else if (check == 3) //checked for three times but no match, add to next element
                {
                    Debug.Log("Checked for three times but no match, add to next element");
                    spawnPoint[(i + 1) % 3] = spawnReq;
                    check = 0;
                }
                i = (i + 1) % 3;
                check++;
            }
        }

        time = (int) Time.time;
        if (time % spawnCycle == 0)
        {
            Destroy(instantiatedObj);
            //Debug.Log(time);
            randomSpawn = (int)Random.Range(0f, 2.9f);
            //Debug.Log("The next to be spawned in queue is position " + randomSpawn);
            /*switch (randomSpawn)
            {
                case 1:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt1").position, Quaternion.identity);
                    break;
                case 2:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt2").position, Quaternion.identity);
                    break;
                case 3:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt3").position, Quaternion.identity);
                    break;
                case 4:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt4").position, Quaternion.identity);
                    break;
                case 5:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt5").position, Quaternion.identity);
                    break;
                case 6:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt6").position, Quaternion.identity);
                    break;
                case 7:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt7").position, Quaternion.identity);
                    break;
                case 8:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt8").position, Quaternion.identity);
                    break;
                case 9:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt9").position, Quaternion.identity);
                    break;
                case 10:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt10").position, Quaternion.identity);
                    break;
                case 11:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt11").position, Quaternion.identity);
                    break;
                case 12:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt12").position, Quaternion.identity);
                    break;
                case 13:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt13").position, Quaternion.identity);
                    break;
                case 14:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt14").position, Quaternion.identity);
                    break;
                case 15:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt15").position, Quaternion.identity);
                    break;
                case 16:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt16").position, Quaternion.identity);
                    break;
                case 17:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt17").position, Quaternion.identity);
                    break;
                case 18:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt18").position, Quaternion.identity);
                    break;
                case 19:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt19").position, Quaternion.identity);
                    break;
                case 20:
                    instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt20").position, Quaternion.identity);
                    break;
                default:
                    break;
            }*/
            location = "spawnPt" + spawnPoint[randomSpawn].ToString();
            instantiatedObj = (GameObject)Instantiate(objectToSpawn, transform.Find("spawnPt" + spawnPoint[randomSpawn].ToString()).position, Quaternion.identity);
            
        }
    }

    /*void spawnSeqUpdate(int spawnpoint)
    {
        if (spawnpoint != lastspawnReq)
        {
            if (spawnpoint != spawnPoint[rotation])
            {
                
            }
            
        }*/

    /*void enemySpawn()
    {

       
    }*/
    



}
  