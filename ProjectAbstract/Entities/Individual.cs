
namespace ProjectAbstract.Entities {

    class Individual : TaxPayer {

        public double healthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double annualIncome, double healthExpenditures) : base (name, annualIncome) {
            this.healthExpenditures = healthExpenditures;
        }

        //como o metodo na superclasse é abstrato, sou obrigado a instanciar aqui também
        public override double Tax() {
            if (annualIncome < 20000) {
                return annualIncome * 0.15 - healthExpenditures * 0.5;
            } else {
                return annualIncome * 0.25 - healthExpenditures * 0.5;
            }
        }
    }
}
