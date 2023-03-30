namespace CriadoresCaes.Models {

    /// <summary>
    /// Fotografias dos cães, nas suas atividades
    /// </summary>
    public class Fotografias {

        public int Id { get; set; }

        /// <summary>
        /// Nome do ficheiro com a fotografia
        /// </summary>
        public string NomeFicheiro { get; set; }

        /// <summary>
        /// Nome do local onde a fotografia foi tirada
        /// </summary>
        public string Local { get; set; }

        /// <summary>
        /// Data da fotografia
        /// </summary>
        public DateTime DataFotografia { get; set; }

    }
}
