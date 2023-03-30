namespace CriadoresCaes.Models {

    /// <summary>
    /// Descrição dos cães
    /// </summary>
    public class Animais {


        public int Id { get; set; }

        /// <summary>
        /// Nome do cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data de Nascimento do animal
        /// </summary>
        public DateTime DataNascimento { get; set;}

        /// <summary>
        /// data de compra do animal
        /// </summary>
        public DateTime DataCompra { get; set;}

        /// <summary>
        /// sexo do animal
        /// F - fêmia
        /// M - Macho
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// LOP do registo do animal
        /// </summary>
        public string NumLOP { get; set; }

    }
}
