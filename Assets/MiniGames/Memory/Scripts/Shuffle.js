/*		credits: xtase studios - http://xtasestudios.com/scripts		*/
#pragma strict
import System.Collections.Generic;

public var memorycard:GameObject;
public var cards:Texture[];

private var cardslist:List.<Card> = new List.<Card>();
	
class Card{
	public var number:int;
	public var texture:Texture;
	
	public function Card(n:int, t:Texture){
		number = n;
		texture = t;
	}
}
	
function Start () {
	for(var i:int=0; i<cards.Length; i++){
		cardslist.Add(new Card(i, cards[i]));
		cardslist.Add(new Card(i, cards[i]));
	}
	
	if(cards.Length > 0)
		ShuffleCards();
}

function Update () {

}

function ShuffleCards(){
	var nrofcards:int = cardslist.Count;
	Camera.main.GetComponent(Logic).SetSetsOfCards(cards.Length);
	var temp:List.<Card> = new List.<Card>();
	
	for(var i:int =0; i<nrofcards; i++){
		var random:int = Random.Range(0, nrofcards-i);
		temp.Add(cardslist[random]);
		cardslist.RemoveAt(random);
	}
	
	cardslist = temp;
	SpawnCards();
}

function SpawnCards(){
	var cardsinrow:int = 4;
	var cardsincolumn:int = cardslist.Count/cardsinrow;
	if(cardslist.Count % cardsinrow > 0)
		cardsincolumn += 1;
	var spacebetweencards:float = .2f;
	
	for(var i:int=0; i<cardslist.Count; i++){
		var mc:GameObject = Instantiate(memorycard, new Vector3((i%cardsinrow+(i%cardsinrow*spacebetweencards))-(cardsinrow/2f)+spacebetweencards, 0, (i/cardsinrow+(i/cardsinrow*spacebetweencards))-(cardsincolumn/2f)+spacebetweencards), memorycard.transform.rotation);
		mc.GetComponentInChildren(MemoryCard).SetMemorycard(cardslist[i].texture, cardslist[i].number);
	}
}