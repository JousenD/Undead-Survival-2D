using UnityEngine;

namespace JousenD.UndeadSurvival2d.UI
{
    public class HealthBar : SliderBar
    {
        [SerializeField]
        private HealthSO _healthSO;

        private void Update()
        {
            SetValue(_healthSO.CurrentHealth, _healthSO.MaxHealth);
        }
    }
}