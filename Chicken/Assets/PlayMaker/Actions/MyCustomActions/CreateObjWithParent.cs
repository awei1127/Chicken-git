using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("MyCustomActions")]
	[Tooltip("在指定父物件下生成一個Game Object")]
	public class CreateObjWithParent : FsmStateAction
	{
		public Transform parent;
		public FsmGameObject obj;
		public FsmFloat positionX;
		public FsmFloat positionY;
		public FsmVector3 rotation;
		private Vector3 position;

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			position.x = positionX.Value;
			position.y = positionY.Value;
			
			Object.Instantiate(obj.Value, position, Quaternion.Euler(rotation.Value), parent);
			Finish();
			
		}


	}

}
