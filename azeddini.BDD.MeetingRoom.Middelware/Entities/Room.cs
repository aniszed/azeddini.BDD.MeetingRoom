using azeddini.BDD.MeetingRoom.Middelware.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace azeddini.BDD.MeetingRoom.Middelware
{
   public class Room: KeyEntity
    {
        public string Name
        {
            get;
            set;
        }
            }
}
