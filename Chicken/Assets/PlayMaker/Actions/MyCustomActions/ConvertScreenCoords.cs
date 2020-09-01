using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{

	[ActionCategory("MyCustomActions")]
	[Tooltip("Convert screen coords when Canvas render mode is setting to Screen Space - Camera.")]
	public class ConvertScreenCoords : FsmStateAction
	{

		// Code that runs on entering the state.
		public override void OnEnter()
		{
			Finish();
		}


	}

}
