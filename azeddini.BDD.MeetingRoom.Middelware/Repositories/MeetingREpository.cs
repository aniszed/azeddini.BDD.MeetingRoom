using azeddini.BDD.MeetingRoom.Middelware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azeddini.BDD.MeetingRoom.Middelware.Repositories
{
    public class MeetingRepository
    {
        public string Add(Meeting meeting)
        {
            var meetingCode = Guid.NewGuid().ToString();
            Database.Meetings.Add(meetingCode, meeting);
            return meetingCode;
        }

        public bool Exists(string meetingCode)
        {
            return Database.Meetings.ContainsKey(meetingCode);
        }

        public void Remove(string meetingCode)
        {
            Database.Meetings.Remove(meetingCode);
        }

        public bool IsMeetingInvolvesConflicts(Meeting meeting)
        {
            for (var i = meeting.StartsAt; i < meeting.EndsAt; i++)
            {
                if (SlotAlreadyBooked(meeting.Room, meeting.MeetingDate.Date, i))
                {
                    return true;
                }
            }
            return false;
        }

        public PossibleSlot[] GetPossibleSlots(string room, DateTime date)
        {
            var firstSlotPerDay = 0;
            var lastSlotPerDay = 23;

            var results = new List<PossibleSlot>();

            for (var i = firstSlotPerDay; i < lastSlotPerDay; i++)
            {
                if (!SlotAlreadyBooked(room, date, i))
                {
                    results.Add(new PossibleSlot { StartsAt = i, EndsAt = i + 1 });
                }
            }

            return results.ToArray();
        }

        private bool SlotAlreadyBooked(string room, DateTime date, int requestedStartHour)
        {
            return
                Database.Meetings.Any(x =>
                    x.Value.Room.Equals(room, StringComparison.InvariantCultureIgnoreCase) &&
                    x.Value.MeetingDate.Equals(date) &&
                    x.Value.StartsAt <= requestedStartHour &&
                    x.Value.EndsAt > requestedStartHour);
        }
    }
}
