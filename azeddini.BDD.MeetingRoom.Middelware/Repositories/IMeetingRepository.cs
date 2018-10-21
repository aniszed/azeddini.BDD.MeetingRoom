using azeddini.BDD.MeetingRoom.Middelware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azeddini.BDD.MeetingRoom.Middelware.Repositories
{
    public interface IMeetingRepository
    {
        void Remove(string meetingCode);
        string Add(Meeting meeting);
        bool Exists(string meetingCode);
        bool IsMeetingInvolvesConflicts(Meeting meeting);
        PossibleSlot[] GetAvailableSlots(string room, DateTime date);
    }
}
