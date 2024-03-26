using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

// Encapsulation and access modifiers
public class TrafficLight
{
    private enum LightColor { Red, Yellow, Green }
    private LightColor currentColor;

    public TrafficLight(LightColor initialColor)
    {
        currentColor = initialColor;
    }

    public void DisplayStatus()
    {
        switch (currentColor)
        {
            case LightColor.Red:
                Console.WriteLine("Traffic Light Status: RED (Stop!)");
                break;
            case LightColor.Yellow:
                Console.WriteLine("Traffic Light Status: YELLOW (Proceed with caution)");
                break;
            case LightColor.Green:
                Console.WriteLine("Traffic Light Status: GREEN (Go)");
                break;
        }
    }

    public void ChangeLight()
    {
        switch (currentColor)
        {
            case LightColor.Red:
                currentColor = LightColor.Green;
                break;
            case LightColor.Yellow:
                currentColor = LightColor.Red;
                break;
            case LightColor.Green:
                currentColor = LightColor.Yellow;
                break;
        }
    }
}

class Program
{
    static async Task Main()
    {
        // Create a traffic light
        TrafficLight trafficLight = new TrafficLight(TrafficLight.LightColor.Red);

        // Display initial status
        trafficLight.DisplayStatus();

        // Change traffic light after a delay
        await Task.Delay(3000);
        trafficLight.ChangeLight();
        trafficLight.DisplayStatus();

        // Serialize traffic light state to XML
        XmlSerializer serializer = new XmlSerializer(typeof(TrafficLight));
        using (StreamWriter writer = new StreamWriter("TrafficLightState.xml"))
        {
            serializer.Serialize(writer, trafficLight);
            Console.WriteLine("Traffic light state serialized to TrafficLightState.xml");
        }

        // Deserialize traffic light state from XML
        using (StreamReader reader = new StreamReader("TrafficLightState.xml"))
        {
            TrafficLight deserializedTrafficLight = (TrafficLight)serializer.Deserialize(reader);
            Console.WriteLine("Deserialized Traffic Light State:");
            deserializedTrafficLight.DisplayStatus();
        }
    }
}
