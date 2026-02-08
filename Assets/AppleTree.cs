using UnityEngine;
using System.Collections;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 10f;
    public float leftAndRightEdge = 24f;
    public float changeDirChance = 0.02f;
    public float appleDropDelay = 1f;

    void Start()
    {
        InvokeRepeating("DropApple", 2f, appleDropDelay);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }

        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        Vector3 spawnPos = transform.position;
spawnPos.y -= 12f;   // adjust this number as needed
Instantiate(applePrefab, spawnPos, Quaternion.identity);
    }
}