using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace CriadoresCaes.Models {
    /// <summary>
    /// dados dos criadores dos animais
    /// </summary>
    public class Criadores {

        public Criadores(){
            // inicializar a lista de animais do criador
            ListaAnimais = new HashSet<Animais>();
            // inicializar a lista de raças que o criador cria
            ListaRacas = new HashSet<Racas>();
        }

        /*
         */

        public int Id { get; set; }

        /// <summary>
        /// nome do criador
        /// </summary>
        [Required(ErrorMessage ="O {0} é de preenchismento obrigratório.")]
        public string Nome { get; set; }

        /// <summary>
        /// nome pelo qual o criador é conhecido
        /// no mercado de venda de animais
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        [Display(Name ="Nome Comercial")]
        public string NomeComercial { get; set; }

        /// <summary>
        /// morada do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        [Display(Name ="Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Email do criador
        /// </summary>
        [EmailAddress][Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        public string Email { get; set; }

        /// <summary>
        /// Telemóvel do criador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchismento obrigratório.")]
        [Display(Name ="Telemóvel")]
        public string Telemovel { get; set; }

        /*+++++++++++++++++++++++++++++++++++++++++++
         * relacionamentos associados ao Criador
         */

        /// <summary>
        /// Lista dos animais associados ao Criador
        /// </summary>
        public ICollection<Animais> ListaAnimais { get; set; }

        /// <summary>
        /// Lista das raças de um criador
        /// </summary>
        public ICollection<Racas> ListaRacas { get; set; }



    }
}
