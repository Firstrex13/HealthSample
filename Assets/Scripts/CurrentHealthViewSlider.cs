using UnityEngine;
using UnityEngine.UI;

public class CurrentHealthViewSlider : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _slider;
    [SerializeField] private Gradient _gradient; 
    [SerializeField] private Image _fillColor;

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

    private void UpdateValue()
    {
        float currentValue = _health.CurrentHealth / _health.MaxValue;

        _slider.value = currentValue;
        _fillColor.color = _gradient.Evaluate(_slider.value);

    }
}
