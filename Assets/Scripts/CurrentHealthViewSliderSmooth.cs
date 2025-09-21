using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHealthViewSliderSmooth : MonoBehaviour
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
        StartCoroutine(nameof(ChangeValue));
    }

    private IEnumerator ChangeValue()
    {
        float duration = 1f;
        float time = 0f;

        while (time < duration)
        {
            time += Time.deltaTime;

            float currentValue = _health.CurrentHealth / _health.MaxValue;

            _slider.value = Mathf.MoveTowards(_slider.value, currentValue, Time.deltaTime);

            _fillColor.color = _gradient.Evaluate(_slider.value);

            yield return null;
        }
    }
}
