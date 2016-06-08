using System;

namespace CalculateMBI_OOP
{
    public class Human
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public Gender Gender { get; set; }
    }

    public static class BMI_Function
    {
        public static double GetHumanBMI(Human human)
        {
            return human.Weight / Math.Pow(human.Height, 2);
        }
    }

    public abstract class BMICaculator
    {
        public BMICaculator(Human human)
        {
            _human = human;
        }

        private Human _human;
        protected double _minBMI { get; set; }
        protected double _maxBMI { get; set; }

        private bool isCalculate { get; set; }
        private double _humanBMI { get; set; }
        public double humanBMI
        {
            get
            {
                if (!isCalculate)
                {
                    isCalculate = true;
                    _humanBMI = BMI_Function.GetHumanBMI(_human);
                }

                return _humanBMI;
            }
        }

        public string Comment
        {
            get
            {
                return GetComment();
            }
        }
        private string GetComment()
        {
            if (humanBMI < _minBMI)
            {
                return "太瘦";
            }
            else if (humanBMI > _maxBMI)
            {
                return "太胖";
            }
            else
            {
                return "適中";
            }
        }
    }

    public class MaleCaculator : BMICaculator
    {
        public MaleCaculator(Human human, double minBMI, double maxBMI) : base(human)
        {
            _minBMI = minBMI;
            _maxBMI = maxBMI;
        }
    }

    public class FeMaleCaculator : BMICaculator
    {
        public FeMaleCaculator(Human human, double minBMI, double maxBMI) : base(human)
        {
            _minBMI = minBMI;
            _maxBMI = maxBMI;
        }
    }

    public static class CalculatorFactory
    {
        public static BMICaculator GetCaculator(this Human human)
        {
            if (human.Gender == Gender.Male)
            {
                return new MaleCaculator(human, 20, 25);
            }
            else
            {
                return new FeMaleCaculator(human, 18, 22);
            }
        }
    }

    public enum Gender
    {
        Male = 0,
        FeMale = 1
    }
}
