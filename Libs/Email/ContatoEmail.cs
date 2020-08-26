using LojaVirtual.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace LojaVirtual.Libs.Email
{
    public class ContatoEmail
    {
        public static void EnviarContatoPorEmail(Contato contato)
        {
            string corpoEmail = string.Format("<h2>Contato - LojaVirtual</h2>" +
            "<b>Nome: </b> {0} <br />" +
            "<b>E-mail: </b> {1} <br />" +
            "<b>Texto: </b> {2} <br />" +
            "<br /> E-mail enviado automaticamente do site LojaVirtual.",
            contato.Nome,
            contato.Email,
            contato.Texto
            );

            // Servidor que enviará e-mails

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("marlon.raoni@gmail.com", ""); // Configurar posteriormente
            smtp.EnableSsl = true;


            // Contruir mensagem

            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("marlon.raoni@gmail.com");
            mensagem.To.Add("marlon.raoni@gmail.com");
            mensagem.Subject = "Contato - Loja Virtual";
            mensagem.Body = corpoEmail;
            mensagem.IsBodyHtml = true;

            //smtp.Send(mensagem);
        }
    }
}
