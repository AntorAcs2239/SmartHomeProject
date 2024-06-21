// See https://aka.ms/new-console-template for more information
using SmartHomeProject;

TV tV = new TV("Sony TV", 30);
SmartTV smartTV = new SmartTV("Philips Smart Tv", 40, "Android");
SmartLock smartLock = new SmartLock("Aqara Smart Lock", "123456");
Heater heater = new Heater("AENO heater", 20);
AirConditionar airConditionarForLivingRoom = new AirConditionar("LG airconditionar", 30);
AirConditionar airConditionarForBedRoom = new AirConditionar("LG airconditionar", 20);

SmartRoom livingRoom = new SmartRoom("Living Room");
SmartRoom bedRoom = new SmartRoom("Bed Room");

SmartHoom smartHoom = new SmartHoom();

livingRoom.AddDevice(airConditionarForLivingRoom);
livingRoom.AddDevice(tV);
livingRoom.AddDevice(smartLock);

bedRoom.AddDevice(smartTV);
bedRoom.AddDevice(heater);
bedRoom.AddDevice(airConditionarForBedRoom);

smartHoom.AddRoom(livingRoom);
smartHoom.AddRoom(bedRoom);

smartHoom.InstalledRoomInHoom();


