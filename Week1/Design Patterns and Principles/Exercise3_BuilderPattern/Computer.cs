public class Computer
{
    public string CPU { get; }
    public string RAM { get; }
    public string Storage { get; }
    public string GPU { get; }
    public bool HasWifi { get; }

    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
        GPU = builder.GPU;
        HasWifi = builder.HasWifi;
    }

    public override string ToString() =>
        $"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}, GPU: {GPU}, WiFi: {HasWifi}";

    public class Builder
    {
        public string CPU { get; private set; } = "Default CPU";
        public string RAM { get; private set; } = "8GB";
        public string Storage { get; private set; } = "256GB";
        public string GPU { get; private set; } = "Integrated";
        public bool HasWifi { get; private set; } = false;

        public Builder SetCPU(string cpu) { CPU = cpu; return this; }
        public Builder SetRAM(string ram) { RAM = ram; return this; }
        public Builder SetStorage(string storage) { Storage = storage; return this; }
        public Builder SetGPU(string gpu) { GPU = gpu; return this; }
        public Builder SetWifi(bool wifi) { HasWifi = wifi; return this; }
        public Computer Build() => new Computer(this);
    }
}
