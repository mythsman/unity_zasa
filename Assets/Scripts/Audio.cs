using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Audio : MonoBehaviour {
	private static Audio instance=null;
	private static AudioSource audioSource;
	private  static bool onPlaying=true;
	public static Audio GetInstance(){
		return instance;
	}
	void Start(){
		if (instance == null) {
			instance =this;
			audioSource = this.GetComponent<AudioSource> ();
			DontDestroyOnLoad (this);
			Texture2D texture = Resources.Load ("icons/mouse_60") as Texture2D;
			Cursor.SetCursor (texture,new Vector2(32,32),CursorMode.ForceSoftware);
		}else{
			Destroy (this.gameObject);
		}
	}

	public void OnClick(){
		if (onPlaying) {
			audioSource.Pause ();
			onPlaying = false;
			GameObject.Find ("GlobalCanvas/MusicButton/RawImage").GetComponent<RawImage> ().texture = Resources.Load ("icons/music_off") as Texture;
		} else {
			audioSource.Play ();
			onPlaying = true;
			GameObject.Find ("GlobalCanvas/MusicButton/RawImage").GetComponent<RawImage> ().texture = Resources.Load ("icons/music_on") as Texture;
		}
	}
}
