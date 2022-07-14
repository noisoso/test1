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
            // 8方向なので360/8=45。たとえば4方向にスナップしたいなら360/4で90を渡せばよい。
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