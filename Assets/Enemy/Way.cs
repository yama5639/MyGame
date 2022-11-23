using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way : MonoBehaviour
{
    //�v���C���[
    private GameObject player;
    //�e�̃I�u�W�F�N�g
    public GameObject bullet;
    //1��őł��o���e��
    public int bulletWayNum = 3;
    //�ł��o���e�̊Ԋu
    public float bulletWaySpace = 30;
    public float time = 1;
    //�ŏ��ɑł��o���܂ł̎���
    public float delayTime = 1;
    //���݂̎���
    float nowtime = 0;
    // Start is called before the first frame update
    void Start()
    {
        //�^�C�}�[������
        nowtime = delayTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        //�^�C�}�[�����炷
        nowtime -= Time.deltaTime;
        if (nowtime <= 0)
        {
            //�p�x�����̕ϐ�
            float bulletWaySpaceSplit = 0;
            for (int i = 0; i < bulletWayNum; i++)
            {
                //�e�̐���
                CreateShotObject(bulletWaySpace - bulletWaySpaceSplit + transform.localEulerAngles.y);
                //�p�x����
                bulletWaySpaceSplit += (bulletWaySpace / (bulletWayNum - 1)) * 2;
            }
            //�^�C�}�[������
            nowtime = time;
        }
    }
    private void CreateShotObject(float axis)
    {
        //�x�N�g���擾
        var direction = player.transform.position - transform.position;
        direction.y = 0;
        //�������擾
        var lookRotation = Quaternion.LookRotation(direction, Vector3.up);
        //�e����
        GameObject bulletClone = Instantiate(bullet, transform.position, Quaternion.identity);
        var bulletObject = bulletClone.GetComponent<EnemyBullet>();
        bulletObject.SetCharacterObject(gameObject);
        bulletObject.SetForWordAxis(lookRotation * Quaternion.AngleAxis(axis, Vector3.up));
    }
}
