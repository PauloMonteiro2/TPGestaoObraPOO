namespace TPGestaoObraPOO.Models
{
    public abstract class ConstructionJob
    {

        #region Propriedades Privadas

        private double budget;
        private DateOnly endDate;
        private string status;

        #endregion

        public string Name { get; set; }

        public string Address { get; set; }

        public string Description { get; set; }

        #region Propriedades Públicas

        /// Obtém o ID da obra. O ID é definido apenas uma vez.

        public int JobId { get; private set; }

        public DateOnly StartDate { get; set; }

        #endregion

        #region Construtor
        public ConstructionJob(int jobId, string jobName, string description, double initialBudget)
        {
            JobId = jobId;
            Name = jobName;
            budget = initialBudget;
        }

        public string Status
        {
            get { return status; }
            set
            {
                if (value == "Em curso" || value == "Concluído" || value == "Em Planeamento")
                {
                    status = value;
                }
                else
                {
                    throw new ArgumentException("Estado inválido!");
                }
            }
        }

        public DateOnly EndDate
        {
            get { return endDate; }
            set
            {
                if (StartDate == default)
                {
                    throw new InvalidOperationException("A data de início deve ser definida antes da data de término.");
                }
                if (value >= StartDate)
                {
                    endDate = value;
                }
                else
                {
                    throw new ArgumentException("A data de término deve ser posterior à data de início da obra!");
                }
            }
        }

        public double Budget
        {
            get { return budget; }
            private set { budget = value; }
        }
        #endregion

        #region CalcularTaxaObra
        public abstract double Calculate(); // Calcula a taxa de uma obra pública
        #endregion
    }
}