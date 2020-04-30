
namespace ProjectAbstract.Entities {

    abstract class TaxPayer {

        public string name { get; set; }
        public double annualIncome { get; set; }

        public TaxPayer() { }

        protected TaxPayer(string name, double annualIncome) {
            this.name = name;
            this.annualIncome = annualIncome;
        }

        public abstract double Tax();

    }
}
