using UnityEngine;
using UnityEngine.UI;

public class Heal : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Button _healButton;

    [SerializeField] private int _healAmount;

    private void OnEnable()
    {
        _healButton.onClick.AddListener(ChangeValue);
    }

    private void OnDisable()
    {
        _healButton.onClick.RemoveListener(ChangeValue);
    }

    private void Awake()
    {
        _healButton = GetComponent<Button>();
    }

    private void ChangeValue()
    {
        _health.ApplyHeal(_healAmount);
    }
}
