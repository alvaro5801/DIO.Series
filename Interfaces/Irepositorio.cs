using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface Irepositorio <T>
    {
      List<T>Lista();

      T RetornaPorId(int id);

      void Insert(T entidade);

      void Excluir(int id);

      void Atualiza (int id, T entidade);

      int ProximoId();
      
         
    }


}