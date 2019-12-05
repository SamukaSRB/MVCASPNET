using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SRB_WEB.Models
{    [Table("Produtos")]
    public class Produto
    {
        public int ProdutoId { get; set; }
        [Required(ErrorMessage = " O ean do produto é obrigatário",AllowEmptyStrings=false)]
        public string Ean { get; set; }
        [Required(ErrorMessage = " O nome do produto é obrigatário", AllowEmptyStrings = false)]
        public string Nome { get; set; }
        [Required(ErrorMessage = " O descrição do produto é obrigatário", AllowEmptyStrings = false)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = " O preço do produto é obrigatário", AllowEmptyStrings = false)]
        public decimal Preco { get; set; }
        [Required(ErrorMessage = " O imagem do produto é obrigatário", AllowEmptyStrings = false)]
        public string Imagem { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}