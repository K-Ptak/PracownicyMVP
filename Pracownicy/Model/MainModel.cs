namespace Pracownicy.Model
{
    class MainModel
    {

        private EmployeeBuilder employeeTemp;
        public EmployeeBuilder EmployeeTemp
        {
            get => employeeTemp;
            set { employeeTemp = value; }
        }

        private decimal? argA = null;
        private decimal? argB = null;


        public decimal? ArgA
        {
            get => argA;
            set { argA = value; }
        }
        public decimal? ArgB
        {
            get => argB;
            set { argB = value; }
        }

        public decimal Result { get; set; }

        public MainModel()
        {
            employeeTemp = new EmployeeBuilder();
        }

    }
}
