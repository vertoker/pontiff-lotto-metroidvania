using Core.Input.Keys;

namespace Core.Entities.Interfaces
{
    interface IInput
    {
        public void SetKeyDown(KeyMovement key);
        public void SetKeyDown(KeyWorldInteraction key);
        public void SetKeyDown(KeyFighting key);
        public void SetKeyDown(KeySwitchWeapon key);
        /// /// /// /// /// /// /// /// /// /// /// /// /// ///
        public void SetKeyUp(KeyMovement key);
        public void SetKeyUp(KeyWorldInteraction key);
        public void SetKeyUp(KeyFighting key);
        public void SetKeyUp(KeySwitchWeapon key);
    }
}
