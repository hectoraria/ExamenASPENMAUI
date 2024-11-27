namespace ENT
{
    public class clsMision
    {
        #region Propiedades
        public int Id {  get;  }
        public String Nombre { get; set; }
        public int Dificultad {  get; set; }

        #endregion

        #region Constructores

       public clsMision() { }
        public clsMision(int id, string nombre, int dificultad)
        {
            Id = id;
            Nombre = nombre;
            Dificultad = dificultad;
        }


        #endregion
    }
}
