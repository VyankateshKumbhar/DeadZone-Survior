using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    
    public UnityEvent onScoreChanged;
    public int score { get; private set; }

    public void AddScore(int amount)
    {
        score += amount;
        onScoreChanged.Invoke();
    }

}
