using ENT;

namespace DAL
{
    public class clsListadosDAL
    {
        private static List<clsMision> listadoMisiones = new List<clsMision>
    {
         new clsMision(1, "Recoger los impuestos en el restaurante", 1),
         new clsMision(2,"Hacer una oferta que no puedan rechazar al sindicato de basura", 2),
         new clsMision(3, "Supervisar obres en New Jersey", 3),
         new clsMision(4,"Convencer al Concejal de urbanismo para conseguir favores", 4),
         new clsMision(5, "Encargarse del concejal de urbanismo que no se dejó convencer", 5),
         new clsMision(6, "Llevar la contabilidad del Bada Bing", 1)
        };

        // Listado de candidatos de la familia soprano
        private static List<clsCandidato> listadoCandidatos = new List<clsCandidato>
        {
         new clsCandidato(1,"Vito", "Gordon","Pizza Street","USA","54567686",DateTime.Parse("10/11/1961"), 2500),
         new clsCandidato(2, "Christopher", "Moltisanti", "St Monti","USA","123456789",DateTime.Parse("22/03/2000"),1500),
         new clsCandidato(3, "Braulia", "Galliani", "Brooklyn", "USA", "54567686", DateTime.Parse("09/12/1998"), 2000),
         new clsCandidato(4,"Paulie","Gualtieri","Soprano", "USA", "123456789", DateTime.Parse("24/07/1968"), 20000),
         new clsCandidato(5,"Estas", "Caputo", "Via Bonna", "Italia", "123456789", DateTime.Parse("02/06/1973"), 14000),
         new clsCandidato(6,"Toco","LÁcordeone","Via Musica", "Italia","654321890",DateTime.Parse("12/03/1984"), 16000),
         new clsCandidato(7, "Luigi", "Peperoni", "Piaza Roma", "Italia","123987654", DateTime.Parse("05/04/1999"), 16000),
         new clsCandidato(8, "Silvio", "Dante", "Town Street", "USA", "123459876", DateTime.Parse("10/01/1966"), 2000),
         new clsCandidato(9,"Vito", "Gordon","Pizza Street","USA","54567686",DateTime.Parse("10/11/1961"), 2500),
         new clsCandidato(10, "Christopher", "Moltisanti", "St Monti","USA","123456789",DateTime.Parse("22/03/2000"),1500),
         new clsCandidato(11, "Braulia", "Galliani", "Brooklyn", "USA", "54567686", DateTime.Parse("09/12/1998"), 2000),
        };

        public static List<clsMision> obtenerListaCompletaMisionesDAL()
        {
            List<clsMision> listaM = listadoMisiones;
            return listaM;
        }

        public static List<clsCandidato> obtenerListaCompletaCandidatosDAL()
        {
            List<clsCandidato> listaC = listadoCandidatos;
            return listaC;
        }

        public static clsMision obtenerMisionPorIdDal(int idMision)
        {
            clsMision misionEncontrada = listadoMisiones.FirstOrDefault(m => m.Id == idMision);

            return misionEncontrada;
        }

        public static clsCandidato obtenerCandidatoPorIdDal(int idCandidato)
        {
            clsCandidato candidatoEncontrado = listadoCandidatos.FirstOrDefault(c => c.Id == idCandidato);

            return candidatoEncontrado;
        }
            
    }
}
