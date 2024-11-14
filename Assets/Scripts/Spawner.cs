using UnityEngine; /*Hamie Nouri | 30.09.2024*/

public class Spawner : MonoBehaviour
{
    //================================> Declarations <=============================//
    public GameObject coin;             //The game object we want to spawn
    public int numberToSpawn = 10;      //The number of object we want it to paste
    public float distanceCoin = 2.0f;   //The gap we want between each coin after spawn

    /*-----------------------------------> START <---------------------------------
    * Step 1: Start a For Loop
    * Step 2: Check if "i" is less than the number to spawn, then do the loop, if not-> nvm
    * Step 3: Instantiate coin prefab, move its position to 000, keep rotation the same;
    */
    void Start()
    {
        //Step 1 & 2
        for (var i = 0; i < numberToSpawn; i++) 
        {
            //Step 3
            Instantiate(coin, new Vector3(i * distanceCoin, 0, 0), Quaternion.identity);
        }
    }
}
