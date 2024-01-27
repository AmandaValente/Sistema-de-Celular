
using System.Runtime.Serialization;

namespace DesafioPOO.Models
{
    public abstract class Smartphone : ISmartphone
    {
        public string Numero { get; set; }
        private string Modelo;
        private string Imei;
        protected int Memoria { get; set; }


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Ligar(string numero)
        {
            return "Ligando para " + numero;
        }

         public string ReceberLigacao(string numero)
         {
             return "Recebendo ligação de " + numero;
         }

        private void ValidarMemoria(int memoria)
        {
            int novaMemoria = Memoria - memoria;
            if (novaMemoria < 0) throw new MemoriaInsuficienteException("Memória insuficiente. Libere " + Math.Abs(novaMemoria) + "MB.");

            Memoria = novaMemoria;
        }

        protected abstract string InstalarAplicativo(string nomeApp, int memoria);

        public string InstalarAplicativoValidando(string nomeApp, int memoria)
        {
            ValidarMemoria(memoria);
            return InstalarAplicativo(nomeApp, memoria);
        }

        public string RegistrarVideo(int memoria)
        {
            return "Vídeo ocupando " + memoria + " MB";
        }
    }

    public class MemoriaInsuficienteException : Exception
    {
        public MemoriaInsuficienteException(string? message) : base(message)
        {

        }
    }
}