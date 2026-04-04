using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollctableBehaviour : MonoBehaviour, ICollectableBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private float _healthAmount;
    public void OnCollected(GameObject player)
    {
        player.GetComponent<HealthController>().AddHealth(_healthAmount);
    }
}
