using UnityEngine;
using JousenD.UndeadSurvival2d.Character;
using JousenD.UndeadSurvival2d.Manager;
using JousenD.UndeadSurvival2d.Abilities.Scriptable;


namespace JousenD.UndeadSurvival2d.Abilities.Action
{
    public class AbilityAction : MonoBehaviour
    {
        public AbilitySO abilitySO;
        public Vector3 direction;
        public float range;
        public float currentDistance;



        private SpriteRenderer _sprite;
        private Collider2D _collider;
        private ActionModifier[] _actionModifiers;

        private void Start()
        {
            _sprite = GetComponent<SpriteRenderer>();
            _collider = GetComponent<Collider2D>();

            _actionModifiers = new ActionModifier[abilitySO.ActionModifiers.Length];

            for (var i = 0; i < _actionModifiers.Length; i++)
            {
                var modifier = abilitySO.ActionModifiers[i].GetActionModifier(this);
                _actionModifiers[i] = modifier;
            }
        }

        private void Update()
        {
            _sprite.flipX = GameManager.Instance.GetPlayer().GetFlipX();

            foreach (var modifier in _actionModifiers)
            {
                modifier.Update(this);
            }
        }
        // Reacts to animation event
        public void OnAbilityActivation()
        {
            _collider.enabled = true;
        }

        // Reacts to animation event
        public void OnAbilityDeActivation()
        {
            _collider.enabled = false;
        }

        public void DestroyAction()
        {
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if ((abilitySO.CollideWith.value & 1 << collision.transform.gameObject.layer) > 0)
            {
                if (collision.TryGetComponent<Damageable>(out var damageable))
                {
                    damageable.TakeDamage(abilitySO.Damage);
                }
            }
        }
    }
}
