using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float joystickMoveSpeed = 5f;  //�v���C���[�̃X�s�[�h
    public Joystick joystick;  //�C���X�y�N�^�[����v���t�@�u�́wFixed Joystick�x��ǉ��B
    Vector3 joystickMoveVector;  //�W���C�X�e�B�b�N�̌X���x���擾

    // Update is called once per frame
    void Update()
    {
        joystickMoveVector = Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical;
        if (joystickMoveVector != Vector3.zero)  //�W���C�X�e�B�b�N�𓮂����Ɠ����B
        {
            transform.Rotate(joystickMoveVector, Space.World);  //�W���C�X�e�B�b�N�̌X���x�œ����X�s�[�h���ς��B
        }
    }
}
