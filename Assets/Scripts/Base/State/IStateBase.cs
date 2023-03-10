using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateBase
{
	/// <summary>
	/// その状態になった瞬間の処理
	/// </summary>
	public void StateEnter();

	/// <summary>
	/// その状態のとき毎フレーム呼び出す処理
	/// </summary>
	public void StateUpdate();

	/// <summary>
	/// その状態から抜ける瞬間の処理
	/// </summary>
	public void StateExit();
}
