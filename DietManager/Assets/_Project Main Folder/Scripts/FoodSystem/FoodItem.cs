using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    [Serializable]
    public class FoodItem
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //FoodItem - (0.1)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public string foodName;
        public float itemCalorie;
        public float itemProtein;
        public float itemCarbohydrate;
        public int foodID;

        public FoodItem(string foodName, float itemCalorie, float itemProtein, float itemCarb, float baseGramature)
        {
            this.foodName = foodName;

            float calorieCalc = itemCalorie / baseGramature;
            float proteinCalc = itemProtein / baseGramature;
            float carbCalc = itemCarb / baseGramature;

            this.itemCalorie = calorieCalc;
            this.itemProtein = proteinCalc;
            this.itemCarbohydrate = carbCalc;
        }
    }
}