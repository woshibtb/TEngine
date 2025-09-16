using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TEngine;
using TEngine.Localization;

namespace GameLogic
{
    partial class BattleMainUI : UIWindow
    {
        private bool bRunUpdate = false;
        private int iUpdateCount = 0;

        private void OnClickBackBtn()
		{
			Close();
            GameModule.UI.ShowUIAsync<LoginUI>();
		}
		private void OnClickTestCoroutineBtn()
		{
			Log.Info("点击了Test按钮");
            CoroutineManager.Start(Co_Test());
		}
		private void OnClickTestUpdateBtn()
		{
			Log.Info("点击了TestUpdate按钮");
            bRunUpdate = true;
            iUpdateCount = 0;
		}

        protected override void OnUpdate()
        {
            if (bRunUpdate)
            {
                iUpdateCount++;
                Log.Info("OnUpdate iUpdateCount = {0}", iUpdateCount);
                if (iUpdateCount >= 5)
                {
                    bRunUpdate = false;
                    Log.Info("OnUpdate 结束");
                }
            }
        }

        private IEnumerator Co_Test()
        {
            int iCount = 0;
            while (iCount < 5)
            {
                iCount++;
                Log.Info("Co_Test iCount = {0}", iCount);
                yield return new WaitForSeconds(1);
            }
            Log.Info("Co_Test 结束");
        }
    }
}
