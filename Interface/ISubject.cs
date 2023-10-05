namespace Pattern_Observer.Interface
{
    public interface ISubject
    {
        void Anexar(IObserver o);
        void Remover(IObserver o);
        void Notificar();
        
    }
}
