namespace DesignPatterns.Builder
{
    public class SalaryCalculatorBuilder
    {
        private int _taxPercentage = 0;
        private decimal _bonusPercentage = 0;

        public SalaryCalculatorBuilder WithTaxes(int taxPercentage)
        {
            _taxPercentage = taxPercentage;
            return this;
        }

        public SalaryCalculatorBuilder WithBonus(decimal bonusPercentage)
        {
            _bonusPercentage = bonusPercentage;
            return this;
        }

        public SalaryCalculator Build()
        {
            return new SalaryCalculator(_taxPercentage, _bonusPercentage);
        }
    }
}

// the methods with enable user to use fluent api 
