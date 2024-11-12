namespace DispositivosEletronicos.Models
{
    //essa linha é respondavel por herdar o dispositivo
    public class Computador : DispositivoEletronico
    {
        public bool ehlaptop { get; set; }

        public int MemoriaRam { get; set; }

        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, SO: {SistemaOperacional}";
        }
    }
}
