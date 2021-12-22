/*		credits: xtase studios - http://xtasestudios.com/scripts		*/
#pragma strict
public var cardnumber:int;
private var logic:Logic;
private var selected:boolean = false;

function Start () {
	logic = Camera.main.GetComponent(Logic);
}

function Update () {

}

public function SetMemorycard(t:Texture, number:int){
	renderer.materials[1].mainTexture = t;
	cardnumber = number;
}

public function Show(){
	if(!selected){
		selected = true;
		animation.Play("Flip_show");
		logic.CheckCards(this);
	}
}

public function Hide(){
	animation.Play("Flip_hide");
	selected = false;
}

public function RemoveCard(){
	animation.Play("Flip_hide");
	yield StartCoroutine("Remove");
}
function Remove(){
	yield WaitForSeconds(.5);
	Destroy(gameObject);
}