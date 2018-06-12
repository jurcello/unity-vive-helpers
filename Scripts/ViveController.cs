using UnityEngine;
using HTC.UnityPlugin.Vive;

namespace pipslab { 
    public class ViveController : MonoBehaviour {
        [SerializeField]
        private ViveRoleProperty m_viveRole = ViveRoleProperty.New(HandRole.RightHand);

        public enum TouchPadPosition {
            Up,
            Left,
            Down,
            Right,
            Center
        };

        protected TouchPadPosition GetTouchPosition()
        {
            Vector2 axis = ViveInput.GetPadAxis(m_viveRole);
            if (axis.x > -0.5 && axis.x < 0.5 && axis.y < 0)
            {
                return TouchPadPosition.Down;
            }
            else if (axis.x > -0.5 && axis.x < 0.5 && axis.y > 0)
            {
                return TouchPadPosition.Up;
            }
            else if (axis.x < 0 && axis.y < 0.5 && axis.y > -0.5)
            {
                return TouchPadPosition.Left;
            }
            else if (axis.x > 0 && axis.y < 0.5 && axis.y > -0.5)
            {
                return TouchPadPosition.Right;
            }
            return TouchPadPosition.Center;
        }

        // Use this for initialization
        void Start () {
		
	    }

        protected bool GetTouchPadDown(TouchPadPosition direction)
        {
            if (ViveInput.GetPressDown(m_viveRole, ControllerButton.Pad))
            {
                if (GetTouchPosition() == direction) { 
                    return true;
                }
            }
            return false;
        }

        protected bool GetTouchPadUp(TouchPadPosition direction)
        {
            if (ViveInput.GetPressUp(m_viveRole, ControllerButton.Pad))
            {
                if (GetTouchPosition() == direction)
                {
                    return true;
                }
            }
            return false;
        }


        protected bool GetTouchPadDown()
        {
            if (ViveInput.GetPressDown(m_viveRole, ControllerButton.Pad))
            {
                return true;
            }
            return false;
        }

        protected bool GetTouchPadUp()
        {
            if (ViveInput.GetPressUp(m_viveRole, ControllerButton.Pad))
            {
                return true;
            }
            return false;
        }

        protected bool GetTriggerDown()
        {
            if (ViveInput.GetPressDown(m_viveRole, ControllerButton.Trigger))
            {
                return true;
            }
            return false;
        }

        protected bool GetTriggerUp()
        {
            if (ViveInput.GetPressUp(m_viveRole, ControllerButton.Trigger))
            {
                return true;
            }
            return false;
        }

        protected bool GetGripDown()
        {
            if (ViveInput.GetPressDown(m_viveRole, ControllerButton.Grip))
            {
                return true;
            }
            return false;
        }

        protected bool GetGripUp()
        {
            if (ViveInput.GetPressUp(m_viveRole, ControllerButton.Grip))
            {
                return true;
            }
            return false;
        }

        protected bool GetMenuDown()
        {
            if (ViveInput.GetPressDown(m_viveRole, ControllerButton.Menu))
            {
                return true;
            }
            return false;
        }

        protected bool GetMenuUp()
        {
            if (ViveInput.GetPressUp(m_viveRole, ControllerButton.Menu))
            {
                return true;
            }
            return false;
        }
    }
}