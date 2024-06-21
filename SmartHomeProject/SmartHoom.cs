using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class SmartHoom
    {
        public List<SmartRoom> RoomList;
        public SmartHoom()
        {
            RoomList = new List<SmartRoom>();
        }
        public void AddRoom(SmartRoom room)
        {
            RoomList.Add(room);
        }
        public void RemoveRoom(SmartRoom room)
        {
            RoomList.Remove(room);
        }
        public void InstalledRoomInHoom()
        {
            Console.WriteLine($"Installed Room in the Hoom");
            Console.WriteLine("........................................................\n");
            foreach (SmartRoom room in RoomList)
            {
                Console.WriteLine(room.roomName);
                room.InstallDevices();
            }
        }
    }
}
