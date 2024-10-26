using System.ComponentModel;
using System.Drawing;

namespace TugasBMI
{
    public class Person
    {
        private readonly decimal _weight;
        private readonly decimal _height;
        private readonly float _bmi;
        private const float MaximumUnderWeight = 18.5f;
        private const float MinimumOverWeight = 25f;
        
        public Person(decimal weight, decimal height) 
        {
            _weight = weight;
            _height = height;
            _bmi = CalculateBmi();
        }
        
        public float CalculateBmi()
        {
            var heightInMetres = (float)_height / 100;
            return (float)_weight / (heightInMetres*heightInMetres);
        }
        
        public BmiClassification GetClassification() 
        {
            return GetClassification(_bmi);
        } 
        
        public static BmiClassification GetClassification(float bmi) 
        {
            if (bmi < MaximumUnderWeight) return BmiClassification.Underweight;
            if (bmi > MinimumOverWeight) return BmiClassification.Overweight;

            return BmiClassification.Normal;
        }

        public string GetClassificationText()
        {
            return GetClassificationText(GetClassification());
        }

        public static string GetClassificationText(BmiClassification classification) 
        {
            switch(classification) 
            {
                case BmiClassification.Underweight:
                    return "Kurus";
                case BmiClassification.Overweight:
                    return "Gemuk";
                case BmiClassification.Normal:
                    return "Normal";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
        
        public Color GetClassificationColor() 
        {
            return GetClassificationColor(GetClassification());
        }
        
        public static Color GetClassificationColor(BmiClassification classification) 
        {
            switch(classification) 
            {
                case BmiClassification.Underweight:
                    return Color.Yellow;
                case BmiClassification.Overweight:
                    return Color.Red;
                case BmiClassification.Normal:
                    return Color.Green;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }
    }
    
    public enum BmiClassification
    {
        Underweight,
        Normal,
        Overweight
    }
}