using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caprice.Models
{
    public class Note
    {
        public int Id { get; set; }

        [DisplayName("标题")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} 为必填项.")]
        [StringLength(100, ErrorMessage = "{0} 长度必须在 {2} - {1} 之间.", MinimumLength = 2)]
        public string Title { get; set; }

        [DisplayName("内容")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} 为必填项.")]
        [StringLength(9999, ErrorMessage = "{0} 长度必须在 {2} - {1} 之间.", MinimumLength = 2)]
        public string Content { get; set; }

        [DisplayName("代码")]
        [StringLength(9999, ErrorMessage = "{0} 长度必须在 {2} - {1} 之间.", MinimumLength = 2)]
        public string Code { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
