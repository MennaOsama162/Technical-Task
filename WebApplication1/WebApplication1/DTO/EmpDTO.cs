using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DTO
{
    public class EmpDTO
    {

        public string اسم_العميل { get; set; }

        public string توصيف { get; set; }

        public string الوظيفة { get; set; }

        public string ادخال_بواسطة { get; set; }


        public string رجل_المبيعات { get; set; }

        public string مصدر_العميل { get; set; }


        public string تصنيف_العميل { get; set; }
    }
}
