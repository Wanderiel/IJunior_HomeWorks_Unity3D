using UnityEngine;

namespace BattleForPlatformer
{
    [CreateAssetMenu(fileName = "CharacterConfig", menuName = "Config/CharacterConfig")]
    public class CharacterConfig : ScriptableObject
    {
        [SerializeField] private RunningStateConfig _runningStateConfig;
        [SerializeField] private AirborneStateConfig _airborneStateConfig;

        public RunningStateConfig RunningStateConfig => _runningStateConfig;
        public AirborneStateConfig AirborneStateConfig => _airborneStateConfig;
    }
}
