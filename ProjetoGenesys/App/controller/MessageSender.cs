﻿namespace ProjetoGenesys.App.controller
{
    public class MessageSender
    {
        public class Negative
        {
            public static string getMessage(string message)
            {
                switch (message)
                {
                    case "erroCadastrar":
                        message = "Erro ao cadastrar os Dados";
                        break;
                }

                return message;
            }
        }
        public class Positive
        {
            public static string getMessage(string message)
            {
                switch (message)
                {
                    case "sucessoCadastrar":
                        message = "Cadastro realizado com sucesso!";
                        break;
                }

                return message;
            }
        }
        public class Caution
        {

        }
        public class Danger
        {

        }
    }
}
