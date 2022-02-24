using Core.Entities.Controllers;
using Core.Entities.Interfaces;
using Core.Input.Keys;
using UnityEngine;

namespace Core.Input
{
    public class InputReceiver : MonoBehaviour, IInput
    {
        [SerializeField] private Controller _target;

        public void SetKeyDown(KeyMovement key)
        {
            _target.SetKeyDown(key);
        }
        public void SetKeyDown(KeyWorldInteraction key)
        {
            _target.SetKeyDown(key);
        }
        public void SetKeyDown(KeyFighting key)
        {
            _target.SetKeyDown(key);
        }
        public void SetKeyDown(KeySwitchWeapon key)
        {
            _target.SetKeyDown(key);
        }
        /// /// /// /// /// /// /// /// /// /// /// /// /// ///
        public void SetKeyUp(KeyMovement key)
        {
            _target.SetKeyUp(key);
        }
        public void SetKeyUp(KeyWorldInteraction key)
        {
            _target.SetKeyUp(key);
        }
        public void SetKeyUp(KeyFighting key)
        {
            _target.SetKeyUp(key);
        }
        public void SetKeyUp(KeySwitchWeapon key)
        {
            _target.SetKeyUp(key);
        }
    }
}