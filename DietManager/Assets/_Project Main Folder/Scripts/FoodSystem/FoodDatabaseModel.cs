using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    [CreateAssetMenu(fileName = "New Food Database", menuName = "Diet Manager/Food Database/New Food Database")]
    public class FoodDatabaseModel : ScriptableObject
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //FoodDatabaseModel - (0.1)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public List<FoodItem> allFoods;

        public bool HasFood(string foodName) => allFoods.Exists(e => e.foodName == foodName);

        public FoodItem GetFood(string foodName) => allFoods.Find(e => e.foodName == foodName);

        public bool AddFoodToBase(FoodItem itemToAdd)
        {
            if (HasFood(itemToAdd.foodName)) return false;
            else { allFoods.Add(itemToAdd); return true; }
        }
    }
}