using DesafioPOO.Models;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone, INokia
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public string ApresentarMemoria(int memoria)
        {
            return "Memoria com " + memoria + "MB ocupada.";
        }

        protected override string InstalarAplicativo(string nomeApp, int memoria)
        {
            return "App "+nomeApp+" instalado com sucesso. Memória utilizada "+memoria+" MB. Memória restante "+Memoria+"MB.";
        }
    }
}
