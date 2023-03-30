namespace CriadoresCaes.Models {

    /// <summary>
    /// dados dos criadores dos animais
    /// </summary>
    public class Criadores {

        public int Id { get; set; }

        /// <summary>
        /// nome do criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// nome pelo qual o criador é conhecido
        /// no mercado de venda de animais
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// morada do criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        public string CodPostal { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do criador
        /// </summary>
        public string Telemovel { get; set; }

    }
}
