using DesafioPOO.Models;

namespace TestProject;

public class SmartphoneTest
{

    [Fact]
    public void QuandoMemoriaInsuficienteException()
    {

        var expectedMessage = "Memória insuficiente. Libere 72000MB.";
        var smartphone = new Iphone("213", "IPhone 13", "12455", 128000);

        var ex = Assert.Throws<MemoriaInsuficienteException>(() => smartphone.InstalarAplicativoValidando("Lightroom", 200000));

        Assert.Equal(expectedMessage, ex.Message);
    }


    [Fact]
    public void QuandoMemoriaForSuficienteNoNokiaSucesso()
    {
        var nokia = new Nokia("435", "Nokia C02", "12455123", 64);
        var msg = nokia.InstalarAplicativoValidando("Spotify", 63);
        
        Assert.Equal("App Spotify instalado com sucesso. Memória utilizada 63 MB. Memória restante 1MB.", msg);
    }

    [Fact]
    public void QuandoMemoriaForSuficienteNoIPhoneSucesso()
    {
        var nokia = new Iphone("435", "Iphone 8", "12455123", 64);
        var msg = nokia.InstalarAplicativoValidando("Spotify", 63);
        
        Assert.Equal("Aplicativo Spotify instalado com sucesso. Memória utilizada 63 MB. Memória restante 1MB.", msg);
    }

}
