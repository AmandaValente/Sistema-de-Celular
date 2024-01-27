namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        protected override string InstalarAplicativo(string nomeApp, int memoria)
        {
            return "Aplicativo "+nomeApp+" instalado com sucesso. Memória utilizada "+memoria+" MB. Memória restante "+Memoria+"MB.";
        }
    }
}