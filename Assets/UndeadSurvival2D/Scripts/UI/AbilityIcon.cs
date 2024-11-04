using System;
using UnityEngine;
using UnityEngine.UI;

namespace JousenD.UndeadSurvival2d.UI
{
    public class AbilityIcon : MonoBehaviour
    {
        public Image CooldownImage;

        private Func<float> GetOverallCooldown;
        private Func<float> GetCurrentCooldown;

        private void Start()
        {
            // enabled = false;
        }

        private void Awake()
        {
            enabled = false;
        }

        private void Update()
        {
            CooldownImage.fillAmount = GetCurrentCooldown() / GetOverallCooldown();
        }

        public void InitIcon(
            Sprite icon,
            Func<float> getOverallCooldown,
            Func<float> getCurrentCooldown
        )
        {
            GetComponent<Image>().sprite = icon;
            GetOverallCooldown = getOverallCooldown;
            GetCurrentCooldown = getCurrentCooldown;
            enabled = true;
        }

    }
}