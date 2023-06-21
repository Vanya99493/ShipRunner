using UnityEngine;

namespace Infrastructure 
{
    public class GameBootrstraper : MonoBehaviour
    {
        private void Awake()
        {
            Game game = new Game();
        }
    }
}