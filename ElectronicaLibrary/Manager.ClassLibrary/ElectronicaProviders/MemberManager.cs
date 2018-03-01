using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;
using Electronica.Entity;
namespace Electronica.Manager.ElectronicaProviders
{
    public class MemberManager
    {
        public bool AddMember(MemberDto objMemberDto)
        {
            MemberDal objMemberDal = new MemberDal();
            Member objMember = new Member();
            Login objLogin = new Login();
            objMember.MemberFirstName = objMemberDto.MemberFirstName;
            objMember.MemberEmail = objMemberDto.MemberEmail;
            objMember.MemberContact = objMemberDto.MemberContact;
            objMember.MemberPassword = objMemberDto.MemberPassword;
            objMember.MemberEducation = objMemberDto.MemberEducation;
            objMember.MemberImage = objMemberDto.MemberImage;
            objMember.MemberLastName = objMemberDto.MemberLastName;
            objLogin.UserName= objMemberDto.MemberEmail;
            objLogin.Password= objMemberDto.MemberPassword;
            objLogin.UserType = 1;
            bool status= objMemberDal.InsertMember(objMember,objLogin);
            return status;
        }
    }
}
