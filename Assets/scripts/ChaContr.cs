using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaContr : MonoBehaviour
{
    public GameObject MyCharacter;
    public Transform atthispoint;
    public bool stopSpawning = true;
    public float SpawnTime;
    public float SpawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 farePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        transform.position = new Vector3(Mathf.Clamp(farePos.x, -3f, 3f), transform.position.y, transform.position.z);

        
    }
    private void FixedUpdate()
    {
        if (Input.touchCount > 0)
        {
            Touch Finger = Input.GetTouch(0);
            if (Finger.phase == TouchPhase.Stationary)
            {
                stopSpawning = true;
                Debug.Log("dokundun");
                InvokeRepeating("SpawnObject", SpawnTime, SpawnDelay);
            }
            if (Finger.phase == TouchPhase.Ended)
            {
                Debug.Log("bitti");
                stopSpawning = true;
            }
        }
    }
    public void SpawnObject()
    {
        Instantiate(MyCharacter, atthispoint.position, atthispoint.rotation);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
    
    


}
