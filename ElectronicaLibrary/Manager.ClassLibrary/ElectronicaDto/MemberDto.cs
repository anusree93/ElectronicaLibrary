using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electronica.Manager.ElectronicaDto
{
    public class MemberDto
    {

        [Display(Description ="First name",Name ="Enter FirstName")]
        [RegularExpression("^([A-z]+)$",ErrorMessage ="Only Alphabets allowed")]
        public string MemberFirstName { get; set; }
        public string MemberLastName { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter a valid Email")]
        public string MemberEmail { get; set; }
        public int MemberContact { get; set; }
        public string MemberEducation { get; set; }
        public byte[] MemberImage { get; set; }
            
        public string MemberPassword { get; set; }
        [Compare("MemberPassword",ErrorMessage ="PASSWORD MISMATCH")]
        public string MemberConfirmPassword { get; set; }
    }
        
}
