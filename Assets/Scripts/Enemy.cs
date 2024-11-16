using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f; // Aşağı doğru hareket hızı
    public float rotationSpeed = 20f; // Kendi ekseninde dönme hızı

    void Update()
    {
        // Aşağı doğru hareket
        transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);

        // Kendi ekseninde dönme
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);

        // Ekranın altına geçtiyse yok et
        if (transform.position.y < -6f) // Ekranın alt sınırına göre ayarlayın
        {
            Destroy(gameObject);
        }
    }
}
