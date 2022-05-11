//==============================================================
// HealthSystem
// HealthSystem.Instance.TakeDamage (float Damage);
// HealthSystem.Instance.HealDamage (float Heal);
// HealthSystem.Instance.UseMana (float Mana);
// HealthSystem.Instance.RestoreMana (float Mana);
// Attach to the Hero.
//==============================================================

using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
	public static HealthSystem PlayerHealth;

	public Image healthBar;
	public float hitPoint = 100;
	public float maxHitPoint = 100;
	
	
	public bool Regenerate = true;
	public float regen = 0.1f;
	private float timeleft = 0.0f;	// Left time for current interval
	public float regenUpdateInterval = 1f;



	void Awake()
	{
		PlayerHealth = this;
	}

  	void Start()
	{
		UpdateGraphics();
		timeleft = regenUpdateInterval; 
	}

	void Update ()
	{
		if(hitPoint <= 0 )
        {
			SceneManager.LoadScene("Level_2");
        }
		if (Regenerate)
			Regen();
	}

	private void Regen()
	{
		timeleft -= Time.deltaTime;

		if (timeleft <= 0.0) 
		{
			HealDamage(regen);			

			UpdateGraphics();

			timeleft = regenUpdateInterval;
		}
	}

	public void TakeDamage(float Damage)
	{
		hitPoint -= Damage;

		UpdateGraphics();
	}

	public void HealDamage(float Heal)
	{
		hitPoint += Heal;
		if (hitPoint > maxHitPoint) 
			hitPoint = maxHitPoint;

		UpdateGraphics();
	}

	private void UpdateGraphics()
	{
		healthBar.fillAmount = hitPoint / 100;
	}

}
