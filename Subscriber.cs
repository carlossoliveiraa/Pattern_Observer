using Pattern_Observer.Interface;

internal partial class Program
{
    public class Subscriber : IObserver
    {
        public string Nome { get; private set; }

        public Subscriber(string nome)
        {
            Nome = nome;
        }
        public void Update(ISubject subject)
        {
            Console.WriteLine(@$"o usuario {Nome} recebeu a notificacao das alteracoes
                no canal {((YoutubeChannel)subject).Nome}");

            Console.WriteLine();
        }
    }

    public class VipSubscriber : IObserver
    {
        public string Nome { get; private set; }

        public VipSubscriber(string nome)
        {
            Nome = nome;
        }
        public void Update(ISubject subject)
        {
            Console.WriteLine(@$"OII, eu sou usuario {Nome} e sou vip  recebo notificacao no canal {((YoutubeChannel)subject).Nome}");

            Console.WriteLine();
        }
    }
}