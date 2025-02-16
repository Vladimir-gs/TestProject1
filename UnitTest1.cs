namespace TestProject1;

public class UnitTest1
{
    [Fact]

    public void Mas_de_8_Caracteres()
    {
        var Prueba = new Contraseņas();

        bool result = Prueba.ContraseņaSegura("12345678");

        Assert.False(result);
    }
    [Fact]
    public void Contiene_Mayusculas()
    {
        var Prueba = new Contraseņas();

        bool result = Prueba.ContieneMayusculas("Vladimir123");

        Assert.True(result);
    }
    [Fact]
    public void Contiene_Simbolos()
    {
        var Prueba = new Contraseņas();

        bool result = Prueba.ContieneSimbolos("#Vladi112312");

        Assert.True(result);
    }
}
public class Contraseņas
{
    public bool ContraseņaSegura(string contraseņa)
    {
        if (contraseņa.Length >= 8)
        {
            return false;
        }
        return true;
    }

    public bool ContieneMayusculas(string contraseņa)
    {
        return contraseņa.Any(c => char.IsLetter(c) && char.IsUpper(c));
    }

    public bool ContieneSimbolos(string contraseņa)
    {
        return contraseņa.Any(c => char.IsSymbol(c) || !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c));
    }
}
