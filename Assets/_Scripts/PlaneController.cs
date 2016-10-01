using UnityEngine;
using System.Collections;

public class PlaneController : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private Vector2 _currentPosition;
	private float _playerInput;
	private float _speed;

	// PUBLIC INSTANCE VARIABLES (TESTING ONLY)
	public GameController gameController;

	[Header("Sounds")]
	public AudioSource thunderSound;
	public AudioSource yaySound;


	// Use this for initialization
	void Start () {
		this._speed = 5;

		this._transform = this.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._move ();
	}

	/**
	 * this method moves the game object across the x-axis following the mouse movement
	 */
	private void _move() {
		this._currentPosition = this._transform.position;

		this._playerInput = Input.GetAxis ("Horizontal");

		if (this._playerInput > 0) {
			this._currentPosition += new Vector2 (this._speed, 0);
		}

		if (this._playerInput < 0) {
			this._currentPosition -= new Vector2 (this._speed, 0);
		}

		this._transform.position = new Vector2 (Mathf.Clamp(this._currentPosition.x,-290f, 290f), -200f);
	}

	private void OnTriggerEnter2D(Collider2D other) {
		
		if (other.gameObject.CompareTag ("Island")) {
			this.yaySound.Play ();
			this.gameController.ScoreValue += 100;
		}

		if (other.gameObject.CompareTag ("Cloud")) {
			this.thunderSound.Play ();
			this.gameController.LivesValue -= 1;
		}

	}
		
}
