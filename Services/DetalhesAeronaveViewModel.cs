// Utilização dos namespaces
namespace VoeAirlinesSenai.Services
{
    public class DetalhesAeronaveViewModel
    {
        private int id;
        private string fabricante;
        private string modelo;
        private string codigo;

        public DetalhesAeronaveViewModel(int id, string fabricante, string modelo, string codigo)
        {
            this.id = id;
            this.fabricante = fabricante;
            this.modelo = modelo;
            this.codigo = codigo;
        }
    }
}