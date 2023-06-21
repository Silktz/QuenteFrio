//By Silktz
Random random = new Random();
int numaleatorio = random.Next(1, 101);
int resposta = 1;   
int tente = 0;

mensagem("=-=-=-Quente ou frio-=-=-=");
mensagem("Aperte tecla ENTER para proseguir");
Console.ReadLine();
mensagem("Gerando um número..");
Thread.Sleep(600);
mensagem("Espere o número ser gerado..");
Thread.Sleep(800);
mensagem("Número aleatório gerado..");
mensagem("O número está presente dentre 1 e o 100.. ");
mensagem("Digite um número para tentar acertar o número aleatório.. ");

while(resposta != numaleatorio)
    {
            resposta = int.Parse(Console.ReadLine()!);
            int distancia;
            distancia = Math.Abs(resposta - numaleatorio);
            tente++;

            if (resposta > 0 && resposta <= 100)
            {
            if (tente > 7)
            {
                corzinha("A quantidade de tentativas maxima foi alcançada...", ConsoleColor.DarkRed);
                return;
            }
            
            else if (distancia <= 3 && distancia >= 1)
            {
                corzinha("Está PELANDO, o número escrito está bem próximo ", ConsoleColor.DarkYellow);
                corzinha("Digite outro número..", ConsoleColor.DarkCyan);
            }
            else if (distancia <= 10 && distancia > 3)
            {
                corzinha("Você está QUENTE, continue tentando!..", ConsoleColor.Yellow);
                corzinha("Digite outro número..", ConsoleColor.DarkCyan);
            }
            else if (distancia <= 30 && distancia > 10)
            {
                corzinha("Você está FRIO, tente outro número..", ConsoleColor.DarkBlue);
                distancia2();
                corzinha("Digite outro número..", ConsoleColor.DarkCyan);
            }
            else if (distancia > 30)
            {
                corzinha("Você está CONGELANDO, o número digitado está longe do que eu pensei!", ConsoleColor.Blue);
                distancia2();
                corzinha("Digite outro número..", ConsoleColor.DarkCyan);
            }
            }

            else
            {
                corzinha("Digite um valor entre 1 a 100.. ", ConsoleColor.Blue);
                return;
            }
    }
        
Console.ForegroundColor = ConsoleColor.DarkGreen;
mensagem($"Parabéns, você acertou o número aleatório! O número era ({numaleatorio}), a quantidade de tentativas foram de ({tente}).");
Console.ResetColor();

void corzinha(string mensagem, ConsoleColor corMensagem)
{
Console.ForegroundColor = corMensagem;
Console.WriteLine(mensagem);
Console.ResetColor();
}

void distancia2()
{
    if (resposta - numaleatorio < 0)
    {
        Console.WriteLine("O número aleatório é maior que o número digitado.");
        Console.WriteLine("");
    }
    else 
    {
        Console.WriteLine("O número aleatório é menor que o número digitado.");
        Console.WriteLine("");
    }
}

void mensagem(string mensagem2)
{
    Console.WriteLine(mensagem2);
    Console.WriteLine("");
}
