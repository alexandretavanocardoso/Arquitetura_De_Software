using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Violacao
{
    // no caso essa violação seria essa classe ter varias responsabilidades no mesmo metodo
    // impactando na mudança, ajustes, etc
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }


        public string AdicionarCliente()
        {
            if (!Email.Contains("@")) return "Cliente com e-mail inválido";

            if (Cpf.Length != 11) return "Cliente com CPF inválido";

            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSER INTO CLIENTE vALUES(@NOME, @EMAIL, @CPF, @DATACADASTRO)";

                cmd.Parameters.AddWithValue("NOME", Nome);
                cmd.Parameters.AddWithValue("EMAIL", Email);
                cmd.Parameters.AddWithValue("CPF", Cpf);
                cmd.Parameters.AddWithValue("DATACADASTRO", DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

            var email = new MailMessage("empresa@empresa.com", Email);
            var client = new SmtpClient() 
            { 
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            email.Subject = "Bem vindo";
            email.Body = "Parabens";
            client.Send(email);

            return "Cliente cadastrado com sucesso";
        }
    }
}
