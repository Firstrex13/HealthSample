using UnityEngine;
using UnityEngine.UI;

public class HealthViewSlider : HealthViewBasic
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Gradient _gradient;
    [SerializeField] private Image _fillColor;

    public override void UpdateValue()
    {
        float currentValue = Health.CurrentHealth / Health.MaxValue;

        _slider.value = currentValue;
        _fillColor.color = _gradient.Evaluate(_slider.value);
    }
}
