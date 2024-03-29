namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva() { }

        public Reserva(int diasReservados) =>
            DiasReservados = diasReservados;

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
                Hospedes = hospedes;

            else
                throw new Exception("A suíte não comporta o número de hóspedes requisitado");
        }

        public void CadastrarSuite(Suite suite) =>
            Suite = suite;

        public int ObterQuantidadeHospedes() =>
            Hospedes.Count;

        public decimal CalcularValorTotalReserva()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valor *= 0.9M;

            return valor;
        }
    }
}