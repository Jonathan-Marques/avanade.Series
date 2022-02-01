using System;
using System.Collections.Generic;
using avanade.Series.interfaces;

namespace avanade.Series
{
    public class SerieRepositorio : Irepositorio<Serie>
    {   
        private List <Serie> ListaSerie = new List<Serie>();
        public void Atualiza (int id, Serie entidade)
        {
            ListaSerie[id] = entidade;
        }

        public void Exclui (int id)
        {
            ListaSerie[id].Excluir();
        }

        public void Insere (Serie entidade)
        {
            ListaSerie.Add(entidade);
        }

        public List<Serie> Lista()
        {
            return ListaSerie;

        public int ProximoId ()       
        {
            return ListaSerie.Count;
        }

        public int RetornaPorId (int id)       
        {
            return ListaSerie[id]
        }

        
    }

}