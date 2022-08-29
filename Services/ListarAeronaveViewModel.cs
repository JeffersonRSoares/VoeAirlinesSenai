// Utilização dos namespaces
namespace VoeAirlinesSenai.Services
{
    public class ListarAeronaveViewModel
    {
        private int id;
        private string modelo;
        private string codigo;

        public ListarAeronaveViewModel(int id, string modelo, string codigo)
        {
            this.id = id;
            this.modelo = modelo;
            this.codigo = codigo;
        }
    }
}