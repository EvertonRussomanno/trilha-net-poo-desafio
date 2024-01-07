namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("IPhone instalando: " + nomeApp);
        }

        public override string ToString()
        {
            return $"IPhone => Number: {Numero}, Model: {Modelo}, IMEI: {IMEI}, MEM: {Memoria}";
        }
    }
}