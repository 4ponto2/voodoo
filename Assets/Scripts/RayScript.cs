using UnityEngine;
using System.Collections;

public class RayScript : MonoBehaviour {

	Ray ray;
	RaycastHit2D hit;
	public GameObject obj;
	private Animator animator;
	public BossScript bossscript;

	void Start(){
		animator = obj.GetComponent<Animator>();
	}

	void Update(){

		if(Input.GetKey(KeyCode.Mouse0)){
			print("teste");;
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			hit = Physics2D.Raycast(ray.origin, ray.direction);

			//hit = Physics2D.Raycast(cameraPosition, mousePosition, distance (optional));
			
			if(hit.collider != null){
				print("teste2");;

				if(hit.collider.gameObject.tag=="Player"){
					print("teste3");;
					animator.SetTrigger("Hit");
				}
				//Debug.DrawRay(ray.origin, hit.point, Color.red);
				//Debug.Log("object clicked: "+hit.collider.tag);

				//Destroy(GameObject.Find(hit.collider.gameObject.name));
			}
		}
	}
}
