
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Logic : MonoBehaviour {

	private MemoryCard[] cards = new MemoryCard[2];
	private int setsofcards;
	private int nroftries = 0;

	[SerializeField]
	GameObject triggerObject;
	
	public void CheckCards(MemoryCard mc){
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
	
	void CardsMatching(){
		cards[0].RemoveCard();
		cards[1].RemoveCard();
		
		setsofcards--;
		if(setsofcards == 0)
			GameEnd();
	}
	void CardsNotMatching(){
		cards[0].Hide();
		cards[1].Hide();
	}
	void GameEnd(){
		Debug.Log("Game has ended, number of tries: " + nroftries);
		SceneManager.LoadScene("School01");
		TaskCounter.taskCount++;
	}
	public void SetSetsOfCards(int i){
		setsofcards = i;
	}
}
