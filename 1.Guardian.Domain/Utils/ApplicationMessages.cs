namespace Guardian.Domain.Utils
{
    public static class ApplicationMessages
    {
        // Value Objects messages.
        public static string InvalidDocument = "Documento inválido";
        public static string MinStringLength = "O campo {0} deve ter no mínimo {1} caracteres";
        public static string MaxStringLength = "O campo {0} deve ter no máximo {1} caracteres";
        public static string InvalidEmail = "E-mail inválido";

        // Entities messages.
        public static string InvalidPhone = "Telefone inválido";
        public static string InvalidCustomer = "Cliente inválido";
    }
}