namespace OdontoGendaC.Models
{
    public class Consulta
    {
        public int Id { get; set; } // Identificador único da consulta
        public string NomePaciente { get; set; } // Nome do paciente
        public string Dentista { get; set; } // Nome do dentista
        public DateTime DataConsulta { get; set; } // Data da consulta
        public string Horario { get; set; } // Horário da consulta
        public string Observacoes { get; set; } // Observações adicionais
    }
}
