namespace DIO.Serie
{
    public abstract class EntidadeBase
    {
      public int Id { get; protected set;}
        public bool Excluido { get; private set; }

        public void Excluir(){
           this.Excluido = true;
         }
    }
}