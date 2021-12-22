/*		credits: xtase studios - http://xtasestudios.com/scripts		*/
#pragma strict

function Start () {

}

function Update () {
	if(Input.GetMouseButtonDown(0) ){
		var ray:Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		var hit:RaycastHit;
		if (Physics.Raycast(ray, hit, 100))
			if(hit.transform.GetComponent(MemoryCard) != null){
				hit.transform.GetComponent(MemoryCard).Show();
			}
	}
}