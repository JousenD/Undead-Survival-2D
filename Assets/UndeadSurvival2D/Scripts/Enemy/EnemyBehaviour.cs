using UnityEngine;
using System.Collections;
using JousenD.UndeadSurvival2d.Character;

namespace JousenD.UndeadSurvival2d.Enemy
{
    public class EnemyBehaviour : CharacterBehaviour
    {
        new void Start()
        {
            base.Start();
            Debug.Log("Init EnemyBehaviour");
        }

        void Update()
        {

        }
    }


}
