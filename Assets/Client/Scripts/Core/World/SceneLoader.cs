using Core.Loop;

using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace Core.World
{
    public class SceneLoader : MonoBehaviour
    {
        [SerializeField] private Transform target;
        [SerializeField] private LevelData[] _data;
        [SerializeField] private List<string> _activeSceneNames = new List<string>();

        private void OnEnable()
        {
            TimerLoop.UpdateTimer += ComputeLevelsLoad;
        }
        private void OnDisable()
        {
            TimerLoop.UpdateTimer -= ComputeLevelsLoad;
        }

        private void ComputeLevelsLoad(double time)//Требует оптимизации
        {
            Vector2 targetPosition = target.position;
            foreach (var level in _data)
            {
                if (level.InBounds(targetPosition))
                {
                    LoadSubScene(level.Name);
                }
                else
                {
                    UnloadSubScene(level.Name);
                }
                //Debug.Log(string.Join(" ", level.InBounds(target.position), level.Name));
            }
        }
        private void LoadSubScene(string name)
        {
            if (!_activeSceneNames.Contains(name))
            {
                SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
                _activeSceneNames.Add(name);
            }
        }
        private void UnloadSubScene(string name)
        {
            if (_activeSceneNames.Remove(name))
                SceneManager.UnloadSceneAsync(name);
        }
        public void LoadAll()
        {

        }
        public void UnloadAll()
        {

        }
    }
}