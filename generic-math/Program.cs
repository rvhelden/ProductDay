
var factory = new GenericSampleFactory<SampleFactory, Sample>();




var instance1 = factory.CreateInstance();
instance1.Number = 2;

var instance2 = factory.CreateInstance();
instance2.Number = 3;



var instance3 = factory.Add(instance1, instance2);



Console.WriteLine($"{instance1.Number} + {instance2.Number} = {instance3.Number}");



class GenericSampleFactory<TFactory, TData>
    where TFactory : IFactory<TData>
    where TData : IAddition<TData>
{
    public TData CreateInstance()
    {
        return TFactory.CreateInstance();
    }

    public TData Add(TData data1, TData data2)
    {
        return data1 + data2;
    }
}