using Electronica.Manager.ElectronicaDto;
using Electronica.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Manager.ElectronicaProviders
{
    public class FeedbackManager
    {
        public void UpdateFeedback(FeedBackDto fd)
        {
           FeedbackDal pd = new FeedbackDal();
            //pd.UpdateFeedback();
            ParticipantEnrollment pe = new ParticipantEnrollment();
            pe.EventID = fd.EventID;
            pe.UserID = fd.UserID;
            pe.InteractionSkill = fd.InteractionSkill;
            pe.PresentationSkill = fd.PresentationSkill;
            pe.SubjectKnowledge = fd.SubjectKnowledge;
            pe.TrainingContent = fd.TrainingContent;
            pe.TrainingSkill = fd.TrainingSkill;
            pe.Comments = fd.Comments;
            pd.UpdateFeedback(pe);

        }
    }
}
