using UnityEngine;
using System.Collections;


public class Ball : MonoBehaviour {
  
    public enum BALL_TYPE {
		NONE = -1,
		TYPE_1,
		TYPE_2,
		TYPE_3,
		TYPE_4,
		TYPE_5
	}

	public GameObject[] colorsGO;

	[HideInInspector]
	public int row;

	[HideInInspector]
	public int column;

	[HideInInspector]
	public BALL_TYPE type;

	[HideInInspector]
	public bool visited;

	[HideInInspector]
	public bool connected;

	private Vector3 ballPosition;

	private Grid grid;


	public void SetBallPosition (Grid grid, int column, int row)
	{

		this.grid = grid;
		this.column = column;
		this.row = row;

		ballPosition = new Vector3 ( (column * grid.TILE_SIZE) - grid.GRID_OFFSET_X , grid.GRID_OFFSET_Y + (-row * grid.TILE_SIZE)  , 0);

		if (column % 2 == 0) {
			ballPosition.y -= grid.TILE_SIZE * 0.5f;
		}

		transform.localPosition = ballPosition;

		foreach (var go in colorsGO) {
			go.SetActive(false);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "bullet") {
			var b = other.gameObject.GetComponent<Bullet> ();
			grid.AddBall (this, b);
        }

	}

	public void SetType (BALL_TYPE type) {

		foreach (var go in colorsGO) {
			go.SetActive(false);
		}

		this.type = type;

		if (type == BALL_TYPE.NONE)
			return;

		colorsGO [(int)type].SetActive (true);
	}

}
