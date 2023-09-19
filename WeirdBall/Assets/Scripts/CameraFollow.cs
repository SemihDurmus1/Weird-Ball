using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Takip edilecek Player objesi
    public float followDelay = 1.0f; // Takip gecikme s�resi

    private void Update()
    {
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, player.position.z);
        // Hedef pozisyonu, Player objesinin x,y ve z koordinatlar�n� kullanarak g�ncelliyoruz
        transform.position = Vector3.Lerp(transform.position, targetPosition, followDelay * Time.deltaTime);
        // Lerp fonksiyonu ile takip�i nesnenin pozisyonunu g�ncelliyoruz.
    } 
}
