using System;

public abstract class RobotPrototype
{
    public string ModelName { get; set; }
    public int BatteryCapacity { get; set; }
    public string SoftwareVersion { get; set; }

    public abstract RobotPrototype Clone();
    public abstract void DisplayInfo();
}

public class ServiceRobot : RobotPrototype
{
    public string ServiceTask { get; set; } 

    public override RobotPrototype Clone()
    {
        return (RobotPrototype)this.MemberwiseClone(); 
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Service Robot -> Model: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Task: {ServiceTask}");
    }
}


public class IndustrialRobot : RobotPrototype
{
    public string IndustrialTask { get; set; } 

    public override RobotPrototype Clone()
    {
        return (RobotPrototype)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Industrial Robot -> Model: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Task: {IndustrialTask}");
    }
}

public class EntertainmentRobot : RobotPrototype
{
    public string EntertainmentFeature { get; set; } 

    public override RobotPrototype Clone()
    {
        return (RobotPrototype)this.MemberwiseClone();
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Entertainment Robot -> Model: {ModelName}, Battery: {BatteryCapacity}h, OS: {SoftwareVersion}, Feature: {EntertainmentFeature}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        ServiceRobot baseServiceRobot = new ServiceRobot
        {
            ModelName = "SR-X1",
            BatteryCapacity = 10,
            SoftwareVersion = "1.0",
            ServiceTask = "Healthcare Assistance"
        };

        
        ServiceRobot customizedServiceRobot = (ServiceRobot)baseServiceRobot.Clone();
        customizedServiceRobot.BatteryCapacity = 24; 
        customizedServiceRobot.SoftwareVersion = "1.1"; 

        
        Console.WriteLine("--- Original Robot ---");
        baseServiceRobot.DisplayInfo();

        Console.WriteLine("\n--- Cloned & Customized Robot ---");
        customizedServiceRobot.DisplayInfo();
    }
}