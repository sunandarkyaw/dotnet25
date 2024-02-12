namespace SystemAPI.Model
{
    public class SensorData
    {
        public string deviceId { get; set; }
        public string deviceType { get; set; }
        public string deviceName { get; set; }
        public string groupId { get; set; }
        public string dataType { get; set; }
        public PowerData data { get; set; }
        public TimeSpan timestamp { get; set; }
    }

    public class PowerData
    {
        public Boolean fullPowerMode { get; set; }
        public Boolean activePowerControl { get; set;}
        public int firmwareVersion { get;set; }
        public decimal temperature { get;set; }
        public decimal humidity { get; set; }
    }

}
