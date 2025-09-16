using System.Collections;
using System.Collections.Generic;
using TEngine;
using UnityEngine;

namespace GameLogic
{
    public class LoginUITest : MonoBehaviour
    {
        private int iCount = 0;
        // Start is called before the first frame update
        void Start()
        {
            Log.Info("LoginUITest.Start()");
        }

        public void OnClick_Test()
        {
            Log.Info("LoginUITest.OnClick_Test() iCount = {0}", iCount++);
        }
    }
}
