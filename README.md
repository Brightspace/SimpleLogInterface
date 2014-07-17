A clean and simple logging interface intended to be logging system independent.

The goal was to have a logging interface which did not promote mixing context information
into the message string, but instead seperating this data into seperate fields.

Example:

var instance;
var ec2InstanceId;

m_log.Debug(
		() => new {
			Message = "Created ec2 instance",
			InstanceName = instance.Name,
			Ec2Instance = ec2InstanceId
		}
	);

This allows for an easy translation into formats like json:

{
	"Message":"Created ec2 instance",
	"InstanceName":"Test",
	"Ec2Instance":"i-c885efe4"
}
