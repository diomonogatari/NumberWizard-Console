using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HelloWorld : MonoBehaviour
{
    int max;
    int min;
    int guess;
    int triesThatTookToGuess = 0;
    GameObject meh;
    void Start()
    {
        Random r = new Random();
        max = 1000;
        min = 1;
        guess = Random.Range(min, max);
        meh = GameObject.Find("Main Camera");
        
        Debug.Log("Sup nigger");
        Debug.Log("Choose a number");
        Debug.Log("Can't be higher than: " + max.ToString());
        Debug.Log("Can't be lower than: " + min.ToString());
        Debug.Log("Press UP arrow for HIGHER or DOWN arrow for LOWER");
        Debug.Log("Press ENTER if CORRECT");
        //
        Debug.Log("Is your number " + guess);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))// Up pressed, higher pls
        {
            min = guess;
            newGuess(min, max, out guess);
        }else
        if (Input.GetKeyDown(KeyCode.DownArrow))// Down pressed, lower pls
        {
            max = guess;
            newGuess(min, max,out guess);
        }else
        if (Input.GetKeyDown(KeyCode.Return))// Correct
        {
            Debug.Log("Yay");
            Debug.Log("Took me " + triesThatTookToGuess + " to guess");
            Destroy(meh);
            
        }
    }
    void newGuess(int min, int max,out int guess)
    {
        guess = (max + min) / 2; //average for binary search
        triesThatTookToGuess++; //increment tries
        Debug.Log("My new guess is " + guess); // user UI
    }
}
 