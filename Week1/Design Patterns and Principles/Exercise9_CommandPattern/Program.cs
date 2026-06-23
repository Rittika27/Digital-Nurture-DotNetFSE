Light light = new();
RemoteControl remote = new();

remote.SetCommand(new LightOnCommand(light));
remote.PressButton();

remote.SetCommand(new LightOffCommand(light));
remote.PressButton();
