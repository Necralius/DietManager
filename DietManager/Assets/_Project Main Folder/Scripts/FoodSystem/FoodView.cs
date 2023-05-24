using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    public class FoodView : MonoBehaviour
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //CompleteCodeName - (Code Version)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public TextMeshProUGUI foodName;
        public TextMeshProUGUI foodCalorie;
        public TextMeshProUGUI foodProtein;
        public TextMeshProUGUI foodCarb;
        public TextMeshProUGUI foodID;

        public FoodItem foodItem;

        public void UiUpdateView()
        {
            foodName.text = foodItem.foodName;
            foodCalorie.text = string.Format("Calorie:{0}", foodItem.itemCalorie);
            foodProtein.text = string.Format("Protein:{0}", foodItem.itemProtein);
            foodCarb.text = string.Format("Carbohydrate:{0}", foodItem.itemCarbohydrate);
            foodID.text = string.Format("ID:{0}", foodItem.foodID);
        }
        public void SetUpItem(FoodItem foodItem)
        {
            this.foodItem = foodItem;
            UiUpdateView();
        }
    }
}