using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInfo
{
	public string name;
	public int lives;
	public float health;
	public float PosX, PosY, PosZ, RotX, RotY, RotZ, ScaleX, ScaleY, ScaleZ;

	public static PlayerInfo CreateFromJSON(string jsonString)
	{
		return JsonUtility.FromJson<PlayerInfo>(jsonString);
	}

	// Given JSON input:
	// {"name":"Dr Charles","lives":3,"health":0.8}
	// this example will return a PlayerInfo object with
	// name == "Dr Charles", lives == 3, and health == 0.8f.
}

public class ReadJSON : MonoBehaviour {

	Vector3 positions = new Vector3();
	Vector3 rotations = new Vector3();
	Vector3 scales    = new Vector3();

	// Use this for initialization
	void Start () 
	{
		PlayerInfo _pi = new PlayerInfo ();
		PlayerInfo _pj = new PlayerInfo ();

		_pj = PlayerInfo.CreateFromJSON ("{\"name\":\"Dr Charles\",\"lives\":3,\"health\":0.8}");

//		Debug.Log ("name: " + _pj.name + "\nlives:" + _pj.lives + "\nhealth:" + _pj.health);

		_pi = PlayerInfo.CreateFromJSON ("{\"PosX\":0.0, \"PosY\":175.0, \"PosZ\":-10.0, \"RotX\":0.0, \"RotY\":0.0, \"RotZ\":0.0, \"ScaleX\":1.0, \"ScaleY\":1.0, \"ScaleZ\":1.0}");

//		Debug.Log ("P I Pos:" + _pi.PosX   + "," + _pi.PosY   + "," + _pi.PosZ  );
//		Debug.Log ("P I Rot:" + _pi.RotX   + "," + _pi.RotY   + "," + _pi.RotZ  );
//		Debug.Log ("P I Rot:" + _pi.ScaleX + "," + _pi.ScaleY + "," + _pi.ScaleZ);
//		Debug.Log ("P I name: " + _pi.name + "\nlives:" + _pi.lives + "\nhealth:" + _pi.health);
//		Debug.Log ("P J name: " + _pj.name + "\nlives:" + _pj.lives + "\nhealth:" + _pj.health);

		positions.Set (_pi.PosX  , _pi.PosY  , _pi.PosZ  );
		rotations.Set (_pi.RotX  , _pi.RotY  , _pi.RotZ  );
		scales.Set    (_pi.ScaleX, _pi.ScaleY, _pi.ScaleZ);

		transform.position         = positions;
		transform.localEulerAngles = rotations;
		transform.localScale       = scales;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}


