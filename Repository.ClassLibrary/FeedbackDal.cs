using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
   public class FeedbackDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public void UpdateFeedback(ParticipantEnrollment pe)
                 {
            var res = context.ParticipantEnrollments.Where(p => p.UserID == pe.UserID && p.EventID == pe.EventID).Single();
            res.InteractionSkill = pe.InteractionSkill;
            res.PresentationSkill = pe.PresentationSkill;
            res.SubjectKnowledge = pe.SubjectKnowledge;
            res.TrainingContent = pe.TrainingContent;
            res.TrainingSkill = pe.TrainingSkill;
            res.Comments = pe.Comments;
            context.SaveChanges();
        }

    }
}
