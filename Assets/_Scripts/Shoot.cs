using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    //�����ӵ�Ԥ����
    public GameObject BulletPrefab;

    //����һ���������͵�Transform ����ʵ����һ��Ҫ����Ķ���
    public Transform BulletSpawn;

    //����һ���ӵ�������ٶ�
    public float BulletSpeed = 2000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnShootButtonPressed()
    {
        //����һ����Ϸ����bullet 
        //Instantitate��һ����Ϸ������Ϸ�����λ�ã���Ϸ����ĽǶȣ�
        //���ǻ�������������������ӵ�Ԥ���帳ֵ��BulletPrefab  Ȼ����bullet����ȡ�ӵ�Ԥ�����һϵ��ֵ�����������ͼƬչʾ
        //��������൱�ڰ��ӵ�Ԥ�����λ�úͽǶȲ�������bullet  ������дbullet�������ӵ���һϵ�й���
        GameObject bullet = Instantiate(BulletPrefab, BulletSpawn.position, BulletSpawn.rotation) as GameObject;

        //����Ҫ���ӵ���Ӹ������� ��Ӹ������Ժ�Ż�����ѧ���� �Żᶯ
        //bullet.GetComponent<Rigidbody>().velocity�����Ż�ȡ������ٶ�ʸ������ʾ�����λ�ñ仯��
        //����˵ �����������Ű�һ����ǰ���ٶȸ������
        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * BulletSpeed;

        //�ӵ��������������ٵĻ��ͻ�һֱ�ѻ�  �Ͼ������ܰٷ�����
        //Destroy�����ٶ��󣬶���ʱ���
        Destroy(bullet, 2);
    }
    void OnCollisionEnter(Collision other)
    {
        //if (collisionInfo.gameObject.tag == "Bullet")
        //{ }
        print("123");

    }
}
