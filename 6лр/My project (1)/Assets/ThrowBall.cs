using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ThrowBall : MonoBehaviour
{
    // Определяем мяч
    public GameObject ball;
    // Точка, где бубут появляться мячи
    public Transform spawnBalls;
    // Сила броска мяча
    public float throwForce;
    // Минимальная задержка между бросками
    private float rate = 0.9f;
    // Время броска
    private float nextThrow = 0.0f;
    void FixedUpdate()
    {
        //Бросок мяча
        // Нажата ли ЛКМ, и прошло ли с момента прошлого броска достаточно времени
        if (Input.GetButton("Fire1") && Time.time > nextThrow)
        {
            // Время броска = текущее время + задержка
            nextThrow = Time.time + rate;
            // Создаём копию префаба мяча
            GameObject newBall = Instantiate(ball);
            // Помещаем копию префаба мяча на точку спавна и добавляем смещение вперёд
        newBall.transform.position = spawnBalls.transform.position +
spawnBalls.transform.forward;
            // Применяем физику твёрдого тела. Сообщаем мячу импульс, умноженный на коэффициент силы броска
        newBall.GetComponent<Rigidbody>().AddForce(spawnBalls.forward *
throwForce, ForceMode.Impulse);
        }
    }
}