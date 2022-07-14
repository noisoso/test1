using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody2D rb2D;
    public float move_speed = 10f; //�ǐՃX�s�[�h

    GameObject PlayerObject; // player�I�u�W�F�N�g���󂯎���
    public Transform Player; // �v���C���[�̍��W���Ȃǂ��󂯎���

    // Start is called before the first frame update
    void Start()
    {
        // ������2D���W�b�h�{�f�B���󂯎��B
        rb2D = GetComponent<Rigidbody2D>();

        // player��GameObject��T���Ď擾
        PlayerObject = GameObject.Find("player");
        // player��Transform�����擾
        Player = PlayerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        // -----------------
        // �ǐ�
        // -----------------
        Vector2 e_pos = transform.position;  // ����(�G�L�����N�^)�̐��E���W
        Vector2 p_pos = Player.position;  // �v���C���[�̐��E���W

        // �v���C���[�̕����ɓ����x�N�g��(move_speed�ő��x�𒲐�)
        Vector2 force = (p_pos - e_pos) * move_speed;
        // ���킶��ǐ�
        rb2D.AddForce(force, ForceMode2D.Force);
    }
}
