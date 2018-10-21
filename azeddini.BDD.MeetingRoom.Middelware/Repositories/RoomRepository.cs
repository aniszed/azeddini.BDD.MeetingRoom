using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azeddini.BDD.MeetingRoom.Middelware.Repositories
{
  public  class RoomRepository : IRoomRepository 
    {
        public Room[] GetAll()
        {
            return Database.Rooms.ToArray();
        }
    }
}
