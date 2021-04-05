using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Solid.SRP.SRP.Solucao
{
    public class ClienteRepository
    {
        public void AdicionarCliente(Cliente cliente)
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MinhaConnection";
                cmd.Connection = cn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSER INTO CLIENTE vALUES(@NOME, @EMAIL, @CPF, @DATACADASTRO)";

                cmd.Parameters.AddWithValue("NOME", cliente.Nome);
                cmd.Parameters.AddWithValue("EMAIL", cliente.Email);
                cmd.Parameters.AddWithValue("CPF", cliente.Cpf);
                cmd.Parameters.AddWithValue("DATACADASTRO", cliente.DataCadastro);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void EnviarEmail(string de, string para, string assunto, string mensagem)
        {
            var email = new MailMessage(de, para);
            var client = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            email.Subject = assunto;
            email.Body = mensagem;
            client.Send(email);
        }
    }
}
