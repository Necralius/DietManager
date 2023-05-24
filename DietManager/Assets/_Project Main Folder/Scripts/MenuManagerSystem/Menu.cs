using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    public class Menu : MonoBehaviour
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //Menu - (0.1)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public bool isActive = false;
        public string menuName = "menu_";

        public void Deactivate() { gameObject.SetActive(false); isActive = false; }
        public void Activate() { gameObject.SetActive(true); isActive = true; }
    }
}