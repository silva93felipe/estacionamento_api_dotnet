using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    public abstract class Base<T>
    {
        public T Id { get; private set; }
        public bool Ativo {get; protected set; }
        public DateTime CreatAt {get; private set;}
        public DateTime UpdateAt {get; protected set;}

        public Base(){
            Ativo = true;
            CreatAt = DateTime.Now;
            UpdateAt = DateTime.Now;
        }

    }
}