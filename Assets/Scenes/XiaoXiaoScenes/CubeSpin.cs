using UnityEngine;

public class CubeSpin : MonoBehaviour
{
    public float minSpeed = 5f;    // 最慢转速（度/秒）
    public float maxSpeed = 25f;   // 最快转速（度/秒）

    Vector3 axis;
    float speed;

    void Start()
    {
        axis = Random.onUnitSphere;                 // 随机旋转轴
        speed = Random.Range(minSpeed, maxSpeed);   // 随机转速
    }

    void Update()
    {
        transform.Rotate(axis, speed * Time.deltaTime, Space.Self);
    }
}