using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace DesafioPOO
{
    class Program
    {
        static void Main()
        {
            Menu menu = new Menu();
            menu.Executar();
        }
    }

    class Menu
    {
        public void Executar()
        {
            Console.WriteLine("Bem-vindo ao Testador de Smartphones!");

            Nokia nokiaPhone = ObterDadosSmartphoneNokia();
            TestadorSmartphone.Testar(nokiaPhone, "WhatsApp");

            Iphone iphone = ObterDadosSmartphoneIphone();
            TestadorSmartphone.Testar(iphone, "Instagram");
        }

        private Nokia ObterDadosSmartphoneNokia()
        {
            Console.WriteLine($"Digite os dados para o smartphone nokia:");
            string numero = ObterEntrada("Número: ");
            string modelo = ObterEntrada("Modelo: ");
            string imei = ObterEntrada("IMEI: ");
            int memoria = ObterEntradaInteiro("Memória: ");

            return new Nokia(numero, modelo, imei, memoria);
        }

        private Iphone ObterDadosSmartphoneIphone()
        {
            Console.WriteLine($"Digite os dados para o smartphone iphone:");
            string numero = ObterEntrada("Número: ");
            string modelo = ObterEntrada("Modelo: ");
            string imei = ObterEntrada("IMEI: ");
            int memoria = ObterEntradaInteiro("Memória: ");

            return new Iphone(numero, modelo, imei, memoria);
        }

        private string ObterEntrada(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private int ObterEntradaInteiro(string prompt)
        {
            while (true)
            {
                string input = ObterEntrada(prompt);

                if (int.TryParse(input, out int result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Por favor, insira um valor inteiro válido e maior que zero.");
            }
        }
    }

    static class TestadorSmartphone
    {
        public static void Testar(Smartphone smartphone, string aplicativo)
        {
            smartphone.Ligar();
            smartphone.ReceberLigacao();
            smartphone.InstalarAplicativo(aplicativo);
            Console.WriteLine();
        }
    }
}