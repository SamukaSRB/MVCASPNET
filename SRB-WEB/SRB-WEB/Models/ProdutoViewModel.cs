using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SRB_WEB.Models
{
    public class ProdutoViewModel
    {

        public Int32 ProdutoId { get; set; }
        [Required(ErrorMessage = "O Ean do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Ean do Produto")]
        public String Ean { get; set; }
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Nome do Produto")]
        public String Nome { get; set; }
        [Required(ErrorMessage = "A descrição do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Descrição")]
        public String Descricao { get; set; }
        [Required(ErrorMessage = "O preço do produto é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Preço do produto")]
        public Decimal Preco { get; set; }
        [Required(ErrorMessage = "A categoria do produto é obrigatória", AllowEmptyStrings = false)]
        [Display(Name = "Categoria do produto")]
        public Int32 CategoriaId { get; set; }
        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "Imagem do produto")]
        public HttpPostedFileBase ImageUpload { get; set; }

    }
}