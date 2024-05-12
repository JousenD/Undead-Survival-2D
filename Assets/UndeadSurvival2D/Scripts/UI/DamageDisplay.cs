using UnityEngine;
using TMPro;

using UnityCamera = UnityEngine.Camera;

namespace JousenD.UndeadSurvival2d.UI
{
    public class DamageDisplay : MonoBehaviour
    {
        public TextMeshProUGUI DamageText;
        private Transform _target;
        private RectTransform _canvas;

        private void Update()
        {
            //Debug.Log("Target null");
            if (_target == null) { return; }
            //Debug.Log("Target not null");

            float offsetPosY = _target.transform.position.y + 0.1f;
            var offsetPosition = new Vector3(
                _target.transform.position.x,
                offsetPosY,
                _target.transform.position.z
            );

            var screenPoint = UnityCamera.main.WorldToScreenPoint(offsetPosition);
            RectTransformUtility.ScreenPointToLocalPointInRectangle(
                _canvas,
                screenPoint,
                null,
                out Vector2 localPosition
            );

            transform.localPosition = localPosition;
            //transform.localPosition = new Vector2(-20,-20);
            
        }


        public void ShowDamage(
            int damage,
            Transform target,
            RectTransform canvas
        )
        {
            _canvas = canvas;
            _target = target;
            DamageText.text = damage.ToString();
            gameObject.SetActive(true);
        }

    }
}
