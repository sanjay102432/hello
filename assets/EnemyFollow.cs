using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player;

    public float speed = 3f;

    public float followDistance = 5f;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if (distance < followDistance)
        {
            transform.position = Vector2.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime
            );
        }
    }
}