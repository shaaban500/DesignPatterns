namespace DesignPatterns.Builder
{
    public class SalaryCalculator
    {
        public int TaxPercentage { get; }
        public decimal BonusPercentage { get; }

        public SalaryCalculator(int taxPercentage = 0, decimal bonusPercentage = 0)
        {
            TaxPercentage = taxPercentage;
            BonusPercentage = bonusPercentage;
        }
    }
}
