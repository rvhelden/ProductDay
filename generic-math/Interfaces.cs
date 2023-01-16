




public interface IFactory<T>
    where T : IAddition<T>
{
    static abstract T CreateInstance();
}




public interface IAddition<TSelf>
    where TSelf : IAddition<TSelf>
{
    static abstract TSelf operator +(TSelf instance1, TSelf instance2);
}