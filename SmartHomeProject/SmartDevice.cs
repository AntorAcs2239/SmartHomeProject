using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeProject
{
    public abstract class SmartDevice
    {
        public string DeviceName;
        private string DeviceStatus;
        public SmartDevice(string DeviceName)
        {
            this.DeviceName = DeviceName;
            DeviceStatus = "Off";
        }
        public void TurnOn()
        {
            DeviceStatus = "On";
            Console.WriteLine($"{DeviceName} is turned ON");
        }
        public void TurnOff()
        {
            DeviceStatus = "Off";
            Console.WriteLine($"{DeviceName} is turned Off");
        }
        public abstract void DeviceFunctionality();
    }
    public class SmartLock : SmartDevice
    {
        private String pinCode;
        private bool isLocked;
        public SmartLock(String DeviceName, String initialPinCode) : base(DeviceName)
        {
            pinCode = initialPinCode;
            isLocked = true;
        }
        public void changePinCode(String newPinCode)
        {
            pinCode = newPinCode;
        }
        public void Lock()
        {
            isLocked = true;
        }
        public void UnLock(String unLockPin)
        {
            if (pinCode == unLockPin)
            {
                isLocked = false;
            }
            else
            {
                Console.WriteLine("Please Enter Correct Pin Code and Try again");
            }
        }
        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes Lock and Unlock");
        }
    }
    public abstract class EntertainmentDevice : SmartDevice
    {
        public EntertainmentDevice(String deviceName) : base(deviceName)
        {

        }
    }
    public class TV : EntertainmentDevice
    {
        public int ScreenSize { get; set; }
        public int volume;

        public TV(String deviceName, int screenSize) : base(deviceName)
        {
            this.ScreenSize = screenSize;
            volume = 20;
        }
        public void changeChannel(int channel)
        {
            Console.WriteLine($"{DeviceName} changed channel to {channel}");
        }
        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes watching video Channel, changeChannel,Volume increase,Volume Decrease");
        }
    }
    public class Speaker : EntertainmentDevice
    {
        public int Wattage { get; set; }
        private int volume;
        public Speaker(String deviceName, int Wattage) : base(deviceName)
        {
            this.Wattage = Wattage;
            volume = 15;
        }
        public void PlayMusic(String track)
        {
            Console.WriteLine($"{DeviceName} is Playing music of Track: {track}");
        }
        public void IncreaseVolume()
        {
            volume++;
        }
        public void DecreaseVolume()
        {
            volume--;
        }
        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes Playing Music,Volume increase,decrease");
        }
    }
    public class SmartTV : TV
    {
        public String OS { get; set; }
        public SmartTV(String deviceName, int screenSize, string oS) : base(deviceName, screenSize)
        {
            OS = oS;
        }

        public void AccessInternetConnection()
        {
            Console.WriteLine($"{DeviceName} is get access to the internet");
        }

        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes watching Video Channnel Online or Offline, changeChannel,Volume increase,Volume Decrease");
        }

    }
    public abstract class ClimateControlDevice : SmartDevice
    {
        public ClimateControlDevice(String deviceName) : base(deviceName)
        {

        }
    }
    public class Heater : ClimateControlDevice
    {
        public int Power { get; set; }
        public Heater(String deviceName, int power) : base(deviceName)
        {
            Power = power;
        }

        public void SetTemparature(double temparature)
        {
            Console.WriteLine($"{DeviceName} set temprature to {temparature} degrees");
        }
        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes heating");
        }
    }
    public class AirConditionar : ClimateControlDevice
    {
        public int Power { get; set; }
        public AirConditionar(String deviceName,int power) : base(deviceName)
        {
            Power=power;
        }
        public void Cooling(double temparature)
        {
            Console.WriteLine($"{DeviceName} colling set to temprature {temparature} degrees ");
        }
        public override void DeviceFunctionality()
        {
            Console.WriteLine($"{DeviceName} functionality includes Colling Room");
        }
    }
}
