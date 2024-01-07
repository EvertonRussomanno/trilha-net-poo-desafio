namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Nokia instalando: " + nomeApp);
        }

        public override string ToString()
        {
            return $"Nokia => Number: {Numero}, Model: {Modelo}, IMEI: {IMEI}, MEM: {Memoria}";
        }
    }
}