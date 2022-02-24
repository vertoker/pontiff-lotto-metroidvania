using Core.Input.Keys;
using UnityEngine;

namespace Core.Entities.Controllers
{
    public class Controller : MonoBehaviour
    {
        [SerializeField] private InputBlock _movement;
        [SerializeField] private InputBlock _worldInteraction;
        [SerializeField] private InputBlock _fighting;
        [SerializeField] private InputBlock _switchWeapon;

        public void SetKeyDown(KeyMovement key)
        {
            _movement.SetKeyDown(key);
        }
        public void SetKeyDown(KeyWorldInteraction key)
        {
            _worldInteraction.SetKeyDown(key);
        }
        public void SetKeyDown(KeyFighting key)
        {
            _fighting.SetKeyDown(key);
        }
        public void SetKeyDown(KeySwitchWeapon key)
        {
            _switchWeapon.SetKeyDown(key);
        }
        /// /// /// /// /// /// /// /// /// /// /// /// /// ///
        public void SetKeyUp(KeyMovement key)
        {
            _movement.SetKeyUp(key);
        }
        public void SetKeyUp(KeyWorldInteraction key)
        {
            _worldInteraction.SetKeyUp(key);
        }
        public void SetKeyUp(KeyFighting key)
        {
            _fighting.SetKeyUp(key);
        }
        public void SetKeyUp(KeySwitchWeapon key)
        {
            _switchWeapon.SetKeyUp(key);
        }
    }
}