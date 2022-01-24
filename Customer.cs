public class Customer
{
    public int Id { get; set; }
    public string InternalCode { get; set; }
    public decimal SalaryByDay { get; set; }
    public int DayWork { get; set; }

    public decimal CalcularSalario()
    {
        return SalaryByDay * DayWork;
    }
}