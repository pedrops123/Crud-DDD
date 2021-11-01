using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Notifications
{
    public class Notify
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        public Notify()
        {
            notificacoes = new List<Notify>();
        }

        /// <summary>
        /// Nome da Proprieadade a ser validado
        /// </summary>
        [NotMapped]
        public string NomePropriedade { get; set; }

        /// <summary>
        /// Mensagem retorno
        /// </summary>
        [NotMapped]
        public string Mensagem { get; set; }

        /// <summary>
        /// Lista de mensagens de erro.
        /// </summary>
       
        [NotMapped]
        public List<Notify> notificacoes;

        /// <summary>
        /// Função para validar Propriedades tipo string 
        /// </summary>
        /// <param name="valor">Valor a ser validado</param>
        /// <param name="nomePropriedade">Nome do parametro</param>
        /// <returns></returns>
        public bool ValidarPropriedades(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notify()
                {
                    Mensagem = "Campo Obrigatorio",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }

        /// <summary>
        /// Função para validar Propriedades tipo Inteiros 
        /// </summary>
        /// <param name="valor">Valor a ser validado</param>
        /// <param name="nomePropriedade">Nome do parametro</param>
        /// <returns></returns>
        public bool ValidarPropriedadeInt(int valor , string nomePropriedade)
        {
            if(valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notify()
                {
                    Mensagem = "Campo Obrigatorio",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }

            return true;
        }

    }
}
