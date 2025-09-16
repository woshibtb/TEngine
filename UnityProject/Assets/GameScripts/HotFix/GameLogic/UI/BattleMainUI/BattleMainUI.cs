using UnityEngine;
using UnityEngine.UI;
using TEngine;

namespace GameLogic
{
	[Window(UILayer.UI, location: "BattleMainUI")]
	partial class BattleMainUI : UIWindow
	{
		#region 脚本工具生成的代码
		private RectTransform _rectContainer;
		private GameObject _itemTouch;
		private Button _btnBack;
		private Button _btnTestCoroutine;
		private Button _btnTestUpdate;
		private GameObject _goTopInfo;
		private GameObject _itemRoleInfo;
		private GameObject _itemMonsterInfo;
		protected override void ScriptGenerator()
		{
			_rectContainer = FindChildComponent<RectTransform>("m_rectContainer");
			_itemTouch = FindChild("m_rectContainer/m_itemTouch").gameObject;
			_btnBack = FindChildComponent<Button>("m_rectContainer/m_btnBack");
			_btnTestCoroutine = FindChildComponent<Button>("m_rectContainer/m_btnTestCoroutine");
			_btnTestUpdate = FindChildComponent<Button>("m_rectContainer/m_btnTestUpdate");
			_goTopInfo = FindChild("m_goTopInfo").gameObject;
			_itemRoleInfo = FindChild("m_goTopInfo/m_itemRoleInfo").gameObject;
			_itemMonsterInfo = FindChild("m_goTopInfo/m_itemMonsterInfo").gameObject;
			_btnBack.onClick.AddListener(OnClickBackBtn);
			_btnTestCoroutine.onClick.AddListener(OnClickTestCoroutineBtn);
			_btnTestUpdate.onClick.AddListener(OnClickTestUpdateBtn);
		}
		#endregion

		#region 事件
		

		#endregion

	}
}
