using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _damageAmount;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            var healthController = collision.gameObject.GetComponent<HealthController>();
            healthController.TakeDamage(_damageAmount);
        }
    }
}
