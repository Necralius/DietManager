using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NekraliusDevelopmentStudio
{
    public class FoodListView : MonoBehaviour
    {
        //Code made by Victor Paulo Melo da Silva - Game Developer - GitHub - https://github.com/Necralius
        //CompleteCodeName - (Code Version)
        //Code State - (Needs Refactoring, Needs Coments, Needs Improvement)
        //This code represents (Code functionality or code meaning)

        public GameObject foodItemPrefab;
        public Transform foodListContent;

        public FoodDatabaseModel foodDatabase;

        public void UpdateItemList()
        {
            foreach (Transform trans in foodListContent) Destroy(trans.gameObject);
            foreach (FoodItem item in foodDatabase.allFoods) Instantiate(foodItemPrefab, transform).GetComponent<FoodView>().SetUpItem(item);
        }
        private void Start()
        {
            UpdateItemList();
        }
        private void OnEnable()
        {
            UpdateItemList();
        }
    }
}