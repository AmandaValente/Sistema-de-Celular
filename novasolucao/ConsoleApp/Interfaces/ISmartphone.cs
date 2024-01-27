using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public interface ISmartphone
    {
        string Ligar(string numero);
        string ReceberLigacao(string numero);
        string RegistrarVideo(int memoria);
    }
}
