using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthBarUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private UnityEngine.UI.Image _healthBarForeGroundImage;

    public void UpdateHealthBar(HealthController healthController)
    {
        _healthBarForeGroundImage.fillAmount = healthController.RemainingHealthPercentage;
    }
}
