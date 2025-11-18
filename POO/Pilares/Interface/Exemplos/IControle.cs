using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
                // métodos obrigatórios na classe que implementar a interface
        void Ligar();
        void Desligar();
        void AumentarVolume();
        void DiminuirVolume();
    }
}