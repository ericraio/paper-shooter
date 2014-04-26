using UnityEngine;
using System.Collections;

public class HealthScript : MonoBehaviour {

	public int hitPoints = 2;

	public bool isEnemy = true;

	void OnTriggerEnter2D(Collider2D collider) {
		ShotScript shot = collider.gameObject.GetComponent<ShotScript>();

		if(shot != null) {
			if(shot.isEnemyShot != isEnemy) {
				hitPoints -= shot.damage;

				Destroy(shot.gameObject);

				if (hitPoints <= 0) {
					SpecialEffectsHelper.Instance.Explosion(transform.position);
					SoundEffectsHelper.Instance.MakeExplosionSound();
					Destroy(gameObject);
				}
			}
		}
	}
}
