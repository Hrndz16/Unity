using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
    public Image healthBarImage;

    private RespawnManager respawnManager;

    void Start()
    {
        currentHealth = maxHealth;
        respawnManager = FindObjectOfType<RespawnManager>();
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        if (healthBarImage != null)
        {
            healthBarImage.fillAmount = currentHealth / maxHealth;
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameObject.SetActive(false);
        respawnManager.StartRespawn(this.gameObject, 3f); // 3 segundos para reaparecer
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bala"))
        {
            TakeDamage(20f);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("BalaDoble"))
        {
            TakeDamage(40f);
            Destroy(other.gameObject);
        }
    }
}
