using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public class SmartRoom
    {
        public List<SmartDevice> devices;
        public String roomName;
        public SmartRoom(String roomName)
        {
            this.roomName = roomName;
            devices = new List<SmartDevice>();
        }
        public void AddDevice(SmartDevice device)
        {
            devices.Add(device);
        }
        public void RemoveDevice(SmartDevice device)
        {
            devices.Remove(device);
        }
        public void InstallDevices()
        {
            Console.WriteLine($"Installed Device in the {roomName}\n");
            foreach (SmartDevice device in devices)
            {
                Console.WriteLine(device.DeviceName);
                device.DeviceFunctionality();
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------");
        }
    }
}
