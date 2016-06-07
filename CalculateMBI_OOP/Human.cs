using System;

namespace CalculateMBI_OOP
{
    public class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Gender Gender { get; set; }
        public double BMI
        {
            get { return GetBMI(); }
        }
        public string Comment
        {
            get { return GetComment(); }
        }

        private double GetBMI()
        {
            return Weight / Math.Pow(Height, 2);
        }

        private string GetComment()
        {
            if (Gender == Gender.Male)
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
