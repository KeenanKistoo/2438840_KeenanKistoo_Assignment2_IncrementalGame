using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
   public void Quit()
    {
        Application.Quit();
        print("quit game");
    }
}
