# SimpleLogInterface

[![Build status](https://ci.appveyor.com/api/projects/status/t0tsyqo49tvx64af/branch/master?svg=true)](https://ci.appveyor.com/project/Brightspace/simpleloginterface/branch/master)
[![NuGet](https://img.shields.io/nuget/dt/SimpleLogInterface.svg)](https://www.nuget.org/packages/SimpleLogInterface)

A clean and simple logging interface intended to be logging system independent.

The goal was to have a logging interface which did not promote mixing context information
into the message string, but instead seperating this data into seperate fields.

Example:

```cs
m_log.Debug(
	() => new {
		Message = "Created ec2 instance",
		InstanceName = instance.Name,
		Ec2Instance = ec2InstanceId
	}
);
```

This allows for an easy translation into formats like json:

```json
{
	"Message":"Created ec2 instance",
	"InstanceName":"Test",
	"Ec2Instance":"i-c885efe4"
}
```
