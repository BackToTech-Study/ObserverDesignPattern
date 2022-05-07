class Subject
{
    private int temperature = 0;
    private List<IObserver> subscribers = new List<IObserver>();

    public void setTemperature(int newValue) 
    {
        temperature = newValue;
        notifySubscribers();
    }

    public void register( IObserver newSubscriber ) 
    {
        if (null != newSubscriber )
            subscribers.Add(newSubscriber);
    }

    public void unregister( IObserver subscriber ) {
        subscribers.Remove (subscriber);
    }

    private void notifySubscribers ()
    {
        subscribers.ForEach( subscriber => subscriber.update(temperature) );
    }
}