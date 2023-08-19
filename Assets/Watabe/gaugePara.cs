using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    //スライダーを取得
    Slider _slider;

    void Start()
    {
        _slider=GameObject.Find("Slider").GetComponent<Slider>();
        _slider.value=0;
    }

    void Update()
    {
        //スペース押したらゲージが増える
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _slider.value+=0.1f;
        }
    }
}
