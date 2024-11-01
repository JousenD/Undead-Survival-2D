using JousenD.UndeadSurvival2d.UI;
using UnityEngine;
using TMPro;
using JousenD.UndeadSurvival2d.Persistance.Scriptable;
using System.Threading.Tasks;
using UnityEngine.UI;




namespace JousenD.UndeadSurvival2d.Manager
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; private set; }

        public string NiceTime
        {
            get
            {
                var gameTime = _gameStateSO.GameTime;
                int minutes = Mathf.FloorToInt(gameTime / 60f);
                int seconds = Mathf.FloorToInt(gameTime - minutes * 60);
                string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);
                return niceTime;
            }
        }

        public RectTransform DamageCanvas;
        public GameObject DamageTextPrefab;
        public TextMeshProUGUI LevelText;
        public TextMeshProUGUI TimerText;
        public Image DeathOverlay;
        public Button QuitButton;



        [SerializeField]
        private ExperienceBar _expBar;

        [SerializeField]
        private GameStateSO _gameStateSO;


        [SerializeField]
        private IntValueSO _levelSO;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            LevelText.text = $"lvl: {_levelSO.RuntimeValue}";
            TimerText.text = NiceTime;

        }

        public void SetExperience(int exp, int maxExp)
        {
            _expBar.SetValue(exp, maxExp);
        }
        
        
        public void ShowDamage(int damage, Transform target)
        {
            var damageGO = Instantiate(DamageTextPrefab, DamageCanvas.transform);
            var damageDisplay = damageGO.GetComponent<DamageDisplay>();

            damageDisplay.ShowDamage(damage, target, DamageCanvas);
        }

        public async Task DisplayLooseScreen()
        {
            var progress = 0f;

            while (progress <= 0.5f)
            {
                progress += 0.01f;

                DeathOverlay.color = new Color(
                    DeathOverlay.color.r,
                    DeathOverlay.color.g,
                    DeathOverlay.color.b,
                    progress
                );

                await Task.Delay(10);
            }

            QuitButton.gameObject.SetActive(true);
        }
    }
}
