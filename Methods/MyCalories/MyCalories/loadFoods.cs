using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyCalories
{
    class loadFoods
    {
      public static Dictionary<string, Food> foods = new Dictionary<string, Food>();

       public void readFoods()
        {
            var lineOfEveryFood = File.ReadAllLines("foods.txt");

            for (int i = 0; i < lineOfEveryFood.Length; i++)
            {
                var lineParts = lineOfEveryFood[i].Split(new[] { ' ', '\t' }, StringSplitOptions
                    .RemoveEmptyEntries);

                if (lineParts.Length > 4)
                {
                    var foodName = lineParts[0];
                    double calories = 0;
                    double fats = 0;
                    double protein = 0;
                    double carbohydrates = 0;


                    double ifParsedResult = 0;
                    double ifThirthParsed = 0;

                    bool tryParseSecond = double.TryParse(lineParts[1], out ifParsedResult);
                    bool tryParseThirth = double.TryParse(lineParts[2], out ifThirthParsed);

                    if (tryParseSecond)
                    {
                        calories = ifParsedResult / 100;
                        fats = double.Parse(lineParts[2]) / 100;
                        protein = double.Parse(lineParts[3]) / 100;
                        carbohydrates = double.Parse(lineParts[4]) / 100;
                    }
                    else
                    {
                        foodName += " " + lineParts[1];

                        if (tryParseThirth)
                        {
                            calories = ifThirthParsed / 100;
                            fats = double.Parse(lineParts[3]) / 100;
                            protein = double.Parse(lineParts[4]) / 100;
                            carbohydrates = double.Parse(lineParts[5]) / 100;


                        }
                        else
                        {
                            foodName += " " + lineParts[2];
                            calories = double.Parse(lineParts[3]) / 100;
                            fats = double.Parse(lineParts[4])/100;
                            protein = double.Parse(lineParts[5])/100;
                            carbohydrates = double.Parse(lineParts[6])/100;
                        }

                    }


                    Food currentFood = new Food()
                    {
                        foodName = foodName,
                        foodCaloriesPer1g = calories,
                        fatsPer1g = fats,
                        proteinPer1G = protein,
                        carbohydratesPer1g = carbohydrates


                    };
                    foods.Add(foodName, currentFood);

                }

            }
        }

    }
}
