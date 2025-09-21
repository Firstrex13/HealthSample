using UnityEngine;

public class HealthViewBasic : MonoBehaviour
{
    [SerializeField] private Health _health;

    protected Health Health => _health;

    private void OnEnable()
    {
        _health.Hit += UpdateValue;
        _health.Healed += UpdateValue;
    }

    private void OnDisable()
    {
        _health.Hit -= UpdateValue;
        _health.Healed -= UpdateValue;
    }

    public virtual void UpdateValue() { }
}
