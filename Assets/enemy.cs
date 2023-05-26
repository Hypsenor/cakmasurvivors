using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float attackRange = 3f;
    public float attackCooldown = 1f;
    private float lastAttackTime;

    private void Start()
    {
        // Oyuncuyu bulmak için etiketini kullanabilirsiniz.
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Oyuncuya do?ru yönelin
        Vector3 direction = player.position - transform.position;
        transform.Translate(direction.normalized * moveSpeed * Time.deltaTime, Space.World);

        // Oyuncuya sald?r?n
        if (direction.magnitude <= attackRange && Time.time >= lastAttackTime + attackCooldown)
        {
            AttackPlayer();
            lastAttackTime = Time.time;
        }
    }

    private void AttackPlayer()
    {
        // Oyuncuya sald?rma kodunu buraya yazabilirsiniz.
        Debug.Log("Oyuncuya sald?r?ld?!");
    }
}
