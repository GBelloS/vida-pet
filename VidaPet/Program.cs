public class Main {
    public static void main(String[] args) {
        Console.WriteLine("***************************************");
        Console.WriteLine("*****    Sistema de Agendamento   *****");
        Console.WriteLine("***** Clínica Veterinária VidaPet *****");
        Console.WriteLine("***************************************");
        Console.WriteLine();
        Console.WriteLine("         ** Primeiro Acesso **");
        Console.WriteLine();
        Console.WriteLine("Cadastro do Recepcionista:");
        Console.WriteLine();
        Console.Write(  "    Login: "); string loginRecepcionista = Console.ReadLine()??"";
//        Console.Write(  "    Senha: "); string senhaRecepcionista = Console.ReadLine()??"";
        Console.WriteLine();
        Console.WriteLine("Cadastro feito com sucesso!:");
        Console.WriteLine();
        Console.WriteLine("***************************************");

        byte opcao;
        do {
            Console.WriteLine();
            Console.WriteLine("Escolha o que deseja fazer:");
            Console.WriteLine();
            Console.WriteLine("    1) Cadastrar Veterinário");
            Console.WriteLine("    2) Cadastrar Animal");
            Console.WriteLine("    0) Sair");
            Console.WriteLine();
            Console.Write(  "Opção escolhida: "); bool success = byte.TryParse(Console.ReadLine(),out opcao);

            switch (opcao) {
                case 1:
                    break;
                case 2:
                    Console.Write("2");
                    break;
                case 0:
                    Console.Write("0");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("      ** ERRO: opção inválida! **");
                    break;
            }
        } while (opcao != 0);
    }
}
