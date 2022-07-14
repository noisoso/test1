using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float joystickMoveSpeed = 5f;  //プレイヤーのスピード
    public Joystick joystick;  //インスペクターからプレファブの『Fixed Joystick』を追加。
    Vector3 joystickMoveVector;  //ジョイスティックの傾き度を取得

    // Update is called once per frame
    void Update()
    {
        joystickMoveVector = Vector3.right * joystick.Horizontal + Vector3.up * joystick.Vertical;
        if (joystickMoveVector != Vector3.zero)  //ジョイスティックを動かすと動く。
        {
            transform.Rotate(joystickMoveVector, Space.World);  //ジョイスティックの傾き度で動くスピードが変わる。
        }
    }
}
