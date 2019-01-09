using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Startingthegame : MonoBehaviour {

    private void OncollisiomEnter2d(Collision2D collision)
    {
        { 
        if (collision.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene("main game")

      ;
        }


