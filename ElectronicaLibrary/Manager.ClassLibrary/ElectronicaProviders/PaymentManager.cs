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
    public class PaymentManager
    {
        public bool AddPayment(EnrollmentDto objEnrollmentDto)
        {
            EnrollmentDal objEnrollmentDal = new EnrollmentDal();
            Enrollment objEnrollment = new Enrollment();
            objEnrollment.EnrollId = objEnrollmentDto.EnrollId;
            objEnrollment.PaymentStatus = objEnrollmentDto.PaymentStatus;
            objEnrollment.Skill1 = objEnrollmentDto.Skill1;
            objEnrollment.Skill2 = objEnrollmentDto.Skill2;
            objEnrollment.Skill3 = objEnrollmentDto.Skill3;
            objEnrollment.Comments = objEnrollmentDto.Comments;
            objEnrollment.EnrollEventId= objEnrollmentDto.EnrollEventId;
            objEnrollment.EnrollMemberId= objEnrollmentDto.EnrollMemberId;
            bool status = objEnrollmentDal.InsertPayment(objEnrollment);
            return status;
        }
    }
}