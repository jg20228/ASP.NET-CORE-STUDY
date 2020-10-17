using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace AspnetCoreStudy.Models
{
    public class User
    {
        // 사용자 번호
        public int id { get; set; }
        // 사용자 이름
        public string name { get; set; }
    }
}
