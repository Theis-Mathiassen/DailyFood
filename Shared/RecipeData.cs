

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyFood.Shared
{
    public class RecipeData
    {
        public Recipe[] recipes { get; set; }
        public Categori[] categori { get; set; }
        public Tagname[] tagNames { get; set; }
        public Tag[] tag { get; set; }
        public Direction[] directions { get; set; }
        public Ingredient[] ingredients { get; set; }
        public Commodity[] commodities { get; set; }
    }

    public class Recipe : Food
    {
        public string id { get; set; }
        public string iconFileName { get; set; }
        public string picFileName { get; set; }
        public string title { get; set; }
        public string categoriId { get; set; }
        public string prepTime { get; set; }
        public string workTime { get; set; }
        public string complexity { get; set; }
        public string rating { get; set; }
        public string servings { get; set; }
        public string ratio { get; set; }
        public string comment { get; set; }
        public string energyProServingkJ { get; set; }
        public string fatProServing { get; set; }
        public string carbohydratesProServing { get; set; }
        public string fiberProServing { get; set; }
        public string proteinProServing { get; set; }
        public string alcoholProServing { get; set; }
        public string energyPro100gkJ { get; set; }
        public string fatPro100g { get; set; }
        public string carbohydratesPro100g { get; set; }
        public string fiberPro100g { get; set; }
        public string proteinPro100g { get; set; }
        public string alcoholPro100g { get; set; }

        public float Getalco100g()
        {
            return float.Parse(alcoholPro100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getcarb100g()
        {
            return float.Parse(carbohydratesPro100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getenergy100gkJ()
        {
            return float.Parse(energyPro100gkJ, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getfat100g()
        {
            return float.Parse(fatPro100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getfiber100g()
        {
            return float.Parse(fiberPro100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string Getname()
        {
            return title;
        }

        public float Getprot100g()
        {
            return float.Parse(proteinPro100g, CultureInfo.InvariantCulture.NumberFormat);
        }
    }

    public class Categori
    {
        public string id { get; set; }
        public string categori { get; set; }
    }

    public class Tagname
    {
        public string id { get; set; }
        public string tag { get; set; }
    }

    public class Tag
    {
        public string idx { get; set; }
        public string tagId { get; set; }
        public string recipeId { get; set; }
    }

    public class Direction
    {
        public string idx { get; set; }
        public string recipeId { get; set; }
        public string direction { get; set; }
        public string dOrder { get; set; }
        public string highlight { get; set; }
    }

    public class Ingredient
    {
        public string idx { get; set; }
        public string recipeId { get; set; }
        public string amount { get; set; }
        public string unit { get; set; }
        public string commodityId { get; set; }
        public string comment { get; set; }
        public string iOrder { get; set; }
    }

    public class Commodity : Food
    {
        public string id { get; set; }
        public string name { get; set; }
        public string prot100g { get; set; }
        public string carb100g { get; set; }
        public string fiber100g { get; set; }
        public string fat100g { get; set; }
        public string alco100g { get; set; }
        public string energy100gkJ { get; set; }
        public string density { get; set; }
        public string unitWeight { get; set; }
        public string gi { get; set; }

        public float Getalco100g()
        {
            return float.Parse(alco100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getcarb100g()
        {
            return float.Parse(carb100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getenergy100gkJ()
        {
            return float.Parse(energy100gkJ, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getfat100g()
        {
            return float.Parse(fat100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public float Getfiber100g()
        {
            return float.Parse(fiber100g, CultureInfo.InvariantCulture.NumberFormat);
        }

        public string Getname()
        {
            return name;
        }

        public float Getprot100g()
        {
            return float.Parse(prot100g, CultureInfo.InvariantCulture.NumberFormat);
        }
    }
}
