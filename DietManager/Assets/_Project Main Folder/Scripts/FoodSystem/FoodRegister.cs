using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    public class FoodRegister : MonoBehaviour
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //FoodRegister - (0.1)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public TMP_InputField foodName;
        public TMP_InputField foodCalorie;
        public TMP_InputField foodProtein;
        public TMP_InputField foodCarb;
        public TMP_InputField foodGramature;

        public TextMeshProUGUI itemResultDebug;

        public FoodDatabaseModel foodDatabaseModel;

        public void RegistryFood()
        {
            if (foodDatabaseModel.HasFood(foodName.text)) { Debug.Log("Item already exists!"); itemResultDebug.text = "Item already exists!"; }
            else
            {
                FoodItem newFood = new FoodItem(foodName.text, (float)Convert.ToDouble(foodCalorie.text), (float)Convert.ToDouble(foodProtein.text), (float)Convert.ToDouble(foodCarb.text), (float)Convert.ToDouble(foodGramature.text));
                foodDatabaseModel.AddFoodToBase(newFood);

                Debug.Log("Item sucessfuly added!"); itemResultDebug.text = "Item sucessfuly added!";
            }
        }
    }
}