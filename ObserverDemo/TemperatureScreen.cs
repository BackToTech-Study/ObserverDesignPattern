class TemperatureScreen : IObserver
{
    public void update(int temperature)
    {
        showTemperature(temperature);
    }

    private void showTemperature(int temperature) 
    {
        Console.WriteLine($"The temperature is {temperature}");
    }
}