using System.Collections.Generic;
using UnityEngine;

namespace Core.Animation
{
    public class SpriteAnimator : MonoBehaviour
    {
        [SerializeField] private List<Animation> _animations = new List<Animation>();
        [SerializeField] private SpriteRenderer _renderer;

        private double startTime, currentTime;
        private Animation _current;

        private void OnEnable()
        {
            AnimationExecutor.UpdateTimer += Update;
        }
        private void OnDisable()
        {
            AnimationExecutor.UpdateTimer -= Update;
        }

        public void Switch(string name)
        {
            Animation anim = _animations.Find((Animation anim) => anim.Name == name);

            if (anim == null)
                return;

            _current = anim;
            startTime = currentTime;
            Update(currentTime);
        }

        private void Update(double time)
        {
            currentTime = time;
            _renderer.sprite = _current.Get(currentTime - startTime);
        }
    }
}