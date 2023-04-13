using System.ComponentModel.DataAnnotations.Schema;

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

        /* ++++++++++++++++++++++++++++++++++++++
         * Criação das chaves forasteiras
         * ++++++++++++++++++++++++++++++++++++++
         */

        /// <summary>
        /// FK para o Criador do cão/cadela
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; } //efetivamente, esta é q é a FK, para a EF
        /*
         * o uso de [anotadores] serve para formatar o comportamento
         * dos 'objetos' por ele referenciados
         * estes 'objetos' podem ser:
         *  - atributos
         *  - funções (métodos)
         *  - classes
         *  */


    }
}
