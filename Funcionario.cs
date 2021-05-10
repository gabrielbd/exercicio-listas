

namespace ExercicioLista
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Percentual(int percentual)
        {
           Salario = Salario + percentual;
        }
        public override string ToString()
        {
            return "ID :"+Id + ", Nome: " + Nome + ", Salario: " + Salario;

        }

    }
}
