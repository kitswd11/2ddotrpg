﻿using UnityEngine;

/*===============================================================*/
/// <summary>
/// @biref BattleSceneObjectにScriptを関連づけます
/// @biref 攻撃コマンドの処理を管理します
/// </summary>
public class Attack : Combat {

	/*===============================================================*/
	/// <summary>
	/// @brief UnityEngine ライフサイクルによる初期化
	/// </summary>
	void Start( ) {
		// 初期化関数を呼び出す
		Initialize( );


	}
	/*===============================================================*/

	/*===============================================================*/
	/// <summary>
	/// @brief 初期化
	/// </summary>
	void Initialize( ) {


	}
	/*===============================================================*/

	/*===============================================================*/
	/// <summary>
	/// @brief UnityEngine ライフサイクルによって毎フレーム呼ばれます
	/// </summary>
	void Update( ) {
		//Debug.Log( "attack : " + Hud.Player1._Player1 );
		//Debug.Log( "attack : " + Generate.GetEnemyStatusData( generateEnemies[ 0 ].name + "_NAME" ) );


	}
	/*===============================================================*/


}
/*===============================================================*/
