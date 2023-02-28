namespace Exercicio_POO_06_Aluno
{
    public class Aluno
    {
        public const int VALOR_MINIMO = 60;
        public string? Nome { get; set; }
        public double NotaTrimestre1 { get; set; }
        public double NotaTrimestre2 { get; set; }
        public double NotaTrimestre3 { get; set; }
        public double CalcularNotaFinal() => NotaTrimestre1 + NotaTrimestre2 + NotaTrimestre3;

        public bool VerificarSeAprovado() => CalcularNotaFinal() >= VALOR_MINIMO;

        public double VerificarQuantasNotasFaltam()
        {
            if (VerificarSeAprovado())
                return CalcularNotaFinal();
            else
                return VALOR_MINIMO - CalcularNotaFinal();
        }
    }
}
