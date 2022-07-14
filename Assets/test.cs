using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void Update()
    {
        var v = Input.GetAxis("Vertical");
        var h = Input.GetAxis("Horizontal");
        if (v * v + h * h > 0f)
        {
            // 8�����Ȃ̂�360/8=45�B���Ƃ���4�����ɃX�i�b�v�������Ȃ�360/4��90��n���΂悢�B
            var snapped = SnapAngle(new Vector2(v, h), 45f * Mathf.Deg2Rad);
            Debug.Log(snapped);
        }
    }

    Vector2 SnapAngle(Vector2 vector, float angleSize)
    {
        var angle = Mathf.Atan2(vector.y, vector.x);

        var index = Mathf.RoundToInt(angle / angleSize);
        var snappedAngle = index * angleSize;
        var magnitude = vector.magnitude;
        return new Vector2(
            Mathf.Cos(snappedAngle) * magnitude,
            Mathf.Sin(snappedAngle) * magnitude);
    }
}