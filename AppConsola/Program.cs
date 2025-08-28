

Console.WriteLine("Hello, World!");


public class Vehiculos
{
    public int Ruedas;
    public string? Placa;
    public bool Electrico;
    public DateTime FechaDeMatricula;
    public Tipos? Tipo;
    public List<Revisiones>? Revisiones;
}


public class Tipos
{
    public int Id;
    public string? Nombre;
}

public class Revisiones
{
    public int Id;
    public DateTime Fecha;
    public string? Observaciones;
}

public class Propietario
{
    public int Id;
    public string? Nombre;
    public string? Documento;
}


conflicto 1
