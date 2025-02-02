// See https://aka.ms/new-console-template for more information

RemoteControl remoteControl = new RemoteControl();

Light streetLight = new Light("Street");
Speaker stereoSpeaker = new Speaker("Stereo");

LightOnCommand streetLightOnCommand = new LightOnCommand(streetLight);
SpeakerOnCommand stereoSpeakerOnCommand = new SpeakerOnCommand(stereoSpeaker);

LightOffCommand streetLightOffCommand = new LightOffCommand(streetLight);
SpeakerOffCommand stereoSpeakerOffCommand = new SpeakerOffCommand(stereoSpeaker);

remoteControl.AddOnCommand(0, streetLightOnCommand);
remoteControl.AddOnCommand(1, stereoSpeakerOnCommand);

remoteControl.AddOffCommand(0, streetLightOffCommand);
remoteControl.AddOffCommand(1, stereoSpeakerOffCommand);

remoteControl.PressOnButton(0);
remoteControl.PressOnButton(1);
remoteControl.PressOffButton(0);
remoteControl.PressOffButton(1);

