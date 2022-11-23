using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
    //プレイヤー
    private GameObject player;
    //弾のオブジェクト
    public GameObject bullet;
    //1回で打ち出す弾数
    public int bulletWayNum = 3;
    //打ち出す弾の間隔
    public float bulletWaySpace = 30;
    public float time = 1;
    //最初に打ち出すまでの時間
    public float delayTime = 1;
    //現在の時間
    float nowtime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //タイマー初期化
        nowtime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        //タイマーを減らす
        nowtime -= Time.deltaTime;
        if (nowtime <= 0)
        {
            //角度調整の変数
            float bulletWaySpaceSplit = 0;
            for (int i = 0; i < bulletWayNum; i++)
            {
                //弾の生成
                CreateShotObject(bulletWaySpace - bulletWaySpaceSplit + transform.localEulerAngles.y);
                //角度調整
                bulletWaySpaceSplit += (bulletWaySpace / (bulletWayNum - 1)) * 2;
            }
            //タイマー初期化
            nowtime = time;
        }
    }
    private void CreateShotObject(float axis)
    {
        //ベクトル取得
        var direction = player.transform.position - transform.position;
        direction.y = 0;
        //向きを取得
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        //弾生成
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharacterObject(gameObject);
        bulletObject.SetForWordAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}
