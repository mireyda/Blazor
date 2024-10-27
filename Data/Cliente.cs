namespace webempresa.Data;
using System.Text.Json.Serialization;
public class Cliente
{
    [JsonPropertyName("id_cliente")]
    public int? Id_cliente { get; set; }  // Asegúrate de que esta propiedad esté definida y se asigne correctamente


    [JsonPropertyName("nombres")]
    public string? Nombres { get; set; }

    [JsonPropertyName("apellidos")]
    public string? Apellidos { get; set; }

    [JsonPropertyName("direccion")]
    public string? Direccion { get; set; }

    [JsonPropertyName("telefono")]
    public string? Telefono { get; set; }

    [JsonPropertyName("fecha_nacimiento")]
    public DateTime? Fecha_nacimiento { get; set; }
}
