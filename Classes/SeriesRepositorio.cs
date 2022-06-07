using System;
using System.Collections.Generic;
using E_M.Series.Interface;

namespace E_M.Series
{
    public class SerieRepositorio : IRepositorio<Series>
    {

        private List<Series> listaSeries = new List<Series>();
        public void Atualiza(int id, Series objeto)
        { 
            listaSeries[id] = objeto;
        }

        public void Exclui(int id)
        {
           listaSeries[id].Excluir();
        }

        public void Insere(Series objeto)
        {
            listaSeries.Add(objeto);
        }

        public List<Series> Lista()
        {
           return listaSeries;
        }

        public int ProximoId()
        {
            throw new NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}