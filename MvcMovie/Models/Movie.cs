using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "标题"),Required,StringLength(60,MinimumLength = 1,ErrorMessage ="标题字数应大于等于1个字符，小于60个字符。")]
        public string? Title { get; set; }
        
        [Display(Name ="年代"),DataType(DataType.Date,ErrorMessage ="年代不能为空。")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "流派"),StringLength(30,ErrorMessage ="字数不能大于30。")]
        public string? Genre { get; set; }

        [Display(Name = "价格")]
        [Range(1,100),DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "分级"), StringLength(5, ErrorMessage = "字数不能大于5。")]
        public string? Rating { get; set; }
    }
}
