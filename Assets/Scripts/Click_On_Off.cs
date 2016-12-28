using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_On_Off : MonoBehaviour {

	//bool turn_on;
	public int direct;
	public int index;
	//public ArrayList other_obj = new ArrayList ();

	// Use this for initialization
	void Start () {
		//turn_on = false;
		//other_obj.Add (this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
			  
	}
	void OnMouseDown() {
		//Point_List.point_list.Add (Main.table[direct,index]);
	}

	public void set_active(){
		//turn_on = true;
	}
		

	void OnCollisionEnter(Collision other){

	}

	//void OnCollisionStay(Collision collisionInfo){
	//	if(collisionInfo.collider.GetComponent<MeshRenderer>().material.color==Color.red && this.gameObject.GetComponent<MeshRenderer>().material.color!=Color.red)
	//		this.gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
	//}

	void OnTriggerStay(Collider other){
		/*if (other.GetComponent<MeshRenderer> ().material.color == Color.red && this.gameObject.GetComponent<MeshRenderer> ().material.color != Color.red) {
			this.gameObject.GetComponent<MeshRenderer> ().material.color = Color.red;
			turn_on = true;
		}
		*/
	}
		

	public void set_property(int d,int i){
		direct = d;
		index = i;
	}
}
