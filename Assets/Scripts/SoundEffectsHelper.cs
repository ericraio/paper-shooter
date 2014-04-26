using UnityEngine;
using System.Collections;

public class SoundEffectsHelper : MonoBehaviour {

	public static SoundEffectsHelper Instance;

	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;

	void Awake() {
		if(Instance != null) { Debug.LogError("Multiple instances of SoundEffectsHelper!"); }
		Instance = this;
	}

	public void MakeExplosionSound() {
		MakeSound(explosionSound);
	}

	public void MakePlayerShotSound() {
		MakeSound(playerShotSound);
	}

	public void MakeEnemyShotSound() {
		MakeSound(enemyShotSound);
	}

	private void MakeSound(AudioClip orginalClip) {
		// As it is not 3D audo clip, position does not matter.
		AudioSource.PlayClipAtPoint(orginalClip, transform.position);
	}

}
