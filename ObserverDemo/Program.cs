// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var subject = new Subject();
var moodCalculator = new MoodCalculator();
var screen = new TemperatureScreen();

subject.register(screen);
subject.setTemperature(10);

subject.register(moodCalculator);
subject.setTemperature(20);

subject.unregister(screen);
subject.setTemperature(30);
