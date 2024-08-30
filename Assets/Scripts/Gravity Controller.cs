using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    //�d�͉����x
    const float Gravity = 9.8f;
    //�d�͂̓K�p�
    public float gravityScale = 1.0f;

    void Update()
    {
        Vector3 vector = new Vector3();

        if (Application.isMobilePlatform)
        {
            vector.x = Input.acceleration.x;
            vector.z = Input.acceleration.y;
            vector.y = Input.acceleration.z;
        }

        else
        {

            //�L�[�̓��͂����m���x�N�g����ݒ�
            vector.x = Input.GetAxis("Horizontal");
            vector.z = Input.GetAxis("Vertical");
            //���������̔���̓L�[�̂��Ƃ���
            if (Input.GetKey("z"))
            {
                vector.y = 1.0f;
            }
            else
            {
                vector.y = -1.0f;
            }


        }

        //�V�[���̏d�͂���̓x�N�g���̕����ɍ��킹�ĕω�������
        Physics.gravity = Gravity * vector.normalized * gravityScale;

    }

}
