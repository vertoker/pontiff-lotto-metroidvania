using Core.Input.Keys;
using UnityEngine;

namespace Core.Entities.Controllers
{
    public class InputBlock : MonoBehaviour
    {
        public virtual void SetKeyDown(KeyMovement key)
        {

        }
        public virtual void SetKeyDown(KeyWorldInteraction key)
        {

        }
        public virtual void SetKeyDown(KeyFighting key)
        {

        }
        public virtual void SetKeyDown(KeySwitchWeapon key)
        {

        }
        /// /// /// /// /// /// /// /// /// /// /// /// /// ///
        public virtual void SetKeyUp(KeyMovement key)
        {

        }
        public virtual void SetKeyUp(KeyWorldInteraction key)
        {

        }
        public virtual void SetKeyUp(KeyFighting key)
        {

        }
        public virtual void SetKeyUp(KeySwitchWeapon key)
        {

        }
    }
}