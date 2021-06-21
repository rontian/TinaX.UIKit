using UnityEngine;

namespace TinaX.UIKit.Router
{
    public class UIGroupRouter : IRouter
    {
        private readonly UIGroup m_Group;

        public UIGroupRouter(UIGroup group)
        {
            this.m_Group = group;
        }

        public bool TryGetUILoadPath(string uiName, out string uiLoadPath)
        {
            if(m_Group != null)
            {
                return m_Group.TryGetPath(uiName, out uiLoadPath);
            }
            else
            {
                uiLoadPath = default;
                Debug.LogWarningFormat("[TinaX.UIKit]UI Group is empty.");
                return false;
            }
        }
    }
}
