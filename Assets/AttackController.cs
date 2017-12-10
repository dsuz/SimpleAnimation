using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    [SerializeField] float m_attackPower = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Rigidbody2D rb2d = collision.gameObject.GetComponent<Rigidbody2D>();
            rb2d.AddForce(Vector2.up * m_attackPower, ForceMode2D.Impulse);
        }
    }
}