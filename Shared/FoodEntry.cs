using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFood.Shared
{
    public class FoodEntry
    {
        public event EventHandler FoodEntryChanged;
        
        private Food? foodType;
        public Food? FoodType { get => foodType; set { foodType = value; FoodEntryChanged?.Invoke(this, new EventArgs()); } }

        private float weight;
        public float Weight { get => weight; set { weight = value; FoodEntryChanged?.Invoke(this, new EventArgs()); } }

        private DateTime date;
        public DateTime Date { get => date; set { date = value; FoodEntryChanged?.Invoke(this, new EventArgs()); } }
        public FoodEntry()
        {
            
        }
        public FoodEntry(Food foodType, float weight, DateTime date)
        {
            FoodType = foodType;
            Weight = weight;
            Date = date;
        }
    }
}
