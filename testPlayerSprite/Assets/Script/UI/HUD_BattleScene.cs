﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*===============================================================*/
/// <summary>
/// @brief BattleSceneオブジェクトにスクリプトを関連づけます
/// @brief BattleSceneのステータス(UI{HUD})情報を操作するクラス
/// @brief HPやMPなど・・・
/// </summary>
/*===============================================================*/
public class HUD_BattleScene : PlayerManager {

	/* オブジェクト参照  ヒエラルキーから, drag & drop でオブジェクトを指定します */
	/* BattleScene オブジェクトに スクリプトが関連づけられています */
	public GameObject lblName; /* BattleScene CharacterName */
	public GameObject lblHP; /* BattleScene HP_BAR */
	public GameObject slider; /* BattleScene HP_BAR_Slider */
	public GameObject lblMP; /* BattleScene MP_BAR */
	public GameObject sliderMP; /* BattleScene MP_BAR_Slider */

	public GameObject lblName2; /* BattleScene CharacterName */
	public GameObject lblHP2; /* BattleScene HP_BAR */
	public GameObject slider2; /* BattleScene HP_BAR_Slider */
	public GameObject lblMP2; /* BattleScene MP_BAR */
	public GameObject sliderMP2; /* BattleScene MP_BAR_Slider */

	public GameObject lblName3; /* BattleScene CharacterName */
	public GameObject lblHP3; /* BattleScene HP_BAR */
	public GameObject slider3; /* BattleScene HP_BAR_Slider */
	public GameObject lblMP3; /* BattleScene MP_BAR */
	public GameObject sliderMP3; /* BattleScene MP_BAR_Slider */

	public GameObject lblName4; /* BattleScene CharacterName */
	public GameObject lblHP4; /* BattleScene HP_BAR */
	public GameObject slider4; /* BattleScene HP_BAR_Slider */
	public GameObject lblMP4; /* BattleScene MP_BAR */
	public GameObject sliderMP4; /* BattleScene MP_BAR_Slider */

	/* 更新用変数 */
	private float valHP1; /* = SaveData.getInt( PlayerManager.KEY.Character01_HP.ToString( ), 0 ); */
	private float valHP2; /* = SaveData.getInt( PlayerManager.KEY.Character02_HP.ToString( ), 0 ); */
	private float valHP3;
	private float valHP4;

	private float valMP1;
	private float valMP2;
	private float valMP3;
	private float valMP4;

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
		// 取りあえずの実装 キャラ入れ替えには, 対応していない
		valHP1 = Player1.HP;
		valHP2 = Player2.HP;
		valHP3 = Player3.HP;
		valHP4 = Player4.HP;

		valMP1 = Player1.MP;
		valMP2 = Player2.MP;
		valMP3 = Player3.MP;
		valMP4 = Player4.MP;

		/* 各 Component の登録と関連づけ */
		/*************************************************************/
		/* NAME */
		Text TxtName = lblName.GetComponent<Text>( );

		/* HP */
		Text lblHPText = lblHP.GetComponent<Text>( );
		Slider barValue = slider.GetComponent<Slider>( );

		/* MP */
		Text lblMPText = lblMP.GetComponent<Text>( );
		Slider barValueMP = sliderMP.GetComponent<Slider>( );
		/************************************************************/
		/* NAME */
		Text TxtName2 = lblName2.GetComponent<Text>( );

		/* HP */
		Text lblHPText2 = lblHP2.GetComponent<Text>( );
		Slider barValue2 = slider2.GetComponent<Slider>( );

		/* MP */
		Text lblMPText2 = lblMP2.GetComponent<Text>( );
		Slider barValueMP2 = sliderMP2.GetComponent<Slider>( );
		/*************************************************************/
		/* NAME */
		Text TxtName3 = lblName3.GetComponent<Text>( );

		/* HP */
		Text lblHPText3 = lblHP3.GetComponent<Text>( );
		Slider barValue3 = slider3.GetComponent<Slider>( );

		/* MP */
		Text lblMPText3 = lblMP3.GetComponent<Text>( );
		Slider barValueMP3 = sliderMP3.GetComponent<Slider>( );
		/*************************************************************/
		/* NAME */
		Text TxtName4 = lblName4.GetComponent<Text>( );

		/* HP */
		Text lblHPText4 = lblHP4.GetComponent<Text>( );
		Slider barValue4 = slider4.GetComponent<Slider>( );

		/* MP */
		Text lblMPText4 = lblMP4.GetComponent<Text>( );
		Slider barValueMP4 = sliderMP4.GetComponent<Slider>( );
		/*************************************************************/

		/* 関連づけたコンポーネントの初期化 */
		// 取りあえずの実装 キャラ入れ替えには, 対応していない
		TxtName.text = Player1._Player1;
		barValue.maxValue = valHP1; /* HP 最大値 */
		lblHPText.text = "HP" + valHP1 + "/" + barValue.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValue.value = valHP1;
		barValueMP.maxValue = valMP1; /* MP 最大値 */
		lblMPText.text = "MP" + valMP1 + "/" + barValueMP.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValueMP.value = valMP1;

		TxtName2.text = Player2._Player2;
		barValue2.maxValue = valHP2; /* HP 最大値 */
		lblHPText2.text = "HP" + valHP2 + "/" + barValue2.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValue2.value = valHP2;
		barValueMP2.maxValue = valMP2; /* MP 最大値 */
		lblMPText2.text = "MP" + valMP2 + "/" + barValueMP2.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValueMP2.value = valMP2;

		TxtName3.text = Player3._Player3;
		barValue3.maxValue = valHP3; /* HP 最大値 */
		lblHPText3.text = "HP" + valHP3 + "/" + barValue3.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValue3.value = valHP3;
		barValueMP3.maxValue = valMP3; /* MP 最大値 */
		lblMPText3.text = "MP" + valMP3 + "/" + barValueMP3.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValueMP3.value = valMP3;

		TxtName4.text = Player4._Player4;
		barValue4.maxValue = valHP4; /* HP 最大値 */
		lblHPText4.text = "HP" + valHP4 + "/" + barValue4.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValue4.value = valHP4;
		barValueMP4.maxValue = valMP4; /* MP 最大値 */
		lblMPText4.text = "MP" + valMP4 + "/" + barValueMP4.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValueMP4.value = valMP4;


	}
	/*===============================================================*/

	/*===============================================================*/
	/// <summary>
	/// @brief UnityEngine ライフサイクルによって毎フレーム呼ばれます
	/// </summary>
	void Update () {
		Text lblHPText = lblHP.GetComponent<Text>( );
		Slider barValue = slider.GetComponent<Slider>( );
		if ( valHP1 < barValue.maxValue ) valHP1 += 0.01f; /* slider 更新テスト */
		lblHPText.text = "HP" + valHP1 + "/" + barValue.maxValue; /* max.Value は, level up による HP 最大値変動でロジックを変更するかも */
		barValue.value = valHP1;


	}
	/*===============================================================*/


}