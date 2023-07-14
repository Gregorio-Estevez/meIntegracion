namespace Integracion.models
{
    public class MCaja
    {
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public string Nombre { get; set; }
        public string documento { get; set; }
        public string tipoDocumento { get; set;}
        public double pago { get; set; }
        public int estado { get; set; }

    }
}
