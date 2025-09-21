using TMPro;
using UnityEngine;

public class CurrentHealthTextView : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private TextMeshProUGUI _currentHealthText;
    [SerializeField] private TextMeshProUGUI _maxHealth;


    private void OnEnable()
    {
        _health.Hit += UpdateText;
        _health.Healed += UpdateText;
    }

    private void OnDisable()
    {
        _health.Hit -= UpdateText;
        _health.Healed -= UpdateText;
    }

    private void Start()
    {
        _maxHealth.text = _health.MaxValue.ToString();
        _currentHealthText.text = _health.MaxValue.ToString();
    }

    private void UpdateText()
    {
        _currentHealthText.text = _health.CurrentHealth.ToString();
    }
}
