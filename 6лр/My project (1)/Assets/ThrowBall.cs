using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThrowBall : MonoBehaviour
{
    // ���������� ���
    public GameObject ball;
    // �����, ��� ����� ���������� ����
    public Transform spawnBalls;
    // ���� ������ ����
    public float throwForce;
    // ����������� �������� ����� ��������
    private float rate = 0.9f;
    // ����� ������
    private float nextThrow = 0.0f;
    void FixedUpdate()
    {
        //������ ����
        // ������ �� ���, � ������ �� � ������� �������� ������ ���������� �������
        if (Input.GetButton("Fire1") && Time.time > nextThrow)
        {
            // ����� ������ = ������� ����� + ��������
            nextThrow = Time.time + rate;
            // ������ ����� ������� ����
            GameObject newBall = Instantiate(ball);
            // �������� ����� ������� ���� �� ����� ������ � ��������� �������� �����
        newBall.transform.position = spawnBalls.transform.position +
spawnBalls.transform.forward;
            // ��������� ������ ������� ����. �������� ���� �������, ���������� �� ����������� ���� ������
        newBall.GetComponent<Rigidbody>().AddForce(spawnBalls.forward *
throwForce, ForceMode.Impulse);
        }
    }
}