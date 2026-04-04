using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectableBehaviour
{
    // Start is called before the first frame update
    void OnCollected(GameObject player);
}
