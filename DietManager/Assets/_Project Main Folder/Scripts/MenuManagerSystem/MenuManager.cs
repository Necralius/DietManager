using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    public class MenuManager : MonoBehaviour
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //MenuManager - (0.1)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public List<Menu> allMenus;

        private void Start()
        {
            allMenus = FindObjectsOfType<Menu>().ToList();
        }

        public void OpenMenu(string menuName)
        {
            allMenus.ForEach(e => e.gameObject.SetActive(false));
            allMenus.First(e => e.menuName == menuName).gameObject.SetActive(true);
        }
        public void OpenMenu(Menu menu)
        {
            allMenus.ForEach(e => e.gameObject.SetActive(false));
            allMenus.First(e => e.Equals(menu)).gameObject.SetActive(true);
        }
    }
}