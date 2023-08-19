using UnityEngine;

public class ItemSpawn : MonoBehaviour
{ 
    //シリアライズ化
    [Header("アイテムオブジェクト")]public GameObject itemObject;
    [Header("生成までの経過時間")]public float UPDATE_TIME;
    [Header("生成範囲最小X座標")] public float minX;
    [Header("生成範囲最大X座標")] public float maxX;
    [Header("生成範囲最小Y座標")] public float minY;
    [Header("生成範囲最大Y座標")] public float maxY;
    //プライベート変数
    float progressTime;

    void Start()
    {
        //経過時間を初期化
        progressTime = 0.0f;
    }
    void Update()
    {
        //経過時間を増やす
        progressTime += Time.deltaTime;

        //一定時間経過したら
        if (progressTime > UPDATE_TIME)
        {
            //生成位置を決める
            float x = Random.Range(minX, maxX);
            float z = 0.0f;
            //Y軸のみどんどん上に向かっていく
            float y = Random.Range(minY, minY++);
            //最大値を超えたら最小値に戻す
           if (y == maxY) { y = minY; }

            //オブジェクトを生成する
            Instantiate(itemObject, new Vector3(x, y, z), Quaternion.identity);
            progressTime = 0.0f;
        }
    }
}