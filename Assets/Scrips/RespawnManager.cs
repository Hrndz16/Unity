using UnityEngine;
using System.Collections;

public class RespawnManager : MonoBehaviour
{
    public void StartRespawn(GameObject player, float delay)
    {
        StartCoroutine(RespawnCoroutine(player, delay));
    }

    IEnumerator RespawnCoroutine(GameObject player, float delay)
    {
        yield return new WaitForSeconds(delay);

        // Restaurar salud
        Health health = player.GetComponent<Health>();
        health.currentHealth = health.maxHealth;

        if (health.healthBarImage != null)
            health.healthBarImage.fillAmount = 1f;

        // Posición original o como desees
        player.transform.position = new Vector3(-0.317999989f, 2.08500004f, 7.11100006f);
        player.SetActive(true);
    }
}
