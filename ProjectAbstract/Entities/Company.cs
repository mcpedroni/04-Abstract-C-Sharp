
namespace ProjectAbstract.Entities {

    class Company : TaxPayer {

        public int numberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome) {
            this.numberOfEmployees = numberOfEmployees;
        }

        public override double Tax() {
            if (numberOfEmployees > 10) {
                return annualIncome * 0.14;
            } else {
                return annualIncome * 0.16;
            }
        }
    }
}
