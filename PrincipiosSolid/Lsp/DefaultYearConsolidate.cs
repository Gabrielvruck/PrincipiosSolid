namespace PrincipiosSolid.Lsp
{
    public class DefaultYearConsolidate
    {
        private readonly SimpleAverageGradeCalculator _calculator;
        public DefaultYearConsolidate(SimpleAverageGradeCalculator averageGradeCalculator)
        {
            _calculator = averageGradeCalculator;
        }

        public void Consolidate()
        {
            _calculator.Calculate(new int[] { 1, 2, 3, 4 });
        }
    }
    public class SchoolService
    {
        public void ConsolidateClass()
        {
            var averageGradeCalculator = new SimpleAverageGradeCalculator("Portugues", 2022, 1);

            var defaultYearConsolidateService = new DefaultYearConsolidate(averageGradeCalculator);

            defaultYearConsolidateService.Consolidate();

            var t = new WeightAverageGradeCalculator("Portugues", 2022, 1);
            t.Calculate(new int[] { 1,2, 3, 4 });   
        }
    }
}
