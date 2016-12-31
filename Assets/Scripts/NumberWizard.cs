using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	int guesscount = 0;	
	int max = 10000;
	int min = 1;
	int guess = 5000;

	// Use this for initialization
	void Start () {

	
		print ("Welcome to Number Wizard");
		print ("Think of a number");
	
		print ("The highest number you can pick is " +max);
		print ("The lowest number you can pick is " +min); 
		print ("Is the number higher or lower than " +guess);
		print ("Press UP for higher, press DOWN for lower, return for equal");


	}

	void GuessAgain (){
		guess =  (max+min)/2;
		print ("Is the number higher or lower than " +guess);

	}
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.UpArrow)){
			print("Up pressed");
			min = guess;
			GuessAgain();
			guesscount++;
		}

		else if(Input.GetKeyDown(KeyCode.DownArrow)){
			print("Down pressed");
			max = guess;
			GuessAgain();
			guesscount++;
		}

		else if(Input.GetKeyDown(KeyCode.Return)){
			print ("Horray I guessed the number in " +guesscount);
		}


	}
}
