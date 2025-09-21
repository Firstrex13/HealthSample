using TMPro;
using UnityEngine;

public class HealthTextView : HealthViewBasic
{
    [SerializeField] private TextMeshProUGUI _currentHealthText;
    [SerializeField] private TextMeshProUGUI _maxHealth;

    private void Start()
    {
        _maxHealth.text = Health.MaxValue.ToString();
        _currentHealthText.text = Health.MaxValue.ToString();
    }

    public override void UpdateValue()
    {
        _currentHealthText.text = Health.CurrentHealth.ToString();
    }
}
