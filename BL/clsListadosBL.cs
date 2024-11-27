using DAL;
using ENT;

namespace BL
{
    public class clsListadosBL
    {
        public static List<clsMision> obtenerListaCompletaMisionesBL()
        {
            
            return clsListadosDAL.obtenerListaCompletaMisionesDAL();
        }

        public static List<clsCandidato> obtenerListaCompletaCandidatosBL(int dificultad)
        {
            List<clsCandidato> listaC = clsListadosDAL.obtenerListaCompletaCandidatosDAL();

            List<clsCandidato> listaCandidatosFiltrados = new List<clsCandidato>();

            foreach (clsCandidato c in listaC)
            {
                switch (dificultad) 
                {
                    case 1:
                        {
                            if (c.Pais == "USA")
                            {
                                listaCandidatosFiltrados.Add(c);
                            }
                            break;
                        }

                    case 2:
                        {
                            if (c.Pais == "USA")
                            {
                                listaCandidatosFiltrados.Add(c);
                            }
                            break;
                        }

                    case 3:
                        {
                            if(c.Pais=="USA" && DateTime.Now.Year - c.FechaNac.Year >= 40)
                            {
                                listaCandidatosFiltrados.Add(c);
                            }
                            break;
                        }

                    case 4:
                        {
                            if (c.Pais == "Italia" && DateTime.Now.Year - c.FechaNac.Year <= 45)
                            {
                                listaCandidatosFiltrados.Add(c);
                            }
                            break;
                        }

                    case 5:
                        {
                            if (c.Pais == "Italia" && DateTime.Now.Year - c.FechaNac.Year >= 45 && DateTime.Now.Year -c.FechaNac.Year <=55 )
                            {
                                listaCandidatosFiltrados.Add(c);
                            }
                            break;
                        }

                    
                }

            }

            return listaCandidatosFiltrados;
        }

        public static clsMision obtenerMisionPorIdBL(int idMision)
        {
            

            return clsListadosDAL.obtenerMisionPorIdDal(idMision);
        }

        public static clsCandidato obtenerCandidatoPorIdBL(int idCandidato)
        {
      
            return clsListadosDAL.obtenerCandidatoPorIdDal(idCandidato);
        }
    }
}
