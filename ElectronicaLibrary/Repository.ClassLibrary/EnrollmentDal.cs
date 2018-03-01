using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
    public class EnrollmentDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public bool InsertEnrollment(Enrollment obj)
        {
            //context.Database.Delete();
            //context.Database.Create();
            context.Enrollments.Add(obj);
            context.SaveChanges();
            return true;
        }
        public bool InsertPayment(Enrollment obj)
        {

            Enrollment enrollment=context.Enrollments.Find(obj.EnrollId);
            enrollment.PaymentStatus = true;
            context.SaveChanges();
            return true;
        }
    }
}
