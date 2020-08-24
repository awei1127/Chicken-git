using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("MyCustomActions")]
	[Tooltip("在指定父物件下生成一個Game Object")]
	public class CreateObjWithParent : FsmStateAction
	{
		public Transform parent;
		public FsmGameObject obj;
		public FsmVector3 position;
		public FsmVector3 rotation;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			Object.Instantiate(obj.Value, position.Value, Quaternion.Euler(rotation.Value), parent);
			Finish();
		}


	}

}
