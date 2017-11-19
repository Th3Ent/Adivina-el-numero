using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberScript : MonoBehaviour {

    public InputField input;
    public Text infoText;
    private bool adivinado;
    private int guessNumber;
    private int userGuess;
	void Start () {
        guessNumber = Random.Range(0, 100);
        adivinado = false;
	}
	
	public void CheckGuess(){
        if (!adivinado)
        {
            userGuess = int.Parse(input.text);

            if (userGuess == guessNumber)
            {
                infoText.text = "Lo adivinaste wey. Eres un champion";
                adivinado = true;
            }
            else if (userGuess > guessNumber)
            {
                infoText.text = "Prueba con un numero mas pecuenio";
            }
            else if (userGuess < guessNumber)
            {
                infoText.text = "Prueba con un numero mas mallor";

            }
            input.text = "";
        }
        else
        {
            infoText.text = "Ya adivinaste el numero, dale a Play Again";
        }
    }

    public void playAgain(){
        if (adivinado)
        {
            guessNumber = Random.Range(0, 100);
            infoText.text = "Adivina el numero entre 0 y 100";
            adivinado = false;
        }
        else
        {
            infoText.text = "Aun no has adivinado el numero D:";
        }


    }
}
