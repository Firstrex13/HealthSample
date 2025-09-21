using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _hitButton;

    [SerializeField] private int _hitAmount;

    private void OnEnable()
    {
        _hitButton.onClick.AddListener(TakeDamage);
    }

    private void OnDisable()
    {
        _hitButton.onClick.RemoveListener(TakeDamage);
    }

    private void Awake()
    {
        _hitButton = GetComponent<Button>();
    }

    private void TakeDamage()
    {
        _health.TakeDamage(_hitAmount);
    }
}
