using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    //プレイヤーと衝突したらゲージが増える
    [Header("増加するゲージ量")]public float _gaugeParameter;
    //[Header("プレイヤー判定")] public PlayerTriggerCheck _player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //ゲージを増やす
            //GaugeManager.Instance.AddGauge(_gaugeParameter);
            //オブジェクトを削除する
            Destroy(this.gameObject);
        }
    }
}
