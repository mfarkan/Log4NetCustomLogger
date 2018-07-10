# Welcome to My Log4Net Library

I know this library almost doing nothing but it's helping me something ;)

[Log4net.config](https://github.com/mfarkan/Log4NetCustomLogger/blob/master/Log4NetCustomLogger/log4net.config)

It has ERROR,DEBUG,INFO,WARN level logging.

If you want to use this library for your solution or project just use **CustomLog4netLibrary.dll**

Here is the sample of using library ; 

```c#
var logfile = Path.Combine(CurrentDomain.BaseDirectory, "log4net.config");
Log4NetLogger.Init(logfile);
Log4NetLogger log = new Log4NetLogger();
log.Log("this is a debug log...", LogType.Debug);
```
Sample with IoC Container ( Castle Windsor ) ;

```c#
//container Registration
container.Register(Component.For<ILogger>().ImplementedBy<Log4netLogger>().LifestyleTransient());
var logfile = Path.Combine(CurrentDomain.BaseDirectory, "log4net.config");
Log4netLogger.Init(logfile);
```

```c#
//Using the library.
public class Sample
{
  private readonly ILogger _logger;
	public Sample(ILogger logger)
	{
		_logger=logger;
	}
}
```
