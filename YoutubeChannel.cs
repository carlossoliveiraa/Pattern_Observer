using Pattern_Observer.Interface;

internal partial class Program
{
    public class YoutubeChannel : ISubject
    {
        public List<IObserver> observers;
        public string Nome { get; set; }

        public YoutubeChannel(string nome)
        {
            observers = new List<IObserver>();
            Nome = nome;
        }

        public void Anexar(IObserver o)
        {
            Console.Write("Anexando novo objservador!");
            Console.WriteLine();
            observers.Add(o);
        }
        public void Remover(IObserver o)
        {
            Console.Write("Desanexando novo objservador!");
            Console.WriteLine();
            observers.Remove(o);
        }
        public void Notificar()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

        public void MudarNome(string novoNome)
        {
            Console.WriteLine($"O canal {Nome} alterou o nome para {novoNome} ");
            Console.WriteLine();
            Nome = novoNome;

            Notificar();
        }

        public void UploadNewVideo()
        {
            Console.WriteLine($"O canal postou um novo vídeo! {Nome} ");
            Console.WriteLine();         
            Notificar();
        }
    }
}