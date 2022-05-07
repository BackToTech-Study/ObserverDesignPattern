class MoodCalculator : IObserver
{
    public void update(int temperature)
    {
        var newMood = calculateMood(temperature);
        showMood(newMood);
    }

    private string calculateMood(int temperature)
    {
        if (temperature < 15)
            return "grumpy";

        if (temperature < 23)
            return "chef de sport";

        if (temperature < 30)
            return "chef de plaja";

        return "is this hell ?!";
    }

    private void showMood (string mood)
    {
        Console.WriteLine(mood);
    }
}