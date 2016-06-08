using System;

namespace CalculateMBI_OOP
{
    public class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Gender Gender { get; set; }
    }

    public static class BMI
    {
        public static double GetHumanBMI(Human human)
        {
            return human.Weight / Math.Pow(human.Height, 2);
        }
    }

    public static class ResultFactory
    {
        public static string GetComment(Gender gender, double BMI)
        {
            if (gender == Gender.Male)
            {
                if (BMI < 20)
                {
                    return "太瘦";
                }
                else if (BMI > 25)
                {
                    return "太胖";
                }
                else
                {
                    return "適中";
                }
            }
            else
            {
                if (BMI < 18)
                {
                    return "太瘦";
                }
                else if (BMI > 22)
                {
                    return "太胖";
                }
                else
                {
                    return "適中";
                }
            }
        }
    }

    public enum Gender
    {
        Male = 0,
        FeMale = 1
    }
}
