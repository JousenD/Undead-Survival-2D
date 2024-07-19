using UnityEngine;

namespace JousenD.UndeadSurvival2d.Persistance.Scriptable
{
    [CreateAssetMenu(fileName = "GameStateSO", menuName = "Game/Game State SO")]
    public class GameStateSO : GameDataContainerSO
    {
        [SerializeField]
        private FloatValueSO _gameTimeSO;

        [SerializeField]
        private IntValueSO _gameStageSO;

        [SerializeField]
        private BoolValueSO _isGameOverSO;

        public bool IsGameOver
        {
            get => _isGameOverSO.RuntimeValue;
            set => _isGameOverSO.RuntimeValue = value;
        }

        public float GameTime
        {
            get => _gameTimeSO.RuntimeValue;
            set => _gameTimeSO.RuntimeValue = value;
        }

        public int GameStage
        {
            get => _gameStageSO.RuntimeValue;
            set => _gameStageSO.RuntimeValue = value;
        }

        public override void Reset()
        {
            _gameTimeSO.ResetValue();
            _gameStageSO.ResetValue();
            _isGameOverSO.ResetValue();

        }
    }
}