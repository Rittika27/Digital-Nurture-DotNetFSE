Computer gamingPC = new Computer.Builder()
    .SetCPU("Intel i9")
    .SetRAM("32GB")
    .SetStorage("1TB SSD")
    .SetGPU("NVIDIA RTX 4090")
    .SetWifi(true)
    .Build();

Computer officePC = new Computer.Builder()
    .SetCPU("Intel i5")
    .SetRAM("16GB")
    .SetStorage("512GB SSD")
    .Build();

Console.WriteLine("Gaming PC  : " + gamingPC);
Console.WriteLine("Office PC  : " + officePC);
