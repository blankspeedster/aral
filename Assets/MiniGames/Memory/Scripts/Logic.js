/*		credits: xtase studios - http://xtasestudios.com/scripts		*/
#pragma strict

private var cards:MemoryCard[] = new MemoryCard[2];
private var setsofcards:int;
private var nroftries:int = 0;
	
function Start () {

}

function Update () {

}

public function CheckCards(mc:MemoryCard){
	if(cards[0] == null)
		cards[0] = mc;
	else{
		cards[1] = mc;
		nroftries++;
		
		if(cards[0].cardnumber == cards[1].cardnumber)
			CardsMatching();
		else
			CardsNotMatching();
		
		cards[0] = null;
		cards[1] = null;
	}
}

function CardsMatching(){
	cards[0].RemoveCard();
	cards[1].RemoveCard();
	
	setsofcards--;
	if(setsofcards == 0)
		GameEnd();
}
function CardsNotMatching(){
	cards[0].Hide();
	cards[1].Hide();
}
function GameEnd(){
	Debug.Log("Game has ended, number of tries: " + nroftries);
}
public function SetSetsOfCards(i:int){
	setsofcards = i;
}