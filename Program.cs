using System;
using System.Runtime.InteropServices;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var canal = new YoutubeChannel("Amamos Programar");

        var subscritoCarlos = new Subscriber("Carlos");
        canal.Anexar(subscritoCarlos);

        canal.Anexar(new Subscriber("Priscila"));
        canal.Anexar(new Subscriber("Marisa"));

        canal.UploadNewVideo();

        canal.Remover(subscritoCarlos);

        canal.Anexar(new VipSubscriber("Pedro"));

        canal.MudarNome("Amamos programar demais");     

        Console.ReadKey();
    }
}