namespace CriadoresCaes.Models {

    /// <summary>
    /// Descrição das raças de cães
    /// </summary>
    public class Racas {

        public Racas() {
            // inicializar a lista de animais da raça
            ListaAnimais = new HashSet<Animais>();
            // inicializar a lista de criadores da raça
            ListaCriadores = new HashSet<Criadores>();
        }

        /// <summary>
        /// PK
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Denominação da Raça
        /// </summary>
        public string Nome { get; set;}

        // ***********************************************

        /// <summary>
        /// Lista dos animais associados a Raça
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }
        
        /// <summary>
        /// Lista dos animais associados a Raça
        /// </summary>
        public ICollection<Criadores> ListaCriadores { get; set; }
    }
}
